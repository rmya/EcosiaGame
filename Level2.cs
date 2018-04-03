using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ecosia_Game
{
    public partial class Level2 : Form
    {
        public int sayi = 6;

        public Level2()
        {
            InitializeComponent();
        }

        private void Level2_Load(object sender, EventArgs e2)
        {
           
        }
        private void Level2_KeyDown(object sender, KeyEventArgs e2)
        {
            if (e2.KeyCode == Keys.Right)
            {
                fly2.Location = new Point(fly2.Location.X + 5, fly2.Location.Y);
            }
            else if (e2.KeyCode == Keys.Left)
            {
                fly2.Location = new Point(fly2.Location.X - 5, fly2.Location.Y);
            }
            else if (e2.KeyCode == Keys.Up)
            {
                fly2.Location = new Point(fly2.Location.X, fly2.Location.Y - 5);
            }
            else if (e2.KeyCode == Keys.Down)
            {
                fly2.Location = new Point(fly2.Location.X, fly2.Location.Y + 5);
            }
            //*****************************************************************************************
            if (e2.KeyCode == Keys.Right)
            {
                tohum2.Location = new Point(tohum2.Location.X + 5, tohum2.Location.Y);
            }
            else if (e2.KeyCode == Keys.Left)
            {
                tohum2.Location = new Point(tohum2.Location.X - 5, tohum2.Location.Y);
            }
            else if (e2.KeyCode == Keys.Up)
            {
                tohum2.Location = new Point(tohum2.Location.X, tohum2.Location.Y - 5);
            }
            else if (e2.KeyCode == Keys.Down)
            {
                tohum2.Location = new Point(tohum2.Location.X, tohum2.Location.Y + 5);
            }
            //tohum atma

            if (e2.KeyCode == Keys.Space)
            {
                tohum2.Visible = true;
                timer1.Interval = 400;
                timer1.Start();

            }
            if (e2.KeyCode == Keys.Space && tree1.Visible == true)
            {
                tohum2.Visible = true;
                timer2.Interval = 400;
                timer2.Start();
            }
            if (e2.KeyCode == Keys.Space && tree2.Visible == true)
            {
                tohum2.Visible = true;
                timer3.Interval = 400;
                timer3.Start();
            }
            if (e2.KeyCode == Keys.Space && tree3.Visible == true)
            {
                tohum2.Visible = true;
                timer4.Interval = 400;
                timer4.Start();
            }
            if (e2.KeyCode == Keys.Space && tree4.Visible == true)
            {
                tohum2.Visible = true;
                timer5.Interval = 400;
                timer5.Start();
            }
            if (e2.KeyCode == Keys.Space && tree5.Visible == true)
            {
                tohum2.Visible = true;
                timer6.Interval = 400;
                timer6.Start();
            }
            if (e2.KeyCode == Keys.Space && tree6.Visible == true)
            {
                tohum2.Visible = true;
                timer7.Interval = 400;
                timer7.Start();
            }
        }

            private void timer1_Tick(object sender, EventArgs e2)
        {
            do
            {
                tohum2.Location = new Point(tohum2.Location.X, tohum2.Location.Y + 3);
            }
            while (tohum2.Location.Y == ground.Location.Y);
            {
                tohum2.Visible = false;
                timer1.Stop();
                tree1.Visible = true;
                score.Text = sayi.ToString();
            }
        }

        private void timer2_Tick(object sender, EventArgs e2)
        {
            do
            {
                tohum2.Location = new Point(tohum2.Location.X, tohum2.Location.Y + 3);
            }
            while (tohum2.Location.Y == ground.Location.Y);
            {
                tohum2.Visible = false;
                timer2.Stop();
                tree2.Visible = true;
                sayi--;
                score.Text = sayi.ToString();
            }
        }

        private void timer3_Tick(object sender, EventArgs e2)
        {
            do
            {
                tohum2.Location = new Point(tohum2.Location.X, tohum2.Location.Y + 5);
            }
            while (tohum2.Location.Y == ground.Location.Y);
            {
                tohum2.Visible = false;
                timer3.Stop();
                tree3.Visible = true;
                score.Text = sayi.ToString();
            }
        }

        private void timer4_Tick(object sender, EventArgs e2)
        {
            do
            {
                tohum2.Location = new Point(tohum2.Location.X, tohum2.Location.Y + 5);
            }
            while (tohum2.Location.Y == ground.Location.Y);
            {
                tohum2.Visible = false;
                timer4.Stop();
                tree4.Visible = true;
                score.Text = sayi.ToString();
            }
        }

        private void timer5_Tick(object sender, EventArgs e2)
        {
            do
            {
                tohum2.Location = new Point(tohum2.Location.X, tohum2.Location.Y + 5);
            }
            while (tohum2.Location.Y == ground.Location.Y);
            {
                tohum2.Visible = false;
                timer5.Stop();
                tree5.Visible = true;
                //score.Text = sayi.ToString();
            }
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            do
            {
                tohum2.Location = new Point(tohum2.Location.X, tohum2.Location.Y + 5);
            }
            while (tohum2.Location.Y == ground.Location.Y);
            {
                tohum2.Visible = false;
                timer6.Stop();
                tree6.Visible = true;
               // score.Text = sayi.ToString();
            }
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            do
            {
                tohum2.Location = new Point(tohum2.Location.X, tohum2.Location.Y + 5);
            }
            while (tohum2.Location.Y == ground.Location.Y);
            {
                tohum2.Visible = false;
                timer7.Stop();
                tree7.Visible = true;
              //  score.Text = sayi.ToString();
            }
        }


    }
    }

