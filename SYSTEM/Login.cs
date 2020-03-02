using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace Dina_QAS.SYSTEM
{
    public partial class Login : Telerik.WinControls.UI.RadForm
    {
        public string constr;
        public string DT_Day;
        public string DT_Mth;
        public string DT_Yr;

        public Login()
        {
            InitializeComponent();
            RadMessageBox.SetThemeName("Fluent");
        }

        private void Login_Load(object sender, EventArgs e)
        {
            oleDbConnection1.ConnectionString = constr;
            this.Size = new Size(450, 250);
            txt_user.Select();
        }

        private void btn_enter_Click(object sender, EventArgs e)
        {
            DataTable user_info = new DataTable();
            OleDbDataAdapter adp1 = new OleDbDataAdapter();
            adp1.SelectCommand = new OleDbCommand();
            adp1.SelectCommand.Connection = oleDbConnection1;
            oleDbCommand1.Parameters.Clear();
            adp1.SelectCommand.CommandText = "SELECT [Account_ID],[Account_Pass],[User_Doc_ID],[User_Name],[Account_Email],[Account_Role_CD],[Account_Active],[Force_Pass_Change]" +
                                             ",iif([Account_pass] = HashBytes('MD5', convert(nvarchar(max),'" + txt_pass.Text + "')),'1','0'), day(GETDATE()), month(GETDATE()), year(GETDATE()), CONVERT(time(0), CURRENT_TIMESTAMP) FROM [DINA_QAS].[dbo].[SYS_LOGIN] where [ACCOUNT_ID] = N'" + txt_user.Text + "'";
            adp1.Fill(user_info);

            Int32 check = user_info.Rows.Count;
            //////////////////////////////////////////// Username Check
            if (check == 0)
            {
                log_update(1);
                RadMessageBox.Instance.FormElement.TitleBar.Font = new Font("Tahoma", 9f, FontStyle.Bold);
                RadMessageBox.Instance.Controls["radLabel1"].Font = new Font("Tahoma", 8.5f, FontStyle.Regular);
                RadMessageBox.Instance.ThemeName = "Fluent";
                RadMessageBox.Show(this, "\n" + "نام کاربری وارد شده یافت نشد." + "\n", "پیغام", MessageBoxButtons.OK, RadMessageIcon.Exclamation, MessageBoxDefaultButton.Button1, RightToLeft.Yes);
            }
            //////////////////////////////////////////// Pass Check
            else if (user_info.Rows[0][8].ToString() == "0")
            {
                log_update(2);
                RadMessageBox.Instance.FormElement.TitleBar.Font = new Font("Tahoma", 9f, FontStyle.Bold);
                RadMessageBox.Instance.Controls["radLabel1"].Font = new Font("Tahoma", 8.5f, FontStyle.Regular);
                RadMessageBox.Instance.ThemeName = "Fluent";
                RadMessageBox.Show(this, "\n" + "کلمه عبور وارد شده صحیح نیست." + "\n", "پیغام", MessageBoxButtons.OK, RadMessageIcon.Exclamation, MessageBoxDefaultButton.Button1, RightToLeft.Yes);
            }
            //////////////////////////////////////////// Active Check
            else if (user_info.Rows[0][6].ToString() == "False")
            {
                log_update(5);
                RadMessageBox.Instance.FormElement.TitleBar.Font = new Font("Tahoma", 9f, FontStyle.Bold);
                RadMessageBox.Instance.Controls["radLabel1"].Font = new Font("Tahoma", 8.5f, FontStyle.Regular);
                RadMessageBox.Instance.ThemeName = "Fluent";
                RadMessageBox.Show(this, "\n" + "حساب کاربری شما مسدود شده است." + "\n" + "لطفا با مدیر سیستم تماس حاصل نمایید." + "\n", "پیغام", MessageBoxButtons.OK, RadMessageIcon.Exclamation, MessageBoxDefaultButton.Button1, RightToLeft.Yes);
                Application.Exit();
            }
            //////////////////////////////////////////// Force Pass Change
            else if (user_info.Rows[0][7].ToString() == "True")
            {
                log_update(4);
                RadMessageBox.Instance.FormElement.TitleBar.Font = new Font("Tahoma", 9f, FontStyle.Bold);
                RadMessageBox.Instance.Controls["radLabel1"].Font = new Font("Tahoma", 8.5f, FontStyle.Regular);
                RadMessageBox.Instance.ThemeName = "Fluent";
                RadMessageBox.Show(this, user_info.Rows[0][3].ToString() + " عزیز: " + "\n\n" + "بنا به دلایل امنیتی، لطفا نسبت به تغییر کلمه عبور خود اقدام نمایید." + "\n", "پیغام", MessageBoxButtons.OK, RadMessageIcon.Exclamation, MessageBoxDefaultButton.Button1, RightToLeft.Yes);
                var pass_change = new SYSTEM.Pass_Change();
                pass_change.constr = constr;
                pass_change.username.Text = user_info.Rows[0][0].ToString();
                pass_change.from_login = true;
                pass_change.ShowDialog();
            }
            else
            {
                //////////////////////////////////////////// Successful Login
                ///////////////////// Get persian Date
                log_update(3);
                DateTime datetime = DateTime.Parse(user_info.Rows[0][11].ToString() + "/" + user_info.Rows[0][10].ToString() + "/" + user_info.Rows[0][9].ToString());
                PersianCalendar psdate = new PersianCalendar();
                DT_Day = (psdate.GetDayOfMonth(datetime).ToString().Length == 1) ? "0" + psdate.GetDayOfMonth(datetime).ToString() : psdate.GetDayOfMonth(datetime).ToString();
                DT_Mth = (psdate.GetMonth(datetime).ToString().Length == 1) ? "0" + psdate.GetMonth(datetime).ToString() : psdate.GetMonth(datetime).ToString();
                DT_Yr = psdate.GetYear(datetime).ToString();
                ///////////////////// Main Form Open
                var mainfrm = new SYSTEM.Main_Panel();
                mainfrm.constr = constr;
                mainfrm.username = user_info.Rows[0][3].ToString();
                mainfrm.lbl_username.Text = user_info.Rows[0][3].ToString();
                mainfrm.Account_ID = user_info.Rows[0][0].ToString();
                mainfrm.lbl_date_time.Text = DT_Yr + "/" + DT_Mth + "/" + DT_Day + " - " + user_info.Rows[0][12].ToString();
                mainfrm.lbl_workstation.Text = Environment.MachineName.ToString();
                string IP = GetIPAddress();
                mainfrm.lbl_ip.Text = IP;
                //mainfrm.User_Role = ds.Tables[0].Rows[0][3].ToString();
                //mainfrm.user_acc_name = user.Text;
                //mainfrm.Access.Text = ds.Tables[0].Rows[0][5].ToString();
                this.Hide();
                mainfrm.Show();
            }
        }

        public string GetIPAddress()
        {
            string Str = System.Net.Dns.GetHostName();
            IPHostEntry ipEntry = System.Net.Dns.GetHostEntry(Str);
            IPAddress[] addr = ipEntry.AddressList;
            return addr[addr.Length - 1].ToString();
        }

        private void Login_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btn_enter_Click(null, null);
            }
        }

        public void log_update(int type)
        {
            switch (type)
            {
                case 1:
                    oleDbCommand1.Parameters.Clear();
                    oleDbCommand1.CommandText = "INSERT INTO [DINA_QAS].[dbo].[SYS_LOGIN_LOG] ([User_ID],[User_Station],[Windows_ID],[System_IP],[Log_Type],[Log_Date],[Log_Time]) " +
                                                "values (?,?,?,?,?,getdate(),getdate())";
                    oleDbCommand1.Parameters.AddWithValue("@User_ID", txt_user.Text);
                    oleDbCommand1.Parameters.AddWithValue("@User_Station", Environment.MachineName);
                    oleDbCommand1.Parameters.AddWithValue("@Windows_ID", Environment.UserName);
                    oleDbCommand1.Parameters.AddWithValue("@System_IP", GetIPAddress());
                    oleDbCommand1.Parameters.AddWithValue("@Log_Type", "ورود ناموفق - نام کاربری اشتباه");
                    oleDbConnection1.Open();
                    oleDbCommand1.ExecuteNonQuery();
                    oleDbConnection1.Close();
                    break;
                case 2:
                    oleDbCommand1.Parameters.Clear();
                    oleDbCommand1.CommandText = "INSERT INTO [DINA_QAS].[dbo].[SYS_LOGIN_LOG] ([User_ID],[User_Station],[Windows_ID],[System_IP],[Log_Type],[Log_Date],[Log_Time]) " +
                                                "values (?,?,?,?,?,getdate(),getdate())";
                    oleDbCommand1.Parameters.AddWithValue("@User_ID", txt_user.Text);
                    oleDbCommand1.Parameters.AddWithValue("@User_Station", Environment.MachineName);
                    oleDbCommand1.Parameters.AddWithValue("@Windows_ID", Environment.UserName);
                    oleDbCommand1.Parameters.AddWithValue("@System_IP", GetIPAddress());
                    oleDbCommand1.Parameters.AddWithValue("@Log_Type", "ورود ناموفق - کلمه عبور اشتباه");
                    oleDbConnection1.Open();
                    oleDbCommand1.ExecuteNonQuery();
                    oleDbConnection1.Close();
                    break;
                case 3:
                    oleDbCommand1.Parameters.Clear();
                    oleDbCommand1.CommandText = "INSERT INTO [DINA_QAS].[dbo].[SYS_LOGIN_LOG] ([User_ID],[User_Station],[Windows_ID],[System_IP],[Log_Type],[Log_Date],[Log_Time]) " +
                                                "values (?,?,?,?,?,getdate(),getdate())";
                    oleDbCommand1.Parameters.AddWithValue("@User_ID", txt_user.Text);
                    oleDbCommand1.Parameters.AddWithValue("@User_Station", Environment.MachineName);
                    oleDbCommand1.Parameters.AddWithValue("@Windows_ID", Environment.UserName);
                    oleDbCommand1.Parameters.AddWithValue("@System_IP", GetIPAddress());
                    oleDbCommand1.Parameters.AddWithValue("@Log_Type", "ورود موفق");
                    oleDbConnection1.Open();
                    oleDbCommand1.ExecuteNonQuery();
                    oleDbConnection1.Close();
                    break;
                case 4:
                    oleDbCommand1.Parameters.Clear();
                    oleDbCommand1.CommandText = "INSERT INTO [DINA_QAS].[dbo].[SYS_LOGIN_LOG] ([User_ID],[User_Station],[Windows_ID],[System_IP],[Log_Type],[Log_Date],[Log_Time]) " +
                                                "values (?,?,?,?,?,getdate(),getdate())";
                    oleDbCommand1.Parameters.AddWithValue("@User_ID", txt_user.Text);
                    oleDbCommand1.Parameters.AddWithValue("@User_Station", Environment.MachineName);
                    oleDbCommand1.Parameters.AddWithValue("@Windows_ID", Environment.UserName);
                    oleDbCommand1.Parameters.AddWithValue("@System_IP", GetIPAddress());
                    oleDbCommand1.Parameters.AddWithValue("@Log_Type", "ورود موفق - اجبار تغییر کلمه عبور");
                    oleDbConnection1.Open();
                    oleDbCommand1.ExecuteNonQuery();
                    oleDbConnection1.Close();
                    break;
                case 5:
                    oleDbCommand1.Parameters.Clear();
                    oleDbCommand1.CommandText = "INSERT INTO [DINA_QAS].[dbo].[SYS_LOGIN_LOG] ([User_ID],[User_Station],[Windows_ID],[System_IP],[Log_Type],[Log_Date],[Log_Time]) " +
                                                "values (?,?,?,?,?,getdate(),getdate())";
                    oleDbCommand1.Parameters.AddWithValue("@User_ID", txt_user.Text);
                    oleDbCommand1.Parameters.AddWithValue("@User_Station", Environment.MachineName);
                    oleDbCommand1.Parameters.AddWithValue("@Windows_ID", Environment.UserName);
                    oleDbCommand1.Parameters.AddWithValue("@System_IP", GetIPAddress());
                    oleDbCommand1.Parameters.AddWithValue("@Log_Type", "ورود ناموفق - حساب کاربری مسدود");
                    oleDbConnection1.Open();
                    oleDbCommand1.ExecuteNonQuery();
                    oleDbConnection1.Close();
                    break;
            }
        }
    }
}
