using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectAkhir_KEL04_PRG2.CRUD;

namespace ProjectAkhir_KEL04_PRG2.Page
{
    public partial class UCMaster : UserControl
    {
        public UCMaster()
        {
            InitializeComponent();
        }

        private void btnKamera_Click(object sender, EventArgs e)
        {
            CRUDKamera k = new CRUDKamera();
            k.Show();
        }

        private void btnCCTV_Click(object sender, EventArgs e)
        {
            CRUDcctv c = new CRUDcctv();
            c.Show();
        }

        private void btnAcc_Click(object sender, EventArgs e)
        {
            CRUDAccKamera a = new CRUDAccKamera();
            a.Show();
        }

        private void btnJenis_Click(object sender, EventArgs e)
        {
            CRUDJenisKamera j = new CRUDJenisKamera();
            j.Show();
        }

        private void btnKategori_Click(object sender, EventArgs e)
        {
            CRUDKategoriAcc i = new CRUDKategoriAcc();
            i.Show();
        }

        private void btnMerk_Click(object sender, EventArgs e)
        {
            CRUDMerk m = new CRUDMerk();
            m.Show();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            CRUDUser u = new CRUDUser();
            u.Show();
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            CRUDSupplier s = new CRUDSupplier();
            s.Show();
        }
    }
}
