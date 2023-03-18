using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Threading;
using System.Media;
using System.IO;
using Microsoft.VisualBasic;
using System.Security.AccessControl;

namespace Wonder2048Tile
{
    public partial class Game2048 : Form
    {
        private SoundPlayer Plus = new SoundPlayer(Wonder2048Tile.Properties.Resources.CanPlus1);
        private SoundPlayer CanMove = new SoundPlayer(Wonder2048Tile.Properties.Resources.Move1);
        private SoundPlayer GameOver = new SoundPlayer(Wonder2048Tile.Properties.Resources.GameOverMario);
        private SoundPlayer WinGame = new SoundPlayer(Wonder2048Tile.Properties.Resources.WinGame);
        Boolean Win = false;
        string [] Continue;
        Random Rd = new Random();
        static ArrayList Slot = new ArrayList();
        static ArrayList ReadFile = new ArrayList();
        int y = 47, x = 1;
        int nHightScore = 0;
        string HightScore;
        public Game2048()
        {
            InitializeComponent();
        }
        private void Game2048_Load(object sender, EventArgs e)
        {
            makeCircleLabel(labelNewGame, 20);
            makeCircleLabel(label17, 30);
            makeCircleLabel(lblScore, 20);
            makeCircleLabel(lbScoreBest, 20);
            CreateNewNum();
            CreateNewNum();
            ReadFiles();
            ReadContinue();
            //MessageBox.Show(Convert.ToString(ReadFile.Count));
            if (ReadFile.Count > 0)
            {
                HightScore = Convert.ToString(ReadFile[ReadFile.Count - 1]);
                nHightScore = Convert.ToInt32(HightScore.Substring(HightScore.IndexOf(" ") + 1));
                if (nHightScore > Convert.ToInt32(lblScore.Text)) 
                {
                    HightScore = HightScore.Substring(0, HightScore.IndexOf(" "));
                    labelTextBest.Text += " " + HightScore;
                    lbScoreBest.Text = Convert.ToString(nHightScore); 
                }
                else
                {
                    lbScoreBest.Text = lblScore.Text;
                }
            }
            else
            {
                lbScoreBest.Text = lblScore.Text;
            }
        }
        private void makeCircleLabel(Label lbl, int d)
        {
            Rectangle r = new Rectangle(0, 0, lbl.Width, lbl.Height);
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddArc(r.X, r.Y, d, d, 180, 90);
            gp.AddArc(r.X + r.Width - d, r.Y, d, d, 270, 90);
            gp.AddArc(r.X + r.Width - d - 1, r.Y + r.Height - d, d, d, 0, 90);
            gp.AddArc(r.X, r.Y + r.Height - d, d, d, 90, 90);
            lbl.Region = new Region(gp);
        }
        public void ChangeColor()
        {
            Label[,] Game = {
                                {Slot1,Slot2,Slot3,Slot4},
                                {Slot5,Slot6,Slot7,Slot8},
                                {Slot9,Slot10,Slot11,Slot12},
                                {Slot13,Slot14,Slot15,Slot16}
                              };
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    makeCircleLabel(Game[i, j], 10);

                    if (Game[i, j].Text == "")
                    {
                        Game[i, j].BackColor = Color.Silver;
                    }
                    else
                    {
                        if (Game[i, j].Text == "2")
                        {
                            Game[i, j].BackColor = Color.Cornsilk;
                            Game[i, j].ForeColor = Color.Black;

                        }
                        if (Game[i, j].Text == "4")
                        {
                            Game[i, j].BackColor = Color.FromName("GradientActiveCaption");
                            Game[i, j].ForeColor = Color.White;
                        }
                        if (Game[i, j].Text == "8")
                        {
                            Game[i, j].BackColor = Color.Plum;
                            Game[i, j].ForeColor = Color.White;
                        }
                        if (Game[i, j].Text == "16")
                        {
                            Game[i, j].BackColor = Color.LightSalmon;
                            Game[i, j].ForeColor = Color.White;
                        }
                        if (Game[i, j].Text == "32")
                        {
                            Game[i, j].BackColor = Color.PaleGreen;
                            Game[i, j].ForeColor = Color.White;
                        }
                        if (Game[i, j].Text == "64")
                        {
                            Game[i, j].BackColor = Color.Aquamarine;
                            Game[i, j].ForeColor = Color.White;
                        }
                        if (Game[i, j].Text == "128")
                        {
                            Game[i, j].BackColor = Color.LightSkyBlue;
                            Game[i, j].ForeColor = Color.White;
                        }
                        if (Game[i, j].Text == "256")
                        {
                            Game[i, j].BackColor = Color.Gold;
                            Game[i, j].ForeColor = Color.White;
                        }
                        if (Game[i, j].Text == "512")
                        {
                            Game[i, j].BackColor = Color.Violet;
                            Game[i, j].ForeColor = Color.White;
                        }
                        if (Game[i, j].Text == "1024")
                        {
                            Game[i, j].BackColor = Color.Orange;
                            Game[i, j].ForeColor = Color.White;
                        }
                        if (Game[i, j].Text == "2048")
                        {
                            Game[i, j].BackColor = Color.Red;
                            Game[i, j].ForeColor = Color.White;
                        }
                        if (Convert.ToInt32(Game[i, j].Text) > 2048)
                        {
                            Game[i, j].BackColor = Color.Black;
                            Game[i, j].ForeColor = Color.White;
                        }
                    }
                }
            }

        }
        public void CreateNewNum()
        {
            Slot.Clear();

            Label[,] Game = {
                                {Slot1,Slot2,Slot3,Slot4},
                                {Slot5,Slot6,Slot7,Slot8},
                                {Slot9,Slot10,Slot11,Slot12},
                                {Slot13,Slot14,Slot15,Slot16}
                              };
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (Game[i, j].Text == "")
                    {
                        Slot.Add(i * 4 + j + 1);
                    }
                }
            }

            if (Slot.Count > 0)
            {
                int RanSlot = int.Parse(Slot[Rd.Next(0, Slot.Count - 1)].ToString());//สุ่มพื้นที่ว่างในเกม
                int i0 = (RanSlot - 1) / 4;
                int j0 = (RanSlot - 1) - i0 * 4;
                int RanNum = Rd.Next(1, 11);//สุ่ม1-10
                if (RanNum <= 7)
                {
                    Game[i0, j0].Text = "2";
                }
                else
                {
                    Game[i0, j0].Text = "4";
                }
            }
            ChangeColor();
        }
        public void MoveDown()
        {
            int score = 0;
            bool CheckMove = true;
            bool CheckPlus = false;
            bool CheckCreateNewNum = false;
            Label[,] Game = {
                                {Slot1,Slot2,Slot3,Slot4},
                                {Slot5,Slot6,Slot7,Slot8},
                                {Slot9,Slot10,Slot11,Slot12},
                                {Slot13,Slot14,Slot15,Slot16}
                              };
            for (int i = 0; i < 4; i++)
            {//0
                int countslot = 0;
                for (int j = 3; j >= 0; j--)
                {//3
                    for (int k = j - 1; k >= 0; k--)
                    {//2
                        if (Game[k, i].Text != "")//[2,1,0,0]
                        {
                            if (Game[k, i].Text == Game[j, i].Text)
                            {
                                CheckPlus = true;
                            }
                            break;
                        }
                    }
                    if (Game[j, i].Text == "")
                    {
                        countslot++;
                    }
                    else
                    {
                        for (int m = j + 1; m <= 3; m++)
                        {
                            if (Game[m, i].Text == "")
                            {
                                CheckCreateNewNum = true;
                                break;
                            }
                        }
                        if (j - 1 >= 0)
                        {
                            bool extrasayi = true;

                            for (int k = j - 1; k >= 0; k--)
                            {
                                if (Game[k, i].Text != "")
                                {
                                    if (Game[j, i].Text == Game[k, i].Text)
                                    {
                                        CheckMove = false;
                                        lblScore.Text = (int.Parse(lblScore.Text) + int.Parse(Game[j, i].Text) * 2).ToString();
                                        if (Convert.ToInt32(lbScoreBest.Text) < Convert.ToInt32(lblScore.Text))
                                        {
                                            lbScoreBest.Text = lblScore.Text;
                                            labelTextBest.Text = "Best";
                                        }
                                        score += int.Parse(Game[j, i].Text) * 2;
                                        CheckCreateNewNum = true;
                                        extrasayi = false;
                                        Game[j, i].Text = (int.Parse(Game[j, i].Text) * 2).ToString();
                                        if (countslot != 0)
                                        {
                                            Game[j + countslot, i].Text = Game[j, i].Text;
                                            Game[j, i].Text = "";

                                        }
                                        Game[k, i].Text = "";
                                        break;
                                    }
                                    break;
                                }
                            }
                            if (extrasayi == true && countslot != 0)
                            {
                                CheckMove = false;
                                Game[j + countslot, i].Text = Game[j, i].Text;
                                Game[j, i].Text = "";
                            }
                        }
                        else
                        {
                            if (countslot != 0)
                            {
                                CheckMove = false;
                                Game[j + countslot, i].Text = Game[j, i].Text;
                                Game[j, i].Text = "";
                            }
                        }
                    }
                }
            }
            if (CheckCreateNewNum == true)
            {
                CreateNewNum();
            }
            if (score != 0)
            {
                label21.Text = "+" + score.ToString();
                timer1.Start();
            }
            if (CheckMove == false && CheckPlus == true)
            {
                Plus.Play();
            }
            if (CheckMove == false && CheckPlus == false)
            {
                CanMove.Play();
            }
        }
        public void MoveUp()
        {
            int score = 0;
            bool CheckMove = true;
            bool CheckPlus = false;
            bool CheckCreateNewNum = false;
            Label[,] Game = {
                                {Slot1,Slot2,Slot3,Slot4},
                                {Slot5,Slot6,Slot7,Slot8},
                                {Slot9,Slot10,Slot11,Slot12},
                                {Slot13,Slot14,Slot15,Slot16}
                              };
            for (int i = 0; i < 4; i++)
            {
                int countslot = 0;
                for (int j = 0; j < 4; j++)
                {
                    for (int k = j + 1; k < 4; k++)
                    {
                        if (Game[k, i].Text != "")
                        {
                            if (Game[k, i].Text == Game[j, i].Text)
                            {
                                CheckPlus = true;//ตรวจว่าตัวข้างบนมันเหมือนกันไหม
                            }
                            break;
                        }
                    }
                    if (Game[j, i].Text == "")
                    {
                        countslot++;//หากด้านบนมีช่องว่างให้บวกนับจำนวนช่องว่างในหลักนี้
                    }
                    else
                    {
                        for (int m = j; m >= 0; m--)
                        {
                            if (Game[m, i].Text == "")
                            {
                                CheckCreateNewNum = true;
                                break;
                            }
                        }
                        if (j + 1 < 4)
                        {
                            bool extrasayi = true;

                            for (int k = j + 1; k < 4; k++)
                            {
                                if (Game[k, i].Text != "")
                                {
                                    if (Game[j, i].Text == Game[k, i].Text)
                                    {
                                        CheckMove = false;
                                        lblScore.Text = (int.Parse(lblScore.Text) + int.Parse(Game[j, i].Text) * 2).ToString();
                                        if (Convert.ToInt32(lbScoreBest.Text) < Convert.ToInt32(lblScore.Text))
                                        {
                                            lbScoreBest.Text = lblScore.Text;
                                        }
                                        score += int.Parse(Game[j, i].Text) * 2;
                                        CheckCreateNewNum = true;
                                        extrasayi = false;
                                        Game[j, i].Text = (int.Parse(Game[j, i].Text) * 2).ToString();
                                        if (countslot != 0)
                                        {
                                            Game[j - countslot, i].Text = Game[j, i].Text;
                                            Game[j, i].Text = "";

                                        }
                                        Game[k, i].Text = "";

                                        break;

                                    }
                                    break;
                                }
                            }
                            if (extrasayi == true && countslot != 0)
                            {
                                CheckMove = false;
                                Game[j - countslot, i].Text = Game[j, i].Text;
                                Game[j, i].Text = "";

                            }
                        }
                        else
                        {
                            if (countslot != 0)
                            {
                                CheckMove = false;
                                Game[j - countslot, i].Text = Game[j, i].Text;
                                Game[j, i].Text = "";

                            }
                        }


                    }
                }
            }
            if (CheckCreateNewNum == true)
            {
                CreateNewNum();
            }
            if (score != 0)
            {
                label21.Text = "+" + score.ToString();
                timer1.Start();
            }
            if (CheckMove == false && CheckPlus == true)
            {
                Plus.Play();
            }
            if (CheckMove == false && CheckPlus == false)
            {
                CanMove.Play();
            }
        }
        public void MoveLeft()
        {
            int score = 0;
            bool CheckMove = true;
            bool CheckPlus = false;
            bool CheckCreateNewNum = false;
            Label[,] Game = {
                                {Slot1,Slot2,Slot3,Slot4},
                                {Slot5,Slot6,Slot7,Slot8},
                                {Slot9,Slot10,Slot11,Slot12},
                                {Slot13,Slot14,Slot15,Slot16}
                              };
            for (int i = 0; i < 4; i++)
            {
                int countslot = 0;
                for (int j = 0; j < 4; j++)
                {

                    for (int k = j + 1; k < 4; k++)
                    {
                        if (Game[i, k].Text != "")
                        {
                            if (Game[i, j].Text == Game[i, k].Text)
                            {
                                CheckPlus = true;
                            }
                            break;
                        }
                    }
                    if (Game[i, j].Text == "")
                    {
                        countslot++;
                    }
                    else
                    {
                        for (int m = j - 1; m >= 0; m--)
                        {
                            if (Game[i, m].Text == "")
                            {
                                CheckCreateNewNum = true;
                                break;
                            }
                        }
                        if (j + 1 < 4)
                        {
                            bool extrasayi = true;
                            for (int k = j + 1; k < 4; k++)
                            {
                                if (Game[i, k].Text != "")
                                {

                                    if (Game[i, j].Text == Game[i, k].Text)
                                    {
                                        CheckMove = false;
                                        lblScore.Text = (int.Parse(lblScore.Text) + int.Parse(Game[i, j].Text) * 2).ToString();
                                        if (Convert.ToInt32(lbScoreBest.Text) < Convert.ToInt32(lblScore.Text))
                                        {
                                            lbScoreBest.Text = lblScore.Text;
                                        }
                                        score += int.Parse(Game[i, k].Text) * 2;
                                        CheckCreateNewNum = true;
                                        extrasayi = false;
                                        Game[i, j].Text = (int.Parse(Game[i, j].Text) * 2).ToString();
                                        if (countslot != 0)
                                        {
                                            Game[i, j - countslot].Text = Game[i, j].Text;
                                            Game[i, j].Text = "";

                                        }
                                        Game[i, k].Text = "";
                                        break;
                                    }
                                    break;
                                }
                            }
                            if (extrasayi == true && countslot != 0)
                            {
                                CheckMove = false;
                                Game[i, j - countslot].Text = Game[i, j].Text;
                                Game[i, j].Text = "";
                            }
                        }
                        else
                        {
                            if (countslot != 0)
                            {
                                CheckMove = false;
                                Game[i, j - countslot].Text = Game[i, j].Text;
                                Game[i, j].Text = "";

                            }
                        }


                    }
                }
            }
            if (CheckCreateNewNum == true)
            {
                CreateNewNum();
            }
            if (score != 0)
            {
                label21.Text = "+" + score.ToString();
                timer1.Start();
            }
            if (CheckMove == false && CheckPlus == true)
            {
                Plus.Play();
            }
            if (CheckMove == false && CheckPlus == false)
            {
                CanMove.Play();
            }
        }
        public void MoveRight()
        {
            int score = 0;
            bool CheckMove = true;
            bool CheckPlus = false;
            bool CheckCreateNewNum = false;
            Label[,] Game = {
                                {Slot1,Slot2,Slot3,Slot4},
                                {Slot5,Slot6,Slot7,Slot8},
                                {Slot9,Slot10,Slot11,Slot12},
                                {Slot13,Slot14,Slot15,Slot16}
                              };
            for (int i = 0; i < 4; i++)
            {
                int countslot = 0;
                for (int j = 3; j >= 0; j--)
                {
                    for (int k = j - 1; k >= 0; k--)
                    {
                        if (Game[i, k].Text != "")
                        {
                            if (Game[i, k].Text == Game[i, j].Text)
                            {
                                CheckPlus = true;
                            }
                            break;
                        }
                    }
                    if (Game[i, j].Text == "")
                    {
                        countslot++;
                    }
                    else
                    {
                        for (int m = j + 1; m < 4; m++)
                        {
                            if (Game[i, m].Text == "")
                            {
                                CheckCreateNewNum = true;
                                break;
                            }
                        }
                        if (j - 1 >= 0)
                        {
                            bool extrasayi = true;

                            for (int k = j - 1; k >= 0; k--)
                            {
                                if (Game[i, k].Text != "")
                                {
                                    if (Game[i, j].Text == Game[i, k].Text)
                                    {
                                        CheckMove = false;
                                        lblScore.Text = (int.Parse(lblScore.Text) + int.Parse(Game[i, j].Text) * 2).ToString();
                                        if (Convert.ToInt32(lbScoreBest.Text) < Convert.ToInt32(lblScore.Text))
                                        {
                                            lbScoreBest.Text = lblScore.Text;
                                        }
                                        score += int.Parse(Game[i, j].Text) * 2;
                                        CheckCreateNewNum = true;
                                        extrasayi = false;
                                        Game[i, j].Text = (int.Parse(Game[i, j].Text) * 2).ToString();
                                        if (countslot != 0)
                                        {
                                            Game[i, j + countslot].Text = Game[i, j].Text;
                                            Game[i, j].Text = "";
                                        }
                                        Game[i, k].Text = "";
                                        break;
                                    }
                                    break;
                                }
                            }
                            if (extrasayi == true && countslot != 0)
                            {
                                CheckMove = false;
                                Game[i, j + countslot].Text = Game[i, j].Text;
                                Game[i, j].Text = "";
                            }
                        }
                        else
                        {
                            if (countslot != 0)
                            {
                                CheckMove = false;
                                Game[i, j + countslot].Text = Game[i, j].Text;
                                Game[i, j].Text = "";
                            }
                        }
                    }
                }
            }
            if (CheckCreateNewNum == true)
            {
                CreateNewNum();
            }
            if (score != 0)
            {
                label21.Text = "+" + score.ToString();
                timer1.Start();
            }
            if (CheckMove == false && CheckPlus == true)
            {
                Plus.Play();
            }
            if (CheckMove == false && CheckPlus == false)
            {
                CanMove.Play();
            }
        }
        public bool CheckGameOver()
        {
            Label[,] Game = {
                                {Slot1,Slot2,Slot3,Slot4},
                                {Slot5,Slot6,Slot7,Slot8},
                                {Slot9,Slot10,Slot11,Slot12},
                                {Slot13,Slot14,Slot15,Slot16}
                              };
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (Game[i, j].Text == "")
                    {
                        return false;
                    }
                    for (int k = j + 1; k < 4; k++)
                    {
                        if (Game[i, j].Text != "")
                        {
                            if (Game[i, j].Text == Game[i, k].Text)
                            {
                                return false;
                            }
                            break;
                        }
                    }
                }
            }
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (Game[j, i].Text == "")
                    {
                        return false;
                    }
                    for (int k = j + 1; k < 4; k++)
                    {
                        if (Game[k, i].Text != "")
                        {
                            if (Game[j, i].Text == Game[k, i].Text)
                            {
                                return false;
                            }
                            break;
                        }
                    }
                }
            }
            return true;
        }
        private void Game2048_KeyDown(object sender, KeyEventArgs e)
        {
            if (CheckGameOver() == false)//ถ้ามีการกดปุ่มต้องเข้าเมธิดเชคก่อนว่ายังสามารถขยับได้ไหม
            {
                if (e.KeyCode == Keys.Up)
                {
                    MoveUp();
                }
                if (e.KeyCode == Keys.Down)
                {
                    MoveDown();
                }
                if (e.KeyCode == Keys.Left)
                {
                    MoveLeft();
                }
                if (e.KeyCode == Keys.Right)
                {
                    MoveRight();
                }
                WriteContinue();
            }
            else
            {
                File.WriteAllText(@"Mydir\Continue.txt", "");
                GameOver.Play();
                lblGameOver.Visible = true;
                BtnTryagain.Visible = true;
                btnExit.Visible = true;
                btnExit.Enabled = true;
                BtnTryagain.Enabled = true;
                this.KeyDown -= new System.Windows.Forms.KeyEventHandler(this.Game2048_KeyDown);
                if (Convert.ToInt32(lblScore.Text) > nHightScore)
                {
                    string NewHightScore = Interaction.InputBox("Congratulation" +
                    Environment.NewLine + "คุณทำคะแนนได้สูงสุด" + Environment.NewLine +
                    "Enter your name  Maximum 7 Alplabet ", "Congratulation",
                    "Enter Your name");
                    while (NewHightScore.Length > 7)
                    {
                        MessageBox.Show("กรุกรอกชื่อไม่เกิน 7 ตัว");
                        NewHightScore = Interaction.InputBox("Congratulation" +
                    Environment.NewLine + "คุณทำคะแนนได้สูงสุด" + Environment.NewLine +
                    "Enter your name  Maximum 7 Alplabet " + Environment.NewLine
                    + "If you don't input we will give your name _Guest_",
                    "Congratulation","Enter Your name");
                    }
                    if (NewHightScore != "")
                    {
                        WriteData(NewHightScore, Convert.ToInt32(lblScore.Text));
                    }
                    else
                    {
                        WriteData("_Guest_", Convert.ToInt32(lblScore.Text));
                    }
                }
            }
            if (Win == false && Check2048() == true)//เชคว่าในเกมมี 2048 หรือยัง
            {
                WinGame.Play();
                lblWin.Visible = true;
                BtnKeepPlaying.Visible = true;
                BtnKeepPlaying.Enabled = true;
                BtnWinExit.Visible = true;
                BtnWinExit.Enabled = true;
                BtnNewgame.Visible = true;
                BtnNewgame.Enabled = true;
                this.KeyDown -= new System.Windows.Forms.KeyEventHandler(this.Game2048_KeyDown);
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            label21.SetBounds(280, y, 1, 1);
            x++;
            y = y - x;
            if (y <= 0)
            {
                y = 47;
                x = 1;
                label21.Text = "";
                label21.Location = new Point(363, 33);
                timer1.Stop();
            }
        }
        private void BtnWinExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void BtnNewgame_Click(object sender, EventArgs e)
        {
            File.WriteAllText(@"Mydir\Continue.txt", "");
            ReadFile.Clear();
            ReadFiles();
            if (ReadFile.Count > 0)
            {
                labelTextBest.Text = "Best";
                HightScore = Convert.ToString(ReadFile[ReadFile.Count - 1]);
                nHightScore = Convert.ToInt32(HightScore.Substring(HightScore.IndexOf(" ") + 1));
                HightScore = HightScore.Substring(0, HightScore.IndexOf(" "));
                labelTextBest.Text += " " + HightScore;
                lbScoreBest.Text = Convert.ToString(nHightScore);
            }
            else
            {
                lbScoreBest.Text = lblScore.Text;
            }
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Game2048_KeyDown);
            Win = false;
            lblScore.Text = "0";
            Label[,] Game = {
                                {Slot1,Slot2,Slot3,Slot4},
                                {Slot5,Slot6,Slot7,Slot8},
                                {Slot9,Slot10,Slot11,Slot12},
                                {Slot13,Slot14,Slot15,Slot16}
                              };
            lblWin.Visible = false;
            BtnKeepPlaying.Visible = false;
            BtnKeepPlaying.Enabled = false;
            BtnWinExit.Visible = false;
            BtnWinExit.Enabled = false;
            BtnNewgame.Visible = false;
            BtnNewgame.Enabled = false;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Game[i, j].Text = "";
                }
            }
            CreateNewNum();
            CreateNewNum();
        }
        private void BtnTryagain_Click(object sender, EventArgs e)
        {
            File.WriteAllText(@"Mydir\Continue.txt", "");
            ReadFile.Clear();
            ReadFiles();
            if (ReadFile.Count > 0)
            {
                labelTextBest.Text = "Best";
                HightScore = Convert.ToString(ReadFile[ReadFile.Count - 1]);
                nHightScore = Convert.ToInt32(HightScore.Substring(HightScore.IndexOf(" ") + 1));
                HightScore = HightScore.Substring(0, HightScore.IndexOf(" "));
                labelTextBest.Text += " " + HightScore;
                lbScoreBest.Text = Convert.ToString(nHightScore);
            }
            else
            {
                lbScoreBest.Text = lblScore.Text;
            }
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Game2048_KeyDown);
            Win = false;
            lblScore.Text = "0";
            Label[,] Game = {
                                {Slot1,Slot2,Slot3,Slot4},
                                {Slot5,Slot6,Slot7,Slot8},
                                {Slot9,Slot10,Slot11,Slot12},
                                {Slot13,Slot14,Slot15,Slot16}
                              };
            lblGameOver.Visible = false;
            btnExit.Visible = false;
            BtnTryagain.Visible = false;
            BtnTryagain.Enabled = false;
            btnExit.Enabled = false;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Game[i, j].Text = "";
                }
            }
            CreateNewNum();
            CreateNewNum();
        }
        private void BtnKeepPlaying_Click(object sender, EventArgs e)
        {
            lblWin.Visible = false;
            BtnKeepPlaying.Visible = false;
            BtnKeepPlaying.Enabled = false;
            BtnWinExit.Visible = false;
            BtnWinExit.Enabled = false;
            BtnNewgame.Visible = false;
            BtnNewgame.Enabled = false;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Game2048_KeyDown);
        }
        private void labelNewGame_Click(object sender, EventArgs e)
        {
            if (lblGameOver.Visible == true)
            {
                this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Game2048_KeyDown);
                lblGameOver.Visible = false;
                btnExit.Visible = false;
                BtnTryagain.Visible = false;
                BtnTryagain.Enabled = false;
                btnExit.Enabled = false;
            }
            else if (lblWin.Visible == true)
            {
                this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Game2048_KeyDown);
                lblWin.Visible = false;
                BtnKeepPlaying.Visible = false;
                BtnKeepPlaying.Enabled = false;
                BtnWinExit.Visible = false;
                BtnWinExit.Enabled = false;
                BtnNewgame.Visible = false;
                BtnNewgame.Enabled = false;
            }
            if (Convert.ToInt32(lblScore.Text) > nHightScore)
            {
                WriteData("_You_", Convert.ToInt32(lblScore.Text));
                ReadFile.Clear();
                ReadFiles();
                if (ReadFile.Count > 0)
                {
                    labelTextBest.Text = "Best";
                    HightScore = Convert.ToString(ReadFile[ReadFile.Count - 1]);
                    nHightScore = Convert.ToInt32(HightScore.Substring(HightScore.IndexOf(" ") + 1));
                    HightScore = HightScore.Substring(0, HightScore.IndexOf(" "));
                    labelTextBest.Text += " " + HightScore;
                    lbScoreBest.Text = Convert.ToString(nHightScore);
                }
                else
                {
                    lbScoreBest.Text = lblScore.Text;
                }
            }
            File.WriteAllText(@"Mydir\Continue.txt", "");
            lblScore.Text = "0";
            Label[,] Game = {
                                {Slot1,Slot2,Slot3,Slot4},
                                {Slot5,Slot6,Slot7,Slot8},
                                {Slot9,Slot10,Slot11,Slot12},
                                {Slot13,Slot14,Slot15,Slot16}
                              };
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Game[i, j].Text = "";
                }
            }
            if (Win == true)
            {
                Win = false;
            }
            CreateNewNum();
            CreateNewNum();
        }
        public bool Check2048()
        {
            Label[,] Game = {
                                {Slot1,Slot2,Slot3,Slot4},
                                {Slot5,Slot6,Slot7,Slot8},
                                {Slot9,Slot10,Slot11,Slot12},
                                {Slot13,Slot14,Slot15,Slot16}
                              };
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (Game[i, j].Text == "2048")
                    {
                        Win = true;
                        return true;
                    }
                }
            }
            return false;
        }
        public void ReadFiles()
        {
            int i = 0;
            try
            {
                string line;
                StreamReader RFile = new StreamReader(Path.GetFullPath(@"Mydir\Highscore.txt"));
                while ((line = RFile.ReadLine()) != null)
                {
                    i++;
                }
                RFile.Close();
                if (i != 0)
                {
                    StreamReader Open = new StreamReader(Path.GetFullPath(@"Mydir\Highscore.txt"));
                    for (int j = 0; j < i; j++)
                    {
                        ReadFile.Add(Decipher(Open.ReadLine(), 13));
                    }
                    Open.Close();
                }
            }
            catch (Exception)
            {
                System.IO.Directory.CreateDirectory(@"Mydir");
                File.WriteAllText(@"Mydir/Highscore.txt", "");
            }
        }
        public void WriteData(string Name, int Score)
        {
            File.WriteAllText(@"Mydir\Highscore.txt", Encipher(Name,13) + " " + Score);
        }
        public void ReadContinue()
        {
            Label[] Game = {Slot1,Slot2,Slot3,Slot4,
            Slot5,Slot6,Slot7,Slot8,
            Slot9,Slot10,Slot11,Slot12,
            Slot13,Slot14,Slot15,Slot16};
            try
            {
                Continue = File.ReadAllLines(@"Mydir\Continue.txt");
                if (Continue.Length==16) {
                    for (int i = 0; i < Continue.Length; i++)
                    {
                        if (Continue[i] == "-")
                        {
                            Game[i].Text = "";
                        }
                        else
                        {
                            Game[i].Text = Continue[i];
                        }
                    }
                    ChangeColor();
                    lblScore.Text = File.ReadAllText(@"Mydir\Scorenow.txt");
                }
            }
            catch (Exception)
            {
                System.IO.Directory.CreateDirectory(@"Mydir");
                File.WriteAllText(@"Mydir/Highscore.txt", "");
            }
        }
        public void WriteContinue()
        {
            string myGame = "";
            Label[,] Game = {
                                {Slot1,Slot2,Slot3,Slot4},
                                {Slot5,Slot6,Slot7,Slot8},
                                {Slot9,Slot10,Slot11,Slot12},
                                {Slot13,Slot14,Slot15,Slot16}
                              };
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (Game[i, j].Text == "")
                    {
                        myGame += "-" + Environment.NewLine;
                    }
                    else
                    {
                        myGame += Game[i, j].Text + Environment.NewLine;
                    }
                }
            }
            File.WriteAllText(@"Mydir\Scorenow.txt", lblScore.Text);
            File.WriteAllText(@"Mydir\Continue.txt", myGame);
        }
        public static char cipher(char ch, int key)
        {
            if (!char.IsLetter(ch))
            {

                return ch;
            }
            char d = char.IsUpper(ch) ? 'A' : 'a';
            return (char)((((ch + key) - d) % 26) + d);
        }
        private string Encipher(string input, int key)
        {
            string output = string.Empty;

            foreach (char ch in input)
                output += cipher(ch, key);
            return output;
        }
        public string Decipher(string input, int key)
        {
            return Encipher(input, 26 - key);
        }
    }
}
