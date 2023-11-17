using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StarCraft
{
    public partial class Terrfight1Form : Form
    {
        public Terrfight1Form(ImageList terrunit)
        {
            InitializeComponent();
            pb_tpro1.Image = terrunit.Images[0];
            pb_tpro2.Image = terrunit.Images[1];
            pb_tpro3.Image = terrunit.Images[2];
            pb_tpro4.Image = terrunit.Images[3];
            pb_tpro5.Image = terrunit.Images[4];
            pb_tpro6.Image = terrunit.Images[5];

            //TerranForm tform = new TerranForm();
            //int marine = 0;
            //int scv = 0;
            //for (int i = 0; i < 6; i++)
            //{
            //    if (terrunit.Images[i] == tform.pb_Marine_In.Image)
            //    {
            //        marine++;
                  
            //    }
            //    else if (terrunit.Images[i] == tform.pb_Scv_In.Image)
            //    {
            //        scv++;
            //    }
            //}

        }

        private void btn_TeFight1Start_Click(object sender, EventArgs e)
        {
            //if ( >= 4)
            //{
            //    lb_ResultTe1.Text = "승리!";
            //}
            //else
            //{
            //    lb_ResultTe1.Text = "패배!";
            //}
        }
    }
}
