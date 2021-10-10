using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HospitalManagement
{
    public partial class Patient : Form
    {

        

        public Patient()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ujjwa\OneDrive\Documents\db_CityHospital.mdf;Integrated Security=True;Connect Timeout=30");

        void populate()
        {
            con.Open();
            string query = "SELECT * FROM tbl_Patient";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            gv_Patient.DataSource = ds.Tables[0];
            con.Close();
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (txt_PatientId.Text == "" || txt_PatientName.Text == "" || txt_PatientAddress.Text == "" || txt_PatientAge.Text == "" || txt_PatientPhone.Text == "" || txt_Disease.Text == "" )
                MessageBox.Show("No Empty Fill Accepted.");
            else
            {
                con.Open();
                string query = "INSERT INTO tbl_Patient VALUES (" + txt_PatientId.Text + ",'" + txt_PatientName.Text + "'," + txt_PatientAddress.Text + ",'" + txt_PatientPhone.Text + "'," + txt_PatientAge.Text + ",'" + combo_Gender.SelectedItem.ToString() + "','" + combo_BloodGroup.SelectedItem.ToString() + "','" + txt_Disease.Text + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Patient Successfully Added");
                con.Close();
                populate();
            }
        }

        private void Patient_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (txt_PatientId.Text == "")
                MessageBox.Show("Enter the Patient Id");
            else
            {
                con.Open();
                string query = "DELETE FROM tbl_Patient WHERE PatientId = " + txt_PatientId.Text + "";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Patient Successfully Deleted.");
                con.Close();
                populate();
            }
        }

        private void gv_Patient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_PatientId.Text = gv_Patient.SelectedRows[0].Cells[0].Value.ToString();
            txt_PatientName.Text = gv_Patient.SelectedRows[0].Cells[1].Value.ToString();
            txt_PatientAddress.Text = gv_Patient.SelectedRows[0].Cells[2].Value.ToString();
            txt_PatientPhone.Text = gv_Patient.SelectedRows[0].Cells[3].Value.ToString();
            txt_PatientAge.Text = gv_Patient.SelectedRows[0].Cells[4].Value.ToString();
            txt_Disease.Text = gv_Patient.SelectedRows[0].Cells[7].Value.ToString();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "UPDATE tbl_Patient SET PatientName = '" + txt_PatientName.Text + "', PatientAddresss = '" + txt_PatientAddress.Text + "', PatientPhone = '" + txt_PatientPhone.Text + "' PatientAge = "+txt_PatientAge.Text+", PatientGender = '"+combo_Gender.SelectedItem.ToString()+"', PatientBloodGroup = '"+combo_BloodGroup.SelectedItem.ToString()+"' WHERE PatientId = " + txt_PatientId.Text + "";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Patient successfully Updated.");
            con.Close();
            populate();
        }
    }
}
