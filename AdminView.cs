using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI.WinForms;

namespace Hospital_Management
{
    public partial class AdminView: Form
    {
        public static string type = "";
        public AdminView()
        {
            InitializeComponent();
        }

        private void AdminView_Load(object sender, EventArgs e)
        {
            patientButton.PerformClick();
            // string name = DataAccess.LoadData("select Name from Receptionist, Login where Receptionist.UserID=Login.ID and Login.ID = " + LoginView.curID + ";").Rows[0][0].ToString();
            // gunaLabel3.Text = "Welcome " + name;
        }
        private void patientButton_Click(object sender, EventArgs e)
        {
            DataTable dt = DataAccess.LoadData("select * from Patient");
            DataGridView1.DataSource = dt;
            DataGridView1.Refresh();
            type = "Patient";
        }
        private void cabinButton_Click(object sender, EventArgs e)
        {
            DataTable dt = DataAccess.LoadData("select * from Cabin");
            DataGridView1.DataSource = dt;
            DataGridView1.Refresh();
            type = "Cabin";
        }

        private void scheduleButton_Click(object sender, EventArgs e)
        {
            DataGridView1.Columns[1].HeaderText = "P Name";
            DataTable dt = DataAccess.LoadData("select Schedule.ID, Patient.Name, Doctor.Name, Schedule.Date, Schedule.S_Time, Schedule.E_Time from Schedule, Patient, Doctor where Patient.ID = Schedule.PatientID and Doctor.ID = Schedule.DoctorID");
            DataGridView1.DataSource = dt;
            DataGridView1.Columns[2].HeaderText = "D Name";
            DataGridView1.Refresh();
            type = "Schedule";
            
        }

        private void doctorButton_Click(object sender, EventArgs e)
        {
            DataTable dt = DataAccess.LoadData("select * from Doctor");
            DataGridView1.DataSource = dt;
            DataGridView1.Refresh();
            type = "Doctor";
            
        }
        private void searchButton_Click(object sender, EventArgs e)
        {
            if (patientButton.Checked)
            {
                DataTable dt = DataAccess.LoadData("select * from Patient where Name like '%" + searchBox1.Text + "%'");
                DataGridView1.DataSource = dt;
                DataGridView1.Refresh();
            }
            else if (doctorButton.Checked)
            {
                DataTable dt = DataAccess.LoadData("select * from Doctor where Name like '%" + searchBox1.Text + "%'");
                DataGridView1.DataSource = dt;
                DataGridView1.Refresh();
            }
            else if (scheduleButton.Checked)
            {
                DataTable dt = DataAccess.LoadData("select * from Schedule where ID like '%" + searchBox1.Text + "%'");
                DataGridView1.DataSource = dt;
                DataGridView1.Refresh();
            }
            else if (cabinButton.Checked)
            {
                DataTable dt = DataAccess.LoadData("select * from Cabin where Name like '%" + searchBox1.Text + "%'");
                DataGridView1.DataSource = dt;
                DataGridView1.Refresh();
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (patientButton.Checked)
            {
                AddPatient.curID = "";
                AddPatient.curName = "";
                AddPatient.curGender = "";
                AddPatient.curDOB = "";
                AddPatient.curPhone = "";
                AddPatient.curAddress = "";
                AddPatient.curDocID = "";
                AddPatient.curDocName = "";
                AddPatient ap = new AddPatient();
                ap.Show();
            }
            else if (cabinButton.Checked)
            {
                AddCabin.curID = "";
                AddCabin.curCategory = "";
                AddCabin.curStatus = "";
                AddCabin.curPatID = "";
                AddCabin.curPatName = "";
                AddCabin ac = new AddCabin();
                ac.Show();
            }
            else if (scheduleButton.Checked)
            {
                AddSchedule.sTime = "";
                AddSchedule.eTime = "";
                AddSchedule.curPatID = "";
                AddSchedule.curPatName = "";
                AddSchedule.curDocID = "";
                AddSchedule.curDocName = "";
                AddSchedule.curID = "";
                AddSchedule.curDate = "";
                AddSchedule asc = new AddSchedule();
                asc.Show();
            }
            else if (doctorButton.Checked)
            {
                AddDoctor.curID = "";
                AddDoctor.curName = "";
                AddDoctor.curGender = "";
                AddDoctor.curDOB = "";
                AddDoctor.curAddress = "";
                AddDoctor.curUserID = "";
                AddDoctor.curDept = "";
                AddDoctor.curPhone = "";
                AddDoctor ad = new AddDoctor();
                ad.Show();
            }

        }

        private void AdminView_Enter(object sender, EventArgs e)
        {
            if (patientButton.Checked)
            {
                patientButton.PerformClick();
            }
            else if (scheduleButton.Checked)
            {
                scheduleButton.PerformClick();
            }
            else if (cabinButton.Checked)
            {
                cabinButton.PerformClick();
            }
            else if (doctorButton.Checked)
            {
                doctorButton.PerformClick();
            }

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            int count = 0;
            if (DataGridView1.SelectedRows.Count != 1)
            {
                MessageBox.Show("Invalid Row Selected");
            }
            else
            {
                try
                {
                    string value = DataGridView1.SelectedRows[0].Cells["ID"].Value.ToString();
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete?", "Delete Confirmation", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        count = DataAccess.ExecuteQuery("DELETE FROM " + type + " WHERE ID = '" + value + "';");
                    }
                    else if (dialogResult == DialogResult.No)
                    {

                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.ToString());
                }
            }
            if (patientButton.Checked)
            {
                patientButton.PerformClick();
            }
            else if (cabinButton.Checked)
            {
                cabinButton.PerformClick();
            }
            else if (scheduleButton.Checked)
            {
                scheduleButton.PerformClick();
            }
            else if (doctorButton.Checked)
            {
                doctorButton.PerformClick();
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (DataGridView1.SelectedRows.Count != 1)
            {
                MessageBox.Show("Invalid Row Selected");
            }
            else
            {
                if (patientButton.Checked)
                {
                    AddPatient ap = new AddPatient();
                    ap.Show();
                }
                else if (cabinButton.Checked)
                {
                    AddCabin ac = new AddCabin();
                    ac.Show();
                }
                else if (scheduleButton.Checked)
                {
                    AddSchedule asc = new AddSchedule();
                    asc.Show();
                }
                else if (doctorButton.Checked)
                {
                    AddDoctor ad = new AddDoctor();
                    ad.Show();
                }
            }

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (patientButton.Checked)
            {
                AddPatient.curID = DataGridView1.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                AddPatient.curName = DataGridView1.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                AddPatient.curGender = DataGridView1.Rows[e.RowIndex].Cells["Gender"].Value.ToString();
                AddPatient.curDOB = DataGridView1.Rows[e.RowIndex].Cells["DoB"].Value.ToString();
                AddPatient.curPhone = DataGridView1.Rows[e.RowIndex].Cells["Phone"].Value.ToString();
                AddPatient.curAddress = DataGridView1.Rows[e.RowIndex].Cells["Address"].Value.ToString();
                AddPatient.curDocID = DataGridView1.Rows[e.RowIndex].Cells["DoctorID"].Value.ToString();
                AddPatient.curDocName = DataAccess.LoadData("select Doctor.Name from Doctor, Patient where Patient.DoctorID = Doctor.ID and Doctor.ID = " + AddPatient.curDocID + ";").Rows[0][0].ToString();
            }
            else if (cabinButton.Checked)
            {
                AddCabin.curID = DataGridView1.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                AddCabin.curCategory = DataGridView1.Rows[e.RowIndex].Cells["Category"].Value.ToString();
                AddCabin.curStatus = DataGridView1.Rows[e.RowIndex].Cells["Status"].Value.ToString();
                //AddCabin.curPatID = DataGridView1.Rows[e.RowIndex].Cells["PatientID"].Value.ToString();
                if (AddCabin.curStatus == "Empty")
                {
                    AddCabin.curPatID = "";
                    AddCabin.curPatName = "";
                }
                else
                {
                    AddCabin.curPatID = DataGridView1.Rows[e.RowIndex].Cells["PatientID"].Value.ToString();
                    AddCabin.curPatName = DataAccess.LoadData("select Patient.Name from Patient, Cabin where Cabin.PatientID = Patient.ID and Patient.ID = " + AddCabin.curPatID + ";").Rows[0][0].ToString();
                }
            }
            else if (scheduleButton.Checked)
            {
                AddSchedule.curID = DataGridView1.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                //AddSchedule.curPatID = DataGridView1.Rows[e.RowIndex].Cells["PatientID"].Value.ToString();
                AddSchedule.curPatName = DataGridView1.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                AddSchedule.curDocName = DataGridView1.Rows[e.RowIndex].Cells["Name1"].Value.ToString();
                //AddSchedule.curDocName = DataAccess.LoadData("select Doctor.Name from Doctor, Schedule where Schedule.DoctorID = Doctor.ID and Doctor.ID = " + AddSchedule.curDocID + ";").Rows[0][0].ToString();
                AddSchedule.curDate = DataGridView1.Rows[e.RowIndex].Cells["Date"].Value.ToString();
                AddSchedule.sTime = DataGridView1.Rows[e.RowIndex].Cells["S_Time"].Value.ToString();
                AddSchedule.eTime = DataGridView1.Rows[e.RowIndex].Cells["E_Time"].Value.ToString();
            }
            else if (doctorButton.Checked)
            {
                AddDoctor.curID = DataGridView1.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                AddDoctor.curName = DataGridView1.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                AddDoctor.curGender = DataGridView1.Rows[e.RowIndex].Cells["Gender"].Value.ToString();
                AddDoctor.curDOB = DataGridView1.Rows[e.RowIndex].Cells["DoB"].Value.ToString();
                AddDoctor.curPhone = DataGridView1.Rows[e.RowIndex].Cells["Phone"].Value.ToString();
                AddDoctor.curAddress = DataGridView1.Rows[e.RowIndex].Cells["Address"].Value.ToString();
                AddDoctor.curDept = DataGridView1.Rows[e.RowIndex].Cells["Department"].Value.ToString();
                AddDoctor.curUserID = DataGridView1.Rows[e.RowIndex].Cells["UserID"].Value.ToString();

            }

        }
    }
}
