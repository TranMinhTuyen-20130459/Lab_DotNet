using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddButton_Click(object sender, EventArgs e)
        {
            pnButton.Controls.Clear();
            for (int i = 1; i <= Int32.Parse(txtNumberControl.Text); i++)
            {
                Button btnRuntime = new Button();
                btnRuntime.BackColor = Color.Red;
                btnRuntime.Location = new System.Drawing.Point(pnButton.Width / 2 - btnRuntime.Width / 2,
                     i * btnRuntime.Height);
                btnRuntime.Text = "button" + i;
                btnRuntime.Tag = i;
                btnRuntime.Click += btnRuntime_click;
                pnButton.Controls.Add(btnRuntime);
            }
        }
        private void btnRuntime_click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            lblMessage.Text = "Button : " + btn.Text + " was clicked";
        }

    }
}
