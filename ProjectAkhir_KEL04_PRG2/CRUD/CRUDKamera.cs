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
    public partial class CRUDKamera : Form
    {
        public CRUDKamera()
        {
            InitializeComponent();
        }
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
            result = first + firstid.ToString().PadLeft(3, '0');
            return result;

        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (txtNama.Text == "" || txtHarga.Text == "" || cbMerk.Text == "" || cbJenis.Text == "" || txtJumlah.Text == "")
            {
                MessageBox.Show("Lengkapi Data Kamera!!", "Peringatan!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                SqlConnection con = new SqlConnection(@"Data Source =LAPTOP-5F5TNO0N\SQLEXPRESS; Initial Catalog =TokoKamera;Integrated Security = True;");

                SqlCommand add = new SqlCommand("sp_addkamera", con);
                add.CommandType = CommandType.StoredProcedure;

                string syntax = "SELECT TOP  1 id_kamera from tblKamera ORDER BY id_kamera desc";
                string id = AutoID("KMR", syntax);



                add.Parameters.AddWithValue("id_kamera", id);
                add.Parameters.AddWithValue("nama_kamera", txtNama.Text);
                add.Parameters.AddWithValue("id_merk", cbMerk.SelectedValue);
                add.Parameters.AddWithValue("id_Jenis", cbJenis.SelectedValue);
                add.Parameters.AddWithValue("jumlah", txtJumlah.Text);
                add.Parameters.AddWithValue("harga", txtHarga.Text);

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

        private void CRUDKamera_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tokoKameraDataSet.tblMerkKamera' table. You can move, or remove it, as needed.
            this.tblMerkKameraTableAdapter.Fill(this.tokoKameraDataSet.tblMerkKamera);
            // TODO: This line of code loads data into the 'tokoKameraDataSet.tblJenisKamera' table. You can move, or remove it, as needed.
            this.tblJenisKameraTableAdapter.Fill(this.tokoKameraDataSet.tblJenisKamera);
          




        }

        private void cbSearch_CheckedChanged(object sender, EventArgs e)
        {
            if(cbSearch.Checked)
            {
                Label.Visible = true;
                txtID.Visible = true;
                btnSearch.Visible = true;
                btnUbah.Visible = true;
                btnHapus.Visible = true;
                btnSimpan.Visible = false;
            }
            else
            {
                Label.Visible = false;
                txtID.Visible = false;
                btnSearch.Visible = false;
                btnUbah.Visible = false;
                btnHapus.Visible = false;
                btnSimpan.Visible = true;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection con = new SqlConnection(@"Data Source =LAPTOP-5F5TNO0N\SQLEXPRESS; Initial Catalog =TokoKamera;Integrated Security = True;");
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("SELECT * FROM tblKamera Where id_kamera = '" + txtID.Text + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                txtNama.Text = dt.Rows[0]["nama_kamera"].ToString();
                cbMerk.SelectedValue = dt.Rows[0]["Id_Merk"].ToString();
                cbJenis.SelectedValue = dt.Rows[0]["id_Jenis"].ToString();
                txtJumlah.Text = dt.Rows[0]["jumlah"].ToString();
                txtHarga.Text = dt.Rows[0]["harga"].ToString();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source =LAPTOP-5F5TNO0N\SQLEXPRESS; Initial Catalog =TokoKamera;Integrated Security = True;");

                SqlCommand add = new SqlCommand("sp_updatekamera", con);
                add.CommandType = CommandType.StoredProcedure;

                add.Parameters.AddWithValue("id_kamera", txtID.Text);
                add.Parameters.AddWithValue("nama_kamera", txtNama.Text);
                add.Parameters.AddWithValue("Id_Merk", cbMerk.SelectedValue);
                add.Parameters.AddWithValue("id_Jenis",cbJenis.SelectedValue);
                add.Parameters.AddWithValue("jumlah", txtJumlah.Text);
                add.Parameters.AddWithValue("harga", txtHarga.Text);
              
                con.Open();
                int result = Convert.ToInt32(add.ExecuteNonQuery());
                con.Close();
                if (result != 0)
                {
                    MessageBox.Show("Update data berhasil");
                   
                }
                else
                {
                    MessageBox.Show("Update data gagal!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            DialogResult valid = MessageBox.Show("ingin menghapus kamera ?", "Informasi", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (valid == DialogResult.OK)
            {
                SqlConnection con = new SqlConnection(@"Data Source =LAPTOP-5F5TNO0N\SQLEXPRESS; Initial Catalog =TokoKamera;Integrated Security = True;");

                try
                {
                    con.Open();
                    SqlCommand del = new SqlCommand("sp_deletekamera", con);
                    del.CommandType = CommandType.StoredProcedure;

                    del.Parameters.AddWithValue("id_kamera", txtID.Text);

                    del.ExecuteNonQuery();
                    MessageBox.Show("Data berhasil dihapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Data gagal di hapus : " + ex.Message);
                }
            }
        }

        private void dgAcc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbJenis_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHarga_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                //MessageBox.Show("Nama Harus diisi dengan huruf", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtJumlah_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                //MessageBox.Show("Nama Harus diisi dengan huruf", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
