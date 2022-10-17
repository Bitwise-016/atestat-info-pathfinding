namespace Algoritmi
{
    using Grid;
    using System.Collections.Generic;
    using System.Linq;

    public class BFS : Baza
    {
        private readonly Queue<Nod> _q = new Queue<Nod>();
        private bool _gasitDestinatie;

        public BFS(Grid grid) : base (grid)
        {
            Nume_Algoritm = "BFS";

            // Adauga primul nod in coada
            _q.Enqueue(new Nod(Id++, null, origine, 0, 0));
        }

        public override Detalii GetPathTick()
        {
            // Daca inca nu s-a gasit destinatia si mai avem noduri in coada, analizam urmatorul nod din coada
            if (_q.Count > 0 && !_gasitDestinatie)
            {
                // Ia urmatorul nod din coada si verifica daca a fost sau nu vizitat
                Nod_Curent = _q.Dequeue();
                if (Vizitat(Nod_Curent.Coord)) return ObtDetalii();

                // Adauga nodul in lista celor deja vizitate
                Inchis.Add(Nod_Curent);
                Grid.SetCell(Nod_Curent.Coord.X, Nod_Curent.Coord.Y, Enums.CellType.Inchis);

                // Parcurge vecinii nodului spre Nord, Sud, Est, Vest pentru a adauga in coada de vizitat pe cei nevizitati
                var vecini = ObtVecini(Nod_Curent);
                foreach (var vecin in vecini)
                {
                    if (Vizitat(vecin)) 
                        continue;

                    var vecinNod = new Nod(Id++, Nod_Curent.Id, vecin.X, vecin.Y, 0, 0);
                    _q.Enqueue(vecinNod);
                    Grid.SetCell(vecin, Enums.CellType.Open);

                    if (!CoordsMatch(vecin, Destinatie)) 
                        continue;

                    // Verifica daca am gasit destinatia
                    Inchis.Add(vecinNod);
                    _gasitDestinatie = true;
                }
            }
            else
            {
                // Drumul a fost gasit asa ca il construim de la A la B si il afisam
                Path = new List<Coord>();

                var step = Inchis.First(x => CoordsMatch(x.Coord, Destinatie));
                while (!CoordsMatch(step.Coord, origine))
                {
                    Path.Add(step.Coord);
                    step = Inchis.First(x => x.Id == step.ParentId);
                }

                Path.Add(origine);
                Path.Reverse();
            }

            return ObtDetalii();
        }

        private bool Vizitat(Coord coord)
        {
            return Inchis.Any(x => CoordsMatch(x.Coord, coord));
        }

        protected override Detalii ObtDetalii()
        {
            return new Detalii
            {
                Path = Path?.ToArray(),
                PathCost = GetPathCost(),
                UltimulNod = Nod_Curent,
                DistantaNodCurent = Nod_Curent == null ? 0 : Manhattan(Nod_Curent.Coord, Destinatie),
                NrNoduriDeschise = _q.Count,
                NrNoduriInchise = Inchis.Count,
                NrNoduriNeexplorate = Grid.GetCountOfType(Enums.CellType.Liber),
                NrOperatii = NrOperatii++
            };
        }
    }
}
