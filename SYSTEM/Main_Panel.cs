using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace Dina_QAS.SYSTEM
{
    public partial class Main_Panel : Telerik.WinControls.UI.RadRibbonForm
    {
        public string constr;
        public string username;
        public string Account_ID;

        public Main_Panel()
        {
            InitializeComponent();
        }

        private void Main_Panel_Load(object sender, EventArgs e)
        {
            oleDbConnection1.ConnectionString = constr;
            radRibbonBar1.RibbonBarElement.TabStripElement.SelectedItem = radRibbonBar1.RibbonBarElement.TabStripElement.Items[0];
            this.radRibbonBar1.RibbonBarElement.QuickAccessToolBar.OverflowButtonElement.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            this.radRibbonBar1.OptionsButton.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            this.radRibbonBar1.ExitButton.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            this.radRibbonBar1.RibbonBarElement.ApplicationButtonElement.Visibility = ElementVisibility.Visible;
            radRibbonBar1.ShowLayoutModeButton = true;
            this.radRibbonBar1.RibbonBarElement.LayoutModeTextElement.Text = "منوی فشرده";
            this.radRibbonBar1.RibbonBarElement.LayoutModeTextElement.TextParams.font = new System.Drawing.Font("Tahoma", 8, FontStyle.Bold);
        }

        private void Main_Panel_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void pass_change_Click(object sender, EventArgs e)
        {
            var pass_change = new SYSTEM.Pass_Change();
            pass_change.from_login = false;
            pass_change.constr = constr;
            pass_change.username.Text = Account_ID;
            pass_change.from_login = false;
            pass_change.ShowDialog();
        }

        private void layout_Click(object sender, EventArgs e)
        {
            if (radRibbonBar1.LayoutMode == RibbonLayout.Simplified)
            {
                radRibbonBar1.LayoutMode = RibbonLayout.Default;
                layout.Text = "منو فشرده";
                layout.Image = Properties.Resources.compress;
            }
            else
            {
                radRibbonBar1.LayoutMode = RibbonLayout.Simplified;
                layout.Text = "منو گسترده";
                layout.Image = Properties.Resources.decompress2;
            }
        }

        private void radRibbonBar1_LayoutModeChanged(object sender, EventArgs e)
        {
            if (radRibbonBar1.LayoutMode == RibbonLayout.Simplified)
            {
                layout.Text = "منو گسترده";
                layout.Image = Properties.Resources.decompress2;
            }
            else
            {
                layout.Text = "منو فشرده";
                layout.Image = Properties.Resources.compress;
            }
        }

        private void new_doc_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(_01_Personel.New_Doc))
                {
                    form.Activate();
                    return;
                }
            }
            var new_staff = new _01_Personel.New_Doc();
            new_staff.constr = constr;
            new_staff.MdiParent = this;
            new_staff.Show();
        }
    }
}
