using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StarCraft
{
    public partial class TerranForm : Form
    {
        public TerranForm()
        {
            InitializeComponent();
        }

        private void cbtn_Barr_Click(object sender, EventArgs e)
        {
            Terrpb_Unit1.Image = pictureBox2.Image;
            btn_TeUnit.BackgroundImage = pb_CopyMar.Image;
        }

        private void cbtn_Co_Click(object sender, EventArgs e)
        {
            Terrpb_Unit1.Image = pictureBox1.Image;
            btn_TeUnit.BackgroundImage = pb_CopyScv.Image;
        }
        int count = 0;
        private void button1T1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            //cbtn_Co.Enabled = true;
            pb_fig.Image = pb_fightgling.Image;
            Terrpb_Unit1.Image = pictureBox3.Image;
            Terrpb_Unit1.Location = new Point(1000, 1000);
            cbtn_Barr.Location = new Point(500, 500);
            cbtn_Co.Location = new Point(500, 500);
            //cbtn_Barr.Image = pictureBox3.Image;
            //cbtn_Co.Image = pictureBox3.Image;
            btn_TeUnit.Location = new Point(618, 471);
            lb_TeMi.Text = "";
            lb_TePe.Text = "";
            lb_res.Location = new Point(419, 235);
            //Terrfight1Form tfight1 = new Terrfight1Form(imageList1);
            //tfight1.Show();
        }

        private void button2T1_Click(object sender, EventArgs e)
        {
            //if (btn_TeUnit.BackgroundImage == pb_CopyMar.Image)
            //{
            if (count == 6)
            {
                pb_Teproduction6.Image = pb_Teback.Image;
                imageList1.Images.Remove(pb_Marine_In.Image);
                lb_TeMi.Text = (int.Parse(lb_TeMi.Text) + 50).ToString();
                lb_TePe.Text = (int.Parse(lb_TePe.Text) - 1).ToString();
            }
            if (count == 5)
            {
                pb_Teproduction5.Image = pb_Teback.Image;
                imageList1.Images.Remove(pb_Marine_In.Image);
                lb_TeMi.Text = (int.Parse(lb_TeMi.Text) + 50).ToString();
                lb_TePe.Text = (int.Parse(lb_TePe.Text) - 1).ToString();
            }
            if (count == 4)
            {
                pb_Teproduction4.Image = pb_Teback.Image;
                imageList1.Images.Remove(pb_Marine_In.Image);
                lb_TeMi.Text = (int.Parse(lb_TeMi.Text) + 50).ToString();
                lb_TePe.Text = (int.Parse(lb_TePe.Text) - 1).ToString();
            }
            if (count == 3)
            {
                pb_Teproduction3.Image = pb_Teback.Image;
                imageList1.Images.Remove(pb_Marine_In.Image);
                lb_TeMi.Text = (int.Parse(lb_TeMi.Text) + 50).ToString();
                lb_TePe.Text = (int.Parse(lb_TePe.Text) - 1).ToString();
            }
            if (count == 2)
            {
                pb_Teproduction2.Image = pb_Teback.Image;
                imageList1.Images.Remove(pb_Marine_In.Image);
                lb_TeMi.Text = (int.Parse(lb_TeMi.Text) + 50).ToString();
                lb_TePe.Text = (int.Parse(lb_TePe.Text) - 1).ToString();
            }
            if (count == 1)
            {
                pb_Teproduction1.Image = pb_Teback.Image;
                imageList1.Images.Remove(pb_Marine_In.Image);
                lb_TeMi.Text = (int.Parse(lb_TeMi.Text) + 50).ToString();
                lb_TePe.Text = (int.Parse(lb_TePe.Text) - 1).ToString();
            }
            if (count == 0)
            {
                imageList1.Images.Clear();
                lb_TeMi.Text = "300";
                lb_TePe.Text = "0";
            }
            count--;
            if (count < 0)
            {
                count = 0;
            }
            //}
            //if (btn_TeUnit.BackgroundImage == pb_CopyScv.Image)
            //{
            //    if (count == 6)
            //    {
            //        pb_Teproduction6.Image = pb_Teback.Image;
            //        imageList1.Images.Remove(pb_Scv_In.Image);
            //        lb_TeMi.Text = (int.Parse(lb_TeMi.Text) + 50).ToString();
            //        lb_TePe.Text = (int.Parse(lb_TePe.Text) - 1).ToString();
            //    }
            //    if (count == 5)
            //    {
            //        pb_Teproduction5.Image = pb_Teback.Image;
            //        imageList1.Images.Remove(pb_Scv_In.Image);
            //        lb_TeMi.Text = (int.Parse(lb_TeMi.Text) + 50).ToString();
            //        lb_TePe.Text = (int.Parse(lb_TePe.Text) - 1).ToString();
            //    }
            //    if (count == 4)
            //    {
            //        pb_Teproduction4.Image = pb_Teback.Image;
            //        imageList1.Images.Remove(pb_Scv_In.Image);
            //        lb_TeMi.Text = (int.Parse(lb_TeMi.Text) + 50).ToString();
            //        lb_TePe.Text = (int.Parse(lb_TePe.Text) - 1).ToString();
            //    }
            //    if (count == 3)
            //    {
            //        pb_Teproduction3.Image = pb_Teback.Image;
            //        imageList1.Images.Remove(pb_Scv_In.Image);
            //        lb_TeMi.Text = (int.Parse(lb_TeMi.Text) + 50).ToString();
            //        lb_TePe.Text = (int.Parse(lb_TePe.Text) - 1).ToString();
            //    }
            //    if (count == 2)
            //    {
            //        pb_Teproduction2.Image = pb_Teback.Image;
            //        imageList1.Images.Remove(pb_Scv_In.Image);
            //        lb_TeMi.Text = (int.Parse(lb_TeMi.Text) + 50).ToString();
            //        lb_TePe.Text = (int.Parse(lb_TePe.Text) - 1).ToString();
            //    }
            //    if (count == 1)
            //    {
            //        pb_Teproduction1.Image = pb_Teback.Image;
            //        imageList1.Images.Remove(pb_Scv_In.Image);
            //        lb_TeMi.Text = (int.Parse(lb_TeMi.Text) + 50).ToString();
            //        lb_TePe.Text = (int.Parse(lb_TePe.Text) - 1).ToString();
            //    }
            //    if (count == 0)
            //    {
            //        imageList1.Images.Clear();
            //        lb_TeMi.Text = "300";
            //        lb_TePe.Text = "0";
            //    }
            //    count--;
            //    if (count < 0)
            //    {
            //        count = 0;
            //    }
            //}
        }

        private void button3T1_Click(object sender, EventArgs e)
        {
            TerrUnitInfoForm territInfo = new TerrUnitInfoForm();
            territInfo.Show();
        }

        private void btn_TeUnit_Click(object sender, EventArgs e)
        {
            if (btn_TeUnit.BackgroundImage == pb_CopyMar.Image)
            {
                if (count == 0)
                {
                    lb_TeMi.Text = "300";
                    lb_TePe.Text = "0";
                }
                count++;
                if (count == 1)
                {
                    pb_Teproduction1.Image = pb_Marine_In.Image;
                    imageList1.Images.Add(pb_Marine_In.Image);
                    lb_TeMi.Text = (int.Parse(lb_TeMi.Text) - 50).ToString();
                    lb_TePe.Text = (int.Parse(lb_TePe.Text) + 1).ToString();
                }
                if (count == 2)
                {
                    pb_Teproduction2.Image = pb_Marine_In.Image;
                    imageList1.Images.Add(pb_Marine_In.Image);
                    lb_TeMi.Text = (int.Parse(lb_TeMi.Text) - 50).ToString();
                    lb_TePe.Text = (int.Parse(lb_TePe.Text) + 1).ToString();
                }
                if (count == 3)
                {
                    pb_Teproduction3.Image = pb_Marine_In.Image;
                    imageList1.Images.Add(pb_Marine_In.Image);
                    lb_TeMi.Text = (int.Parse(lb_TeMi.Text) - 50).ToString();
                    lb_TePe.Text = (int.Parse(lb_TePe.Text) + 1).ToString();
                }
                if (count == 4)
                {
                    pb_Teproduction4.Image = pb_Marine_In.Image;
                    imageList1.Images.Add(pb_Marine_In.Image);
                    lb_TeMi.Text = (int.Parse(lb_TeMi.Text) - 50).ToString();
                    lb_TePe.Text = (int.Parse(lb_TePe.Text) + 1).ToString();
                }
                if (count == 5)
                {
                    pb_Teproduction5.Image = pb_Marine_In.Image;
                    imageList1.Images.Add(pb_Marine_In.Image);
                    lb_TeMi.Text = (int.Parse(lb_TeMi.Text) - 50).ToString();
                    lb_TePe.Text = (int.Parse(lb_TePe.Text) + 1).ToString();
                }
                if (count == 6)
                {
                    pb_Teproduction6.Image = pb_Marine_In.Image;
                    imageList1.Images.Add(pb_Marine_In.Image);
                    lb_TeMi.Text = (int.Parse(lb_TeMi.Text) - 50).ToString();
                    lb_TePe.Text = (int.Parse(lb_TePe.Text) + 1).ToString();
                }
            }
            if (count > 6)
                count = 6;
            //else if (btn_TeUnit.BackgroundImage == pb_CopyScv.Image)
            //{
            //    if (count == 0)
            //    {
            //        lb_TeMi.Text = "300";
            //        lb_TePe.Text = "0";
            //    }
            //    count++;
            //    if (count == 1)
            //    {
            //        pb_Teproduction1.Image = pb_Scv_In.Image;
            //        imageList1.Images.Add(pb_Scv_In.Image);
            //        lb_TeMi.Text = (int.Parse(lb_TeMi.Text) - 50).ToString();
            //        lb_TePe.Text = (int.Parse(lb_TePe.Text) + 1).ToString();
            //    }
            //    if (count == 2)
            //    {
            //        pb_Teproduction2.Image = pb_Scv_In.Image;
            //        imageList1.Images.Add(pb_Scv_In.Image);
            //        lb_TeMi.Text = (int.Parse(lb_TeMi.Text) - 50).ToString();
            //        lb_TePe.Text = (int.Parse(lb_TePe.Text) + 1).ToString();
            //    }
            //    if (count == 3)
            //    {
            //        pb_Teproduction3.Image = pb_Scv_In.Image;
            //        imageList1.Images.Add(pb_Scv_In.Image);
            //        lb_TeMi.Text = (int.Parse(lb_TeMi.Text) - 50).ToString();
            //        lb_TePe.Text = (int.Parse(lb_TePe.Text) + 1).ToString();
            //    }
            //    if (count == 4)
            //    {
            //        pb_Teproduction4.Image = pb_Scv_In.Image;
            //        imageList1.Images.Add(pb_Scv_In.Image);
            //        lb_TeMi.Text = (int.Parse(lb_TeMi.Text) - 50).ToString();
            //        lb_TePe.Text = (int.Parse(lb_TePe.Text) + 1).ToString();
            //    }
            //    if (count == 5)
            //    {
            //        pb_Teproduction5.Image = pb_Scv_In.Image;
            //        imageList1.Images.Add(pb_Scv_In.Image);
            //        lb_TeMi.Text = (int.Parse(lb_TeMi.Text) - 50).ToString();
            //        lb_TePe.Text = (int.Parse(lb_TePe.Text) + 1).ToString();
            //    }
            //    if (count == 6)
            //    {
            //        pb_Teproduction6.Image = pb_Scv_In.Image;
            //        imageList1.Images.Add(pb_Scv_In.Image);
            //        lb_TeMi.Text = (int.Parse(lb_TeMi.Text) - 50).ToString();
            //        lb_TePe.Text = (int.Parse(lb_TePe.Text) + 1).ToString();
            //    }
            //    if (count > 6)
            //        count = 6;
            //}
        }
        int x1 = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (x1 > 140)
            {
                x1 = 0;
                timer1.Stop();
                if (count >= 4)
                    lb_res.Text = "승 리";
                else
                    lb_res.Text = "패 배";
            }
            else
            {
                for (int i = 0; i < 22; i++)
                {
                    pb_fig.Location = new Point(254 + x1, 148);
                    pb_Teproduction1.Location = new Point(789 - x1, 108);
                    pb_Teproduction2.Location = new Point(835 - x1, 108);
                    pb_Teproduction3.Location = new Point(802 - x1, 148);
                    pb_Teproduction4.Location = new Point(848 - x1, 148);
                    pb_Teproduction5.Location = new Point(811 - x1, 188);
                    pb_Teproduction6.Location = new Point(857 - x1, 188);
                    x1 += 10;
                }
            }
        }
        //Terrfight1Form tfi = new Terrfight1Form(count);
    }
}
