namespace NQueens_winforms
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lbliteration = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nmbQueens = new System.Windows.Forms.NumericUpDown();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.board1 = new NQueens_winforms.board();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nmbQueens)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(533, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Iteration:";
            // 
            // lbliteration
            // 
            this.lbliteration.AutoSize = true;
            this.lbliteration.Location = new System.Drawing.Point(614, 24);
            this.lbliteration.Name = "lbliteration";
            this.lbliteration.Size = new System.Drawing.Size(13, 13);
            this.lbliteration.TabIndex = 2;
            this.lbliteration.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(533, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Queens:";
            // 
            // nmbQueens
            // 
            this.nmbQueens.Location = new System.Drawing.Point(536, 86);
            this.nmbQueens.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nmbQueens.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nmbQueens.Name = "nmbQueens";
            this.nmbQueens.Size = new System.Drawing.Size(120, 20);
            this.nmbQueens.TabIndex = 4;
            this.nmbQueens.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(570, 129);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(570, 172);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 6;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // board1
            // 
            this.board1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.board1.Location = new System.Drawing.Point(12, 12);
            this.board1.Name = "board1";
            this.board1.Queens = 4;
            this.board1.Size = new System.Drawing.Size(500, 500);
            this.board1.TabIndex = 0;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(570, 211);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 536);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.nmbQueens);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbliteration);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.board1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nmbQueens)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private board board1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbliteration;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nmbQueens;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnReset;
    }
}

