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
    public partial class VideoFormu : Form
    {
        public VideoFormu()
        {
            InitializeComponent();
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
             axWindowsMediaPlayer1.URL = "C:/ecosia.mp4";
        }

        private void VideoFormu_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            // VideoFormu.ActiveForm.Close();


        }
    }
}
