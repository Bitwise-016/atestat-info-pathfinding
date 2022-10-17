namespace Algoritmi
{
    using Grid;

    public class Detalii
    {
        public bool ExistaDrum => GasitDrum || NrNoduriDeschise > 0;
        public bool GasitDrum => Path != null;
        public Coord[] Path { get; set; }
        public int PathCost { get; set; }
        public Nod UltimulNod { get; set; }
        public int DistantaNodCurent { get; set; }
        public int NrNoduriDeschise { get; set; }
        public int NrNoduriInchise { get; set; }
        public int NrNoduriNeexplorate { get; set; }
        public int NrOperatii { get; set; }
    }
}
