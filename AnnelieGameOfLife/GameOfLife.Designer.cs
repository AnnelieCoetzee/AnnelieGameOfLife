using System.Drawing;

namespace AnnelieGameOfLife
{
    partial class GameOfLife
    {
        private AnnelieGameOfLife.LifeGrid lifeGrid;
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnRandomize;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStep;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnZoomIn;
        private System.Windows.Forms.Button btnZoomOut;
        private System.Windows.Forms.Label lblPopulation;
        private System.Windows.Forms.Label lblStepNumber;
        private System.Windows.Forms.Label lblZoom;
        private System.Windows.Forms.Label lblZoomCount;
        private System.Windows.Forms.Panel pnlScroller;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnRandomize = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnStep = new System.Windows.Forms.Button();
            this.pnlScroller = new System.Windows.Forms.Panel();
            this.btnZoomOut = new System.Windows.Forms.Button();
            this.btnZoomIn = new System.Windows.Forms.Button();
            this.lblZoom = new System.Windows.Forms.Label();
            this.lblZoomCount = new System.Windows.Forms.Label();
            this.lblStepNumber = new System.Windows.Forms.Label();
            this.lblPopulation = new System.Windows.Forms.Label();
            this.lifeGrid = new AnnelieGameOfLife.LifeGrid();
            this.pnlScroller.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(202)))), ((int)(((byte)(210)))));
            this.btnStart.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Location = new System.Drawing.Point(10, 3);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(88, 26);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "&Start";
            this.btnStart.UseVisualStyleBackColor = false;
            // 
            // btnStop
            // 
            this.btnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(202)))), ((int)(((byte)(210)))));
            this.btnStop.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Location = new System.Drawing.Point(10, 37);
            this.btnStop.Margin = new System.Windows.Forms.Padding(4);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(88, 26);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "S&top";
            this.btnStop.UseVisualStyleBackColor = false;
            // 
            // btnRandomize
            // 
            this.btnRandomize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRandomize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(202)))), ((int)(((byte)(210)))));
            this.btnRandomize.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnRandomize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRandomize.Location = new System.Drawing.Point(105, 37);
            this.btnRandomize.Margin = new System.Windows.Forms.Padding(4);
            this.btnRandomize.Name = "btnRandomize";
            this.btnRandomize.Size = new System.Drawing.Size(88, 26);
            this.btnRandomize.TabIndex = 6;
            this.btnRandomize.Text = "R&andomize";
            this.btnRandomize.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(202)))), ((int)(((byte)(210)))));
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Location = new System.Drawing.Point(10, 71);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(88, 26);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(202)))), ((int)(((byte)(210)))));
            this.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Location = new System.Drawing.Point(106, 71);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(88, 26);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            // 
            // btnStep
            // 
            this.btnStep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(202)))), ((int)(((byte)(210)))));
            this.btnStep.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnStep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStep.Location = new System.Drawing.Point(105, 3);
            this.btnStep.Margin = new System.Windows.Forms.Padding(4);
            this.btnStep.Name = "btnStep";
            this.btnStep.Size = new System.Drawing.Size(88, 26);
            this.btnStep.TabIndex = 2;
            this.btnStep.Text = "Ste&p";
            this.btnStep.UseVisualStyleBackColor = false;
            // 
            // pnlScroller
            // 
            this.pnlScroller.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlScroller.AutoScroll = true;
            this.pnlScroller.CausesValidation = false;
            this.pnlScroller.Controls.Add(this.lifeGrid);
            this.pnlScroller.Location = new System.Drawing.Point(11, 105);
            this.pnlScroller.Margin = new System.Windows.Forms.Padding(4);
            this.pnlScroller.Name = "pnlScroller";
            this.pnlScroller.Size = new System.Drawing.Size(595, 593);
            this.pnlScroller.TabIndex = 7;
            // 
            // btnZoomOut
            // 
            this.btnZoomOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnZoomOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(202)))), ((int)(((byte)(210)))));
            this.btnZoomOut.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnZoomOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZoomOut.Location = new System.Drawing.Point(324, 66);
            this.btnZoomOut.Margin = new System.Windows.Forms.Padding(4);
            this.btnZoomOut.Name = "btnZoomOut";
            this.btnZoomOut.Size = new System.Drawing.Size(27, 26);
            this.btnZoomOut.TabIndex = 8;
            this.btnZoomOut.Text = "-";
            this.btnZoomOut.UseVisualStyleBackColor = false;
            // 
            // btnZoomIn
            // 
            this.btnZoomIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnZoomIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(202)))), ((int)(((byte)(210)))));
            this.btnZoomIn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnZoomIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZoomIn.Location = new System.Drawing.Point(289, 65);
            this.btnZoomIn.Margin = new System.Windows.Forms.Padding(4);
            this.btnZoomIn.Name = "btnZoomIn";
            this.btnZoomIn.Size = new System.Drawing.Size(27, 26);
            this.btnZoomIn.TabIndex = 9;
            this.btnZoomIn.Text = "+";
            this.btnZoomIn.UseVisualStyleBackColor = false;
            // 
            // lblZoom
            // 
            this.lblZoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblZoom.AutoSize = true;
            this.lblZoom.Location = new System.Drawing.Point(199, 75);
            this.lblZoom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblZoom.Name = "lblZoom";
            this.lblZoom.Size = new System.Drawing.Size(84, 17);
            this.lblZoom.TabIndex = 10;
            this.lblZoom.Text = "Zoom In/Out:";
            this.lblZoom.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lblZoomCount
            // 
            this.lblZoomCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblZoomCount.AutoSize = true;
            this.lblZoomCount.Location = new System.Drawing.Point(359, 71);
            this.lblZoomCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblZoomCount.Name = "lblZoomCount";
            this.lblZoomCount.Size = new System.Drawing.Size(15, 17);
            this.lblZoomCount.TabIndex = 11;
            this.lblZoomCount.Text = "1";
            // 
            // lblStepNumber
            // 
            this.lblStepNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblStepNumber.AutoSize = true;
            this.lblStepNumber.Location = new System.Drawing.Point(199, 9);
            this.lblStepNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStepNumber.Name = "lblStepNumber";
            this.lblStepNumber.Size = new System.Drawing.Size(35, 17);
            this.lblStepNumber.TabIndex = 12;
            this.lblStepNumber.Text = "Gen:";
            // 
            // lblPopulation
            // 
            this.lblPopulation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPopulation.AutoSize = true;
            this.lblPopulation.Location = new System.Drawing.Point(199, 37);
            this.lblPopulation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPopulation.Name = "lblPopulation";
            this.lblPopulation.Size = new System.Drawing.Size(36, 17);
            this.lblPopulation.TabIndex = 13;
            this.lblPopulation.Text = "Pop: ";
            // 
            // lifeGrid
            // 
            this.lifeGrid.CellColorAlive = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(202)))), ((int)(((byte)(210)))));
            this.lifeGrid.CellColorDead = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(167)))), ((int)(((byte)(158)))));
            this.lifeGrid.Location = new System.Drawing.Point(4, 5);
            this.lifeGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lifeGrid.Name = "lifeGrid";
            this.lifeGrid.Size = new System.Drawing.Size(584, 577);
            this.lifeGrid.TabIndex = 15;
            this.lifeGrid.TabStop = false;
            // 
            // GameOfLife
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 692);
            this.Controls.Add(this.lblPopulation);
            this.Controls.Add(this.lblStepNumber);
            this.Controls.Add(this.lblZoomCount);
            this.Controls.Add(this.lblZoom);
            this.Controls.Add(this.btnZoomIn);
            this.Controls.Add(this.btnZoomOut);
            this.Controls.Add(this.btnStep);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRandomize);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pnlScroller);
            this.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "GameOfLife";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game of Life";
            this.pnlScroller.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}