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
    public partial class LoginView : Form
    {
        public static string curID = "";
        public static string curType = "";
        public LoginView()
        {
            InitializeComponent();
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnLogin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GunaLabel1_Click(object sender, EventArgs e)
        {

        }

        private void lButton_Click(object sender, EventArgs e)
        {
            DataTable dt = DataAccess.LoadData("select * from Login where ID='" + textBox1.Text +
                                               "' and Password='" + textBox2.Text + "'");

            if (dt.Rows.Count != 1)
            {
                MessageBox.Show("Invalid UserName or Password");
                return;
            }
            string type = dt.Rows[0]["UserType"].ToString();
            if (type == "Receptionist")
            {
                LoginView.curID = textBox1.Text;
                RecepView f1 = new RecepView();
                f1.Show();
                this.Hide();
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
