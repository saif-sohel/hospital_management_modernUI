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
    public partial class ScheduleSelection : Form
    {
        public static string date = "";
        public static string doctor = "";
        public static string sTime1 = "";
        public ScheduleSelection()
        {
            InitializeComponent();
        }

        private void ScheduleSelection_Load(object sender, EventArgs e)
        {
            DataTable dt = DataAccess.LoadData("select * from Schedule where date = '" + date + "' and S_Time = '10:00:00' and DoctorID = '" + doctor + "'");
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    Button1.Enabled = false;
                }
            }
            dt = DataAccess.LoadData("select * from Schedule where date = '" + date + "' and S_Time = '10:30:00' and DoctorID = '" + doctor + "'");
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    Button2.Enabled = false;
                }
            }
            dt = DataAccess.LoadData("select * from Schedule where date = '" + date + "' and S_Time = '11:00:00' and DoctorID = '" + doctor + "'");
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    Button3.Enabled = false;
                }
            }
            dt = DataAccess.LoadData("select * from Schedule where date = '" + date + "' and S_Time = '11:30:00' and DoctorID = '" + doctor + "'");
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    Button4.Enabled = false;
                }
            }
            dt = DataAccess.LoadData("select * from Schedule where date = '" + date + "' and S_Time = '12:00:00' and DoctorID = '" + doctor + "'");
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    Button5.Enabled = false;
                }
            }
            dt = DataAccess.LoadData("select * from Schedule where date = '" + date + "' and S_Time = '12:30:00' and DoctorID = '" + doctor + "'");
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    Button6.Enabled = false;
                }
            }
            dt = DataAccess.LoadData("select * from Schedule where date = '" + date + "' and S_Time = '13:00:00' and DoctorID = '" + doctor + "'");
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    Button7.Enabled = false;
                }
            }
            dt = DataAccess.LoadData("select * from Schedule where date = '" + date + "' and S_Time = '13:30:00' and DoctorID = '" + doctor + "'");
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    Button8.Enabled = false;
                }
            }
            dt = DataAccess.LoadData("select * from Schedule where date = '" + date + "' and S_Time = '14:00:00' and DoctorID = '" + doctor + "'");
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    Button9.Enabled = false;
                }
            }
            dt = DataAccess.LoadData("select * from Schedule where date = '" + date + "' and S_Time = '14:30:00' and DoctorID = '" + doctor + "'");
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    Button10.Enabled = false;
                }
            }
            dt = DataAccess.LoadData("select * from Schedule where date = '" + date + "' and S_Time = '15:00:00' and DoctorID = '" + doctor + "'");
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    Button11.Enabled = false;
                }
            }
            dt = DataAccess.LoadData("select * from Schedule where date = '" + date + "' and S_Time = '15:30:00' and DoctorID = '" + doctor + "'");
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    Button12.Enabled = false;
                }
            }
            dt = DataAccess.LoadData("select * from Schedule where date = '" + date + "' and S_Time = '16:00:00' and DoctorID = '" + doctor + "'");
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    Button13.Enabled = false;
                }
            }
            dt = DataAccess.LoadData("select * from Schedule where date = '" + date + "' and S_Time = '16:30:00' and DoctorID = '" + doctor + "'");
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    Button14.Enabled = false;
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            AddSchedule.sTime = "10:00:00";
            AddSchedule.eTime = "10:30:00";
            this.Close();
        }

        private void ScheduleSelection_Activated(object sender, EventArgs e)
        {

        }

        private void ImageButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            AddSchedule.sTime = "10:30:00";
            AddSchedule.eTime = "11:00:00";
            this.Close();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            AddSchedule.sTime = "11:00:00";
            AddSchedule.eTime = "11:30:00";
            this.Close();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            AddSchedule.sTime = "11:30:00";
            AddSchedule.eTime = "12:00:00";
            this.Close();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            AddSchedule.sTime = "12:00:00";
            AddSchedule.eTime = "12:30:00";
            this.Close();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            AddSchedule.sTime = "12:30:00";
            AddSchedule.eTime = "13:00:00";
            this.Close();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            AddSchedule.sTime = "13:00:00";
            AddSchedule.eTime = "13:30:00";
            this.Close();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            AddSchedule.sTime = "13:30:00";
            AddSchedule.eTime = "14:00:00";
            this.Close();
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            AddSchedule.sTime = "14:00:00";
            AddSchedule.eTime = "14:30:00";
            this.Close();
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            AddSchedule.sTime = "14:30:00";
            AddSchedule.eTime = "15:00:00";
            this.Close();
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            AddSchedule.sTime = "15:00:00";
            AddSchedule.eTime = "15:30:00";
            this.Close();
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            AddSchedule.sTime = "15:30:00";
            AddSchedule.eTime = "16:00:00";
            this.Close();
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            AddSchedule.sTime = "16:00:00";
            AddSchedule.eTime = "16:30:00";
            this.Close();
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            AddSchedule.sTime = "16:30:00";
            AddSchedule.eTime = "17:00:00";
            this.Close();
        }
    }
}
