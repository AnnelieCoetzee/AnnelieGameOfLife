using System;
using System.Collections.Generic;
using System.Text;

namespace AnnelieGameOfLife
{
    public sealed class LifeGame
    {

        #region Fields

        private List<int> _birthRules;
        private int _cells;
        private int _cols;
        private bool[] _currentStates;
        private int _liveCells;
        private bool[] _newStates;
        private int _rows;
        private bool[] _startStates;
        private List<int> _surviveRules;
        private string _unparsedRules;

        #endregion Fields

        #region Constructors

        public LifeGame(int gridSize)
            : this(gridSize, gridSize, "23/3")
        {
            // Called ctor with default rules
        }

        public LifeGame(int columns, int rows, string rules)
        {
            _cols = columns;
            _rows = rows;
            _cells = columns * rows;

            ClearGrid();
            _startStates = new bool[_cells];
            ChangeRules(rules);
        }

        #endregion Constructors

        #region Properties

        public int Cells { get { return _cells; } }
        public int Columns { get { return _cols; } }
        public bool[] GameGrid { get { return _currentStates; } }
        public int LiveCellCount { get { return _liveCells; } }
        public int Rows { get { return _rows; } }
        public string Rules { get { return _unparsedRules; } }

        #endregion Properties

        #region Methods

        public void ChangeRules(string rules)
        {
            _unparsedRules = rules;
            string survive = rules.Split('/')[0];
            string birth = rules.Split('/')[1];

            _surviveRules = new List<int>();
            _birthRules = new List<int>();

            for (int i = 0; i < survive.Length; i++)
            {
                _surviveRules.Add(Int32.Parse(survive.Substring(i, 1)));
            }
            for (int i = 0; i < birth.Length; i++)
            {
                _birthRules.Add(Int32.Parse(birth.Substring(i, 1)));
            }
        }

        public void ClearGrid()
        {
            _liveCells = 0;
            _currentStates = new bool[_cells];
            _newStates = new bool[_cells];
        }

        public bool GetCellState(int x, int y)
        {
            if (y < 0 || y >= _rows || x < 0 || x >= _cols)
            { return false; }

            return _currentStates[x + y * _cols];
        }

        public void Randomize(double probability)
        {
            Random rand = new Random();
            _liveCells = 0;
            for (int i = 0; i < _cells; i++)
            {
                _currentStates[i] = rand.NextDouble() <= probability;
                if (_currentStates[i])
                { _liveCells += 1; }
            }
        }

        public void ResetGrid()
        {
            _startStates.CopyTo(_currentStates, 0);
        }

        public void SetStart()
        {
            _currentStates.CopyTo(_startStates, 0);
        }

        public void Step()
        {
            advancePopulation();
            _newStates.CopyTo(_currentStates, 0);
        }
        public void ToggleCellState(int x, int y)
        {
            if (y < 0 || y >= _rows || x < 0 || x >= _cols)
            { return; }

            int index = x + y * _cols;
            _currentStates[index] = !(_currentStates[index]);

            if (_currentStates[index])
            { _liveCells += 1; }
            else
            { _liveCells -= 1; }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            for (int y = 0; y < _rows; y++)
            {
                for (int x = 0; x < _cols; x++)
                {
                    sb.Append(_currentStates[x + y * _cols] ? '*' : '.');
                }
                sb.AppendLine();
            }
            return sb.ToString();
        }

        private void advancePopulation()
        {
            if (_liveCells == 0)
            { return; }

            _liveCells = 0;
            int neighbors;
            int index;
            bool alive;

            for (int y = 0; y < _rows; y++)
            {
                for (int x = 0; x < _cols; x++)
                {
                    neighbors = getNeighbors(x, y);
                    index = x + y * _cols;
                    alive = _currentStates[index];

                    // If cell is alive and survives, or dead and is born
                    if ((alive && _surviveRules.Contains(neighbors)) ||
                        (!alive && _birthRules.Contains(neighbors)))
                    {
                        _newStates[index] = true;
                        _liveCells += 1;
                    }
                    else // The cell neither survives nor is born
                    { _newStates[index] = false; }
                }
            }
        }

        private int getNeighbors(int x, int y)
        {
            int neighborCount = 0;

            /* NW */
            if ((x > 0 && y > 0) && _currentStates[x - 1 + (y - 1) * _cols])
            { neighborCount += 1; }
            /* N  */
            if ((y > 0) && _currentStates[x + (y - 1) * _cols])
            { neighborCount += 1; }
            /* NE */
            if ((x + 1 < _cols && y > 0) && _currentStates[x + 1 + (y - 1) * _cols])
            { neighborCount += 1; }
            /* W  */
            if ((x + 1 < _cols) && _currentStates[x + 1 + y * _cols])
            { neighborCount += 1; }
            /* SW */
            if ((x + 1 < _cols && y + 1 < _rows) && _currentStates[x + 1 + (y + 1) * _cols])
            { neighborCount += 1; }
            /* S  */
            if ((y + 1 < _rows) && _currentStates[x + (y + 1) * _cols])
            { neighborCount += 1; }
            /* SE */
            if ((x > 0 && y + 1 < _rows) && _currentStates[x - 1 + (y + 1) * _cols])
            { neighborCount += 1; }
            /* E  */
            if ((x > 0) && _currentStates[x - 1 + y * _cols])
            { neighborCount += 1; }

            return neighborCount;
        }

        #endregion Methods

    }
}