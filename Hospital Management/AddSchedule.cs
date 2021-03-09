using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management
{
    public partial class AddSchedule : Form
    {
        public static string sTime = "";
        public static string eTime = "";
        public static string curID = "";
        public static string curPatID = "";
        public static string curPatName = "";
        public static string curDocID = "";
        public static string curDocName = "";
        public static string curDate = "";
        public AddSchedule()
        {
            InitializeComponent();
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            ScheduleSelection.date = datePicker.Value.ToString("yyyy-MM-dd");
            ScheduleSelection.doctor = docComboBox.Text;
            ScheduleSelection ss = new ScheduleSelection();
            ss.Show();
        }

        private void AddSchedule_Activated(object sender, EventArgs e)
        {
            startLabel.Text = "Start Time:   " + sTime;
            endLabel.Text = "End Time:   " + eTime;
        }

        private void ptIDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            patNameBox.Text = patComboBox.SelectedValue.ToString();
        }

        private void ptComboBox_Click(object sender, EventArgs e)
        {
            DataTable dt = DataAccess.LoadData("select * from Patient");
            patComboBox.DisplayMember = "ID";
            patComboBox.ValueMember = "Name";
            patComboBox.DataSource = dt;
            patNameBox.Text = patComboBox.SelectedValue.ToString();
        }

        private void docComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            docNameBox.Text = docComboBox.SelectedValue.ToString();
        }

        private void docComboBox_Click(object sender, EventArgs e)
        {
            DataTable dt = DataAccess.LoadData("select * from Doctor");
            docComboBox.DisplayMember = "ID";
            docComboBox.ValueMember = "Name";
            docComboBox.DataSource = dt;
            docNameBox.Text = docComboBox.SelectedValue.ToString();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (idBox.Text == "")
            {
                int count = DataAccess.ExecuteQuery("insert into Schedule (PatientID,DoctorID,Date,S_Time,E_Time) values ('" + patComboBox.Text + "','" + docComboBox.Text + "', '" + datePicker.Value.ToString("yyyy-MM-dd") + "','" + sTime + "','" + eTime + "')");
                if (count != 0)
                {
                    MessageBox.Show(count + " Row(s) inserted");

                }
                else
                {
                    MessageBox.Show("Failed to add Patient");
                }
            }
            else
            {
                try
                {
                    int count = DataAccess.ExecuteQuery("update Schedule set PatientID = '" + patComboBox.Text + "', DoctorID = '" + docComboBox.Text + "', Date = '" + datePicker.Value.ToString("yyyy-MM-dd") + "', S_Time = '" + sTime + "', E_Time = '" + eTime +"' where ID = '" + AddSchedule.curID + "'");
                    MessageBox.Show("Updated " + count + " row(s) in Patient table.");
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.ToString());
                }
            }
        }

        private void ImageButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddSchedule_Load(object sender, EventArgs e)
        {
            if (AddSchedule.curID == "")
            {

            }
            else
            {
                idBox.Text = AddSchedule.curID;
                docComboBox.Text = AddSchedule.curDocID;
                docNameBox.Text = AddSchedule.curDocName;
                patComboBox.Text = AddSchedule.curPatID;
                patNameBox.Text = AddSchedule.curPatName;
                datePicker.Value = DateTime.Parse(AddSchedule.curDate);
                startLabel.Text = "Start Time:   " + sTime;
                endLabel.Text = "End Time:   " + eTime;
            }
        }
    }
}
