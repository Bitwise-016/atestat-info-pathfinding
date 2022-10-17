namespace Algoritmi
{
    using Grid;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public abstract class Baza
    {
        protected readonly Grid Grid;
        protected readonly List<Nod> Inchis;
        protected List<Coord> Path;
        protected readonly Coord origine;
        protected readonly Coord Destinatie;
        protected int Id;
        protected Nod Nod_Curent;
        protected int NrOperatii;
        public string Nume_Algoritm;

        protected Baza(Grid grid)
        {
            Grid = grid;
            Inchis = new List<Nod>();
            origine = Grid.GetStart().Coord;
            Destinatie = Grid.GetEnd().Coord;
            NrOperatii = 0;
            Id = 1;
        }

        public abstract Detalii GetPathTick();

        //Cautam coordonatele Nord, Sud, Est, Vest presupunand ca sunt valide
        protected virtual IEnumerable<Coord> ObtVecini(Nod Actual)
        {
            var vecini = new List<Cell>
            {
                Grid.GetCell(Actual.Coord.X - 1, Actual.Coord.Y),
                Grid.GetCell(Actual.Coord.X + 1, Actual.Coord.Y),
                Grid.GetCell(Actual.Coord.X, Actual.Coord.Y - 1),
                Grid.GetCell(Actual.Coord.X, Actual.Coord.Y + 1)
            };

            return vecini.Where(x => x.Type != Enums.CellType.Invalid && x.Type != Enums.CellType.Solid).Select(x => x.Coord).ToArray();
        }

        protected abstract Detalii ObtDetalii();

        protected static bool CoordsMatch(Coord a, Coord b) => a.X == b.X && a.Y == b.Y;

        //Returneaza distanta in "celule" ale matricii de la un punct X pana intr-un punct Y
        protected static int Manhattan(Coord origine, Coord destinatie)
        {
            return Math.Abs(origine.X - destinatie.X) + Math.Abs(origine.Y - destinatie.Y);
        }

        //returneaza costul drumului intre A si B si returneaza 0 daca drumul e invalid
        protected int GetPathCost()
        {
            if (Path == null) 
                return 0;

            var cost = 0;
            foreach (var step in Path)
                cost += Grid.GetCell(step.X, step.Y).Weight;

            return cost;
        }
    }
}
