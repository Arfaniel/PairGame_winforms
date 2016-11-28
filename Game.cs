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
    public partial class Game : Form
    {
        Random r = new Random();
        public Game()
        {
            InitializeComponent();
            
            grid.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            grid.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            PictureBox pb;
            for (int i = 0; i < grid.RowCount; i++)
            {
                for (int j = 0; j < grid.ColumnCount+2; j++)
                {
                    pb = new PictureBox();
                    pb.Dock = DockStyle.Fill;
                    pb.BackColor = Color.FromArgb(r.Next(0, 256), r.Next(0, 255), r.Next(0, 255));
                    pb.Click += Pb_Click;
                    pb.Name = (i + j).ToString();
                    pb.Margin = new Padding(0);
             
                    pb.SizeMode = PictureBoxSizeMode.StretchImage;
                    pb.Click += Pb_Click1;
                    grid.Controls.Add(pb, j, i);
                }
            }
        }

        private void Pb_Click1(object sender, EventArgs e)
        {
            switch (r.Next(0, 2))
            {
                case 0:
                    (sender as PictureBox).Image = Image.FromFile("f.png");
                    break;
                case 1:
                    (sender as PictureBox).Image = Image.FromFile("m.png");
                    break;
                default:
                    break;
            }
        }

        private void Pb_Click(object sender, EventArgs e)
        {
            MessageBox.Show((sender as PictureBox).Name);
        }
    }
}
