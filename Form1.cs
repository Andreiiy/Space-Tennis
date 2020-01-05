using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Space_Tennis
{
    public partial class Form1 : Form
    {
        private int start_x;
        private int start_y;
        private int point = 20;
        private int dx;
        private int dy;
        private int count;


        private Graphics gr;

        private Water watar;
        private Land land;
        private Ball ball;



        private Player player;

        private Random rand = new Random();

        int[,] mat = new int[30, 40];
        int[,] mat_ball = new int[30, 40];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitGame();
        }
        
        private void InitGame()
        { 
            start_x = 250;
            start_y = 50;
            dx = -1;
            dy = -1;
            count = 0;


            for (int i = 0; i < 30; i++)
            {

                for (int j = 0; j < 40; j++)
                {
                    mat[i, j] = 0;
                    mat_ball[i, j] = 0;

                    if (i == 29 && j == 15)
                        mat[i, j] = 3;
                    if (i == 29 && j == 16)
                        mat[i, j] = 3;
                    if (i == 29 && j == 17)
                        mat[i, j] = 3;
                    if (i == 29 && j == 18)
                        mat[i, j] = 3;

                    if (i == 28 && j == 15)
                        mat_ball[i, j] = 2;

                    if (i == 5 || i == 6 || i == 7 || i == 8)
                    {
                        mat[i, j] = 1;
                    }
                    if (mat_ball[i, j] == 2)
                    {
                        ball = new Ball(this.start_x + point * j, this.start_y + point * i, this.point, this.point, Color.YellowGreen);

                    }
                }
            }
            timer1.Enabled = true;

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            gr = e.Graphics;

            for (int i = 0; i < 30; i++)
            {

                for (int j = 0; j < 40; j++)
                {

                    if (mat[i, j] == 3)
                    {
                        player = new Player(this.start_x + point * j, this.start_y + point * i, this.point, this.point, Color.Orange);
                        player.DrawPlayer(gr);
                    }

                    if (mat[i, j] == 1)
                    {
                        Colors color = new Colors();
                        int col = rand.Next(1, 144);
                        Color colorn = color.Get_Color(col);
                        land = new Land(this.start_x + point * j, this.start_y + point * i, this.point, this.point, colorn);
                        land.DrawLand(gr);

                    }
                    else if (mat[i, j] == 0)
                    {
                        watar = new Water(this.start_x + point * j, this.start_y + point * i, this.point, this.point, Color.DarkBlue);
                        watar.DrawWater(gr);
                    }
                    
                }
            }
          ball.DrawBall(gr);
        }

        private void Check_Winner()
        {
            int count = 0;
            for (int i = 0; i < 30; i++)
            {

                for (int j = 0; j < 40; j++)
                {
                    if (mat[i, j] == 1)
                    {
                        count++;
                    }
                }
            }
            if(count==0)
            {
                timer1.Enabled = false;
                label3.Text = "You're a winner";
            }
         }


        private void Go_ball()
        {


            for (int i = 0; i < 30; i++)
            {

                for (int j = 0; j < 40; j++)
                {
                    if (mat_ball[i, j] == 2)
                    {

                        if (j + dx == 40 || j + dx == -1)
                            dx = dx * (-1);
                        if ( i + dy == -1)
                            dy = dy * (-1);
                        if (i + dy == 30)
                        {

                            timer1.Enabled = false;
                            label3.Text = "Game Over";
                            dy = dy * (-1);

                        }

                        if (mat[i + dy, j] == 1)
                        {
                            mat[i + dy, j] = 0;
                            if (j - 1 != -1)
                                mat[i + dy, j - 1] = 0;
                            if (j + 1 != 40)
                                mat[i + dy, j + 1] = 0;
                            dy = dy * (-1);

                        }

                        if (mat[i, j + dx] == 1)
                        {
                            mat[i, j + dx] = 0;
                            Check_Winner();
                            dx = dx * (-1);

                        }

                        if (mat[i + dy, j + dx] == 1)
                        {
                            mat[i + dy, j + dx] = 0;
                            Check_Winner();
                            dy = dy * (-1);
                            dx = dx * (-1);

                        }
                        if (mat[i + dy, j] == 3)
                        {
                            dy = dy * (-1);

                        }
                        /////////////////////////////////////
                        if (j + dx == 40 || j + dx == -1)
                            dx = dx * (-1);
                        if (i + dy == 30 || i + dy == -1)
                            dy = dy * (-1);
                        if (i + dy == 30)
                        {
                            timer1.Enabled = false;
                            label3.Text = "Game Over";
                        }

                        mat_ball[i + dy, j + dx] = mat_ball[i, j];
                        mat_ball[i, j] = 0;

                        
                            

                        i += dy;
                        j += dx;
                    }

                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (count == 5)
            {
                count = 0;
            }

            if (count == 0)
            {
                Go_ball();
                
            }

            ball.Move(dx*4, dy*4);
            count++;

            Invalidate();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                for (int i = 0; i < 30; i++)
                {
                    for (int j = 0; j < 40; j++)
                    {
                        if (mat[i, j] == 3)

                        {
                            if (j - 1 != -1)
                            {
                                for (int ii = 0; ii < 4; ii++)
                                {
                                    int temp = mat[i, j];
                                    mat[i, j] = mat[i - 1, j];
                                    mat[i, j - 1] = temp;
                                    j++;
                                }
                                                                
                            }
                            else
                            {
                                j += 5;
                            }
                        }
                    }
                }
            }

            if (e.KeyCode == Keys.Right)
            {
                for (int i = 0; i < 30; i++)
                {
                    for (int j = 0; j < 40; j++)
                    {
                        if (mat[i, j] == 3 && j + 1 != 40 && mat[i, j + 1] == 0)

                        {
                            if (j + 1 != 40)
                            {
                                for (int ii = 0; ii < 4; ii++)
                                {
                                    int temp = mat[i, j];
                                    mat[i, j] = mat[i, j + 1];
                                    mat[i, j + 1] = temp;
                                    j--;
                                }
                                j = 39;
                                
                            }
                            else
                            {
                                j += 5;
                            }
                        }
                    }
                }
            }

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            InitGame();
        }
    }
}
