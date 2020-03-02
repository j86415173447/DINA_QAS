using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace Dina_QAS._01_Personel
{
    public partial class New_Doc : Telerik.WinControls.UI.RadForm
    {
        public string constr;
        RoundRectShape roundRectShape1 = new RoundRectShape();
        public DataTable dt_attachments = new DataTable();
        private ErrorProvider errorProvider;

        public New_Doc()
        {
            InitializeComponent();

            this.errorProvider = new ErrorProvider();
            errorProvider.RightToLeft = true;

            lbl_doc_no.TextAlignment = ContentAlignment.MiddleCenter;
            lbl_name_card.TextAlignment = ContentAlignment.MiddleCenter;
            lbl_insert_user.TextAlignment = ContentAlignment.MiddleLeft;
            radLabel48.TextAlignment = ContentAlignment.MiddleCenter;
            lbl_file_size.TextAlignment = ContentAlignment.MiddleRight;
            lbl_file_format.TextAlignment = ContentAlignment.MiddleRight;
            lbl_error_p1.TextAlignment = ContentAlignment.TopLeft;
            lbl_error_p3.TextAlignment = ContentAlignment.TopLeft;

            this.File_Delete.Click += new System.EventHandler(this.DEL_ATTACHMENT);
        }

        private void New_Doc_Load(object sender, EventArgs e)
        {
            oleDbConnection1.ConnectionString = constr;

            ////////////////////////////////////////////////////// Browse Editor File type filter
            Doc_File_Browser.DialogType = Telerik.WinControls.UI.BrowseEditorDialogType.OpenFileDialog;
            OpenFileDialog dialog = (OpenFileDialog)Doc_File_Browser.Dialog;
            dialog.Filter = "Allowed files|*.pdf;*.png;*.jpg;*.docx;*.xlsx;*.zip";

            ////////////////////////////////////////////////////// Element Style initialization
            foreach (Control control in this.Controls)
            {
                Change_shape(control);
                foreach (Control Child1 in control.Controls)
                {
                    Change_shape(Child1);
                    foreach (Control Child2 in Child1.Controls)
                    {
                        Change_shape(Child2);
                        foreach (Control Child3 in Child2.Controls)
                        {
                            Change_shape(Child3);
                        }
                    }
                }
            }
            radButton1.ButtonElement.BorderElement.Visibility = ElementVisibility.Hidden;

            /////////////////////////////// Attachment DataTable initializing
            dt_attachments.Columns.Add(" ", typeof(Bitmap));
            dt_attachments.Columns.Add("ردیف", typeof(string));
            dt_attachments.Columns.Add("کد ماهیت", typeof(string));
            dt_attachments.Columns.Add("ماهیت", typeof(string));
            dt_attachments.Columns.Add("فرمت", typeof(string));
            dt_attachments.Columns.Add("حجم فایل", typeof(string));
            dt_attachments.Columns.Add("آدرس فایل", typeof(string));
            dt_attachments.Columns.Add("Byte", typeof(byte[]));

            radGridView1.DataSource = dt_attachments;
            radGridView1.Columns[6].IsVisible = false;
            radGridView1.Columns[7].IsVisible = false;
            radGridView1.EnableSorting = false;
            
            ////////////////////////////////////////////////////// Combo Boxes initializattion
            /////////////////////////////// initializing Title combo
            DataTable dt = new DataTable();
            OleDbDataAdapter adp = new OleDbDataAdapter();
            adp.SelectCommand = new OleDbCommand();
            adp.SelectCommand.Connection = oleDbConnection1;
            oleDbCommand1.Parameters.Clear();
            string lcommand = "SELECT N'' 'Sex' union SELECT N'خانم' 'Sex' union SELECT N'آقای' 'Sex'";
            adp.SelectCommand.CommandText = lcommand;
            adp.Fill(dt);
            cmb_title.DataSource = dt.DefaultView;
            cmb_title.DisplayMember = "Sex";
            cmb_title.SelectedIndex = 0;
            cmb_title.DropDownHeight = ((dt.Rows.Count) * (cmb_title.ListElement.ItemHeight)) + 1;

            /////////////////////////////// initializing Degree combo
            DataTable dt1 = new DataTable();
            OleDbDataAdapter adp1 = new OleDbDataAdapter();
            adp1.SelectCommand = new OleDbCommand();
            adp1.SelectCommand.Connection = oleDbConnection1;
            oleDbCommand1.Parameters.Clear();
            string lcommand1 = "SELECT '1' 'row', N'' 'degree' union SELECT '2' 'row', N'زیر دیپلم' 'degree' union SELECT '3' 'row', N'دیپلم' 'degree' union SELECT '4' 'row',N'فوق دیپلم' 'degree' union SELECT '5' 'row',N'کارشناسی' 'degree' union SELECT '6' 'row', N'کارشناسی ارشد' 'degree' union SELECT '7' 'row', N'دکتری' 'degree' order by [row] asc";
            adp1.SelectCommand.CommandText = lcommand1;
            adp1.Fill(dt1);
            cmb_degree.DataSource = dt1.DefaultView;
            cmb_degree.DisplayMember = "degree";
            cmb_degree.SelectedIndex = 0;
            cmb_degree.DropDownHeight = ((dt1.Rows.Count) * (cmb_degree.ListElement.ItemHeight)) + 1;

            /////////////////////////////// initializing Major Type combo
            DataTable dt2 = new DataTable();
            OleDbDataAdapter adp2 = new OleDbDataAdapter();
            adp2.SelectCommand = new OleDbCommand();
            adp2.SelectCommand.Connection = oleDbConnection1;
            oleDbCommand1.Parameters.Clear();
            string lcommand2 = "SELECT N'' 'major_type' union SELECT N'مرتبط' 'major_type' union SELECT N'غیر مرتبط' 'major_type'";
            adp2.SelectCommand.CommandText = lcommand2;
            adp2.Fill(dt2);
            cmb_major_type.DataSource = dt2.DefaultView;
            cmb_major_type.DisplayMember = "major_type";
            cmb_major_type.SelectedIndex = 0;
            cmb_major_type.DropDownHeight = ((dt2.Rows.Count) * (cmb_major_type.ListElement.ItemHeight)) + 1;

            /////////////////////////////// initializing MBTI combo
            DataTable dt3 = new DataTable();
            OleDbDataAdapter adp3 = new OleDbDataAdapter();
            adp3.SelectCommand = new OleDbCommand();
            adp3.SelectCommand.Connection = oleDbConnection1;
            oleDbCommand1.Parameters.Clear();
            string lcommand3 = "Select '00' 'Row', '' 'MBTI' Union Select '01' 'Row', 'ENFJ' 'MBTI' Union	Select '02' 'Row', 'ENFP' 'MBTI' Union	Select '03' 'Row', 'ENTJ' 'MBTI' Union	Select '04' 'Row', 'ENTP' 'MBTI' Union	Select '05' 'Row', 'ESFJ' 'MBTI' Union	Select '06' 'Row', 'ESFP' 'MBTI' Union	Select '07' 'Row', 'ESTJ' 'MBTI' Union	Select '08' 'Row', 'ESTP' 'MBTI' Union	Select '09' 'Row', 'INFJ' 'MBTI' Union	Select '10' 'Row', 'INFP' 'MBTI' Union	Select '11' 'Row', 'INTJ' 'MBTI' Union	Select '12' 'Row', 'INTP' 'MBTI' Union	Select '13' 'Row', 'ISFJ' 'MBTI' Union	Select '14' 'Row', 'ISFP' 'MBTI' Union	Select '15' 'Row', 'ISTJ' 'MBTI' Union	Select '16' 'Row', 'ISTP' 'MBTI' order by [Row] asc";
            adp3.SelectCommand.CommandText = lcommand3;
            adp3.Fill(dt3);
            cmb_mbti.DataSource = dt3.DefaultView;
            cmb_mbti.DisplayMember = "MBTI";
            cmb_mbti.SelectedIndex = 0;
            cmb_mbti.Items[4].Height = 30;
            cmb_mbti.Items[4].TextAlignment = ContentAlignment.TopLeft;
            cmb_mbti.Items[8].Height = 30;
            cmb_mbti.Items[8].TextAlignment = ContentAlignment.TopLeft;
            cmb_mbti.Items[12].Height = 30;
            cmb_mbti.Items[12].TextAlignment = ContentAlignment.TopLeft;
            cmb_mbti.DropDownHeight = ((dt3.Rows.Count) * (cmb_mbti.ListElement.ItemHeight)) + 40;

            /////////////////////////////// initializing Department combo
            DataTable dt4 = new DataTable();
            OleDbDataAdapter adp4 = new OleDbDataAdapter();
            adp4.SelectCommand = new OleDbCommand();
            adp4.SelectCommand.Connection = oleDbConnection1;
            oleDbCommand1.Parameters.Clear();
            string lcommand4 = "SELECT '' 'Dep_ID','' 'Dep_Name' union SELECT [Dep_ID],[Dep_Name] FROM [DINA_QAS].[dbo].[CONF_DEPARTMENT] where [Dep_Active] = 1 Order by [Dep_ID]";
            adp4.SelectCommand.CommandText = lcommand4;
            adp4.Fill(dt4);
            cmb_department.DataSource = dt4.DefaultView;
            cmb_department.DisplayMember = "Dep_Name";
            cmb_department.ValueMember = "Dep_ID";
            cmb_department.SelectedIndex = 0;
            cmb_department.DropDownHeight = ((dt4.Rows.Count) * (cmb_department.ListElement.ItemHeight)) + 1;

            /////////////////////////////// initializing Shift combo
            DataTable dt5 = new DataTable();
            OleDbDataAdapter adp5 = new OleDbDataAdapter();
            adp5.SelectCommand = new OleDbCommand();
            adp5.SelectCommand.Connection = oleDbConnection1;
            oleDbCommand1.Parameters.Clear();
            string lcommand5 = "SELECT '' 'Shift_ID','' 'Shift_Name' union SELECT [Shift_ID],[Shift_Name] FROM [DINA_QAS].[dbo].[CONF_SHIFT] where [Shift_Active] = 1 Order by [Shift_ID]";
            adp5.SelectCommand.CommandText = lcommand5;
            adp5.Fill(dt5);
            cmb_shift.DataSource = dt5.DefaultView;
            cmb_shift.DisplayMember = "Shift_Name";
            cmb_shift.SelectedIndex = 0;
            cmb_shift.DropDownHeight = ((dt5.Rows.Count) * (cmb_shift.ListElement.ItemHeight)) + 1;

            /////////////////////////////// initializing Position combo
            DataTable dt6 = new DataTable();
            OleDbDataAdapter adp6 = new OleDbDataAdapter();
            adp6.SelectCommand = new OleDbCommand();
            adp6.SelectCommand.Connection = oleDbConnection1;
            oleDbCommand1.Parameters.Clear();
            string lcommand6 = "SELECT '0' 'Seniority', '' 'Position_Name' union SELECT [Seniority],[Position_Name] FROM [DINA_QAS].[dbo].[CONF_POSITION] Order by [Seniority] asc";
            adp6.SelectCommand.CommandText = lcommand6;
            adp6.Fill(dt6);
            cmb_position.DataSource = dt6.DefaultView;
            cmb_position.DisplayMember = "Position_Name";
            cmb_position.SelectedIndex = 0;
            cmb_position.DropDownHeight = ((dt6.Rows.Count) * (cmb_position.ListElement.ItemHeight)) + 1;

            /////////////////////////////// initializing Attach type combo
            DataTable dt7 = new DataTable();
            OleDbDataAdapter adp7 = new OleDbDataAdapter();
            adp7.SelectCommand = new OleDbCommand();
            adp7.SelectCommand.Connection = oleDbConnection1;
            oleDbCommand1.Parameters.Clear();
            string lcommand7 = "SELECT '' 'Type_ID', '' 'Type_Name' union SELECT [Type_ID],[Type_Name] FROM [DINA_QAS].[dbo].[CONF_ATTACHMENT_TYPE] WHERE [Type_Active] = 1";
            adp7.SelectCommand.CommandText = lcommand7;
            adp7.Fill(dt7);
            cmb_attach_type.DataSource = dt7.DefaultView;
            cmb_attach_type.DisplayMember = "Type_Name";
            cmb_attach_type.ValueMember = "Type_ID";
            cmb_attach_type.SelectedIndex = 0;
            cmb_attach_type.DropDownHeight = ((dt7.Rows.Count) * (cmb_attach_type.ListElement.ItemHeight)) + 1;

            /////////////////////////////// Org chart label initialization
            DataTable dt8 = new DataTable();
            OleDbDataAdapter adp8 = new OleDbDataAdapter();
            adp8.SelectCommand = new OleDbCommand();
            adp8.SelectCommand.Connection = oleDbConnection1;
            oleDbCommand1.Parameters.Clear();
            string lcommand8 = "SELECT [Seniority],[Position_Name] FROM [DINA_QAS].[dbo].[CONF_POSITION] where [Seniority] != 1 order by [Seniority] desc";
            adp8.SelectCommand.CommandText = lcommand8;
            adp8.Fill(dt8);

            int counter = 0;
            foreach (DataRow row in dt8.Rows)
            {
                string seni = row["Seniority"].ToString();
                string pname = row["Position_Name"].ToString();
                switch (row["Seniority"].ToString())
                {
                    case "2":
                        lbl_p2.Text = pname + " مربوطه"  + ":";
                        counter++;
                        break;
                    case "3":
                        lbl_p3.Text = pname + " مربوطه"  + ":";
                        counter++;
                        break;
                    case "4":
                        lbl_p4.Text = pname + " مربوطه"  + ":";
                        counter++;
                        break;
                    case "5":
                        lbl_p5.Text = pname + " مربوطه"  + ":";
                        counter++;
                        break;
                    case "6":
                        lbl_p6.Text = pname + " مربوطه"  + ":";
                        counter++;
                        break;
                    case "7":
                        lbl_p7.Text = pname + " مربوطه"  + ":";
                        counter++;
                        break;
                }
            }

            ///////////////////////////////////////////////////////////////// Re-Location and sizing of org-chart groupbox
            int missing = 6 - counter;
            foreach (Control cntl in grp_org_chart.Controls)
            {
                cntl.Location = new Point(cntl.Location.X, cntl.Location.Y - (missing * 30));
                if (cntl.Text == "")
                {
                    switch (cntl.Name)
                    {
                        case "lbl_p2":
                            cmb_p2.Visible = false;
                            lbl_p2.Visible = false;
                            break;
                        case "lbl_p3":
                            cmb_p3.Visible = false;
                            lbl_p3.Visible = false;
                            break;
                        case "lbl_p4":
                            cmb_p4.Visible = false;
                            lbl_p4.Visible = false;
                            break;
                        case "lbl_p5":
                            cmb_p5.Visible = false;
                            lbl_p5.Visible = false;
                            break;
                        case "lbl_p6":
                            cmb_p6.Visible = false;
                            lbl_p6.Visible = false;
                            break;
                        case "lbl_p7":
                            cmb_p7.Visible = false;
                            lbl_p7.Visible = false;
                            break;
                    }
                }
            }
        }

        public void Change_shape(Control type)
        {
            switch (type.GetType().ToString())
            {
                case "Telerik.WinControls.UI.RadTextBox":
                    ((Telerik.WinControls.UI.RadTextBox)type).TextBoxElement.Shape = this.roundRectShape1;
                    break;

                case "Telerik.WinControls.UI.RadDropDownList":
                    ((Telerik.WinControls.UI.RadDropDownList)type).DropDownListElement.Shape = this.roundRectShape1;
                    ((Telerik.WinControls.UI.RadDropDownList)type).DropDownListElement.ArrowButton.Shape = this.roundRectShape1;
                    ((Telerik.WinControls.UI.RadDropDownList)type).DropDownListElement.ListElement.Shape = this.roundRectShape1;
                    ((Telerik.WinControls.UI.RadDropDownList)type).DropDownListElement.TextBox.Border.Shape = this.roundRectShape1;
                    ((Telerik.WinControls.UI.RadDropDownList)type).DropDownListElement.TextBox.Shape = this.roundRectShape1;
                    ((Telerik.WinControls.UI.RadDropDownList)type).DropDownListElement.Popup.DropShadow = false;
                    ((Telerik.WinControls.UI.RadDropDownList)type).DropDownListElement.EditableElement.Shape = this.roundRectShape1;
                    ((Telerik.WinControls.UI.RadDropDownList)type).DropDownListElement.ListElement.Font = new System.Drawing.Font("Tahoma", 8, FontStyle.Regular);
                    ((Telerik.WinControls.UI.RadDropDownList)type).DropDownListElement.Popup.Font = new System.Drawing.Font("Tahoma", 8, FontStyle.Regular);
                    break;

                case "Telerik.WinControls.UI.RadDateTimePicker":
                    ((Telerik.WinControls.UI.RadDateTimePicker)type).DateTimePickerElement.Shape = this.roundRectShape1;
                    ((Telerik.WinControls.UI.RadDateTimePicker)type).DateTimePickerElement.ArrowButton.Shape = this.roundRectShape1;
                    ((Telerik.WinControls.UI.RadDateTimePicker)type).DateTimePickerElement.TextBoxElement.Shape = this.roundRectShape1;
                    ((Telerik.WinControls.UI.RadDateTimePicker)type).DateTimePickerElement.TextBoxElement.Border.Shape = this.roundRectShape1;
                    ((Telerik.WinControls.UI.RadDateTimePicker)type).DateTimePickerElement.Calendar.Font = new System.Drawing.Font("Tahoma", 8, FontStyle.Regular);
                    ((Telerik.WinControls.UI.RadDateTimePicker)type).DateTimePickerElement.Calendar.RightToLeft = RightToLeft;
                    ((Telerik.WinControls.UI.RadDateTimePicker)type).Culture = new System.Globalization.CultureInfo("fa-IR");
                    ((Telerik.WinControls.UI.RadDateTimePicker)type).NullableValue = null;
                    ((Telerik.WinControls.UI.RadDateTimePicker)type).SetToNullValue();
                    break;

                case "Telerik.WinControls.UI.RadBrowseEditor":
                    ((Telerik.WinControls.UI.RadBrowseEditor)type).BrowseElement.Shape = this.roundRectShape1;
                    ((Telerik.WinControls.UI.RadBrowseEditor)type).BrowseElement.BrowseButton.Shape = this.roundRectShape1;
                    ((Telerik.WinControls.UI.RadBrowseEditor)type).BrowseElement.ClearButton.Shape = this.roundRectShape1;
                    ((Telerik.WinControls.UI.RadBrowseEditor)type).BrowseElement.ShowClearButton = true;
                    break;

                case "Telerik.WinControls.UI.RadCheckBox":
                    //((Telerik.WinControls.UI.RadCheckBox)type).ButtonElement.BorderElement.ForeColor = Color.FromArgb(191, 219, 255);
                    ((Telerik.WinControls.UI.RadCheckBox)type).RootElement.ApplyShapeToControl = true;
                    ((Telerik.WinControls.UI.RadCheckBox)type).RootElement.Shape = this.roundRectShape1;
                    ((Telerik.WinControls.UI.RadCheckBox)type).ButtonElement.Shape = this.roundRectShape1;
                    ((Telerik.WinControls.UI.RadCheckBox)type).ButtonElement.ButtonFillElement.Shape = new RoundRectShape(10,true,true,true,true);
                    ((Telerik.WinControls.UI.RadCheckBox)type).ButtonElement.BorderElement.Shape = new RoundRectShape(10, true, true, true, true);
                    ((Telerik.WinControls.UI.RadCheckBox)type).ButtonElement.TextElement.Shape = new RoundRectShape(10, true, true, true, true);
                    ((Telerik.WinControls.UI.RadCheckBox)type).ButtonElement.CheckMarkPrimitive.Shape = new RoundRectShape(10, true, true, true, true);
                    ((Telerik.WinControls.UI.RadCheckBox)type).ButtonElement.CheckMarkPrimitive.Border.Shape = new RoundRectShape(10, true, true, true, true);
                    ((Telerik.WinControls.UI.RadCheckBox)type).ButtonElement.CheckMarkPrimitive.Fill.Shape = new RoundRectShape(10, true, true, true, true);
                    break;
            }
        }

        private void Doc_File_Browser_DialogClosed(object sender, Telerik.WinControls.UI.DialogClosedEventArgs e)
        {
            lbl_file_format.Text = "";
            lbl_file_size.Text = "";
            if (e.DialogResult == DialogResult.OK)
            {
                FileInfo file = new FileInfo(Doc_File_Browser.Value);
                if (file.Length <= 2097153)
                {
                    string[] sizes = { "B", "KB", "MB", "GB", "TB" };
                    int order = 0;
                    double len = file.Length;
                    while (len >= 1024 && order < sizes.Length - 1)
                    {
                        order++;
                        len = len / 1024;
                    }
                    lbl_file_size.Text = String.Format("{0:00.##} {1}", len, sizes[order]);
                    lbl_file_format.Text = file.Extension.Replace(".", "");
                }
                else
                {
                    Doc_File_Browser.Value = null;
                    RadMessageBox.Instance.FormElement.TitleBar.Font = new Font("Tahoma", 9f, FontStyle.Bold);
                    RadMessageBox.Instance.Controls["radLabel1"].Font = new Font("Tahoma", 8.5f, FontStyle.Regular);
                    RadMessageBox.Instance.ThemeName = "Fluent";
                    RadMessageBox.Show(this, "\n" + "آپلود فایل های بیشتر از 2 مگابایت مجاز نیست." + "\n", "پیغام", MessageBoxButtons.OK, RadMessageIcon.Error, MessageBoxDefaultButton.Button1, RightToLeft.Yes);
                }
            }
            else
            {
                Doc_File_Browser.Value = null;
            }
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            if (cmb_attach_type.SelectedIndex != 0)
            {
                if (Doc_File_Browser.Value != null)
                {
                    //////////////////////////////////////// Fill Attachment Datatable
                    DataRow newrow = dt_attachments.NewRow();
                    newrow[" "] = Properties.Resources.Close_17;
                    newrow["ردیف"] = (dt_attachments.Rows.Count + 1).ToString();
                    newrow["کد ماهیت"] = cmb_attach_type.SelectedValue.ToString();
                    newrow["ماهیت"] = cmb_attach_type.Text;
                    newrow["فرمت"] = lbl_file_format.Text;
                    newrow["حجم فایل"] = lbl_file_size.Text;
                    newrow["آدرس فایل"] = Doc_File_Browser.Value;
                    newrow["byte"] = null;
                    dt_attachments.Rows.Add(newrow);

                    radGridView1.Columns[0].TextAlignment = ContentAlignment.MiddleCenter;
                    radGridView1.Columns[1].TextAlignment = ContentAlignment.MiddleCenter;
                    radGridView1.Columns[2].TextAlignment = ContentAlignment.MiddleCenter;
                    radGridView1.Columns[3].TextAlignment = ContentAlignment.MiddleLeft;
                    radGridView1.Columns[4].TextAlignment = ContentAlignment.MiddleCenter;
                    radGridView1.Columns[5].TextAlignment = ContentAlignment.MiddleCenter;
                    radGridView1.Columns[0].BestFit();
                    radGridView1.Columns[1].BestFit();
                    radGridView1.Columns[2].BestFit();


                    /////////////////////////////////////// Cleanup after add file
                    Doc_File_Browser.Value = null;
                    lbl_file_format.Text = "";
                    lbl_file_size.Text = "";
                }
                else //////////////////////// No file selected error
                {
                    RadMessageBox.Instance.FormElement.TitleBar.Font = new Font("Tahoma", 9f, FontStyle.Bold);
                    RadMessageBox.Instance.Controls["radLabel1"].Font = new Font("Tahoma", 8.5f, FontStyle.Regular);
                    RadMessageBox.Instance.ThemeName = "Fluent";
                    RadMessageBox.Show(this, "\n" + "آدرس فایل مشخص نشده است." + "\n", "پیغام", MessageBoxButtons.OK, RadMessageIcon.Error, MessageBoxDefaultButton.Button1, RightToLeft.Yes);
                }
            }
            else //////////////////////////// No file type selected error
            {
                RadMessageBox.Instance.FormElement.TitleBar.Font = new Font("Tahoma", 9f, FontStyle.Bold);
                RadMessageBox.Instance.Controls["radLabel1"].Font = new Font("Tahoma", 8.5f,FontStyle.Regular);
                RadMessageBox.Instance.ThemeName = "Fluent";
                RadMessageBox.Show(this, "\n" + "ماهیت سند مشخص نشده است." + "\n", "پیغام", MessageBoxButtons.OK, RadMessageIcon.Error, MessageBoxDefaultButton.Button1, RightToLeft.Yes);
            }
        }

        private void radGridView1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && radGridView1.RowCount != 0)
            {
                RadGridView grid = (RadGridView)sender;
                GridCellElement cell = grid.ElementTree.GetElementAtPoint(e.Location) as GridCellElement;
                if (cell != null && cell.ToString() != "Telerik.WinControls.UI.GridHeaderCellElement")
                {
                    Point p = (sender as Control).PointToScreen(e.Location);
                    radContextMenu1.Show(p.X, p.Y);
                }
            }
        }

        private void radGridView1_ContextMenuOpening(object sender, Telerik.WinControls.UI.ContextMenuOpeningEventArgs e)
        {
            e.Cancel = true;
        }

        public void DEL_ATTACHMENT(object sender, EventArgs e)
        {
            if (radGridView1.Rows.Count != 0)
            {
                int selected = radGridView1.SelectedRows[0].Index;
                dt_attachments.Rows.RemoveAt(selected);
                dt_attachments.AcceptChanges();
                DT_ATTACHMENT_REORDER();
            }
        }

        public void DT_ATTACHMENT_REORDER()
        {
            for (int i = 0; i < dt_attachments.Rows.Count; i++)
            {
                dt_attachments.Rows[i][1] = (i + 1).ToString();
                dt_attachments.AcceptChanges();
            }
            //radGridView1.DataSource = voice_dt;
        }

        private void radGridView1_RowsChanged(object sender, GridViewCollectionChangedEventArgs e)
        {
            if (dt_attachments.Rows.Count == 0)
            {
                try
                {
                    /////////////////////////////// Re-initializing Attach type combo
                    DataTable dt7 = new DataTable();
                    OleDbDataAdapter adp7 = new OleDbDataAdapter();
                    adp7.SelectCommand = new OleDbCommand();
                    adp7.SelectCommand.Connection = oleDbConnection1;
                    oleDbCommand1.Parameters.Clear();
                    string lcommand7 = "SELECT '' 'Type_ID', '' 'Type_Name' union SELECT [Type_ID],[Type_Name] FROM [DINA_QAS].[dbo].[CONF_ATTACHMENT_TYPE] WHERE [Type_Active] = 1";
                    adp7.SelectCommand.CommandText = lcommand7;
                    adp7.Fill(dt7);
                    cmb_attach_type.DataSource = dt7.DefaultView;
                    cmb_attach_type.DisplayMember = "Type_Name";
                    cmb_attach_type.ValueMember = "Type_ID";
                    cmb_attach_type.SelectedIndex = 0;
                    cmb_attach_type.DropDownHeight = ((dt7.Rows.Count) * (cmb_attach_type.ListElement.ItemHeight)) + 1;
                }
                catch
                {

                }
            }
            else
            {
                string query = "";
                for (int i = 0; i < dt_attachments.Rows.Count; i++)
                {
                    try
                    {
                        query = query + "AND [Type_ID] != N'" + dt_attachments.Rows[i][2].ToString() + "' ";
                    }
                    catch
                    {

                    }
                }
                /////////////////////////////// Re-initializing Attach type combo
                DataTable dt7 = new DataTable();
                OleDbDataAdapter adp7 = new OleDbDataAdapter();
                adp7.SelectCommand = new OleDbCommand();
                adp7.SelectCommand.Connection = oleDbConnection1;
                oleDbCommand1.Parameters.Clear();
                string lcommand7 = "SELECT '' 'Type_ID', '' 'Type_Name' union SELECT [Type_ID],[Type_Name] FROM [DINA_QAS].[dbo].[CONF_ATTACHMENT_TYPE] WHERE [Type_Active] = 1" + query;
                adp7.SelectCommand.CommandText = lcommand7;
                adp7.Fill(dt7);
                cmb_attach_type.DataSource = dt7.DefaultView;
                cmb_attach_type.DisplayMember = "Type_Name";
                cmb_attach_type.ValueMember = "Type_ID";
                cmb_attach_type.SelectedIndex = 0;
                cmb_attach_type.DropDownHeight = ((dt7.Rows.Count) * (cmb_attach_type.ListElement.ItemHeight)) + 1;
            }
        }

        private void radGridView1_CellClick(object sender, GridViewCellEventArgs e)
        {
            if (e.Column.Name == " ")
            {
                DEL_ATTACHMENT(null,null);
            }
        }

        private void cmb_department_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            if (cmb_department.SelectedIndex == 0)
            {
                cmb_sub_department.DataSource = null;
            }
            else
            {
                /////////////////////////////// initializing Sub-Department combo
                DataTable dt4 = new DataTable();
                OleDbDataAdapter adp4 = new OleDbDataAdapter();
                adp4.SelectCommand = new OleDbCommand();
                adp4.SelectCommand.Connection = oleDbConnection1;
                oleDbCommand1.Parameters.Clear();
                string lcommand4 = "SELECT '' 'SDep_ID','' 'SDep_Name' union SELECT [SDep_ID],[SDep_Name] FROM [DINA_QAS].[dbo].[CONF_DEPARTMENT_Sub] where [SDep_Active] = 1 and [Dep_ID] = N'" + cmb_department.SelectedValue.ToString() + "' Order by [SDep_ID]";
                adp4.SelectCommand.CommandText = lcommand4;
                adp4.Fill(dt4);
                cmb_sub_department.DataSource = dt4.DefaultView;
                cmb_sub_department.DisplayMember = "SDep_Name";
                cmb_sub_department.ValueMember = "SDep_ID";
                cmb_sub_department.SelectedIndex = 0;
                cmb_sub_department.DropDownHeight = ((dt4.Rows.Count) * (cmb_sub_department.ListElement.ItemHeight)) + 1;
            }
        }

        private void txt_birth_day_TextChanged(object sender, EventArgs e)
        {
            if (ActiveControl.Text.Length == 2)
            {
                this.SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void radTextBox24_TextChanged(object sender, EventArgs e)
        {
            if (ActiveControl.Text.Length == 4)
            {
                this.SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void txt_mobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public bool validation()
        {
            List<string> error_1 = new List<string>();
            List<string> error_3 = new List<string>();
            int i1 = 0;
            int i3 = 0;

            bool data_error = false;
            errorProvider.Clear();
            lbl_error_p1.Text = "";

            bool tab1 = false;
            bool tab2 = false;
            bool tab3 = false;
            bool tab4 = false;

            ///////////////////////////////////////////////// Necessary Fields Checking
            if (!national_id_check())
            {
                this.errorProvider.SetError(this.txt_ntl_code, "کد ملی صحیح نیست.");
                data_error = true; tab1 = true;
                i1++;
                error_1.Add(i1.ToString() + "- " + "کد ملی صحیح نیست.");
            }
            if (cmb_shift.SelectedIndex == 0)
            {
                this.errorProvider.SetError(this.cmb_shift, "شیفت انتخاب نشده است");
                data_error = true; tab3 = true;
                i3++;
                error_3.Add(i3.ToString() + "- " + "شیفت انتخاب نشده است");
            }
            if (cmb_title.SelectedIndex == 0)
            {
                this.errorProvider.SetError(this.cmb_title, "عنوان انتخاب نشده است");
                data_error = true; tab1 = true;
                i1++;
                error_1.Add(i1.ToString() + "- " + "عنوان انتخاب نشده است");
            }
            if (txt_fname.Text == "")
            {
                this.errorProvider.SetError(this.txt_fname, "نام وارد نشده است");
                data_error = true; tab1 = true;
                i1++;
                error_1.Add(i1.ToString() + "- " + "نام وارد نشده است");
            }
            if (txt_lname.Text == "")
            {
                this.errorProvider.SetError(this.txt_lname, "نام خانوادگی وارد نشده است");
                data_error = true; tab1 = true;
                i1++;
                error_1.Add(i1.ToString() + "- " + "نام خانوادگی وارد نشده است");
            }
            if (txt_faname.Text == "")
            {
                this.errorProvider.SetError(this.txt_faname, "نام پدر وارد نشده است");
                data_error = true; tab1 = true;
                i1++;
                error_1.Add(i1.ToString() + "- " + "نام پدر وارد نشده است");
            }
            if (txt_comp_cd.Text == "")
            {
                this.errorProvider.SetError(this.txt_comp_cd, "کد پرسنلی وارد نشده است");
                data_error = true; tab1 = true;
                i1++;
                error_1.Add(i1.ToString() + "- " + "کد پرسنلی وارد نشده است");
            }
            if (txt_birth_day.Text == "" || txt_birth_month.Text == "" || txt_birth_year.Text == "" || int.Parse(txt_birth_day.Text) > 31 || int.Parse(txt_birth_month.Text) > 12 || int.Parse(txt_birth_year.Text) < 1300 || txt_birth_day.Text.Length != 2 || txt_birth_month.Text.Length != 2 || txt_birth_year.Text.Length != 4)
            {
                this.errorProvider.SetError(this.txt_birth_year, "تاریخ تولد صحیح وارد نشده است");
                data_error = true; tab1 = true;
                i1++;
                error_1.Add(i1.ToString() + "- " + "تاریخ تولد صحیح وارد نشده است");
            }
            if (txt_mobile.Text.Length != 11 || txt_mobile.Text.Substring(0,2) != "09")
            {
                this.errorProvider.SetError(this.txt_mobile, "شماره موبایل صحیح وارد نشده است");
                data_error = true; tab1 = true;
                i1++;
                error_1.Add(i1.ToString() + "- " + "شماره موبایل صحیح وارد نشده است");
            }
            if (txt_address.Text == "")
            {
                this.errorProvider.SetError(this.txt_address, "آدرس وارد نشده است");
                data_error = true; tab1 = true;
                i1++;
                error_1.Add(i1.ToString() + "- " + "آدرس وارد نشده است");
            }
            if (cmb_major_type.SelectedIndex == 0)
            {
                this.errorProvider.SetError(this.cmb_major_type, "نوع رشته انتخاب نشده است");
                data_error = true; tab1 = true;
                i1++;
                error_1.Add(i1.ToString() + "- " + "نوع رشته انتخاب نشده است");
            }
            if (cmb_degree.SelectedIndex == 0)
            {
                this.errorProvider.SetError(this.cmb_degree, "مدرک تحصیلی انتخاب نشده است");
                data_error = true; tab1 = true;
                i1++;
                error_1.Add(i1.ToString() + "- " + "مدرک تحصیلی انتخاب نشده است");
            }
            if (dtp_recruitment.Value == null)
            {
                this.errorProvider.SetError(this.dtp_recruitment, "تاریخ استخدام انتخاب نشده است");
                data_error = true; tab1 = true;
                i1++;
                error_1.Add(i1.ToString() + "- " + "تاریخ استخدام انتخاب نشده است");
            }
            if (txt_email.Text == "" || !txt_email.Text.Contains("@"))
            {
                this.errorProvider.SetError(this.txt_email, "ایمیل صحیح وارد نشده است");
                data_error = true; tab1 = true;
                i1++;
                error_1.Add(i1.ToString() + "- " + "ایمیل صحیح وارد نشده است");
            }
            if (cmb_department.SelectedIndex == 0)
            {
                this.errorProvider.SetError(this.cmb_department, "واحد سازمانی انتخاب نشده است");
                data_error = true; tab3 = true;
                i3++;
                error_3.Add(i3.ToString() + "- " + "واحد سازمانی انتخاب نشده است");
            }
            if (cmb_sub_department.SelectedIndex == 0)
            {
                this.errorProvider.SetError(this.cmb_sub_department, "زیر واحد انتخاب نشده است");
                data_error = true; tab3 = true;
                i3++;
                error_3.Add(i3.ToString() + "- " + "زیر واحد انتخاب نشده است");
            }
            if (cmb_position.SelectedIndex == 0)
            {
                this.errorProvider.SetError(this.cmb_position, "جایگاه شغلی انتخاب نشده است");
                data_error = true; tab3 = true;
                i3++;
                error_3.Add(i3.ToString() + "- " + "جایگاه شغلی انتخاب نشده است");
            }
            if (txt_job_title.Text == "")
            {
                this.errorProvider.SetError(this.txt_job_title, "عنوان شغلی انتخاب نشده است");
                data_error = true; tab3 = true;
                i3++;
                error_3.Add(i3.ToString() + "- " + "عنوان شغلی انتخاب نشده است");
            }
            if (cmb_p7.SelectedIndex == 0 && cmb_p7.Visible)
            {
                this.errorProvider.SetError(this.cmb_p7, lbl_p7.Text + " انتخاب نشده است");
                data_error = true; tab3 = true;
                i3++;
                error_3.Add(i3.ToString() + "- " + lbl_p7.Text + " انتخاب نشده است");
            }
            if (cmb_p6.SelectedIndex == 0 && cmb_p6.Visible)
            {
                this.errorProvider.SetError(this.cmb_p6, lbl_p6.Text + " انتخاب نشده است");
                data_error = true; tab3 = true;
                i3++;
                error_3.Add(i3.ToString() + "- " + lbl_p6.Text + " انتخاب نشده است");
            }
            if (cmb_p5.SelectedIndex == 0 && cmb_p5.Visible)
            {
                this.errorProvider.SetError(this.cmb_p5, lbl_p5.Text + " انتخاب نشده است");
                data_error = true; tab3 = true;
                i3++;
                error_3.Add(i3.ToString() + "- " + lbl_p5.Text + " انتخاب نشده است");
            }
            if (cmb_p4.SelectedIndex == 0 && cmb_p4.Visible)
            {
                this.errorProvider.SetError(this.cmb_p4, lbl_p4.Text + " انتخاب نشده است");
                data_error = true; tab3 = true;
                i3++;
                error_3.Add(i3.ToString() + "- " + lbl_p4.Text + " انتخاب نشده است");
            }
            if (cmb_p3.SelectedIndex == 0 && cmb_p3.Visible)
            {
                this.errorProvider.SetError(this.cmb_p3, lbl_p3.Text + " انتخاب نشده است");
                data_error = true; tab3 = true;
                i3++;
                error_3.Add(i3.ToString() + "- " + lbl_p3.Text + " انتخاب نشده است");
            }
            if (cmb_p2.SelectedIndex == 0 && cmb_p2.Visible)
            {
                this.errorProvider.SetError(this.cmb_p2, lbl_p2.Text + " انتخاب نشده است");
                data_error = true; tab3 = true;
                i3++;
                error_3.Add(i3.ToString() + "- " + lbl_p2.Text + " انتخاب نشده است");
            }
            if (pbx_per_picture.Image == null)
            {
                this.errorProvider.SetError(this.pbx_per_picture, "عکس پرسنلی انتخاب نشده است");
                data_error = true; tab1 = true;
                i1++;
                error_1.Add(i1.ToString() + "- " + "عکس پرسنلی انتخاب نشده است");
            }

            /////////////////////////////////////////////// Duplication Checking
            DataTable dt1 = new DataTable();
            OleDbDataAdapter adp1 = new OleDbDataAdapter();
            adp1.SelectCommand = new OleDbCommand();
            adp1.SelectCommand.Connection = oleDbConnection1;
            oleDbCommand1.Parameters.Clear();
            string lcommand1 = "SELECT [Doc_ID], [Title] + ' ' + [First_Name] + ' ' +[Last_Name] FROM [DINA_QAS].[dbo].[PER_DOCUMENT] where [National_Id] = '" + txt_ntl_code.Text + "' OR [Mobile] = '" + txt_mobile.Text + "'";
            adp1.SelectCommand.CommandText = lcommand1;
            adp1.Fill(dt1);
            i1++;
            if (dt1.Rows.Count != 0)
            {
                error_1.Add(i1.ToString() + "- " + "پرونده ی مشابه یافت شد. /" + " شماره پرونده: " + dt1.Rows[0][0].ToString() + " / نام: " + dt1.Rows[0][1].ToString());
            }


            if (i1 != 0)
            {
                lbl_error_p1.Text = "خطاها:" + "\n\n" + string.Join("\n\n", error_1.ToArray());
            }
            if (i3 != 0)
            {
                lbl_error_p3.Text = "خطاها:" + "\n\n" + string.Join("\n\n", error_3.ToArray());
            }
            return data_error;
        }

        private bool national_id_check()
        {
            if (txt_ntl_code.Text != "" && txt_ntl_code.Text.Length == 10)
            {
                int i = int.Parse(txt_ntl_code.Text);
                int[] digits = txt_ntl_code.Text.Select(t => int.Parse(t.ToString())).ToArray();
                int key = digits[0] * 10 + digits[1] * 9 + digits[2] * 8 + digits[3] * 7 + digits[4] * 6 + digits[5] * 5 + digits[6] * 4 + digits[7] * 3 + digits[8] * 2;
                if ((11 - (key % 11)) == digits[9])
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (true)
            {
                int doc_no;
                string doc_no_str;
                DataTable dt22 = new DataTable();
                OleDbDataAdapter adp22 = new OleDbDataAdapter();
                adp22.SelectCommand = new OleDbCommand();
                adp22.SelectCommand.Connection = oleDbConnection1;
                oleDbCommand1.Parameters.Clear();
                string lcommand22 = "SELECT max([Doc_ID]) FROM [DINA_QAS].[dbo].[PER_DOCUMENT]";
                adp22.SelectCommand.CommandText = lcommand22;
                adp22.Fill(dt22);
                if (dt22.Rows[0][0].ToString() == "")
                {
                    doc_no = 1;
                }
                else
                {
                    doc_no = int.Parse(dt22.Rows[0][0].ToString()) + 1;
                }
                if (doc_no < 10)
                {
                    doc_no_str = "0000" + doc_no.ToString();
                }
                else if (doc_no > 9 && doc_no < 100)
                {
                    doc_no_str = "000" + doc_no.ToString();
                }
                else if (doc_no > 99 && doc_no < 1000)
                {
                    doc_no_str = "00" + doc_no.ToString();
                }
                else if (doc_no > 999 && doc_no < 10000)
                {
                    doc_no_str = "0" + doc_no.ToString();
                }
                else
                {
                    doc_no_str = doc_no.ToString();
                }
                //lbl_doc_no.Text = "<html> <color= Black> <size=10>" + "شماره پرونده: <color= Teal> <size=12> <b>" + doc_no_str + "</b>";
                lbl_doc_no.Text = "<html><color= Teal><size=12> <b>" + doc_no_str + "<color=Black><size=10>:پرونده شماره" + "</b>";
            }
            else
            {
                return;
            }
        }
    }
}
