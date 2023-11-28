namespace Osero
{
    partial class result
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
            groupBox1 = new GroupBox();
            lblBlackPoint = new Label();
            lblWhitePoint = new Label();
            WhitePoint = new GroupBox();
            lblWinner = new Label();
            Winner = new Label();
            Rematch = new Button();
            End = new Button();
            groupBox1.SuspendLayout();
            WhitePoint.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblBlackPoint);
            groupBox1.Font = new Font("游ゴシック", 24F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(53, 26);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(141, 103);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "黒";
            // 
            // lblBlackPoint
            // 
            lblBlackPoint.AutoSize = true;
            lblBlackPoint.Location = new Point(43, 46);
            lblBlackPoint.Name = "lblBlackPoint";
            lblBlackPoint.Size = new Size(54, 42);
            lblBlackPoint.TabIndex = 0;
            lblBlackPoint.Text = "00";
            // 
            // lblWhitePoint
            // 
            lblWhitePoint.AutoSize = true;
            lblWhitePoint.Location = new Point(43, 46);
            lblWhitePoint.Name = "lblWhitePoint";
            lblWhitePoint.Size = new Size(54, 42);
            lblWhitePoint.TabIndex = 0;
            lblWhitePoint.Text = "00";
            // 
            // WhitePoint
            // 
            WhitePoint.Controls.Add(lblWhitePoint);
            WhitePoint.Font = new Font("游ゴシック", 24F, FontStyle.Bold, GraphicsUnit.Point);
            WhitePoint.Location = new Point(235, 25);
            WhitePoint.Name = "WhitePoint";
            WhitePoint.Size = new Size(141, 103);
            WhitePoint.TabIndex = 1;
            WhitePoint.TabStop = false;
            WhitePoint.Text = "白";
            // 
            // lblWinner
            // 
            lblWinner.AutoSize = true;
            lblWinner.Font = new Font("游ゴシック", 48F, FontStyle.Bold, GraphicsUnit.Point);
            lblWinner.ForeColor = Color.Red;
            lblWinner.Location = new Point(124, 132);
            lblWinner.Name = "lblWinner";
            lblWinner.Size = new Size(301, 82);
            lblWinner.TabIndex = 2;
            lblWinner.Text = "Winner!!";
            // 
            // Winner
            // 
            Winner.AutoSize = true;
            Winner.Font = new Font("游ゴシック", 48F, FontStyle.Bold, GraphicsUnit.Point);
            Winner.Location = new Point(32, 131);
            Winner.Name = "Winner";
            Winner.Size = new Size(99, 82);
            Winner.TabIndex = 3;
            Winner.Text = "駒";
            // 
            // Rematch
            // 
            Rematch.BackColor = Color.DarkTurquoise;
            Rematch.Font = new Font("游ゴシック", 24F, FontStyle.Bold, GraphicsUnit.Point);
            Rematch.Location = new Point(53, 236);
            Rematch.Name = "Rematch";
            Rematch.Size = new Size(141, 48);
            Rematch.TabIndex = 4;
            Rematch.Text = "再戦";
            Rematch.UseVisualStyleBackColor = false;
            Rematch.Click += Rematch_Click;
            // 
            // End
            // 
            End.BackColor = Color.Crimson;
            End.Font = new Font("游ゴシック", 24F, FontStyle.Bold, GraphicsUnit.Point);
            End.Location = new Point(235, 236);
            End.Name = "End";
            End.Size = new Size(141, 48);
            End.TabIndex = 5;
            End.Text = "終了";
            End.UseVisualStyleBackColor = false;
            End.Click += End_Click;
            // 
            // result
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(428, 296);
            Controls.Add(End);
            Controls.Add(Rematch);
            Controls.Add(Winner);
            Controls.Add(lblWinner);
            Controls.Add(WhitePoint);
            Controls.Add(groupBox1);
            Name = "result";
            Text = "対戦結果";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            WhitePoint.ResumeLayout(false);
            WhitePoint.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label lblBlackPoint;
        private Label lblWhitePoint;
        private GroupBox WhitePoint;
        private Label lblWinner;
        private Label Winner;
        private Button Rematch;
        private Button End;
    }
}