using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NQueens_winforms
{
    class logic
    {
        public int Queens
        { 
            get { return _queens; }
            set { _queens = value; ClearBoard(); }
        }

        public int PlacedQueens { get; set; }

        public int[] CurrentStates
        {
            get { return _currentStates; }
            set { _currentStates = value; }
        }

        private int[] _currentStates;
        private int _queens;

        public int IsAllowed(int x, int y)
        {
            if ( x < 0 || y < 0 || x > Queens || y > Queens)
            {
                return 0;
            }

            return CurrentStates[x + (y * Queens)];
        }

        public void ClearBoard()
        {
            _currentStates = new int[Queens*Queens];
        }

        public void SetSquare(int x, int y)
        {
            CurrentStates[x + (y * Queens)] = 2;
            PlacedQueens = 1;
        }

        


    }
}
