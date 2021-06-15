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

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (txUser.Text == "admin" && txtPass.Text == "admin")
            {
                MessageBox.Show("Login Successfull!");
            }else
            {
                MessageBox.Show("Login Failed,try again");
            }
        }
    }
}
