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
            if (txtNama.Text == "" || txtJenisKel.Text == "" || txtAlamat.Text == "" || txtusername.Text == "" || txtpass.Text == "")
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

                dtTTL.CustomFormat = "yyyy-dd-MM";

                add.Parameters.AddWithValue("id_user", id);
                add.Parameters.AddWithValue("nama_user", txtNama.Text);
                add.Parameters.AddWithValue("jeniskelamin", txtJenisKel.Text);
                add.Parameters.AddWithValue("ttl", dtTTL.Text);
                add.Parameters.AddWithValue("jabatan", cbJabatan.Text);
                add.Parameters.AddWithValue("username", txtusername.Text);
                add.Parameters.AddWithValue("pass", txtpass.Text);

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
    }
}
