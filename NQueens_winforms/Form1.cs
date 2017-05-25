using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NQueens_winforms
{
    public partial class Form1 : Form
    {
        private logic _logic;
        private Timer _timer;

        public int Iteration { get; set; }

        public Form1()
        {
            InitializeComponent();

            _logic = new logic();
            _timer = new Timer();

            _logic.Queens = (int)nmbQueens.Value;

            _timer.Enabled = false;
            _timer.Interval = 1;

            _timer.Tick += new EventHandler(_timer_Tick);
            nmbQueens.ValueChanged += new EventHandler(nmbQueens_ValueChanged);
            btnStart.Click += new EventHandler(btnStart_Click);
            btnStop.Click += new EventHandler(btnStop_Click);
            btnReset.Click += new EventHandler(btnReset_Click);
            board1.MouseDown += new MouseEventHandler(board1_MouseDown);
        }

        private void UpdateDisplay()
        {
            lbliteration.Text = Iteration.ToString();
            board1.UpdateBoard(_logic.CurrentStates);
        }

        private void _timer_Tick(object sender, EventArgs e)
        {
            //logic.Step();
            
            Iteration++;
            UpdateDisplay();
        }

        private void nmbQueens_ValueChanged(object sender, EventArgs e)
        {
            board1.Queens = (int)nmbQueens.Value;
            _logic.Queens = (int)nmbQueens.Value;
            UpdateDisplay();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            _timer.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            _timer.Stop();
            UpdateDisplay();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            _timer.Stop();
            _logic.ClearBoard();
            Iteration = 0;
            UpdateDisplay();
        }

        private void board1_MouseDown(object sender, MouseEventArgs e)
        {
            int y = (int)(((float)e.Y) / (board1.Height / (float)nmbQueens.Value));
            int x = (int)(((float)e.X) / (board1.Width / (float)nmbQueens.Value));

            _logic.ClearBoard();
            _logic.SetSquare(x, y);

            UpdateDisplay();
        }

    }
}
