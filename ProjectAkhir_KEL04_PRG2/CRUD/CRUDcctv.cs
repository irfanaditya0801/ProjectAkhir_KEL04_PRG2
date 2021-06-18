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
    public partial class CRUDcctv : Form
    {
        public CRUDcctv()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source =LAPTOP-5F5TNO0N\SQLEXPRESS; Initial Catalog =TokoKamera;Integrated Security = True;");
        private SqlCommand sqlCmd;
        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox5_TextChanged(object sender, EventArgs e)
        {

        }
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

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (txtNama.Text == "" || txtHarga.Text == "" ||  txtJumlah.Text == "")
            {
                MessageBox.Show("Lengkapi Data CCTV!!", "Peringatan!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                SqlConnection con = new SqlConnection(@"Data Source =LAPTOP-5F5TNO0N\SQLEXPRESS; Initial Catalog =TokoKamera;Integrated Security = True;");

                SqlCommand add = new SqlCommand("sp_addcctv", con);
                add.CommandType = CommandType.StoredProcedure;

                string syntax = "SELECT TOP  1 id_cctv from tblCCTV ORDER BY id_cctv desc";
                string id = AutoID("cctv", syntax);



                add.Parameters.AddWithValue("id_cctv", id);
                add.Parameters.AddWithValue("nama_cctv", txtNama.Text);
                add.Parameters.AddWithValue("harga", txtHarga.Text);
                add.Parameters.AddWithValue("jumlah", txtJumlah.Text);
                

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

        private void checkID_CheckedChanged(object sender, EventArgs e)
        {
            if (checkID.Checked)
            {
                labelID.Visible = true;
                txtID.Visible = true;
                btnSearch.Visible = true;
                btnUbah.Visible = true;
                btnHapus.Visible = true;
                btnSimpan.Visible = false;
            }
            else
            {
                labelID.Visible = false;
                txtID.Visible = false;
                btnSearch.Visible = false;
                btnUbah.Visible = false;
                btnHapus.Visible = false;
                btnSimpan.Visible = true;
            }
        
        }
    }
}
