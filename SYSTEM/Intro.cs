using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace Dina_QAS.SYSTEM
{
    public partial class Intro : Telerik.WinControls.UI.RadForm
    {
        int ticks = 0;
        int stop;
        public string constr;
        public Intro()
        {
            InitializeComponent();
            radProgressBar1.Minimum = 1;
            radProgressBar1.Maximum = 100;
        }

        private void Intro_Load(object sender, EventArgs e)
        {
            lbl_version.Text = "Version: 1.0.1";
            lbl_loading.Text = "در حال بارگذاری...";
            lbl_loading.ForeColor = Color.Teal;
            lbl_version.TextAlign = ContentAlignment.MiddleRight;

            Random rnd = new Random();
            stop = rnd.Next(50, 75);
            timer1.Interval = 35;
        }

        private void Intro_Shown(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (ticks == 40)
            {
                ticks++;
                string IP = "";
                try
                {
                    timer1.Stop();
                    lbl_loading.Text = "ارتباط با پایگاه داده...";
                    IP = File.ReadAllText(Application.StartupPath + "\\IP.ini");
                    constr = "Provider=SQLOLEDB;Data Source=" + IP + ";Persist Security Info=True;Password=j@2050057997;User ID=sa;Initial Catalog=master";
                    oleDbConnection1.ConnectionString = constr;
                    try
                    {
                        //timer1.Stop();
                        oleDbConnection1.Open();
                        oleDbConnection1.Close();
                        //timer1.Start();
                    }
                    catch
                    {
                        RadMessageBox.Instance.FormElement.TitleBar.Font = new Font("Tahoma", 9f, FontStyle.Bold);
                        RadMessageBox.Instance.Controls["radLabel1"].Font = new Font("Tahoma", 8.5f, FontStyle.Regular);
                        RadMessageBox.Instance.ThemeName = "Fluent";
                        RadMessageBox.Show(this, "کد خطا: 100" + "\n\n" + "دسترسی به پایگاه داده ممکن نیست.", "خطا", MessageBoxButtons.OK, RadMessageIcon.Error, MessageBoxDefaultButton.Button1, RightToLeft.Yes);
                        this.Close();
                    }
                    timer1.Start();
                }
                catch
                {
                    RadMessageBox.Instance.FormElement.TitleBar.Font = new Font("Tahoma", 9f, FontStyle.Bold);
                    RadMessageBox.Instance.Controls["radLabel1"].Font = new Font("Tahoma", 8.5f, FontStyle.Regular);
                    RadMessageBox.Instance.ThemeName = "Fluent";
                    RadMessageBox.Show(this, "کد خطا: 101"+"\n\n"+"تنظیمات پایگاه داده یافت نشد.", "خطا", MessageBoxButtons.OK, RadMessageIcon.Error, MessageBoxDefaultButton.Button1, RightToLeft.Yes);
                    this.Close();
                }
            }
            else if (ticks == stop)
            {
                lbl_loading.Text = "در حال راه اندازی...";
                Thread.Sleep(1000);
                ticks++;    
            }
            else if (ticks == 100) ////////////////////////////////// Go to Login Page
            {
                timer1.Enabled = false;
                Thread.Sleep(1000);
                this.Hide();
                var login = new Login();
                login.constr = constr;
                login.Show();
            }
            else
            {
                ticks++;
                radProgressBar1.Value1 = ticks;
                radProgressBar1.Text = ticks + "%";
            }
            if (ticks%5 == 0)
            {
                lbl_loading.Visible = true;
            }
            else if (ticks%9 == 0)
            {
                lbl_loading.Visible = false;
            }
        }
    }
}
