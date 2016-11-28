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
    public partial class Form1 : Form
    {
        Form1 ptrl;
        public Form1()
        {
            InitializeComponent();
            ptrl = this;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            (sender as Button).Text = "Clicked";
            (sender as Button).BackColor = Color.Aqua;
            Form2 f = new Form2(ptrl);
            f.Visible = true;
            ptrl.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Button btn = new Button();
            //btn.Size = new Size(100, 20);
            //btn.Location = new Point(10, 10);
            //btn.Text = "HEllo";
            //this.Controls.Add(btn);
            //btn.Parent = this;
            //btn.Enabled = false;
            //btn.Visible = true;
            //loginTb.Multiline = true;
        }

        private void loginTb_TextChanged(object sender, EventArgs e)
        {
            loginPb.Value = loginTb.Text.Length;
            //loginPb.BackColor = Color.Black;
            loginPb.ForeColor = Color.Black;
            loginPb.Style = ProgressBarStyle.Blocks;

        }

        private void passwordTb_TextChanged(object sender, EventArgs e)
        {
            passwordPb.Value = passwordTb.Text.Length;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Close");
        }
        
    }
}
