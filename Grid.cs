using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Grid : Form
    {
        Random r = new Random();
        public Grid()
        {
            InitializeComponent();
        }

        private void Grid_Load(object sender, EventArgs e)
        {
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.None;
            tableLayoutPanel1.Padding = new Padding(0);
            tableLayoutPanel1.Margin = new Padding(0);
            PictureBox pb;
            
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    pb =  new PictureBox();
                    pb.Size = new Size(10, 10);
                    pb.Dock = DockStyle.Fill;
                    pb.BackColor = Color.FromArgb(r.Next(0, 255), r.Next(0,255), r.Next(0,255));
                    pb.Margin = new Padding(0);
                    pb.Padding = new Padding(0);
                    tableLayoutPanel1.Controls.Add(pb, i, j);
                }
            }
        }
    }
}
