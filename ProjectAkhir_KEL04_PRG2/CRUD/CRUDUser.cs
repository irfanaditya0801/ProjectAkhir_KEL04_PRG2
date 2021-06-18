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
    public partial class CRUDUser : Form
    {
       
        public CRUDUser()
        {
            InitializeComponent();
        }
        SqlCommand sqlCmd;
       
        SqlConnection con = new SqlConnection(@"Data Source =LAPTOP-5F5TNO0N\SQLEXPRESS; Initial Catalog =TokoKamera;Integrated Security = True;");
        private void UpdateDB(string cmd)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source =LAPTOP-5F5TNO0N\SQLEXPRESS; Initial Catalog =TokoKamera;Integrated Security = True;");

                con.Open();
                SqlCommand myCommand = new SqlCommand();
                myCommand.Connection = con;
                myCommand.CommandText = cmd;
                myCommand.ExecuteNonQuery();
                MessageBox.Show("Data berhasil diinput", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Clear()
        {
            txtNama.Text = "";
            cbJenisKel.Text = "";
            txtAlamat.Text = "";
            cbJabatan.Text = "";
            txtusername.Text = "";
            txtpass.Text = "";
       
        }
        //id Otomatis
        public string AutoID (string first, string syntax)
        {
            string result = "";
            int firstid = 0;
            try
            {
               
                con.Open();
                sqlCmd = new SqlCommand(syntax, con);
                SqlDataReader reader = sqlCmd.ExecuteReader();
                if(reader.Read())
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "ID otomatis Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            result = first + firstid.ToString().PadLeft(2, '0');
            return result;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (txtNama.Text == "" || cbJenisKel.SelectedItem == "" || txtAlamat.Text == "" || txtusername.Text == "" || txtpass.Text == "")
            {
                MessageBox.Show("Lengkapi Data User!!", "Peringatan!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                SqlConnection con = new SqlConnection(@"Data Source =LAPTOP-5F5TNO0N\SQLEXPRESS; Initial Catalog =TokoKamera;Integrated Security = True;");

                SqlCommand add = new SqlCommand("sp_adduser", con);
                add.CommandType = CommandType.StoredProcedure;

                string syntax = "SELECT TOP  1 id_user from tblUser ORDER BY id_user desc";
                string id = AutoID("USR", syntax);


                string myCmd = "INSERT INTO tblUser VALUES ('"
                    + id + "','"
                    + txtNama.Text + "','"
                    + cbJenisKel.SelectedItem + "','"
                    + txtAlamat.Text + "','"
                    + cbJabatan.SelectedItem + "','"
                    + txtusername.Text + "','"
                    + txtpass.Text + "')";

                UpdateDB(myCmd);
                Clear();
            }
        }

        private void cbJabatan_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void CRUDUser_Load(object sender, EventArgs e)
        {

        }

        private void checkPass_CheckedChanged(object sender, EventArgs e)
        {
            if(checkPass.Checked)
            {
                txtpass.PasswordChar = '\0';
            }
            else
            {
                txtpass.PasswordChar = '*';
            }
        }

        private void CheckID_CheckedChanged(object sender, EventArgs e)
        {
            if(CheckID.Checked)
            {
                LabelID.Visible = true;
                txtID.Visible = true;
                btnSearch.Visible = true;
                btnUbah.Visible = true;
                btnHapus.Visible = true;
                btnSimpan.Visible = false;
            }
            else
            {
                LabelID.Visible = false;
                txtID.Visible = false;
                btnSearch.Visible = false;
                btnUbah.Visible = false;
                btnHapus.Visible = false;
                btnSimpan.Visible = true;
            }
        }

        private void txtNama_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                //MessageBox.Show("Nama Harus diisi dengan huruf", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection con = new SqlConnection(@"Data Source =LAPTOP-5F5TNO0N\SQLEXPRESS; Initial Catalog =TokoKamera;Integrated Security = True;");
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("SELECT * FROM tblUser Where id_user = '" + txtID.Text + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                txtNama.Text = dt.Rows[0]["nama_user"].ToString();
                cbJenisKel.Text = dt.Rows[0]["jeniskelamin"].ToString();
                txtAlamat.Text = dt.Rows[0]["alamat"].ToString();
                cbJabatan.Text = dt.Rows[0]["jabatan"].ToString();
                txtusername.Text = dt.Rows[0]["username"].ToString();
                txtpass.Text = dt.Rows[0]["pass"].ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source =LAPTOP-5F5TNO0N\SQLEXPRESS; Initial Catalog =TokoKamera;Integrated Security = True;");

                SqlCommand add = new SqlCommand("sp_updateuser", con);
                add.CommandType = CommandType.StoredProcedure;
               // add.Parameters.AddWithValue("id_user", txtID.Text);
                add.Parameters.AddWithValue("nama_user", txtNama.Text);
                add.Parameters.AddWithValue("jeniskelamin", cbJenisKel.SelectedValue);
                add.Parameters.AddWithValue("alamat", txtAlamat.Text);
                add.Parameters.AddWithValue("jabatan", cbJabatan.Text);
                add.Parameters.AddWithValue("username", txtusername.Text);
                add.Parameters.AddWithValue("pass", txtpass.Text);
                con.Open();
                int result = Convert.ToInt32(add.ExecuteNonQuery());
                con.Close();
                if(result !=0)
                {
                    MessageBox.Show("Update data berhasil");
                    Clear();
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
    }
}
