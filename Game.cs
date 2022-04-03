using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flying_Bird
{
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
        }

        StartPage Start = new StartPage();
        Random rnd = new Random();
        int a, b, c;
        int c1, c2, c3, c4;
        int border1, border2;
        bool z;

        public int score, memory;

        private void Form1_Load(object sender, EventArgs e)
        {
            Start();
            Text();

            bird.Location = new Point(50, 300);
            Wall1.Location = new Point(800, a);
            Wall2.Location = new Point(800, (a - border2));
            Wall3.Location = new Point(1200, b);
            Wall4.Location = new Point(1200, (b - border2));
            

            void Start()
            {
                border1 = 450;
                border2 = 700;

                a = rnd.Next(160, border1);
                b = rnd.Next(160, border1);
                c1 = rnd.Next(10, 500);
                c2 = rnd.Next(10, 500);
                c3 = rnd.Next(10, 500);
                c4 = rnd.Next(10, 500);

                cloud1.Top = c1;
                cloud2.Top = c2;
                cloud3.Top = c3;
                cloud4.Top = c4;

                Wall5.Visible = false;
                Wall6.Visible = false;
                z = true;
            }

            void Text()
            {
                label1.Text = ("Score: 0");
            }
        }

        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                if (bird.Top > 25)
                {
                    bird.Top -= 64;
                    timer1.Interval = 10;
                }
            }
            timer1.Interval = 1;
        }

        public void Dead()
        {
            if (Wall1.Bounds.IntersectsWith(bird.Bounds) || Wall2.Bounds.IntersectsWith(bird.Bounds) || Wall3.Bounds.IntersectsWith(bird.Bounds) || Wall4.Bounds.IntersectsWith(bird.Bounds) || Wall5.Bounds.IntersectsWith(bird.Bounds) || Wall6.Bounds.IntersectsWith(bird.Bounds))
            {
                if (z)
                {
                    Start.score = score;
                    this.Hide();
                    Start.Show();
                    z = false;
                }
                timer1.Enabled = false;
            }
            
        }

        void Score()
        {
            if (Wall1.Left == 50 || Wall3.Left == 50 || Wall5.Left == 50)
                score++;

            if (score > 0)
                if (memory != score)
                    label1.Text = ($"Score: {score.ToString()}");

            memory = score;
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            Bird();
            Cloud();
            Wall();
            
            void Bird()
            {
                Dead();
                Score();

                if (bird.Top < 500)
                    bird.Top += 2;
            }

            void Cloud()
            {
                if (cloud1.Left == -50)
                {
                    c1 = rnd.Next(10, 500);
                    cloud1.Location = new Point(1200, c1);
                }
                if (cloud2.Left == -50)
                {
                    c2 = rnd.Next(10, 500);
                    cloud2.Location = new Point(1200, c2);
                }
                if (cloud3.Left == -50)
                {
                    c3 = rnd.Next(10, 500);
                    cloud3.Location = new Point(1200, c3);
                }
                if (cloud4.Left == -50)
                {
                    c4 = rnd.Next(10, 500);
                    cloud4.Location = new Point(1200, c4);
                }
                cloud1.Left -= 1;
                cloud2.Left -= 1;
                cloud3.Left -= 1;
                cloud4.Left -= 1;
            }

            void Wall()
            {
                if (Wall1.Left == 400)
                {
                    Wall5.Visible = true;
                    Wall6.Visible = true;
                    c = rnd.Next(160, border1);
                    Wall5.Location = new Point(1200, c);
                    Wall6.Location = new Point(1200, (c - border2));
                }
                if (Wall3.Left == 400)
                {
                    a = rnd.Next(160, border1);
                    Wall1.Location = new Point(1200, a);
                    Wall2.Location = new Point(1200, (a - border2));
                }
                if (Wall5.Left == 400)
                {
                    b = rnd.Next(160, border1);
                    Wall3.Location = new Point(1200, b);
                    Wall4.Location = new Point(1200, (b - border2));
                }
                Wall1.Left -= 2;
                Wall2.Left -= 2;
                Wall3.Left -= 2;
                Wall4.Left -= 2;
                Wall5.Left -= 2;
                Wall6.Left -= 2;
            }
        }
    }
}
