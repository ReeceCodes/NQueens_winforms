using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NQueens_winforms
{
    class logic
    {
        public int Queens { get; set; }

        public int PlacedQueens { get; set; }

        public int[] CurrentStates
        {
            get { return _currentStates; }
            set { _currentStates = value; }
        }

        private int[] _currentStates;

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

        


    }
}
