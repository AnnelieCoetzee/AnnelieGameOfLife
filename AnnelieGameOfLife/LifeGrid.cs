using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace AnnelieGameOfLife
{
    public sealed partial class LifeGrid : UserControl
    {
        #region Variables
        private Color _cellColorAlive;
        private Color _cellColorDead;
        private int _cols;
        private bool[] _gridStates = new bool[100 * 100];
        private int _rows;
        #endregion

        #region Constructors

        public LifeGrid() : this(100, 100, Color.Black, Color.White)
        {
        }

        public LifeGrid(int cols, int rows, Color aliveColor, Color deadColor)
        {
            InitializeComponent();
            DoubleBuffered = true;
            TabStop = false;

            _cols = cols;
            _rows = rows;

            _cellColorAlive = aliveColor;
            _cellColorDead = deadColor;
        }

        #endregion Constructors

        #region Properties

        [Category("LifeGrid"),
        Description("Color for living cells."),
        DefaultValue(typeof(Color), "Black")]
        public Color CellColorAlive
        {
            get { return _cellColorAlive; }
            set { _cellColorAlive = value; Invalidate(); }
        }

        [Category("LifeGrid"),
        Description("Color for dead cells."),
        DefaultValue(typeof(Color), "White")]
        public Color CellColorDead
        {
            get { return _cellColorDead; }
            set { _cellColorDead = value; Invalidate(); }
        }

        [Category("LifeGrid"),
        Description("Number of Columns."),
        DefaultValue(100)]
        public int Columns
        {
            get { return _cols; }
            set { _cols = value; createGrid(); }
        }

        [Category("LifeGrid"),
                Description("Number of Rows."),
        DefaultValue(100)]
        public int Rows
        {
            get { return _rows; }
            set { _rows = value; createGrid(); }
        }

        #endregion Properties

        #region Methods

        public void UpdateGrid(bool[] gridStates)
        {
            if (gridStates.Length == _gridStates.Length)
            {
                gridStates.CopyTo(_gridStates, 0);
                Invalidate();
            }
            else
            {
                throw new InvalidOperationException("Grid sizes do not match.");
            }
        }

        private void createGrid()
        {
            _gridStates = new bool[_cols * _rows];
            Invalidate();
        }

        private void LifeGrid_Paint(object sender, PaintEventArgs e)
        {
            float cellWidth = (float)Width / _cols;
            float cellHeight = (float)Height / _rows;
            float line = 0;

            Graphics painter = e.Graphics;
            SolidBrush aliveBrush = new SolidBrush(_cellColorAlive);
            SolidBrush deadBrush = new SolidBrush(_cellColorDead);
            // Clear the control
            painter.FillRectangle(new SolidBrush(BackColor), new Rectangle(0, 0, Width, Height));

            for (int y = 0; y < _rows; y++)
            {
                for (int x = 0; x < _cols; x++)
                {
                    if (_gridStates[x + y * _cols])
                    {
                        painter.FillRectangle(aliveBrush, x * cellWidth, y * cellHeight,
                          cellWidth - line, cellHeight - line);
                    }
                    else
                    {
                        painter.FillRectangle(deadBrush, x * cellWidth, y * cellHeight,
                              cellWidth - line, cellHeight - line);
                    }
                }
            }
        }

        #endregion Methods
    }
}