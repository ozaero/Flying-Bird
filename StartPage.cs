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
    public partial class StartPage : Form
    {
        public StartPage()
        {
            InitializeComponent();
        }

        Random rnd = new Random();

        static public bool open = false;
        public int score;
        int a;

        private void StartPage_Load(object sender, EventArgs e)
        {
            if (open)
                NotFirst();
            else
                First();

            void First()
            {
                label3.Visible = false;
                open = true;
            }

            void NotFirst()
            {
                label2.Text = "PLAY AGAIN";
                label2.Left = 40;
                label3.Visible = true;
                label3.Text = $"Last score: {score.ToString()}";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Game Game = new Game();

            this.Hide();
            Game.Show();
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Red;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Black;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int time = rnd.Next(11);
            switch (time)
            {
                case 0:
                    BackColor = Color.Blue;
                    break;
                case 1:
                    BackColor = Color.Aqua;
                    break;
                case 2:
                    BackColor = Color.Aquamarine;
                    break;
                case 3:
                    BackColor = Color.MediumAquamarine;
                    break;
                case 4:
                    BackColor = Color.Cyan;
                    break;
                case 5:
                    BackColor = Color.SteelBlue;
                    break;
                case 6:
                    BackColor = Color.CadetBlue;
                    break;
                case 7:
                    BackColor = Color.CornflowerBlue;
                    break;
                case 8:
                    BackColor = Color.LightBlue;
                    break;
                case 9:
                    BackColor = Color.AliceBlue;
                    break;
                case 10:
                    BackColor = Color.LightSkyBlue;
                    break;
            }
        }
    }
}
