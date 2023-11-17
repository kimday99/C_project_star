using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StarCraft
{
    public partial class Zergfight1Form : Form
    {
        public int re;
        public int dr;

        public Zergfight1Form(ImageList m, ImageList checkimage,int re,int dr)
        {
            this.re = re;
            this.dr = dr;
            InitializeComponent();
            string[] checklist = new string[6];

            //if (m.Images[0] == null)
            //{
            //    con++;
            //    m.Images[0] = pictureBox1.Image;
            //}
            //if (m.Images[1] == null)
            //{
            //    con++;
            //    m.Images[1] = pictureBox1.Image;
            //}
            //if (m.Images[2] == null)
            //{
            //    con++;
            //    m.Images[2] = pictureBox1.Image;
            //}
            //if (m.Images[3] == null)
            //{
            //    con++;
            //    m.Images[3] = pictureBox1.Image;
            //}
            //if (m.Images[4] == null)
            //{
            //    con++;
            //    m.Images[4] = pictureBox1.Image;
            //}
            //if (m.Images[5] == null)
            //{
            //    con++;
            //    m.Images[5] = pictureBox1.Image;
            //}
            pb_pro1.Image = m.Images[0];
            pb_pro2.Image = m.Images[1];
            pb_pro3.Image = m.Images[2];
            pb_pro4.Image = m.Images[3];
            pb_pro5.Image = m.Images[4];
            pb_pro6.Image = m.Images[5];


            //for (int i = 0; i < 6; i++)
            //{
            //    if (m.Images[i] == checkimage.Images[0])
            //    {
            //        checklist[i] = "드론";
            //        drone++;
            //    }
            //    else if (m.Images[i] == checkimage.Images[1])
            //    {
            //        checklist[i] = "저글링";
            //        gling++;
            //    }
            //    else
            //    {
            //        checklist[i] = "없음";
            //        back++;
            //    }
            //}
            //if ((gling == 4) || ((gling == 3) || (drone == 1)))
            //{
            //    re = "최저가로 승리!!";
            //}

        }
        public void btn_ZFight1Start_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        int x = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (x > 110)
            {
                x = 0;
                if (re >= 4)
                {
                    lb_ResultZ1.Text = "승  리!";
                }
                else
                {
                    lb_ResultZ1.Text = "패  배!";
                }
                timer1.Stop();
            }
            else
            {
                for (int i = 0; i < 10; i++)
                {
                    pb_zfight1.Location = new Point(188 + x, 140);
                    pb_pro1.Location = new Point(500 - x, 120);
                    pb_pro2.Location = new Point(550 - x, 120);
                    pb_pro3.Location = new Point(500 - x, 160);
                    pb_pro4.Location = new Point(550 - x, 160);
                    pb_pro5.Location = new Point(500 - x, 200);
                    pb_pro6.Location = new Point(550 - x, 200);
                    x += 1;
                }
            }
        }
    }
}
