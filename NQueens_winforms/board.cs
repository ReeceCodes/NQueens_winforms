using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NQueens_winforms
{
    public partial class board : UserControl
    {
        #region properties
        public int Queens
        {
            get
            {
                return _queens;
            }
            set
            {
                _queens = value;
                CreateBoard();
            }
        }

        #endregion
        //initially I was going to use a bool but there are three states I need to know, available, unavailable, queened (0,1,2). 
        //if it's queened or unavailable then it's 'filled'. this should make it so that I can find the next 'available' spot for a queens
        private int[] theboard = new int[16]; //minimum
        private int _queens;

        public board() : this(4) { } //4 is the smallest board size with a solution

        public board(int queens)
        {
            Queens = queens;

            this.Paint += new PaintEventHandler(board_Paint);
        }

        public void CreateBoard()
        {
            theboard = new int[Queens * Queens];
            Invalidate();
        }

        public void UpdateBoard(int[] boardstates)
        {
            if (boardstates.Length == theboard.Length)
            {
                boardstates.CopyTo(theboard, 0);
                Invalidate();
            }
        }

        public void board_Paint(object sender, PaintEventArgs e)
        {
            float squaresize = (float)Width / Queens; //it's a square so I only need to have a width or height

            Graphics painter = e.Graphics;
            SolidBrush square1 = new SolidBrush(Color.White);
            SolidBrush square2 = new SolidBrush(Color.Black);
            SolidBrush filled = new SolidBrush(Color.Red);

            painter.FillRectangle(new SolidBrush(BackColor), new Rectangle(0, 0, Width, Height));

            for (int y = 0; y < Queens; y++)
            {
                for (int x = 0; x < Queens; x++)
                {
                    //fill every other one with alternating colors, if it's a filled space then use the filled color                    
                    if ((x + y) % 2 == 0)
                    {
                        painter.FillRectangle(square1, x * squaresize, y * squaresize, squaresize, squaresize);
                    }
                    else
                    {
                        painter.FillRectangle(square2, x * squaresize, y * squaresize, squaresize, squaresize);
                    }

                    if (theboard[x + y * Queens] == 2) //has a queen
                    {
                        painter.FillRectangle(filled, x * squaresize, y * squaresize, squaresize, squaresize);
                    }
                }
            }
        }

    }
}
