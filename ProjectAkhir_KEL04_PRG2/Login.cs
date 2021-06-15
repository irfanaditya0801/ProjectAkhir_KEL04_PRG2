using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectAkhir_KEL04_PRG2
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            if (guna2TextBox1.Text=="admin" && guna2TextBox2.Text=="admin")
            {
                MessageBox.Show("Login Successful!");
            }
            else
            {
                MessageBox.Show("Login Failed Try again.");
            }
        }
    }
}
