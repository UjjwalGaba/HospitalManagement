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
    public partial class Diagnosis : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ujjwa\OneDrive\Documents\db_CityHospital.mdf;Integrated Security=True;Connect Timeout=30");

        public Diagnosis()
        {
            InitializeComponent();
        }

        void populateCombo()
        {
            string sql = "SELECT * FROM tbl_Patient";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader read;
            try
            {
                con.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("PatientId", typeof(int));
                read = cmd.ExecuteReader();
                dt.Load(read);
                combo_PatientId.ValueMember = "PatientId";
                combo_PatientId.DataSource = dt;
                con.Close();
            }
            catch
            {

            }
        }
        String PatientName;
        void fetchPatientName()
        {
            con.Open();
            string myname = "SELECT * FROM tbl_Patient WHERE PatientId " + combo_PatientId.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(myname, con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                PatientName = dr["PatientName"].ToString();
                txt_PatientName.Text = PatientName;
            }
            con.Close();
        }

        void populate()
        {
            con.Open();
            string query = "SELECT * FROM tbl_Diagnosis";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            gv_Diagnosis.DataSource = ds.Tables[0];
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
            if (txt_Diagnosis.Text == "" || txt_Medicines.Text == "" || txt_Diagnosis.Text == "" || txt_PatientName.Text == "")
                MessageBox.Show("No Empty Fill Accepted.");
            else
            {
                con.Open();
                string query = "INSERT INTO tbl_Diagnosis VALUES (" + txt_DiagnosisId.Text + "," + combo_PatientId.SelectedItem.ToString() + ",'" + txt_PatientName.Text + "','" + txt_Symptoms.Text + "', '"+txt_Diagnosis.Text+"','"+txt_Medicines.Text+"')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Diagnosis Successfully Added");
                con.Close();
                populate();
            }
        }

        private void Diagnosis_Load(object sender, EventArgs e)
        {
            populateCombo();
            populate();
        }

        private void combo_PatientId_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fetchPatientName();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (txt_DiagnosisId.Text == "")
                MessageBox.Show("Enter the Diagnosis Id");
            else
            {
                con.Open();
                string query = "DELETE FROM tbl_Diagnosis WHERE DiagnosisId = " + txt_DiagnosisId.Text + "";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Diagnosis Successfully Deleted.");
                con.Close();
                populate();
            }
        }

        private void gv_Diagnosis_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_DiagnosisId.Text = gv_Diagnosis.SelectedRows[0].Cells[0].Value.ToString();
           
            combo_PatientId.SelectedValue = gv_Diagnosis.SelectedRows[0].Cells[2].Value.ToString();
            txt_PatientName.Text = gv_Diagnosis.SelectedRows[0].Cells[1].Value.ToString();
            txt_Symptoms.Text = gv_Diagnosis.SelectedRows[0].Cells[3].Value.ToString();
            txt_Diagnosis.Text = gv_Diagnosis.SelectedRows[0].Cells[4].Value.ToString();
            txt_Medicines.Text = gv_Diagnosis.SelectedRows[0].Cells[7].Value.ToString();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "UPDATE tbl_Diagnosis SET PatientId = '" + combo_PatientId.SelectedItem.ToString() + "', PatientName = '" + txt_PatientName.Text + "', Symptoms = '" + txt_Symptoms.Text + "', Diagnosis = '"+txt_Diagnosis.Text +"' , Medicines = '"+txt_Medicines.Text+"'WHERE DiagnosisId = " + txt_DiagnosisId.Text + "";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Diagnosis successfully Updated.");
            con.Close();
            populate();
        }
    }
}
