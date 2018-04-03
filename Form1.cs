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
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)//What is Ecosia? butonu
        {
            VideoFormu VideoFormu = new VideoFormu();
            VideoFormu.ShowDialog();
            
        }

        private void button1_Click(object sender, EventArgs e)//Play button
        {
            Game Game = new Game();
            Game.ShowDialog();

          
        }

        private void bilgi_button_Click(object sender, EventArgs e)
        {
    
            VideoFormu VideoFormu = new VideoFormu();
            VideoFormu.ShowDialog();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    }

