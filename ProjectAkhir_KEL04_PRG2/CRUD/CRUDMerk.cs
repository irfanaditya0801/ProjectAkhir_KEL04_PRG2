﻿using System;
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
    public partial class CRUDMerk : Form
    {
        public CRUDMerk()
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
            result = first + firstid.ToString().PadLeft(2, '0');
            return result;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (txtNama.Text == "")
            {
                MessageBox.Show("Lengkapi Data Merk!!", "Peringatan!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                SqlConnection con = new SqlConnection(@"Data Source =LAPTOP-5F5TNO0N\SQLEXPRESS; Initial Catalog =TokoKamera;Integrated Security = True;");

                SqlCommand add = new SqlCommand("sp_addmerkkamera", con);
                add.CommandType = CommandType.StoredProcedure;

                string syntax = "SELECT TOP  1 Id_Merk from tblMerkKamera ORDER BY Id_Merk desc";
                string id = AutoID("MRK", syntax);



                add.Parameters.AddWithValue("id_merk", id);
                add.Parameters.AddWithValue("nama_merk", txtNama.Text);


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

        private void cbSearch_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSearch.Checked)
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

        private void btnUbah_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source =LAPTOP-5F5TNO0N\SQLEXPRESS; Initial Catalog =TokoKamera;Integrated Security = True;");

                SqlCommand add = new SqlCommand("sp_updatemerkkamera", con);
                add.CommandType = CommandType.StoredProcedure;

                add.Parameters.AddWithValue("Id_Merk", txtID.Text);
                add.Parameters.AddWithValue("nama_merk", txtNama.Text);

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
            DialogResult valid = MessageBox.Show("ingin menghapus Merk ?", "Informasi", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (valid == DialogResult.OK)
            {
                SqlConnection con = new SqlConnection(@"Data Source =LAPTOP-5F5TNO0N\SQLEXPRESS; Initial Catalog =TokoKamera;Integrated Security = True;");

                try
                {
                    con.Open();
                    SqlCommand del = new SqlCommand("sp_deletemerkkamera", con);
                    del.CommandType = CommandType.StoredProcedure;

                    del.Parameters.AddWithValue("Id_Merk", txtID.Text);

                    del.ExecuteNonQuery();
                    MessageBox.Show("Data berhasil dihapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Data gagal di hapus : " + ex.Message);
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection con = new SqlConnection(@"Data Source =LAPTOP-5F5TNO0N\SQLEXPRESS; Initial Catalog =TokoKamera;Integrated Security = True;");
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("SELECT * FROM tblMerkKamera Where Id_Merk = '" + txtID.Text + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                txtNama.Text = dt.Rows[0]["nama_merk"].ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
