
namespace Wonder2048Tile
{
    partial class Game2048
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game2048));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelNewGame = new System.Windows.Forms.Label();
            this.labelTextBest = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.lbScoreBest = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.BtnWinExit = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.BtnNewgame = new System.Windows.Forms.Button();
            this.BtnKeepPlaying = new System.Windows.Forms.Button();
            this.BtnTryagain = new System.Windows.Forms.Button();
            this.lblWin = new System.Windows.Forms.Label();
            this.lblGameOver = new System.Windows.Forms.Label();
            this.Slot16 = new System.Windows.Forms.Label();
            this.Slot12 = new System.Windows.Forms.Label();
            this.Slot8 = new System.Windows.Forms.Label();
            this.Slot4 = new System.Windows.Forms.Label();
            this.Slot15 = new System.Windows.Forms.Label();
            this.Slot11 = new System.Windows.Forms.Label();
            this.Slot7 = new System.Windows.Forms.Label();
            this.Slot3 = new System.Windows.Forms.Label();
            this.Slot14 = new System.Windows.Forms.Label();
            this.Slot13 = new System.Windows.Forms.Label();
            this.Slot10 = new System.Windows.Forms.Label();
            this.Slot9 = new System.Windows.Forms.Label();
            this.Slot6 = new System.Windows.Forms.Label();
            this.Slot5 = new System.Windows.Forms.Label();
            this.Slot2 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.Slot1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(45, -39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 182);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 57;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.WaitOnLoad = true;
            // 
            // labelNewGame
            // 
            this.labelNewGame.BackColor = System.Drawing.Color.Yellow;
            this.labelNewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNewGame.Location = new System.Drawing.Point(327, 98);
            this.labelNewGame.Name = "labelNewGame";
            this.labelNewGame.Size = new System.Drawing.Size(180, 45);
            this.labelNewGame.TabIndex = 56;
            this.labelNewGame.Text = "New Game";
            this.labelNewGame.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelNewGame.Click += new System.EventHandler(this.labelNewGame_Click);
            // 
            // labelTextBest
            // 
            this.labelTextBest.AutoSize = true;
            this.labelTextBest.BackColor = System.Drawing.Color.Bisque;
            this.labelTextBest.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTextBest.Location = new System.Drawing.Point(412, 13);
            this.labelTextBest.Name = "labelTextBest";
            this.labelTextBest.Size = new System.Drawing.Size(55, 25);
            this.labelTextBest.TabIndex = 55;
            this.labelTextBest.Text = "Best";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Bisque;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(302, 38);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(0, 25);
            this.label21.TabIndex = 54;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Bisque;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(273, 13);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(68, 25);
            this.label22.TabIndex = 53;
            this.label22.Text = "Score";
            // 
            // lbScoreBest
            // 
            this.lbScoreBest.BackColor = System.Drawing.Color.Bisque;
            this.lbScoreBest.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbScoreBest.Location = new System.Drawing.Point(397, 6);
            this.lbScoreBest.Name = "lbScoreBest";
            this.lbScoreBest.Size = new System.Drawing.Size(168, 80);
            this.lbScoreBest.TabIndex = 52;
            this.lbScoreBest.Text = "0";
            this.lbScoreBest.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblScore
            // 
            this.lblScore.BackColor = System.Drawing.Color.Bisque;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(250, 6);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(111, 80);
            this.lblScore.TabIndex = 51;
            this.lblScore.Text = "0";
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // BtnWinExit
            // 
            this.BtnWinExit.BackColor = System.Drawing.Color.Gold;
            this.BtnWinExit.Enabled = false;
            this.BtnWinExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnWinExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BtnWinExit.Location = new System.Drawing.Point(170, 437);
            this.BtnWinExit.Name = "BtnWinExit";
            this.BtnWinExit.Size = new System.Drawing.Size(240, 58);
            this.BtnWinExit.TabIndex = 50;
            this.BtnWinExit.Text = "EXIT";
            this.BtnWinExit.UseVisualStyleBackColor = false;
            this.BtnWinExit.Visible = false;
            this.BtnWinExit.Click += new System.EventHandler(this.BtnWinExit_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Gray;
            this.btnExit.Enabled = false;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(170, 437);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(240, 58);
            this.btnExit.TabIndex = 49;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Visible = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // BtnNewgame
            // 
            this.BtnNewgame.BackColor = System.Drawing.Color.Gold;
            this.BtnNewgame.Enabled = false;
            this.BtnNewgame.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNewgame.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BtnNewgame.Location = new System.Drawing.Point(170, 367);
            this.BtnNewgame.Name = "BtnNewgame";
            this.BtnNewgame.Size = new System.Drawing.Size(240, 58);
            this.BtnNewgame.TabIndex = 48;
            this.BtnNewgame.Text = "New game";
            this.BtnNewgame.UseVisualStyleBackColor = false;
            this.BtnNewgame.Visible = false;
            this.BtnNewgame.Click += new System.EventHandler(this.BtnNewgame_Click);
            // 
            // BtnKeepPlaying
            // 
            this.BtnKeepPlaying.BackColor = System.Drawing.Color.Gold;
            this.BtnKeepPlaying.Enabled = false;
            this.BtnKeepPlaying.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnKeepPlaying.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BtnKeepPlaying.Location = new System.Drawing.Point(170, 290);
            this.BtnKeepPlaying.Name = "BtnKeepPlaying";
            this.BtnKeepPlaying.Size = new System.Drawing.Size(240, 58);
            this.BtnKeepPlaying.TabIndex = 47;
            this.BtnKeepPlaying.Text = "Keep Playing";
            this.BtnKeepPlaying.UseVisualStyleBackColor = false;
            this.BtnKeepPlaying.Visible = false;
            this.BtnKeepPlaying.Click += new System.EventHandler(this.BtnKeepPlaying_Click);
            // 
            // BtnTryagain
            // 
            this.BtnTryagain.BackColor = System.Drawing.Color.Gray;
            this.BtnTryagain.Enabled = false;
            this.BtnTryagain.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTryagain.ForeColor = System.Drawing.Color.White;
            this.BtnTryagain.Location = new System.Drawing.Point(170, 336);
            this.BtnTryagain.Name = "BtnTryagain";
            this.BtnTryagain.Size = new System.Drawing.Size(240, 58);
            this.BtnTryagain.TabIndex = 46;
            this.BtnTryagain.Text = "Try Again";
            this.BtnTryagain.UseVisualStyleBackColor = false;
            this.BtnTryagain.Visible = false;
            this.BtnTryagain.Click += new System.EventHandler(this.BtnTryagain_Click);
            // 
            // lblWin
            // 
            this.lblWin.BackColor = System.Drawing.Color.Gold;
            this.lblWin.Font = new System.Drawing.Font("Times New Roman", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblWin.Location = new System.Drawing.Point(0, 146);
            this.lblWin.Name = "lblWin";
            this.lblWin.Size = new System.Drawing.Size(612, 142);
            this.lblWin.TabIndex = 44;
            this.lblWin.Text = "You Win!";
            this.lblWin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblWin.Visible = false;
            // 
            // lblGameOver
            // 
            this.lblGameOver.BackColor = System.Drawing.Color.Gray;
            this.lblGameOver.Font = new System.Drawing.Font("Times New Roman", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameOver.ForeColor = System.Drawing.Color.White;
            this.lblGameOver.Location = new System.Drawing.Point(0, 146);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(612, 142);
            this.lblGameOver.TabIndex = 45;
            this.lblGameOver.Text = "Game Over";
            this.lblGameOver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblGameOver.Visible = false;
            // 
            // Slot16
            // 
            this.Slot16.BackColor = System.Drawing.Color.Orange;
            this.Slot16.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Slot16.Location = new System.Drawing.Point(416, 417);
            this.Slot16.Name = "Slot16";
            this.Slot16.Size = new System.Drawing.Size(92, 60);
            this.Slot16.TabIndex = 28;
            this.Slot16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Slot12
            // 
            this.Slot12.BackColor = System.Drawing.Color.LemonChiffon;
            this.Slot12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Slot12.Location = new System.Drawing.Point(416, 338);
            this.Slot12.Name = "Slot12";
            this.Slot12.Size = new System.Drawing.Size(92, 60);
            this.Slot12.TabIndex = 29;
            this.Slot12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Slot8
            // 
            this.Slot8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(179)))), ((int)(((byte)(253)))));
            this.Slot8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Slot8.Location = new System.Drawing.Point(416, 259);
            this.Slot8.Name = "Slot8";
            this.Slot8.Size = new System.Drawing.Size(92, 60);
            this.Slot8.TabIndex = 30;
            this.Slot8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Slot4
            // 
            this.Slot4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Slot4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Slot4.Location = new System.Drawing.Point(416, 180);
            this.Slot4.Name = "Slot4";
            this.Slot4.Size = new System.Drawing.Size(92, 60);
            this.Slot4.TabIndex = 31;
            this.Slot4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Slot15
            // 
            this.Slot15.BackColor = System.Drawing.Color.Gold;
            this.Slot15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Slot15.Location = new System.Drawing.Point(307, 417);
            this.Slot15.Name = "Slot15";
            this.Slot15.Size = new System.Drawing.Size(92, 60);
            this.Slot15.TabIndex = 32;
            this.Slot15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Slot11
            // 
            this.Slot11.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Slot11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Slot11.Location = new System.Drawing.Point(307, 338);
            this.Slot11.Name = "Slot11";
            this.Slot11.Size = new System.Drawing.Size(92, 60);
            this.Slot11.TabIndex = 33;
            this.Slot11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Slot7
            // 
            this.Slot7.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Slot7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Slot7.Location = new System.Drawing.Point(307, 259);
            this.Slot7.Name = "Slot7";
            this.Slot7.Size = new System.Drawing.Size(92, 60);
            this.Slot7.TabIndex = 34;
            this.Slot7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Slot3
            // 
            this.Slot3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Slot3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Slot3.Location = new System.Drawing.Point(307, 180);
            this.Slot3.Name = "Slot3";
            this.Slot3.Size = new System.Drawing.Size(92, 60);
            this.Slot3.TabIndex = 35;
            this.Slot3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Slot14
            // 
            this.Slot14.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Slot14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Slot14.Location = new System.Drawing.Point(198, 417);
            this.Slot14.Name = "Slot14";
            this.Slot14.Size = new System.Drawing.Size(92, 60);
            this.Slot14.TabIndex = 36;
            this.Slot14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Slot13
            // 
            this.Slot13.BackColor = System.Drawing.Color.Violet;
            this.Slot13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Slot13.Location = new System.Drawing.Point(89, 417);
            this.Slot13.Name = "Slot13";
            this.Slot13.Size = new System.Drawing.Size(92, 60);
            this.Slot13.TabIndex = 37;
            this.Slot13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Slot10
            // 
            this.Slot10.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Slot10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Slot10.Location = new System.Drawing.Point(198, 338);
            this.Slot10.Name = "Slot10";
            this.Slot10.Size = new System.Drawing.Size(92, 60);
            this.Slot10.TabIndex = 38;
            this.Slot10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Slot9
            // 
            this.Slot9.BackColor = System.Drawing.Color.Pink;
            this.Slot9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Slot9.Location = new System.Drawing.Point(89, 338);
            this.Slot9.Name = "Slot9";
            this.Slot9.Size = new System.Drawing.Size(92, 60);
            this.Slot9.TabIndex = 39;
            this.Slot9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Slot6
            // 
            this.Slot6.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Slot6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Slot6.Location = new System.Drawing.Point(198, 259);
            this.Slot6.Name = "Slot6";
            this.Slot6.Size = new System.Drawing.Size(92, 60);
            this.Slot6.TabIndex = 40;
            this.Slot6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Slot5
            // 
            this.Slot5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Slot5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Slot5.Location = new System.Drawing.Point(89, 259);
            this.Slot5.Name = "Slot5";
            this.Slot5.Size = new System.Drawing.Size(92, 60);
            this.Slot5.TabIndex = 41;
            this.Slot5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Slot2
            // 
            this.Slot2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Slot2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Slot2.Location = new System.Drawing.Point(198, 180);
            this.Slot2.Name = "Slot2";
            this.Slot2.Size = new System.Drawing.Size(92, 60);
            this.Slot2.TabIndex = 42;
            this.Slot2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.Wheat;
            this.label17.Location = new System.Drawing.Point(64, 163);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(468, 332);
            this.label17.TabIndex = 27;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 60);
            this.label1.TabIndex = 43;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Slot1
            // 
            this.Slot1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Slot1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Slot1.Location = new System.Drawing.Point(89, 180);
            this.Slot1.Name = "Slot1";
            this.Slot1.Size = new System.Drawing.Size(92, 60);
            this.Slot1.TabIndex = 42;
            this.Slot1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Game2048
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(610, 545);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelNewGame);
            this.Controls.Add(this.labelTextBest);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.lbScoreBest);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.BtnWinExit);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.BtnNewgame);
            this.Controls.Add(this.BtnKeepPlaying);
            this.Controls.Add(this.BtnTryagain);
            this.Controls.Add(this.lblWin);
            this.Controls.Add(this.lblGameOver);
            this.Controls.Add(this.Slot16);
            this.Controls.Add(this.Slot12);
            this.Controls.Add(this.Slot8);
            this.Controls.Add(this.Slot4);
            this.Controls.Add(this.Slot15);
            this.Controls.Add(this.Slot11);
            this.Controls.Add(this.Slot7);
            this.Controls.Add(this.Slot3);
            this.Controls.Add(this.Slot14);
            this.Controls.Add(this.Slot13);
            this.Controls.Add(this.Slot10);
            this.Controls.Add(this.Slot9);
            this.Controls.Add(this.Slot6);
            this.Controls.Add(this.Slot5);
            this.Controls.Add(this.Slot1);
            this.Controls.Add(this.Slot2);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "Game2048";
            this.Text = "Game2048";
            this.Load += new System.EventHandler(this.Game2048_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Game2048_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelNewGame;
        private System.Windows.Forms.Label labelTextBest;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label lbScoreBest;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Button BtnWinExit;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button BtnNewgame;
        private System.Windows.Forms.Button BtnKeepPlaying;
        private System.Windows.Forms.Button BtnTryagain;
        private System.Windows.Forms.Label lblWin;
        private System.Windows.Forms.Label lblGameOver;
        private System.Windows.Forms.Label Slot16;
        private System.Windows.Forms.Label Slot12;
        private System.Windows.Forms.Label Slot8;
        private System.Windows.Forms.Label Slot4;
        private System.Windows.Forms.Label Slot15;
        private System.Windows.Forms.Label Slot11;
        private System.Windows.Forms.Label Slot7;
        private System.Windows.Forms.Label Slot3;
        private System.Windows.Forms.Label Slot14;
        private System.Windows.Forms.Label Slot13;
        private System.Windows.Forms.Label Slot10;
        private System.Windows.Forms.Label Slot9;
        private System.Windows.Forms.Label Slot6;
        private System.Windows.Forms.Label Slot5;
        private System.Windows.Forms.Label Slot2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Slot1;
    }
}

