using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StarCraft
{
    public partial class Tossfight1Form : Form
    {
        public Tossfight1Form(ImageList Toss)
        {
            InitializeComponent();
            pb_pro1.Image = Toss.Images[0];
            pb_pro2.Image = Toss.Images[1];
            pb_pro3.Image = Toss.Images[2];
            pb_pro4.Image = Toss.Images[3];
            pb_pro5.Image = Toss.Images[4];
            pb_pro6.Image = Toss.Images[5];
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void btn_TFight1Start_Click(object sender, EventArgs e)
        {

        }
    }
}
