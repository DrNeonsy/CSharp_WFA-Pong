namespace CSharp_WFA_Pong
{
    partial class Game
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.playerOne = new System.Windows.Forms.PictureBox();
            this.gameLoop = new System.Windows.Forms.Timer(this.components);
            this.scoreLeftSide = new System.Windows.Forms.Label();
            this.scoreRightSide = new System.Windows.Forms.Label();
            this.playerTwo = new System.Windows.Forms.PictureBox();
            this.pongBall = new System.Windows.Forms.PictureBox();
            this.sep1 = new System.Windows.Forms.PictureBox();
            this.sep2 = new System.Windows.Forms.PictureBox();
            this.sep3 = new System.Windows.Forms.PictureBox();
            this.sep4 = new System.Windows.Forms.PictureBox();
            this.sep5 = new System.Windows.Forms.PictureBox();
            this.sep6 = new System.Windows.Forms.PictureBox();
            this.sep7 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.playerOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pongBall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sep1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sep2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sep3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sep4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sep5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sep6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sep7)).BeginInit();
            this.SuspendLayout();
            // 
            // playerOne
            // 
            this.playerOne.BackColor = System.Drawing.Color.OrangeRed;
            this.playerOne.Location = new System.Drawing.Point(9, 500);
            this.playerOne.Margin = new System.Windows.Forms.Padding(0);
            this.playerOne.Name = "playerOne";
            this.playerOne.Size = new System.Drawing.Size(6, 150);
            this.playerOne.TabIndex = 0;
            this.playerOne.TabStop = false;
            // 
            // gameLoop
            // 
            this.gameLoop.Enabled = true;
            this.gameLoop.Interval = 5;
            this.gameLoop.Tick += new System.EventHandler(this.Loop);
            // 
            // scoreLeftSide
            // 
            this.scoreLeftSide.BackColor = System.Drawing.Color.Transparent;
            this.scoreLeftSide.Font = new System.Drawing.Font("Calibri", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.scoreLeftSide.ForeColor = System.Drawing.Color.OrangeRed;
            this.scoreLeftSide.Location = new System.Drawing.Point(720, 9);
            this.scoreLeftSide.Name = "scoreLeftSide";
            this.scoreLeftSide.Size = new System.Drawing.Size(97, 54);
            this.scoreLeftSide.TabIndex = 1;
            this.scoreLeftSide.Text = "0";
            this.scoreLeftSide.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // scoreRightSide
            // 
            this.scoreRightSide.BackColor = System.Drawing.Color.Transparent;
            this.scoreRightSide.Font = new System.Drawing.Font("Calibri", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.scoreRightSide.ForeColor = System.Drawing.Color.BlueViolet;
            this.scoreRightSide.Location = new System.Drawing.Point(1086, 9);
            this.scoreRightSide.Name = "scoreRightSide";
            this.scoreRightSide.Size = new System.Drawing.Size(84, 54);
            this.scoreRightSide.TabIndex = 3;
            this.scoreRightSide.Text = "0";
            this.scoreRightSide.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // playerTwo
            // 
            this.playerTwo.BackColor = System.Drawing.Color.BlueViolet;
            this.playerTwo.Location = new System.Drawing.Point(1883, 500);
            this.playerTwo.Margin = new System.Windows.Forms.Padding(0);
            this.playerTwo.Name = "playerTwo";
            this.playerTwo.Size = new System.Drawing.Size(6, 150);
            this.playerTwo.TabIndex = 5;
            this.playerTwo.TabStop = false;
            // 
            // pongBall
            // 
            this.pongBall.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.pongBall.Location = new System.Drawing.Point(926, 461);
            this.pongBall.Name = "pongBall";
            this.pongBall.Size = new System.Drawing.Size(21, 21);
            this.pongBall.TabIndex = 6;
            this.pongBall.TabStop = false;
            // 
            // sep1
            // 
            this.sep1.BackColor = System.Drawing.Color.White;
            this.sep1.Location = new System.Drawing.Point(932, 12);
            this.sep1.Name = "sep1";
            this.sep1.Size = new System.Drawing.Size(9, 118);
            this.sep1.TabIndex = 7;
            this.sep1.TabStop = false;
            // 
            // sep2
            // 
            this.sep2.BackColor = System.Drawing.Color.White;
            this.sep2.Location = new System.Drawing.Point(932, 171);
            this.sep2.Name = "sep2";
            this.sep2.Size = new System.Drawing.Size(9, 118);
            this.sep2.TabIndex = 8;
            this.sep2.TabStop = false;
            // 
            // sep3
            // 
            this.sep3.BackColor = System.Drawing.Color.White;
            this.sep3.Location = new System.Drawing.Point(932, 332);
            this.sep3.Name = "sep3";
            this.sep3.Size = new System.Drawing.Size(9, 118);
            this.sep3.TabIndex = 9;
            this.sep3.TabStop = false;
            // 
            // sep4
            // 
            this.sep4.BackColor = System.Drawing.Color.White;
            this.sep4.Location = new System.Drawing.Point(932, 488);
            this.sep4.Name = "sep4";
            this.sep4.Size = new System.Drawing.Size(9, 118);
            this.sep4.TabIndex = 10;
            this.sep4.TabStop = false;
            // 
            // sep5
            // 
            this.sep5.BackColor = System.Drawing.Color.White;
            this.sep5.Location = new System.Drawing.Point(932, 642);
            this.sep5.Name = "sep5";
            this.sep5.Size = new System.Drawing.Size(9, 118);
            this.sep5.TabIndex = 11;
            this.sep5.TabStop = false;
            // 
            // sep6
            // 
            this.sep6.BackColor = System.Drawing.Color.White;
            this.sep6.Location = new System.Drawing.Point(932, 794);
            this.sep6.Name = "sep6";
            this.sep6.Size = new System.Drawing.Size(9, 118);
            this.sep6.TabIndex = 12;
            this.sep6.TabStop = false;
            // 
            // sep7
            // 
            this.sep7.BackColor = System.Drawing.Color.White;
            this.sep7.Location = new System.Drawing.Point(932, 935);
            this.sep7.Name = "sep7";
            this.sep7.Size = new System.Drawing.Size(9, 77);
            this.sep7.TabIndex = 13;
            this.sep7.TabStop = false;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(1898, 1024);
            this.Controls.Add(this.pongBall);
            this.Controls.Add(this.sep7);
            this.Controls.Add(this.sep6);
            this.Controls.Add(this.sep5);
            this.Controls.Add(this.sep4);
            this.Controls.Add(this.sep3);
            this.Controls.Add(this.sep2);
            this.Controls.Add(this.sep1);
            this.Controls.Add(this.playerTwo);
            this.Controls.Add(this.playerOne);
            this.Controls.Add(this.scoreRightSide);
            this.Controls.Add(this.scoreLeftSide);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(1920, 1080);
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pong";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Game_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Game_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.playerOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pongBall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sep1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sep2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sep3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sep4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sep5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sep6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sep7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer gameLoop;
        private PictureBox playerOne;
        private Label scoreLeftSide;
        private Label scoreRightSide;
        private PictureBox playerTwo;
        private PictureBox pongBall;
        private PictureBox sep1;
        private PictureBox sep2;
        private PictureBox sep3;
        private PictureBox sep4;
        private PictureBox sep5;
        private PictureBox sep6;
        private PictureBox sep7;
    }
}