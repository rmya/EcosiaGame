using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Imaging;

namespace Ecosia_Game
{
    public partial class Game : Form
    {
        public int sayac = 3;

        public Game()
        {
            InitializeComponent();

        }

        private void Game_Load(object sender, EventArgs e)
        {
            
        }
         
        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                fly.Location = new Point(fly.Location.X + 5, fly.Location.Y);
            }
            else if (e.KeyCode == Keys.Left)
            {
                fly.Location = new Point(fly.Location.X - 5, fly.Location.Y);
            }
            else if (e.KeyCode == Keys.Up)
            {
                fly.Location = new Point(fly.Location.X, fly.Location.Y - 5);
            }
            else if (e.KeyCode == Keys.Down)
            {
                fly.Location = new Point(fly.Location.X, fly.Location.Y + 5);
            }
            //*****************************************************************************************
            if (e.KeyCode == Keys.Right)
            {
                tohum.Location = new Point(tohum.Location.X + 5, tohum.Location.Y);
            }
            else if (e.KeyCode == Keys.Left)
            {
                tohum.Location = new Point(tohum.Location.X - 5, tohum.Location.Y);
            }
            else if (e.KeyCode == Keys.Up)
            {
                tohum.Location = new Point(tohum.Location.X, tohum.Location.Y - 5);
            }
            else if (e.KeyCode == Keys.Down)
            {
                tohum.Location = new Point(tohum.Location.X, tohum.Location.Y + 5);
            }

            //Tohum atma
            if (e.KeyCode == Keys.Space)
            {
                tohum.Visible = true;
                tohum_timer1.Interval = 400;
                tohum_timer1.Start();
                               
            }
            if (e.KeyCode == Keys.Space && tree.Visible == true)
            {
                tohum.Visible = true;
                tohum_timer2.Interval = 400;
                tohum_timer2.Start();
               
            }
            if(e.KeyCode == Keys.Space && tree.Visible == true && tree2.Visible == true)
            {
                tohum.Visible = true;
                tohum_timer3.Interval = 400;
                tohum_timer3.Start();
                               
            }
            if (e.KeyCode == Keys.Space && tree.Visible == true && tree2.Visible == true && tree3.Visible == true)
            {
                tohum.Visible = true;
                tohum_timer4.Interval = 400;
                tohum_timer4.Start();
                                
            }
            
            if(sayac == 0)
            {
                MessageBox.Show("Level 2'ye geçmek istiyor musun :) ?", "Level 1 tamamlandı" , MessageBoxButtons.YesNo,MessageBoxIcon.None,MessageBoxDefaultButton.Button2);
                DialogResult sonuc;
                sonuc = MessageBox.Show("Level 2'ye geçmek istiyor musun :) ?", "Level 1 tamamlandı", MessageBoxButtons.YesNo, MessageBoxIcon.None, MessageBoxDefaultButton.Button2);
                if(sonuc == DialogResult.Yes)
                {
                    Level2 Level2 = new Level2();
                    Level2.ShowDialog();
                    Application.Run(new Level2());
                    Close();
                    
                }
               
            }
            // Uçak ve diğer nesneler arası ilişki /*******************************************
            if (fly.Bounds.IntersectsWith(ground.Bounds))
            {
                endGame();
            }
            if (fly.Bounds.IntersectsWith(ev.Bounds))
            {
                endGame();
            }
            if (fly.Bounds.IntersectsWith(ev2.Bounds))
            {
                endGame();
            }

        }
        public void endGame()
        {
            MessageBox.Show("Nesneye çarptın. \n Yeniden başla !" , "GAME OVER!", MessageBoxButtons.YesNo, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2);
            DialogResult sonuc2;
            sonuc2 = MessageBox.Show("Nesneye çarptın. \n Yeniden başla !", "GAME OVER!", MessageBoxButtons.YesNo, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2);
            if(sonuc2 == DialogResult.Yes)
            {
                Game Game = new Game();
                Game.ShowDialog();
                this.Hide();
                this.Close();
                
            }
            if(sonuc2 == DialogResult.No)
            {
                this.Close();
            }
        }

        private void tohum_timer1_Tick(object sender, EventArgs e)
        {
            do
            {
                tohum.Location = new Point(tohum.Location.X, tohum.Location.Y + 8);             
            }
            while (tohum.Location.Y == ground.Location.Y);
            {             
                tohum.Visible = false;
                tohum_timer1.Stop();               
                tree.Visible = true;
                score.Text = sayac.ToString();
            }
         

        }


        private void tohum_timer2_Tick(object sender, EventArgs e)
        {
            do
            {
                tohum.Location = new Point(tohum.Location.X, tohum.Location.Y + 8);
            }
            while (tohum.Location.Y == ground.Location.Y);
            {
                tohum.Visible = false;
                tohum_timer2.Stop();
                tree2.Visible = true;
                sayac--;
                score.Text = sayac.ToString();
            }
        }

        private void tohum_timer3_Tick(object sender, EventArgs e)
        {
            do
            {
                tohum.Location = new Point(tohum.Location.X, tohum.Location.Y + 8);
            }
            while (tohum.Location.Y == ground.Location.Y);
            {
                tohum.Visible = false;
                tohum_timer3.Stop();
                tree3.Visible = true;
                score.Text = sayac.ToString();
            }
        }

        private void tohum_timer4_Tick(object sender, EventArgs e)
        {
            do
            {
                tohum.Location = new Point(tohum.Location.X, tohum.Location.Y + 8);
            }
            while (tohum.Location.Y == ground.Location.Y);
            {
                tohum.Visible = false;
                tohum_timer4.Stop();
                tree4.Visible = true;
                score.Text = sayac.ToString();
            }
        }

       

    }
}      
        
    

