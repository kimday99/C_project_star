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
    public partial class ProtossForm : Form
    {
        public ProtossForm()
        {
            InitializeComponent();
        }
        ImageList tossimages = new ImageList();
        int count = 0;
        int count2 = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            pb_fightM.Location = new Point(239, 109);
            Tosspb_Unit1.Image = Toss_level1.BackgroundImage;
            Tosspb_Unit1.Location = new Point(1000, 1000);
            cbtn_Gate.Location = new Point(500, 500);
            cbtn_Nex.Location = new Point(500, 500);
            btn_Un.Location = new Point(618, 471);

            lb_PMi.Text = "";
            lb_PPe.Text = "";
            lb_Pres.Location = new Point(393, 471);
            if (count2 >= 2)
                lb_Pres.Text = "승 리";
            else
                lb_Pres.Text = "패 배";
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void cbtn_Gate_Click(object sender, EventArgs e)
        {
            Tosspb_Unit1.Image = pictureBox2.Image;
            btn_Un.BackgroundImage = pb_CopyZea.Image;
        }

        private void cbtn_Nex_Click(object sender, EventArgs e)
        {
            Tosspb_Unit1.Image = pictureBox1.Image;
            btn_Un.BackgroundImage = pb_CopyPro.Image;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (btn_Un.BackgroundImage == pb_CopyPro.Image)
            {
                if (count == 6)
                {
                    pb_T_production6.Image = pb_back.Image;

                    lb_PMi.Text = (int.Parse(lb_PMi.Text) + 50).ToString();
                    lb_PPe.Text = (int.Parse(lb_PPe.Text) - 1).ToString();
                }
                if (count == 5)
                {
                    pb_T_production5.Image = pb_back.Image;
                    lb_PMi.Text = (int.Parse(lb_PMi.Text) + 50).ToString();
                    lb_PPe.Text = (int.Parse(lb_PPe.Text) - 1).ToString();
                }
                if (count == 4)
                {
                    pb_T_production4.Image = pb_back.Image;
                    lb_PMi.Text = (int.Parse(lb_PMi.Text) + 50).ToString();
                    lb_PPe.Text = (int.Parse(lb_PPe.Text) - 1).ToString();
                }
                if (count == 3)
                {
                    pb_T_production3.Image = pb_back.Image;
                    lb_PMi.Text = (int.Parse(lb_PMi.Text) + 50).ToString();
                    lb_PPe.Text = (int.Parse(lb_PPe.Text) - 1).ToString();
                }
                if (count == 2)
                {
                    pb_T_production2.Image = pb_back.Image;
                    lb_PMi.Text = (int.Parse(lb_PMi.Text) + 50).ToString();
                    lb_PPe.Text = (int.Parse(lb_PPe.Text) - 1).ToString();
                }
                if (count == 1)
                {
                    pb_T_production1.Image = pb_back.Image;
                    lb_PMi.Text = (int.Parse(lb_PMi.Text) + 50).ToString();
                    lb_PPe.Text = (int.Parse(lb_PPe.Text) - 1).ToString();
                }
                if (count == 0)
                {
                    lb_PMi.Text = "300";
                    lb_PPe.Text = "0";
                }
                count--;

                if (count < 0)
                {
                    count = 0;
                }
            }
            else if (btn_Un.BackgroundImage == pb_CopyZea.Image)
            {                
                    if (count == 6)
                    {
                        pb_T_production6.Image = pb_back.Image;
                        lb_PMi.Text = (int.Parse(lb_PMi.Text) + 100).ToString();
                        lb_PPe.Text = (int.Parse(lb_PPe.Text) - 2).ToString();
                    }
                    if (count == 5)
                    {
                        pb_T_production5.Image = pb_back.Image;
                        lb_PMi.Text = (int.Parse(lb_PMi.Text) + 100).ToString();
                        lb_PPe.Text = (int.Parse(lb_PPe.Text) - 2).ToString();
                    }
                    if (count == 4)
                    {
                        pb_T_production4.Image = pb_back.Image;
                        lb_PMi.Text = (int.Parse(lb_PMi.Text) + 100).ToString();
                        lb_PPe.Text = (int.Parse(lb_PPe.Text) - 2).ToString();
                    }
                    if (count == 3)
                    {
                        pb_T_production3.Image = pb_back.Image;
                        lb_PMi.Text = (int.Parse(lb_PMi.Text) + 100).ToString();
                        lb_PPe.Text = (int.Parse(lb_PPe.Text) - 2).ToString();
                    }
                    if (count == 2)
                    {
                        pb_T_production2.Image = pb_back.Image;
                        lb_PMi.Text = (int.Parse(lb_PMi.Text) + 100).ToString();
                        lb_PPe.Text = (int.Parse(lb_PPe.Text) - 2).ToString();
                    }
                    if (count == 1)
                    {
                        pb_T_production1.Image = pb_back.Image;
                        lb_PMi.Text = (int.Parse(lb_PMi.Text) + 100).ToString();
                        lb_PPe.Text = (int.Parse(lb_PPe.Text) - 2).ToString();
                    }
                    if (count == 0)
                    {
                        lb_PMi.Text = "300";
                        lb_PPe.Text = "0";
                    }
                    count--;
                    count2--;

                    if (count < 0)
                    {
                        count = 0;
                        count2 = 0;
                    }                
            }
        }
        private void btn_Un_Click(object sender, EventArgs e)
        {
            if (btn_Un.BackgroundImage == pb_CopyZea.Image)
            {
                if (count == 0)
                {
                    lb_PMi.Text = "300";
                    lb_PPe.Text = "0";
                }
                count++;
                count++;
                count2++;
                if (count == 1)
                {
                    pb_T_production1.Image = pb_Zeal_In.Image;
                    lb_PMi.Text = (int.Parse(lb_PMi.Text) - 100).ToString();
                    lb_PPe.Text = (int.Parse(lb_PPe.Text) + 2).ToString();
                }
                if (count == 2)
                {
                    pb_T_production2.Image = pb_Zeal_In.Image;
                    lb_PMi.Text = (int.Parse(lb_PMi.Text) - 100).ToString();
                    lb_PPe.Text = (int.Parse(lb_PPe.Text) + 2).ToString();
                }
                if (count == 3)
                {
                    pb_T_production3.Image = pb_Zeal_In.Image;
                    lb_PMi.Text = (int.Parse(lb_PMi.Text) - 100).ToString();
                    lb_PPe.Text = (int.Parse(lb_PPe.Text) + 2).ToString();
                }
                if (count == 4)
                {
                    pb_T_production4.Image = pb_Zeal_In.Image;
                    lb_PMi.Text = (int.Parse(lb_PMi.Text) - 100).ToString();
                    lb_PPe.Text = (int.Parse(lb_PPe.Text) + 2).ToString();
                }
                if (count == 5)
                {
                    pb_T_production5.Image = pb_Zeal_In.Image;
                    lb_PMi.Text = (int.Parse(lb_PMi.Text) - 100).ToString();
                    lb_PPe.Text = (int.Parse(lb_PPe.Text) + 2).ToString();
                }
                if (count == 6)
                {
                    pb_T_production6.Image = pb_Zeal_In.Image;
                    lb_PMi.Text = (int.Parse(lb_PMi.Text) - 100).ToString();
                    lb_PPe.Text = (int.Parse(lb_PPe.Text) + 2).ToString();
                }
                if (count > 6)
                {
                    count = 6;
                    count2 = 3;
                }
            }
            else if (btn_Un.BackgroundImage == pb_CopyPro.Image)
            {
                if (count == 0)
                {
                    lb_PMi.Text = "300";
                    lb_PPe.Text = "0";
                }
                count++;
                if (count == 1)
                {
                    pb_T_production1.Image = pb_Pr_In.Image;
                    lb_PMi.Text = (int.Parse(lb_PMi.Text) - 50).ToString();
                    lb_PPe.Text = (int.Parse(lb_PPe.Text) + 1).ToString();
                }
                if (count == 2)
                {
                    pb_T_production2.Image = pb_Pr_In.Image;
                    lb_PMi.Text = (int.Parse(lb_PMi.Text) - 50).ToString();
                    lb_PPe.Text = (int.Parse(lb_PPe.Text) + 1).ToString();
                }
                if (count == 3)
                {
                    pb_T_production3.Image = pb_Pr_In.Image;
                    lb_PMi.Text = (int.Parse(lb_PMi.Text) - 50).ToString();
                    lb_PPe.Text = (int.Parse(lb_PPe.Text) + 1).ToString();
                }
                if (count == 4)
                {
                    pb_T_production4.Image = pb_Pr_In.Image;
                    lb_PMi.Text = (int.Parse(lb_PMi.Text) - 50).ToString();
                    lb_PPe.Text = (int.Parse(lb_PPe.Text) + 1).ToString();
                }
                if (count == 5)
                {
                    pb_T_production5.Image = pb_Pr_In.Image;
                    lb_PMi.Text = (int.Parse(lb_PMi.Text) - 50).ToString();
                    lb_PPe.Text = (int.Parse(lb_PPe.Text) + 1).ToString();
                }
                if (count == 6)
                {
                    pb_T_production6.Image = pb_Pr_In.Image;
                    lb_PMi.Text = (int.Parse(lb_PMi.Text) - 50).ToString();
                    lb_PPe.Text = (int.Parse(lb_PPe.Text) + 1).ToString();
                }
                if (count > 6)
                    count = 6;
            }
        }
        int xp;
        private void timer1_Tick(object sender, EventArgs e)
        {
            {
                //if (xp > 140)
                //{
                //    xp = 0;
                //    timer1.Stop();
                //    lb_Pres.Location = new Point(425, 270);
                //    //if (count2 >= 2)
                //    //    lb_Pres.Text = "승 리";
                //    //else
                //    //    lb_Pres.Text = "패 배";
                //}
                //else
                //{
                //    for (int i = 0; i < 22; i++)
                //    {
                //        pb_fightM.Location = new Point(254 + xp, 148);
                //        pb_T_production1.Location = new Point(774 - xp, 108);
                //        pb_T_production2.Location = new Point(820 - xp, 108);
                //        pb_T_production3.Location = new Point(787 - xp, 148);
                //        pb_T_production4.Location = new Point(833 - xp, 148);
                //        pb_T_production5.Location = new Point(796 - xp, 188);
                //        pb_T_production6.Location = new Point(842 - xp, 188);
                //        xp += 5;
                //    }
                //}

                if (xp > 120)
                {
                    xp = 0;
                    timer1.Stop();
                    timer1.Interval = 1000;
                    lb_Pres.Location = new Point(425, 270);

                }
                else
                {
                    for (int i = 0; i < 10; i++)
                    {
                        pb_fightM.Location = new Point(254 + xp, 148);
                        pb_T_production1.Location = new Point(774 - xp, 108);
                        pb_T_production2.Location = new Point(820 - xp, 108);
                        pb_T_production3.Location = new Point(787 - xp, 148);
                        pb_T_production4.Location = new Point(833 - xp, 148);
                        pb_T_production5.Location = new Point(796 - xp, 188);
                        pb_T_production6.Location = new Point(842 - xp, 188);
                        xp += 15;
                    }
                }
            }
        }
    }
}
