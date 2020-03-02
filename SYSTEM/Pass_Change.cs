using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Net;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace Dina_QAS.SYSTEM
{
    public partial class Pass_Change : Telerik.WinControls.UI.RadForm
    {
        public string constr;
        public bool from_login = false;

        public Pass_Change()
        {
            InitializeComponent();
            username.TextAlign = HorizontalAlignment.Center;
            new_pass_1.TextAlign = HorizontalAlignment.Center;
            new_pass_2.TextAlign = HorizontalAlignment.Center;
        }

        private void Pass_Change_Load(object sender, EventArgs e)
        {
            oleDbConnection1.ConnectionString = constr;
            new_pass_1.Select();
        }

        private bool pass_evaluation(string pass1, string pass2)
        {
            if (pass1.Length < 4)
            {
                RadMessageBox.Instance.FormElement.TitleBar.Font = new Font("Tahoma", 9f, FontStyle.Bold);
                RadMessageBox.Instance.Controls["radLabel1"].Font = new Font("Tahoma", 8.5f, FontStyle.Regular);
                RadMessageBox.Instance.ThemeName = "Fluent";
                RadMessageBox.Show(this, "\n" + "کلمه عبور باید بیش از 4 حرف باشد." + "\n", "اخطار", MessageBoxButtons.OK, RadMessageIcon.Exclamation, MessageBoxDefaultButton.Button1, RightToLeft.Yes);
                return false;
            }
            else if (pass1 != pass2)
            {
                RadMessageBox.Instance.FormElement.TitleBar.Font = new Font("Tahoma", 9f, FontStyle.Bold);
                RadMessageBox.Instance.Controls["radLabel1"].Font = new Font("Tahoma", 8.5f, FontStyle.Regular);
                RadMessageBox.Instance.ThemeName = "Fluent";
                RadMessageBox.Show(this, "\n" + "کلمه عبور جدید و تکرار آن با هم مطابقت ندارد." + "\n", "اخطار", MessageBoxButtons.OK, RadMessageIcon.Exclamation, MessageBoxDefaultButton.Button1, RightToLeft.Yes);
                return false;
            }
            else
            {
                DataTable user_info = new DataTable();
                OleDbDataAdapter adp1 = new OleDbDataAdapter();
                adp1.SelectCommand = new OleDbCommand();
                adp1.SelectCommand.Connection = oleDbConnection1;
                oleDbCommand1.Parameters.Clear();
                adp1.SelectCommand.CommandText = "SELECT [Account_ID],[Account_Pass],[User_Doc_ID],[User_Name],[Account_Email],[Account_Role_CD],[Account_Active],[Force_Pass_Change]" +
                                                 ",iif([Account_pass] = HashBytes('MD5', convert(nvarchar(max),'" + pass1 + "')),'1','0'), day(GETDATE()), month(GETDATE()), year(GETDATE()), CONVERT(time(0), CURRENT_TIMESTAMP) FROM [DINA_QAS].[dbo].[SYS_LOGIN] where [ACCOUNT_ID] = N'" + username.Text + "'";
                adp1.Fill(user_info);
                if (user_info.Rows[0][8].ToString() == "1")
                {
                    RadMessageBox.Instance.FormElement.TitleBar.Font = new Font("Tahoma", 9f, FontStyle.Bold);
                    RadMessageBox.Instance.Controls["radLabel1"].Font = new Font("Tahoma", 8.5f, FontStyle.Regular);
                    RadMessageBox.Instance.ThemeName = "Fluent";
                    RadMessageBox.Show(this, "\n" + " کلمه عبور جدید نباید مشابه کلمه عبور فعلی باشد ." + "\n", "اخطار", MessageBoxButtons.OK, RadMessageIcon.Exclamation, MessageBoxDefaultButton.Button1, RightToLeft.Yes);
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (pass_evaluation(new_pass_1.Text,new_pass_2.Text))
            {
                oleDbCommand1.Parameters.Clear();
                oleDbCommand1.CommandText = "Update [DINA_QAS].[dbo].[SYS_LOGIN] Set [Account_Pass] = HashBytes('MD5', convert(nvarchar(max),'" + new_pass_1.Text + "')) , [Force_Pass_Change] = 0 where [Account_ID] = N'" + username.Text + "'";
                oleDbConnection1.Open();
                oleDbCommand1.ExecuteNonQuery();
                oleDbConnection1.Close();
                /////////////////////////////////////////////// Update log table
                oleDbCommand1.Parameters.Clear();
                oleDbCommand1.CommandText = "INSERT INTO [DINA_QAS].[dbo].[SYS_LOGIN_LOG] ([User_ID],[User_Station],[Windows_ID],[System_IP],[Log_Type],[Log_Date],[Log_Time]) " +
                                            "values (?,?,?,?,?,getdate(),getdate())";
                oleDbCommand1.Parameters.AddWithValue("@User_ID", username.Text);
                oleDbCommand1.Parameters.AddWithValue("@User_Station", Environment.MachineName);
                oleDbCommand1.Parameters.AddWithValue("@Windows_ID", Environment.UserName);
                oleDbCommand1.Parameters.AddWithValue("@System_IP", GetIPAddress());
                oleDbCommand1.Parameters.AddWithValue("@Log_Type", "تغییر کلمه عبور");
                oleDbConnection1.Open();
                oleDbCommand1.ExecuteNonQuery();
                oleDbConnection1.Close();
                if (from_login)
                {
                    RadMessageBox.Instance.FormElement.TitleBar.Font = new Font("Tahoma", 9f, FontStyle.Bold);
                    RadMessageBox.Instance.Controls["radLabel1"].Font = new Font("Tahoma", 8.5f, FontStyle.Regular);
                    RadMessageBox.Instance.ThemeName = "Fluent";
                    RadMessageBox.Show(this, "تغییر رمز با موفقیت انجام شد" + "\n\n" + "لطفاً مجدداً وارد سامانه شوید.", "پیغام", MessageBoxButtons.OK, RadMessageIcon.Info, MessageBoxDefaultButton.Button1, RightToLeft.Yes);
                    Application.Exit();
                }
                else
                {
                    RadMessageBox.Instance.FormElement.TitleBar.Font = new Font("Tahoma", 9f, FontStyle.Bold);
                    RadMessageBox.Instance.Controls["radLabel1"].Font = new Font("Tahoma", 8.5f, FontStyle.Regular);
                    RadMessageBox.Instance.ThemeName = "Fluent";
                    RadMessageBox.Show(this, "تغییر رمز با موفقیت انجام شد" + "\n", "پیغام", MessageBoxButtons.OK, RadMessageIcon.Info, MessageBoxDefaultButton.Button1, RightToLeft.Yes);
                    this.Close();
                }
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string GetIPAddress()
        {
            string Str = System.Net.Dns.GetHostName();
            IPHostEntry ipEntry = System.Net.Dns.GetHostEntry(Str);
            IPAddress[] addr = ipEntry.AddressList;
            return addr[addr.Length - 1].ToString();
        }
    }
}
