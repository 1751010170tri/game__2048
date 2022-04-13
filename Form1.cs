using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace game2048
{
    public partial class Form1 : Form
    {
        int tong = 0;
        int[] test = { 0, 0, 0, 0 };
        int score = 0;
        int count = 1;
        int cohieu = 0;
        int score2 =0;
        public void Color()
        {
            Label[,] Game = {
                                {lb1,lb2,lb3,lb4},
                                {lb5,lb6,lb7,lb8},
                                {lb9,lb10,lb11,lb12},
                                {lb13,lb14,lb15,lb16}
                              };
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {

                    if (Game[i, j].Text == "0")
                    {
                        Game[i, j].BackColor = System.Drawing.Color.YellowGreen;
                        Game[i, j].ForeColor = System.Drawing.Color.YellowGreen;

                    }
                    if (Game[i, j].Text == "2")
                    {
                        Game[i, j].BackColor = System.Drawing.Color.DarkOrchid;
                        Game[i, j].ForeColor = System.Drawing.Color.White;

                    }
                    if (Game[i, j].Text == "4")
                    {
                        Game[i, j].BackColor = System.Drawing.Color.Gray;
                        Game[i, j].ForeColor = System.Drawing.Color.White;
                    }
                    if (Game[i, j].Text == "8")
                    {
                        Game[i, j].BackColor = System.Drawing.Color.Orange;
                        Game[i, j].ForeColor = System.Drawing.Color.White;
                    }
                    if (Game[i, j].Text == "16")
                    {
                        Game[i, j].BackColor = System.Drawing.Color.OrangeRed;
                        Game[i, j].ForeColor = System.Drawing.Color.White;
                    }
                    if (Game[i, j].Text == "32")
                    {
                        Game[i, j].BackColor = System.Drawing.Color.PaleGreen;
                        Game[i, j].ForeColor = System.Drawing.Color.White;
                    }
                    if (Game[i, j].Text == "64")
                    {
                        Game[i, j].BackColor = System.Drawing.Color.LightPink;
                        Game[i, j].ForeColor = System.Drawing.Color.White;
                    }
                    if (Game[i, j].Text == "128")
                    {
                        Game[i, j].BackColor = System.Drawing.Color.Red;
                        Game[i, j].ForeColor = System.Drawing.Color.White;
                    }
                    if (Game[i, j].Text == "256")
                    {
                        Game[i, j].BackColor = System.Drawing.Color.DarkRed;
                        Game[i, j].ForeColor = System.Drawing.Color.White;
                    }
                    if (Game[i, j].Text == "512")
                    {
                        Game[i, j].BackColor = System.Drawing.Color.LightBlue;
                        Game[i, j].ForeColor = System.Drawing.Color.White;
                    }
                    if (Game[i, j].Text == "1024")
                    {
                        Game[i, j].BackColor = System.Drawing.Color.Blue;
                        Game[i, j].ForeColor = System.Drawing.Color.White;
                    }
                    if (Game[i, j].Text == "2048")
                    {
                        Game[i, j].BackColor = System.Drawing.Color.Green;
                        Game[i, j].ForeColor = System.Drawing.Color.White;
                    }
                    if (Game[i, j].Text == "4096")
                    {
                        Game[i, j].BackColor = System.Drawing.Color.LightGoldenrodYellow;
                        Game[i, j].ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
                    }
                }
            }
        }

        public Form1()
        {
            InitializeComponent();
            

        }
        int k = 2;
        public void addNumber(Label[,] a,int x)
        {
            Random ran = new Random();
            int[] number = { 2, 4};
            int limit = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (a[i, j].Text == "0")
                        limit++;
                    if (limit > 2)
                        break;

                }
                 if (limit > 2)
                        break;
            }
            if (limit < x)
                x = limit;
            int ss = 0;
            while (ss < x)
            {
                int rannum = ran.Next(0, 2);
                int ranx = ran.Next(0, 4);
                int rany = ran.Next(0, 4);
                if (a[ranx, rany].Text == "0")
                {
                    a[ranx, rany].Text = number[rannum].ToString();
                    ss++;

                }
            };
            Color();
        }
        public void Score(int a)
        {
            if (a > score)
                score = a;
            
        }
        public bool isAvailable(Label[,] a)
        {

            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                {
                    if (a[i, j].Text == "0")
                        return true;
                    if (j < 3 && a[i, j].Text == a[i, j + 1].Text)
                    {
                        return true;
                    }
                    if (i < 3 && a[i, j].Text == a[i + 1, j].Text)
                    {
                        return true;
                    }
                }
            return false;
        }

        public void Duyet(int[] a)
        {

            int i = 0;
            while (i < 4)
            {
                if (a[i] == 0)
                    i++;

                else
                {
                    int j = i + 1;
                    while (j < 4)
                    {
                        if (a[j] == 0)
                            j++;
                        else
                        {
                            if (a[j] == a[i])
                            {
                                a[i] = a[i] + a[j];
                                a[j] = 0;
                                tong = tong + a[i];
                                i++;
                                break;
                            }
                            else
                                break;
                        }
                    }
                    i++;
                }
            }
            int m = 0;
            int n = 0;
            while (m < 4)
            {
                if (a[m] != 0)
                    m++;

                else
                {
                    n = m + 1;
                    while (n < 4)
                    {
                        if (a[n] == 0)
                            n++;
                        else
                        {
                            a[m] = a[n];
                            a[n] = 0;

                            break;
                        }

                    }
                    m++;
                }
                
            }
            lbScore.Text = tong.ToString();
            Score(tong);
        }
        public void daoNguoc(int[] a)
        {
            int m = 3;
            int n = 3;
            while (m >= 0)
            {
                if (a[m] != 0)
                    m--;

                else
                {
                    n = m - 1;
                    while (n >= 0)
                    {
                        if (a[n] == 0)
                            n--;
                        else
                        {
                            a[m] = a[n];
                            a[n] = 0;

                            break;
                        }

                    }
                }
                m--;
            }
        }
        public void daoNguoc2(int[] a)
        {
            int tmp;
            tmp=a[3];
            a[3] = a[0];
            a[0] = tmp;
            tmp = a[2];
            a[2] = a[1];
            a[1] = tmp;
            int m = 0;
            int n = 0;
            while (m < 4)
            {
                if (a[m] != 0)
                    m++;

                else
                {
                    n = m + 1;
                    while (n < 4)
                    {
                        if (a[n] == 0)
                            n++;
                        else
                        {
                            a[m] = a[n];
                            a[n] = 0;

                            break;
                        }

                    }
                }
                m++;
            }


            }
        public void left()
        {
            Label[,] Game = {
                                {lb1,lb2,lb3,lb4},
                                {lb5,lb6,lb7,lb8},
                                {lb9,lb10,lb11,lb12},
                                {lb13,lb14,lb15,lb16}
                              };
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    test[j] = int.Parse(Game[i, j].Text);



                }
                Duyet(test);
                for (int j = 0; j < 4; j++)
                {
                    Game[i, j].Text = test[j].ToString();
                }

            }
            Color();
            addNumber(Game,k);
            if (!isAvailable(Game))
            {
                Color();
                if (cohieu == 0)
                {
                    lsvScore.Items.Add(String.Format("Điểm lần {0}:   {1} ", count, tong));
                    count++;
                    cohieu++;
                    score2 = score;
                    HighScore.Text = score2.ToString();
                }
                MessageBox.Show("Game Over", "Thông Báo");
            }
        }
        public void right()
        {
            
            Label[,] Game = {
                                {lb1,lb2,lb3,lb4},
                                {lb5,lb6,lb7,lb8},
                                {lb9,lb10,lb11,lb12},
                                {lb13,lb14,lb15,lb16}
                              };
            for (int i = 0; i < 4; i++)
            {
                int k = 0;
                for (int j = 3; j >= 0; j--)
                {
                   
                    test[k] = int.Parse(Game[i, j].Text);
                    k++;



                }
                Duyet(test);
                daoNguoc2(test);
                daoNguoc(test);
                for (int j = 3; j >= 0; j--)
                {
                    Game[i, j].Text = test[j].ToString();
                }

            }
            Color();
            addNumber(Game,k);
            if (!isAvailable(Game))
            {
                Color();
                if (cohieu == 0)
                {
                    lsvScore.Items.Add(String.Format("Điểm lần {0}:   {1} ", count, tong));
                    count++;
                    cohieu++;
                    score2 = score;
                    HighScore.Text = score2.ToString();
                }
                MessageBox.Show("Game Over", "Thông Báo");
            }
        }
        public void up()
        {
            Label[,] Game = {
                                {lb1,lb2,lb3,lb4},
                                {lb5,lb6,lb7,lb8},
                                {lb9,lb10,lb11,lb12},
                                {lb13,lb14,lb15,lb16}
                              };
            for (int i = 0; i < 4; i++)
            {

                for (int j = 0; j < 4; j++)
                {
                    test[j] = int.Parse(Game[j, i].Text);



                }
                Duyet(test);
                for (int j = 0; j < 4; j++)
                {
                    Game[j, i].Text = test[j].ToString();
                }

            }
            Color();
            addNumber(Game,k);
            if (!isAvailable(Game))
            {
                Color();
                if (cohieu == 0)
                {
                    lsvScore.Items.Add(String.Format("Điểm lần {0}:   {1} ", count, tong));
                    count++;
                    cohieu++;
                    score2 = score;
                    HighScore.Text = score2.ToString();
                }
                MessageBox.Show("Game Over", "Thông Báo");
            }
        }
        public void down()
        {
            Label[,] Game = {
                                {lb1,lb2,lb3,lb4},
                                {lb5,lb6,lb7,lb8},
                                {lb9,lb10,lb11,lb12},
                                {lb13,lb14,lb15,lb16}
                              };
            for (int i = 0; i < 4; i++)
            {
                int k = 0;
                for (int j = 3; j >= 0; j--)
                {
                    test[k] = int.Parse(Game[j, i].Text);
                    k++;


                }
                Duyet(test);
                daoNguoc2(test);
                daoNguoc(test);
                for (int j = 3; j >= 0; j--)
                {
                    Game[j, i].Text = test[j].ToString();
                }

            }
            Color();
            addNumber(Game,k);
            if (!isAvailable(Game))
            {
                Color();
                if (cohieu == 0)
                {
                    lsvScore.Items.Add(String.Format("Điểm lần {0}:   {1} ", count, tong));
                    count++;
                    cohieu++;
                    score2 = score;
                    HighScore.Text = score2.ToString();
                }
                MessageBox.Show("Game Over", "Thông Báo");
            }






        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            
                if (keyData == Keys.Up)
                {
                    up();
                    return true;
                }
                if (keyData == Keys.Down)
                {
                    down();
                    return true;
                }
                if (keyData == Keys.Left)
                {
                    left();
                    return true;
                }
                if (keyData == Keys.Right)
                {
                    right();
                    return true;
                }
            
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void btUp_Click(object sender, EventArgs e)
        {
            up();

        }

        private void btLeft_Click(object sender, EventArgs e)
        {
            left();
        }

        private void btDown_Click(object sender, EventArgs e)
        {
            down();
        }

        private void btRight_Click(object sender, EventArgs e)
        {
            right();
        }

        private void newGame_Click(object sender, EventArgs e)
        {
            Label[,] Game = {
                                {lb1,lb2,lb3,lb4},
                                {lb5,lb6,lb7,lb8},
                                {lb9,lb10,lb11,lb12},
                                {lb13,lb14,lb15,lb16}
                              };
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Game[i, j].Text = "0";
                    Color();
                }
            }
            tong = 0;
            lbScore.Text = "0";
            cohieu=0;
            score=score2;
        }

        private void howToPlay_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dùng các phím điều hướng lên,xuống,trái,phải trên bàn phím,hoặc click chuột vào các biểu tượng tương ứng trên màn hình để di chuyển các ô số giống nhau lại và tính tổng.Game được mặc định ở mức dễ nếu muốn tăng độ khó chọn New Game->Khó.Sau khi thua chọn Menu->New Game-> chọn mức game Khó hoặc Dễ để chơi lại","Cách chơi");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dễToolStripMenuItem_Click(object sender, EventArgs e)
        {
            k = 2;
        }

        private void khóToolStripMenuItem_Click(object sender, EventArgs e)
        {
            k = 3;
        }
    }
}
