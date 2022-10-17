namespace Algoritmi
{
    using Grid;
    using System.Collections.Generic;
    using System.Linq;

    public class Dijkstra : Baza
    {
        private readonly List<Nod> _deschise = new List<Nod>();
        private readonly List<Coord> _vecini;

        public Dijkstra(Grid grid) : base(grid)
        {
            Nume_Algoritm = "Dijkstra";
            _vecini = new List<Coord>();

            // Adauga nodul originar in lista de noduri deschise
            _deschise.Add(new Nod(Id++, null, origine, 0, 0));
        }

        public override Detalii GetPathTick()
        {
            if (Nod_Curent == null)
            {
                if (!_deschise.Any()) return ObtDetalii();

                // Verifica nodul actual din lista de deschise
                Nod_Curent = _deschise.OrderBy(x => x.F).First();

                // Mutam nodul in lista de inchise ca sa nu fie reverificat
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

                if (CoordsMatch(thisvecin, Destinatie))
                {
                    // Daca vecinul e destinatia, construim drumul parcurgand lista inchisa in ordine inversa pana nu mai avem noduri de tip parinte
                    Path = new List<Coord> { thisvecin };
                    int? parentId = Nod_Curent.Id;
                    while (parentId.HasValue)
                    {
                        var nextNod = Inchis.First(x => x.Id == parentId);
                        Path.Add(nextNod.Coord);
                        parentId = nextNod.ParentId;
                    }

                    // Inversam drumul ca sa plece din  A in B
                    Path.Reverse();

                    return ObtDetalii();
                }

                // Obtinem costul nodului actual plus al pasului urmator
                var cellWeight = Grid.GetCell(thisvecin.X, thisvecin.Y).Weight;
                var vecinCost = Nod_Curent.G + cellWeight;

                // Verificam daca nodul e deschis si daca drumul are un cost mai mare
                var openListItem = _deschise.FirstOrDefault(x => x.Id == ObtNodExistent(true, thisvecin));
                if (openListItem != null && openListItem.F > vecinCost)
                {
                    //Redirectionam nodul din lista pentru a folosi drumul de cost minim
                    openListItem.F = vecinCost;
                    openListItem.ParentId = Nod_Curent.Id;
                }

                // Verificam daca nodul e inchis si daca drumul are un cost mai mare
                var InchisListItem = Inchis.FirstOrDefault(x => x.Id == ObtNodExistent(false, thisvecin));
                if (InchisListItem != null && InchisListItem.F > vecinCost)
                {
                    //Redirectionam nodul din lista pentru a folosi drumul de cost minim
                    InchisListItem.F = vecinCost;
                    InchisListItem.ParentId = Nod_Curent.Id;
                }

                // Daca nu e nici deschis nici inchis, il adaugam in lista
                if (openListItem != null || InchisListItem != null) return ObtDetalii();
                _deschise.Add(new Nod(Id++, Nod_Curent.Id, thisvecin, Nod_Curent.G + cellWeight, 0));
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
                DistantaNodCurent = Nod_Curent == null ? 0 : Manhattan(Nod_Curent.Coord, Destinatie),
                NrNoduriDeschise = _deschise.Count,
                NrNoduriInchise = Inchis.Count,
                NrNoduriNeexplorate = Grid.GetCountOfType(Enums.CellType.Liber),
                NrOperatii = NrOperatii++
            };
        }
    }
}
