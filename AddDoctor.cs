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
    public partial class AddDoctor : Form
    {
        public static string curID = "";
        public static string curName = "";
        public static string curGender = "";
        public static string curDOB = "";
        public static string curAddress = "";
        public static string curUserID = "";
        public static string curDept = "";
        public static string curPhone = "";
        public AddDoctor()
        {
            InitializeComponent();
        }

        private void userComboBox_Click(object sender, EventArgs e)
        {
            DataTable dt = DataAccess.LoadData("select * from Login where UserType = 'Doctor'");
            userComboBox.DisplayMember = "ID";
            userComboBox.ValueMember = "UserType";
            userComboBox.DataSource = dt;
        }

        private void deptComboBox_Click(object sender, EventArgs e)
        {
            deptComboBox.DisplayMember = "Text";
            //comboBox.ValueMember = "Value";

            var items = new[] {
                new { Text = "Cardiology"},
                new { Text = "Gynecology"},
                new { Text = "Neurology"},
                new { Text = "Oncology"}
            };

            deptComboBox.DataSource = items;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (idBox.Text == "")
            {
                
                int count = DataAccess.ExecuteQuery("insert into Doctor (UserID,Name,Gender,DoB,Phone,Address,Department) values ('" + userComboBox.Text + "','" + nameBox.Text + "','" + genderBox.Text + "', '" + datePicker.Value.ToString("yyyy-MM-dd") + "','" + phoneBox.Text + "','" + addressBox.Text + "', '" + deptComboBox.Text + "')");
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
                    int count = DataAccess.ExecuteQuery("update Doctor set UserID = '" + userComboBox.Text+ "', Name = '" + nameBox.Text + "', Gender = '" + genderBox.Text + "', DoB = '" + datePicker.Value.ToString("yyyy-MM-dd") + "', Address = '" + addressBox.Text + "', Phone = '" + phoneBox.Text + "', Department = '" + deptComboBox.Text + "' where ID = '" + AddDoctor.curID + "'");
                    MessageBox.Show("Updated " + count + " row(s) in Patient table.");
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.ToString());
                }
            }
            idBox.Text = "";
            nameBox.Text = "";
            genderBox.Text = "";
            curAddress = "";
            curPhone = "";
        }

        private void AddDoctor_Load(object sender, EventArgs e)
        {
            if (AddDoctor.curID == "")
            {

            }
            else
            {
                idBox.Text = AddDoctor.curID;
                nameBox.Text = AddDoctor.curName;
                genderBox.Text = AddDoctor.curGender;
                datePicker.Value = DateTime.Parse(AddDoctor.curDOB);
                phoneBox.Text = AddDoctor.curPhone;
                addressBox.Text = AddDoctor.curAddress;
                userComboBox.SelectedText = AddDoctor.curUserID;
                deptComboBox.Text = AddDoctor.curDept;
            }
        }

        private void ImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
