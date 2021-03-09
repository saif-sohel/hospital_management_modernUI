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
    public partial class AddPatient : Form
    {
        public static string curID = "";
        public static string curName = "";
        public static string curGender = "";
        public static string curDOB = "";
        public static string curAddress = "";
        public static string curDocID = "";
        public static string curDocName = "";
        public static string curPhone = "";

        public AddPatient()
        {
            InitializeComponent();
        }

        private void gunaImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (idBox.Text == "")
            {
                string docID = "";
                if (docComboBox.Text == "0")
                {
                    docID = null;
                }
                else
                {
                    docID = docComboBox.Text;
                }
                int count = DataAccess.ExecuteQuery("insert into Patient (Name,Gender,DoB,Address,Phone,DoctorID) values ('" + nameBox.Text + "','" + genderBox.Text + "', '" + datePicker.Value.ToString("yyyy-MM-dd") + "','" + addressBox.Text + "','" + phoneBox.Text + "', '"+docID+"')");
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
                    int count = DataAccess.ExecuteQuery("update Patient set Name = '" + nameBox.Text + "', Gender = '" + genderBox.Text + "', DoB = '" + datePicker.Value.ToString("yyyy-MM-dd") + "', Address = '" + addressBox.Text + "',Phone = '" + phoneBox.Text + "', DoctorID = '" + docComboBox.Text + "' where ID = '" + AddPatient.curID + "'");
                    MessageBox.Show("Updated " + count + " row(s) in Patient table.");
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.ToString());
                }
            }
            curID = "";
            curName = "";
            curGender = "";
            curDOB = "";
            curAddress = "";
            curDocID = "";
            curDocName = "";
            curPhone = "";
        }

        private void AddPatient_Load(object sender, EventArgs e)
        {
            if (AddPatient.curID == "")
            {
                
            }
            else
            {
                idBox.Text = AddPatient.curID;
                nameBox.Text = AddPatient.curName;
                genderBox.Text = AddPatient.curGender;
                datePicker.Value = DateTime.Parse(AddPatient.curDOB);
                phoneBox.Text = AddPatient.curPhone;
                addressBox.Text = AddPatient.curAddress;
                docComboBox.Text = AddPatient.curDocID;
                docNameBox.Text = AddPatient.curDocName;

            }

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
    }
}
