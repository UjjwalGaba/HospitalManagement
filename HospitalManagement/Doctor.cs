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
    public partial class Doctor : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ujjwa\OneDrive\Documents\db_CityHospital.mdf;Integrated Security=True;Connect Timeout=30");
        public Doctor()
        {
            InitializeComponent();
        }

        void populate()
        {
            con.Open();
            string query = "SELECT * FROM tbl_Doctor";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            gv_Doctor.DataSource = ds.Tables[0];
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
            if (txt_DoctorId.Text == "" || txt_DoctorName.Text == "" || txt_Password.Text == "" || txt_Experience.Text == "")
                MessageBox.Show("No Empty Fill Accepted.");
            else
            {
                con.Open();
                string query = "INSERT INTO tbl_Doctor VALUES (" + txt_DoctorId.Text + ",'" + txt_DoctorName.Text + "'," + txt_Experience.Text + ",'" + txt_Password.Text + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Doctor Successfully Added");
                con.Close();
                populate();
            }
        }

        

        private void Doctor_Load_1(object sender, EventArgs e)
        {
            populate();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (txt_DoctorId.Text == "")
                MessageBox.Show("Enter the Doctor Id");
            else
            {
                con.Open();
                string query = "DELETE FROM tbl_Doctor WHERE DoctorId = " + txt_DoctorId.Text + "";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Doctor Successfully Deleted.");
                con.Close();
                populate();
            }
        }

        private void gv_Doctor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_DoctorId.Text = gv_Doctor.SelectedRows[0].Cells[0].Value.ToString();
            txt_DoctorName.Text = gv_Doctor.SelectedRows[0].Cells[1].Value.ToString();
            txt_Experience.Text = gv_Doctor.SelectedRows[0].Cells[2].Value.ToString();
            txt_Password.Text = gv_Doctor.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "UPDATE tbl_Doctor SET DoctorName = '"+txt_DoctorName.Text+"', Experience = '"+txt_Experience.Text+"', DoctorPassword = '"+txt_Password.Text+"' WHERE DoctorId = "+txt_DoctorId.Text+"";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Doctor successfully Updated.");
            con.Close();
            populate();
        }
    }
}
