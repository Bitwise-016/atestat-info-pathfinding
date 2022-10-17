namespace GUI
{
    using Classes;
    using System;
    using System.Windows.Forms;
    using Algoritmi;
    using Grid;
    using System.Linq;

    public partial class Main : Form
    {
        private MazeDrawer _matrice_de_desenat;
        private Baza[] _algoritmi;
        private int _algoritm_Actual;
        private LabelCollection[] _nume = new LabelCollection[4];
        private System.Timers.Timer _pathTimer;
        private const int Delay = 5;

        public Main()
        {
            InitializeComponent();

            // Un Timer care ofera un delay pentru a putea vizualiza algoritmul (se poate reduce in cazul pc-urilor mai slabe)
            _pathTimer = new System.Timers.Timer(Delay);
            _pathTimer.Elapsed += PathTimer_Elapsed;

            // Vectorul pentru colectarea rezultatelor algoritmilor
            _nume[0] = new LabelCollection
            {
                AlgoritmId = 0,
                Labels = new[] { lblAlgoritm, lblDijkstraOp, lblDijkstraNE, lblDijkstraOpen, lblDijkstraInchis, lblDijkstraLung }
            };
            _nume[1] = new LabelCollection
            {
                AlgoritmId = 1,
                Labels = new[] { lblAlgoritm, lblAStarOp, lblAStarNE, lblAStarOpen, lblAStarInchis, lblAStarLung }
            };
            _nume[2] = new LabelCollection
            {
                AlgoritmId = 2,
                Labels = new[] { lblAlgoritm, lblBfsOp, lblBfsNE, lblBreadthFirstOpen, lblBreadthFirstInchis, lblBfsLung }
            };
            _nume[3] = new LabelCollection
            {
                AlgoritmId = 3,
                Labels = new[] { lblAlgoritm, lblDfsOp, lblDfsNE, lblDepthFirstOpen, lblDepthFirstInchis, lblDfsLung }
            };

            Initializare();
        }

        // Initializare (Matrice+Variabile)
        private void Initializare()
        {
            _pathTimer.Stop();

            // Generam matrici pana gasim una cu drum valid din A in B
            var radacina_buna = 0;
            while (radacina_buna == 0)
                radacina_buna = Gaseste_Radacina_Buna();

            // Initializam algoritmul si desenam matricea
            _algoritm_Actual = -1;
            _matrice_de_desenat = new MazeDrawer(pbMaze, radacina_buna);
            _algoritmi = new Baza[] { new Dijkstra(_matrice_de_desenat.Grid), new AStar(_matrice_de_desenat.Grid), new BFS(_matrice_de_desenat.Grid), new DFS(_matrice_de_desenat.Grid) };
            Text = @"Path Finding " + _matrice_de_desenat.Seed;
            _matrice_de_desenat.Draw();
        }

        //Generam matrici pana gasim una cu un drum valid A->B
        private int Gaseste_Radacina_Buna()
        {
            var testMazeDrawer = new MazeDrawer(pbMaze);
            var testPathFinder = new DFS(testMazeDrawer.Grid);
            var progress = testPathFinder.GetPathTick();
            while (progress.ExistaDrum && !progress.GasitDrum)
            {
                progress = testPathFinder.GetPathTick();
            }

            return progress.GasitDrum ? testMazeDrawer.Seed : 0;
        }

        // Obtinem urmatorul pas din cautarea drumului
        private void PathTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            _pathTimer.Stop();
            var resetTimer = false;

            // Treci la urmatorul pas in algoritm
            var searchStatus = _algoritmi[_algoritm_Actual].GetPathTick();
            StatsUpdate(searchStatus);

            // Daca am gasit un drum, il desenam, daca nu, actualizam pozitia actuala in matrice
            if (searchStatus.GasitDrum)
            {
                Deseneaza_Drum(searchStatus);
            }
            else
            {
                _matrice_de_desenat.Draw();
                
                resetTimer = true;
            }

            if (resetTimer) _pathTimer.Start();
        }

        //Desenarea caii gasite in matrice
        private void Deseneaza_Drum(Detalii details)
        {
            for (var i = 1; i < details.Path.Length - 1; i++)
            {
                var pas = details.Path[i];
                _matrice_de_desenat.Grid.SetCell(pas.X, pas.Y, Enums.CellType.Path);
                _matrice_de_desenat.Draw();
                System.Threading.Thread.Sleep(25);
            }

        }
        // Actualizam starea (afisajul) in functie de algoritmul actual
        private void StatsUpdate(Detalii details)
        {
            var labelCollection = _nume.First(x => x.AlgoritmId == _algoritm_Actual);

            labelCollection.Labels[0].BeginInvoke((MethodInvoker)delegate { labelCollection.Labels[0].Text = "Algoritm utilizat: " + _algoritmi[_algoritm_Actual].Nume_Algoritm; });
            labelCollection.Labels[1].BeginInvoke((MethodInvoker)delegate { labelCollection.Labels[1].Text = details.NrOperatii.ToString(); });
            labelCollection.Labels[2].BeginInvoke((MethodInvoker)delegate { labelCollection.Labels[2].Text = details.NrNoduriNeexplorate.ToString(); });
            labelCollection.Labels[3].BeginInvoke((MethodInvoker)delegate { labelCollection.Labels[3].Text = details.NrNoduriDeschise.ToString(); });
            labelCollection.Labels[4].BeginInvoke((MethodInvoker)delegate { labelCollection.Labels[4].Text = details.NrNoduriInchise.ToString(); });
            labelCollection.Labels[5].BeginInvoke((MethodInvoker)delegate { labelCollection.Labels[5].Text = details.GasitDrum ? $"{details.Path.Length}/{details.PathCost}" : "?/?"; });
        }

        // Porneste urmatorul algoritm
        private void BtnGo_Click(object sender, EventArgs e)
        {
            _algoritm_Actual++;
            if (_algoritm_Actual == _algoritmi.Length) return;
            _matrice_de_desenat.Reset();

            _pathTimer.Start();
        }

        //Genereaza o noua matrice
        private void BtnMaze_Click(object sender, EventArgs e)
        {
            Initializare();
        }
        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
