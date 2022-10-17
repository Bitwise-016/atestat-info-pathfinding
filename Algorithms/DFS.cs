namespace Algoritmi
{
    using Grid;
    using System.Collections.Generic;
    using System.Linq;

    public class DFS : Baza
    {
        readonly Stack<Nod> _stiva = new Stack<Nod>();

        public DFS(Grid grid) : base (grid)
        {
            Nume_Algoritm = "DFS";

            // Adauga primul nod in stiva
            _stiva.Push(new Nod(Id++, null, origine, 0, 0));
        }

        public override Detalii GetPathTick()
        {
            // Verifica urmatorul nod din stiva pentru a vedea daca s-a gasit destinatia
            Nod_Curent = _stiva.Peek();
            if (CoordsMatch(Nod_Curent.Coord, Destinatie))
            {
                // Toate obiectele din stiva vor face parte din drumul parcurs asa ca le putem adauga direct 
                Path = new List<Coord>();
                foreach (var obj in _stiva)
                    Path.Add(obj.Coord);

                Path.Reverse();

                return ObtDetalii();
            }

            // Cautam toti vecinii nevizitati
            var vecini = ObtVecini(Nod_Curent).Where(x => !Vizitat(new Coord(x.X, x.Y))).ToArray();
            if (vecini.Any())
            {
                foreach (var vecin in vecini)
                    Grid.SetCell(vecin.X, vecin.Y, Enums.CellType.Open);

                // Luam vecinul si il adaugam in stiva
                var next = vecini.First();
                var newNod = new Nod(Id++, null, next.X, next.Y, 0, 0);
                _stiva.Push(newNod);
                Grid.SetCell(newNod.Coord.X, newNod.Coord.Y, Enums.CellType.Actual);
            }
            else
            {
                // Scoatem nodul nefolosit din stiva si il adaugam in lsita de celule inchise
                var abandonedCell = _stiva.Pop();
                Grid.SetCell(abandonedCell.Coord.X, abandonedCell.Coord.Y, Enums.CellType.Inchis);
                Inchis.Add(abandonedCell);
            }

            return ObtDetalii();
        }

        private bool Vizitat(Coord coord)
        {
            return _stiva.Any(x => CoordsMatch(x.Coord, coord)) || Inchis.Any(x => CoordsMatch(x.Coord, coord));
        }

        protected override Detalii ObtDetalii()
        {
            return new Detalii
            {
                Path = Path?.ToArray(),
                PathCost = GetPathCost(),
                UltimulNod = Nod_Curent,
                DistantaNodCurent = Nod_Curent == null ? 0 : Manhattan(Nod_Curent.Coord, Destinatie),
                NrNoduriDeschise = _stiva.Count,
                NrNoduriInchise = Inchis.Count,
                NrNoduriNeexplorate = Grid.GetCountOfType(Enums.CellType.Liber),
                NrOperatii = NrOperatii++
            };
        }
    }
}
