using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AnnelieGameOfLife
{
    internal enum ZoomType
    { In, Out }

    public partial class GameOfLife : Form
    {

        #region Fields

        private List<string> _gameRules;
        private int _gridSize;
        private LifeGame _lifeGame;
        private double _probability;
        private DateTime _startTime;
        private int _stepNumber;
        private DateTime _stopTime;
        private Timer _timer;
        private int _zoomCount;
        private int _zoomMax;
        private double _zoomRate;
        private int _zoomStartX;
        private int _zoomStartY;

        #endregion Fields

        #region Constructors

        public GameOfLife()
        {
            InitializeComponent();
            _probability = 0.25;
            _gridSize = 250;
            _stepNumber = 0;

            _zoomStartX = pnlScroller.Width;
            _zoomStartY = pnlScroller.Height;
            _zoomMax = 5;
            _zoomRate = 1.5;
            _zoomCount = 0;

            _lifeGame = new LifeGame(_gridSize);
            _timer = new Timer();
            _gameRules = new List<string>();

            lifeGrid.Columns = _gridSize;
            lifeGrid.Rows = _gridSize;

            _timer.Enabled = false;
            _timer.Interval = 1;

            _timer.Tick += new EventHandler(_timer_Tick);

            lifeGrid.MouseDown += new MouseEventHandler(lifeGrid_MouseDown);

            btnStart.Click += new EventHandler(btnStart_Click);
            btnStop.Click += new EventHandler(btnStop_Click);
            btnStep.Click += new EventHandler(btnStep_Click);

            btnReset.Click += new EventHandler(btnReset_Click);
            btnClear.Click += new EventHandler(btnClear_Click);
            btnRandomize.Click += new EventHandler(btnRandomize_Click);

            btnZoomIn.Click += new EventHandler(btnZoomIn_Click);
            btnZoomOut.Click += new EventHandler(btnZoomOut_Click);
        }

        #endregion Constructors

        #region Methods

        private void _timer_Tick(object sender, EventArgs e)
        {
            _lifeGame.Step();
            _stepNumber += 1;

            if (_stepNumber % 6 == 0)
            { updateFormVisuals(); }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            _timer.Stop();
            _lifeGame.ClearGrid();
            _stepNumber = 0;

            updateFormVisuals();
        }

        private void btnRandomize_Click(object sender, EventArgs e)
        {
            _lifeGame.Randomize(_probability);
            _stepNumber = 0;

            updateFormVisuals();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            _timer.Stop();
            _lifeGame.ResetGrid();
            _stepNumber = 0;

            updateFormVisuals();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            _lifeGame.Randomize(_probability);
            _stepNumber = 0;
            updateFormVisuals();
            _lifeGame.SetStart();
            _timer.Start();
            _startTime = DateTime.Now;
        }

        private void btnStep_Click(object sender, EventArgs e)
        {
            _timer.Stop();
            _lifeGame.Step();
            _stepNumber += 1;

            updateFormVisuals();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            _timer.Stop();
            updateFormVisuals();
        }

        private void btnZoomIn_Click(object sender, EventArgs e)
        {
            zoomView(ZoomType.In);
        }

        private void btnZoomOut_Click(object sender, EventArgs e)
        {
            zoomView(ZoomType.Out);
        }

        private void lifeGrid_MouseDown(object sender, MouseEventArgs e)
        {
            int y = (int)(((float)e.Y) * _lifeGame.Rows / lifeGrid.Height);
            int x = (int)(((float)e.X) * _lifeGame.Columns / lifeGrid.Width);

            _lifeGame.ToggleCellState(x, y);
            lifeGrid.UpdateGrid(_lifeGame.GameGrid);
        }

        private void runTest(int gridSize)
        {
            LifeGame lifeSim = new LifeGame(gridSize);
            lifeSim.Randomize(.25);

            int startCount = lifeSim.LiveCellCount;

            _startTime = DateTime.Now;
            for (int i = 0; i < 1000; i++)
            {
                lifeSim.Step();
            }
            _stopTime = DateTime.Now;

            MessageBox.Show("Initial population of " + startCount +
                ".\n\n1000 random generations took " + (_stopTime - _startTime));
        }

        private void updateFormVisuals()
        {
            lblStepNumber.Text = "Gen: ";
            if (_stepNumber > 0)
            { lblStepNumber.Text += _stepNumber.ToString(); }

            lblPopulation.Text = "Pop: ";
            if (_lifeGame.LiveCellCount > 0)
            { lblPopulation.Text += _lifeGame.LiveCellCount; }

            lblZoomCount.Text = (_zoomCount + 1).ToString();

            lifeGrid.UpdateGrid(_lifeGame.GameGrid);
        }

        private void zoomView(ZoomType zoomType)
        {
            if (zoomType == ZoomType.In)
            {
                if ((lifeGrid.Width < (_zoomMax * _zoomStartX)) &&
                    (lifeGrid.Height < (_zoomMax * _zoomStartY)))
                {
                    lifeGrid.Width = Convert.ToInt32(lifeGrid.Width * _zoomRate);
                    lifeGrid.Height = Convert.ToInt32(lifeGrid.Height * _zoomRate);
                    _zoomCount += 1;
                }
            }
            else
            {
                if ((lifeGrid.Width > _zoomStartX) ||
                    (lifeGrid.Height > _zoomStartY))
                {
                    lifeGrid.Width = Convert.ToInt32(lifeGrid.Width / _zoomRate);
                    lifeGrid.Height = Convert.ToInt32(lifeGrid.Height / _zoomRate);
                    _zoomCount -= 1;
                }
            }
            updateFormVisuals();
        }

        #endregion Methods
    }
}