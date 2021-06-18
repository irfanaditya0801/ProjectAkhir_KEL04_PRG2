using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectAkhir_KEL04_PRG2.CRUD
{
    public partial class CRUDJenisKamera : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source =LAPTOP-5F5TNO0N\SQLEXPRESS; Initial Catalog =TokoKamera;Integrated Security = True;");
        private SqlCommand sqlCmd;

        public string AutoID(string first, string syntax)
        {
            string result = "";
            int firstid = 0;
            try
            {

                con.Open();
                sqlCmd = new SqlCommand(syntax, con);
                SqlDataReader reader = sqlCmd.ExecuteReader();
                if (reader.Read())
                {
                    string last = reader[0].ToString();
                    firstid = Convert.ToInt32(last.Remove(0, first.Length)) + 1;
                }
                else
                {
                    firstid = 1;
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ID otomatis Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            result = first + firstid.ToString().PadLeft(2, '0');
            return result;
        }
        public CRUDJenisKamera()
        {
            InitializeComponent();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (txtNama.Text == "")
            {
                MessageBox.Show("Lengkapi Data Jenis!!", "Peringatan!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                SqlConnection con = new SqlConnection(@"Data Source =LAPTOP-5F5TNO0N\SQLEXPRESS; Initial Catalog =TokoKamera;Integrated Security = True;");

                SqlCommand add = new SqlCommand("sp_addjeniskamera", con);
                add.CommandType = CommandType.StoredProcedure;

                string syntax = "SELECT TOP  1 id_Jenis from tblJenisKamera ORDER BY id_Jenis desc";
                string id = AutoID("JNS", syntax);



                add.Parameters.AddWithValue("id_Jenis", id);
                add.Parameters.AddWithValue("nama_jenis", txtNama.Text);
               

                try
                {
                    con.Open();
                    add.ExecuteNonQuery();
                    MessageBox.Show("Berhasil menyimpan Data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Data gagal disimpan " + ex.Message);
                }
            }
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbSearch_CheckedChanged(object sender, EventArgs e)
        {
            if(cbSearch.Checked)
            {
                LabelID.Visible = true;
                txtID.Visible = true;
                btnSearch.Visible = true;
                btnHapus.Visible = true;
                btnUbah.Visible = true;
                btnSimpan.Visible = false;
            }
            else
            {
                LabelID.Visible = false;
                txtID.Visible = false;
                btnSearch.Visible = false;
                btnHapus.Visible = false;
                btnUbah.Visible = false;
                btnSimpan.Visible = true;
            }
        }
    }
}
