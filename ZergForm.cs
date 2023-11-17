using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StarCraft
{
    public partial class ZergForm : Form
    {
        public ZergForm()
        {
            InitializeComponent();
        }

        ImageList myimages = new ImageList();
        int count = 0;
        public int count2;
        public int count3;

        public void btn_Zergling_Click(object sender, EventArgs e)
        {


            if (count == 0)
            {
                lb_Mi.Text = "300";
                lb_Pe.Text = "0";
            }
            count++;
            if (count == 1)
            {
                pb_production1.Image = pb_Ze_In.Image;
                lb_Mi.Text = "250";
                lb_Pe.Text = "1";
            }
            if (count == 2)
            {
                pb_production2.Image = pb_Ze_In.Image;
                lb_Mi.Text = "200";
                lb_Pe.Text = "2";
            }
            if (count == 3)
            {
                pb_production3.Image = pb_Ze_In.Image;
                lb_Mi.Text = "150";
                lb_Pe.Text = "3";
            }
            if (count == 4)
            {
                pb_production4.Image = pb_Ze_In.Image;
                lb_Mi.Text = "100";
                lb_Pe.Text = "4";
            }
            if (count == 5)
            {
                pb_production5.Image = pb_Ze_In.Image;
                lb_Mi.Text = "50";
                lb_Pe.Text = "5";
            }
            if (count == 6)
            {
                pb_production6.Image = pb_Ze_In.Image;
                lb_Mi.Text = "0";
                lb_Pe.Text = "6";
            }
            if (count > 6)
                count = 6;
            count2 = count;
        }

        public void btn_Drone_Click(object sender, EventArgs e)
        {

            if (count == 0)
            {
                lb_Mi.Text = "300";
                lb_Pe.Text = "0";
            }
            count++;
            if (count == 1)
            {
                pb_production1.Image = pb_Dr_In.Image;
                lb_Mi.Text = "250";
                lb_Pe.Text = "1";
            }
            if (count == 2)
            {
                pb_production2.Image = pb_Dr_In.Image;
                lb_Mi.Text = "200";
                lb_Pe.Text = "2";
            }
            if (count == 3)
            {
                pb_production3.Image = pb_Dr_In.Image;
                lb_Mi.Text = "150";
                lb_Pe.Text = "3";
            }
            if (count == 4)
            {
                pb_production4.Image = pb_Dr_In.Image;
                lb_Mi.Text = "100";
                lb_Pe.Text = "4";
            }
            if (count == 5)
            {
                pb_production5.Image = pb_Dr_In.Image;
                lb_Mi.Text = "50";
                lb_Pe.Text = "5";
            }
            if (count == 6)
            {
                pb_production6.Image = pb_Dr_In.Image;
                lb_Mi.Text = "0";
                lb_Pe.Text = "6";
            }
            if (count > 6)
                count = 6;
            count3 = count;
        }

        public void button3_Click(object sender, EventArgs e)
        {
            ZergUnitInfoForm zunitInfo = new ZergUnitInfoForm();
            zunitInfo.Show();
        }

        public void button2_Click(object sender, EventArgs e)
        {
            if (count == 6)
            {
                pb_production6.Image = pb_back.Image;
                lb_Mi.Text = (int.Parse(lb_Mi.Text) + 50).ToString();
                lb_Pe.Text = (int.Parse(lb_Pe.Text) - 1).ToString();
            }
            if (count == 5)
            {
                pb_production5.Image = pb_back.Image;
                lb_Mi.Text = (int.Parse(lb_Mi.Text) + 50).ToString();
                lb_Pe.Text = (int.Parse(lb_Pe.Text) - 1).ToString();
            }
            if (count == 4)
            {
                pb_production4.Image = pb_back.Image;
                lb_Mi.Text = (int.Parse(lb_Mi.Text) + 50).ToString();
                lb_Pe.Text = (int.Parse(lb_Pe.Text) - 1).ToString();
            }
            if (count == 3)
            {
                pb_production3.Image = pb_back.Image;
                lb_Mi.Text = (int.Parse(lb_Mi.Text) + 50).ToString();
                lb_Pe.Text = (int.Parse(lb_Pe.Text) - 1).ToString();
            }
            if (count == 2)
            {
                pb_production2.Image = pb_back.Image;
                lb_Mi.Text = (int.Parse(lb_Mi.Text) + 50).ToString();
                lb_Pe.Text = (int.Parse(lb_Pe.Text) - 1).ToString();
            }
            if (count == 1)
            {
                pb_production1.Image = pb_back.Image;
                lb_Mi.Text = (int.Parse(lb_Mi.Text) + 50).ToString();
                lb_Pe.Text = (int.Parse(lb_Pe.Text) - 1).ToString();
            }
            if (count == 0)
            {
                lb_Mi.Text = "300";
                lb_Pe.Text = "0";
            }
            count--;
            if (count < 0)
            {
                count = 0;
            }

        }

        public void button1_Click(object sender, EventArgs e)
        {


            if (pb_production1.Image == null)
                myimages.Images.Add(pb_back.Image);
            myimages.Images.Add(pb_production1.Image);
            //if (pb_production1.Image == imageList1.Images[0])
            //    myimages.Images.Add(imageList1.Images[0]);


            if (pb_production2.Image == null)
                myimages.Images.Add(pb_back.Image);
            myimages.Images.Add(pb_production2.Image);

            if (pb_production3.Image == null)
                myimages.Images.Add(pb_back.Image);
            myimages.Images.Add(pb_production3.Image);

            if (pb_production4.Image == null)
                myimages.Images.Add(pb_back.Image);
            myimages.Images.Add(pb_production4.Image);

            if (pb_production5.Image == null)
                myimages.Images.Add(pb_back.Image);
            myimages.Images.Add(pb_production5.Image);

            if (pb_production6.Image == null)
                myimages.Images.Add(pb_back.Image);
            myimages.Images.Add(pb_production6.Image);
            
            Zergfight1Form fight1 = new Zergfight1Form(myimages, imageList1,count2,count3);
            fight1.ShowDialog();
        }
    }
}
