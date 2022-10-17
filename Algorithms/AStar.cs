namespace Algoritmi
{
    using Grid;
    using System.Collections.Generic;
    using System.Linq;

    public class AStar : Baza
    {
        private readonly List<Nod> _deschise = new List<Nod>();
        private readonly List<Coord> _vecini;

        public AStar(Grid grid) : base(grid)
        {
            Nume_Algoritm = "A*";
            _vecini = new List<Coord>();

            // Adauga nodul de inceput in lista
            _deschise.Add(new Nod(Id++, null, origine, 0, GetH(origine, Destinatie)));
        }

        public override Detalii GetPathTick()
        {
            if (Nod_Curent == null)
            {
                if (!_deschise.Any()) return ObtDetalii();

                // Scoatem nodul din lista pentru a-l verifica
                Nod_Curent = _deschise.OrderBy(x => x.F).ThenBy(x => x.H).First();

                // il mutam in cealalta lista pentru a nu-l verifica din nou
                _deschise.Remove(Nod_Curent);
                Inchis.Add(Nod_Curent);
                Grid.SetCell(Nod_Curent.Coord, Enums.CellType.Inchis);

                _vecini.AddRange(ObtVecini(Nod_Curent));
            }

            if (_vecini.Any())
            {
                Grid.SetCell(Nod_Curent.Coord, Enums.CellType.Actual);

                var thisvecin = _vecini.First();
                _vecini.Remove(thisvecin);

                // Verifica daca vecinul este destinatia
                if (CoordsMatch(thisvecin, Destinatie))
                {
                    // Construieste un drum parcurgand invers lista utilizata pana cand nu mai avem noduri de tip "parinte"
                    Path = new List<Coord> { thisvecin };
                    int? parentId = Nod_Curent.Id;
                    while (parentId.HasValue)
                    {
                        var nextNod = Inchis.First(x => x.Id == parentId);
                        Path.Add(nextNod.Coord);
                        parentId = nextNod.ParentId;
                    }

                    // Inversam drumul pentru a porni de la inceput si a se termina in final
                    Path.Reverse();

                    return ObtDetalii();
                }

                // Obtine costul nodului actual plus pas (Resursele pentru A* provin de pe GitHub)
                var hFromHere = GetH(thisvecin, Destinatie);
                var cellWeight = Grid.GetCell(thisvecin.X, thisvecin.Y).Weight;
                var vecinCost = Nod_Curent.G + cellWeight + hFromHere;

                // Verifica daca nodul este pe lista deja si daca are un cost mai mare
                var openListItem = _deschise.FirstOrDefault(x => x.Id == ObtNodExistent(true, thisvecin));
                if (openListItem != null && openListItem.F > vecinCost)
                {
                    //Redirectionam nodul din lista pentru a folosi drumul de cost minim
                    openListItem.F = vecinCost;
                    openListItem.ParentId = Nod_Curent.Id;
                }

                // Verifica daca nodul e pe lista deja si daca are un cost mai mare
                var InchisListItem = Inchis.FirstOrDefault(x => x.Id == ObtNodExistent(false, thisvecin));
                if (InchisListItem != null && InchisListItem.F > vecinCost)
                {
                    //Redirectionam nodul din lista pentru a folosi drumul de cost minim
                    InchisListItem.F = vecinCost;
                    InchisListItem.ParentId = Nod_Curent.Id;
                }

                // Daca nodul vecin nu e pe nicio lista, il adaugam
                if (openListItem != null || InchisListItem != null) return ObtDetalii();
                _deschise.Add(new Nod(Id++, Nod_Curent.Id, thisvecin, Nod_Curent.G + cellWeight, hFromHere));
                Grid.SetCell(thisvecin.X, thisvecin.Y, Enums.CellType.Open);
            }
            else
            {
                Grid.SetCell(Nod_Curent.Coord, Enums.CellType.Inchis);
                Nod_Curent = null;
                return GetPathTick();
            }

            return ObtDetalii();
        }

        private static int GetH(Coord origine, Coord destinatie)
        {
            return Manhattan(origine, destinatie); //După cum știm și din matematică, metoda Manhattan este una din cele mai eficiente metode pentru a obține distanța dintre două puncte într-o matrice. A primit acest nume datorită orașului American, Manhattan, de unde se și inspiră, existând o intersecție la aproape fiecare colț de bloc.
        }

        private int? ObtNodExistent(bool ListaDeschise, Coord coordDeVerificat)
        {
            return ListaDeschise ? _deschise.FirstOrDefault(x => CoordsMatch(x.Coord, coordDeVerificat))?.Id : Inchis.FirstOrDefault(x => CoordsMatch(x.Coord, coordDeVerificat))?.Id;
        }

        protected override Detalii ObtDetalii()
        {
            return new Detalii
            {
                Path = Path?.ToArray(),
                PathCost = GetPathCost(),
                UltimulNod = Nod_Curent,
                DistantaNodCurent = Nod_Curent == null ? 0 : GetH(Nod_Curent.Coord, Destinatie),
                NrNoduriDeschise = _deschise.Count,
                NrNoduriInchise = Inchis.Count,
                NrNoduriNeexplorate = Grid.GetCountOfType(Enums.CellType.Liber),
                NrOperatii = NrOperatii++
            };
        }
    }
}
