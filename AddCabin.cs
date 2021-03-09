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
    public partial class AddCabin : Form
    {
        public static string curID = "";
        public static string curCategory = "";
        public static string curStatus = "";
        public static string curPatID = "";
        public static string curPatName = "";
        public AddCabin()
        {
            InitializeComponent();
        }

        private void ImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gunaPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaLabel3_Click(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            int count = 0;
            if (idBox.Text == "")
            {
                count = DataAccess.ExecuteQuery("insert into Cabin (Category, Status, PatientID) values ('" + CategoryBox.Text + "','" + statusBox.Text + "', '" + patComboBox.Text + "')");
                if (count != 0)
                {
                    MessageBox.Show(count + " Row(s) inserted");

                }
                else
                {
                    MessageBox.Show("Failed to book Cabin");
                }
            }
            else
            {
                try
                {
                    if (statusBox.Text == "Empty")
                    {
                        count = DataAccess.ExecuteQuery("update Cabin set Category = '" + CategoryBox.Text + "', Status = '" + statusBox.Text + "', PatientID = null where ID = '" + AddCabin.curID + "'");
                        MessageBox.Show("Updated " + count + " row(s) in Patient table.");
                    }
                    else
                    {
                        count = DataAccess.ExecuteQuery("update Cabin set Category = '" + CategoryBox.Text + "', Status = '" + statusBox.Text + "', PatientID = '" + patComboBox.Text + "' where ID = '" + AddCabin.curID + "'");
                        MessageBox.Show("Updated " + count + " row(s) in Patient table.");
                    }
                    
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.ToString());
                }
            }
        }

        private void AddCabin_Load(object sender, EventArgs e)
        {
            if (AddCabin.curID == "")
            {

            }
            else
            {
                idBox.Text = AddCabin.curID;
                CategoryBox.Text = AddCabin.curCategory;
                statusBox.Text = AddCabin.curStatus;
                patNameBox.Text = AddCabin.curPatName;

            }
        }

        private void patComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            patNameBox.Text = patComboBox.SelectedValue.ToString();
        }

        private void patComboBox_Click(object sender, EventArgs e)
        {
            DataTable dt = DataAccess.LoadData("select * from Patient");
            patComboBox.DisplayMember = "ID";
            patComboBox.ValueMember = "Name";
            patComboBox.DataSource = dt;
            patNameBox.Text = patComboBox.SelectedValue.ToString();
        }
    }
}
