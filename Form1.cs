using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StarCraft
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Zerg_Click(object sender, EventArgs e)
        {
            ZergForm zerg = new ZergForm();
            zerg.ShowDialog();
        }

        private void btn_Protoss_Click(object sender, EventArgs e)
        {
            ProtossForm protoss = new ProtossForm();
            protoss.ShowDialog();
        }

        private void btn_Terran_Click(object sender, EventArgs e)
        {
            TerranForm terran = new TerranForm();
            terran.ShowDialog();
        }
    }
    public class CircularButton : Button
    {
        protected override void OnPaint(PaintEventArgs pevent)
        {
            GraphicsPath grPath = new GraphicsPath();
            grPath.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            this.Region = new System.Drawing.Region(grPath);
            base.OnPaint(pevent);
        }
    }
}
