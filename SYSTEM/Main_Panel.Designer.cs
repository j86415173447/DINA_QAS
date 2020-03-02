namespace Dina_QAS.SYSTEM
{
    partial class Main_Panel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Panel));
            this.radRibbonBar1 = new Telerik.WinControls.UI.RadRibbonBar();
            this.ribbonTab1 = new Telerik.WinControls.UI.RibbonTab();
            this.ribbonTab2 = new Telerik.WinControls.UI.RibbonTab();
            this.radRibbonBarGroup1 = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.radRibbonBarButtonGroup1 = new Telerik.WinControls.UI.RadRibbonBarButtonGroup();
            this.new_doc = new Telerik.WinControls.UI.RadButtonElement();
            this.doc_amend = new Telerik.WinControls.UI.RadButtonElement();
            this.radRibbonBarButtonGroup2 = new Telerik.WinControls.UI.RadRibbonBarButtonGroup();
            this.doc_del = new Telerik.WinControls.UI.RadButtonElement();
            this.chart_amend = new Telerik.WinControls.UI.RadButtonElement();
            this.radRibbonBarGroup2 = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.radRibbonBarButtonGroup3 = new Telerik.WinControls.UI.RadRibbonBarButtonGroup();
            this.per_general_report = new Telerik.WinControls.UI.RadButtonElement();
            this.birthday_report = new Telerik.WinControls.UI.RadButtonElement();
            this.radRibbonBarGroup3 = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.radRibbonBarButtonGroup4 = new Telerik.WinControls.UI.RadRibbonBarButtonGroup();
            this.score_email = new Telerik.WinControls.UI.RadButtonElement();
            this.score_sms = new Telerik.WinControls.UI.RadButtonElement();
            this.pass_change = new Telerik.WinControls.UI.RadMenuItem();
            this.layout = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuSeparatorItem1 = new Telerik.WinControls.UI.RadMenuSeparatorItem();
            this.app_exit = new Telerik.WinControls.UI.RadMenuItem();
            this.windows8Theme1 = new Telerik.WinControls.Themes.Windows8Theme();
            this.radStatusStrip1 = new Telerik.WinControls.UI.RadStatusStrip();
            this.radLabelElement1 = new Telerik.WinControls.UI.RadLabelElement();
            this.lbl_username = new Telerik.WinControls.UI.RadLabelElement();
            this.commandBarSeparator1 = new Telerik.WinControls.UI.CommandBarSeparator();
            this.radLabelElement2 = new Telerik.WinControls.UI.RadLabelElement();
            this.lbl_date_time = new Telerik.WinControls.UI.RadLabelElement();
            this.commandBarSeparator2 = new Telerik.WinControls.UI.CommandBarSeparator();
            this.radLabelElement3 = new Telerik.WinControls.UI.RadLabelElement();
            this.lbl_workstation = new Telerik.WinControls.UI.RadLabelElement();
            this.commandBarSeparator3 = new Telerik.WinControls.UI.CommandBarSeparator();
            this.radLabelElement4 = new Telerik.WinControls.UI.RadLabelElement();
            this.lbl_ip = new Telerik.WinControls.UI.RadLabelElement();
            this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
            this.oleDbCommand1 = new System.Data.OleDb.OleDbCommand();
            ((System.ComponentModel.ISupportInitialize)(this.radRibbonBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radRibbonBar1
            // 
            this.radRibbonBar1.CommandTabs.AddRange(new Telerik.WinControls.RadItem[] {
            this.ribbonTab1,
            this.ribbonTab2});
            // 
            // 
            // 
            this.radRibbonBar1.ExitButton.Text = "Exit";
            this.radRibbonBar1.ExitButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radRibbonBar1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.radRibbonBar1.LocalizationSettings.LayoutModeText = "Simplified Layout";
            this.radRibbonBar1.Location = new System.Drawing.Point(0, 0);
            this.radRibbonBar1.Name = "radRibbonBar1";
            // 
            // 
            // 
            this.radRibbonBar1.OptionsButton.Text = "Options";
            this.radRibbonBar1.OptionsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            // 
            // 
            // 
            this.radRibbonBar1.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.radRibbonBar1.ShowExpandButton = false;
            this.radRibbonBar1.SimplifiedHeight = 95;
            this.radRibbonBar1.Size = new System.Drawing.Size(1378, 165);
            this.radRibbonBar1.StartButtonImage = global::Dina_QAS.Properties.Resources.start_menu_3;
            this.radRibbonBar1.StartMenuItems.AddRange(new Telerik.WinControls.RadItem[] {
            this.pass_change,
            this.layout,
            this.radMenuSeparatorItem1,
            this.app_exit});
            this.radRibbonBar1.TabIndex = 0;
            this.radRibbonBar1.ThemeName = "Windows8";
            this.radRibbonBar1.LayoutModeChanged += new System.EventHandler(this.radRibbonBar1_LayoutModeChanged);
            ((Telerik.WinControls.UI.RadRibbonBarElement)(this.radRibbonBar1.GetChildAt(0))).SimplifiedHeight = 95;
            ((Telerik.WinControls.UI.RadRibbonBarElement)(this.radRibbonBar1.GetChildAt(0))).Text = "";
            ((Telerik.WinControls.UI.RadToggleSwitchElement)(this.radRibbonBar1.GetChildAt(0).GetChildAt(6).GetChildAt(0))).BorderInnerColor2 = System.Drawing.SystemColors.Control;
            ((Telerik.WinControls.UI.RadToggleSwitchElement)(this.radRibbonBar1.GetChildAt(0).GetChildAt(6).GetChildAt(0))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            ((Telerik.WinControls.UI.ToggleSwitchPartElement)(this.radRibbonBar1.GetChildAt(0).GetChildAt(6).GetChildAt(0).GetChildAt(0))).BackColor2 = System.Drawing.SystemColors.Control;
            ((Telerik.WinControls.UI.ToggleSwitchPartElement)(this.radRibbonBar1.GetChildAt(0).GetChildAt(6).GetChildAt(0).GetChildAt(0))).BackColor3 = System.Drawing.SystemColors.Control;
            ((Telerik.WinControls.UI.ToggleSwitchPartElement)(this.radRibbonBar1.GetChildAt(0).GetChildAt(6).GetChildAt(0).GetChildAt(0))).BackColor4 = System.Drawing.SystemColors.Control;
            ((Telerik.WinControls.UI.RadToggleButtonElement)(this.radRibbonBar1.GetChildAt(0).GetChildAt(6).GetChildAt(2))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            ((Telerik.WinControls.UI.RadToggleButtonElement)(this.radRibbonBar1.GetChildAt(0).GetChildAt(6).GetChildAt(2))).StretchVertically = true;
            // 
            // ribbonTab1
            // 
            this.ribbonTab1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.ribbonTab1.Image = global::Dina_QAS.Properties.Resources.setting_24;
            this.ribbonTab1.IsSelected = true;
            this.ribbonTab1.Name = "ribbonTab1";
            this.ribbonTab1.Text = "تنظیمات مدیریتی";
            this.ribbonTab1.UseMnemonic = false;
            // 
            // ribbonTab2
            // 
            this.ribbonTab2.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.ribbonTab2.Image = global::Dina_QAS.Properties.Resources.Personel_24;
            this.ribbonTab2.IsSelected = false;
            this.ribbonTab2.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radRibbonBarGroup1,
            this.radRibbonBarGroup2,
            this.radRibbonBarGroup3});
            this.ribbonTab2.Name = "ribbonTab2";
            this.ribbonTab2.Text = "امور پرسنلی";
            this.ribbonTab2.UseMnemonic = false;
            // 
            // radRibbonBarGroup1
            // 
            this.radRibbonBarGroup1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.radRibbonBarGroup1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radRibbonBarButtonGroup1,
            this.radRibbonBarButtonGroup2});
            this.radRibbonBarGroup1.Name = "radRibbonBarGroup1";
            this.radRibbonBarGroup1.Text = "پرونده پرسنلی";
            // 
            // radRibbonBarButtonGroup1
            // 
            this.radRibbonBarButtonGroup1.Alignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.radRibbonBarButtonGroup1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.radRibbonBarButtonGroup1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.new_doc,
            this.doc_amend});
            this.radRibbonBarButtonGroup1.Name = "radRibbonBarButtonGroup1";
            this.radRibbonBarButtonGroup1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.radRibbonBarButtonGroup1.Text = "radRibbonBarButtonGroup1";
            // 
            // new_doc
            // 
            this.new_doc.Image = global::Dina_QAS.Properties.Resources.per_doc_add;
            this.new_doc.ImageAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.new_doc.Name = "new_doc";
            this.new_doc.Text = "تشکیل پرونده";
            this.new_doc.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.new_doc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.new_doc.Click += new System.EventHandler(this.new_doc_Click);
            // 
            // doc_amend
            // 
            this.doc_amend.Image = global::Dina_QAS.Properties.Resources.per_doc_am;
            this.doc_amend.ImageAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.doc_amend.Name = "doc_amend";
            this.doc_amend.Text = "اصلاح پرونده";
            this.doc_amend.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.doc_amend.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            // 
            // radRibbonBarButtonGroup2
            // 
            this.radRibbonBarButtonGroup2.Alignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.radRibbonBarButtonGroup2.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.radRibbonBarButtonGroup2.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.doc_del,
            this.chart_amend});
            this.radRibbonBarButtonGroup2.Name = "radRibbonBarButtonGroup2";
            this.radRibbonBarButtonGroup2.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.radRibbonBarButtonGroup2.Text = "radRibbonBarButtonGroup2";
            // 
            // doc_del
            // 
            this.doc_del.Image = global::Dina_QAS.Properties.Resources.per_doc_del;
            this.doc_del.ImageAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.doc_del.Name = "doc_del";
            this.doc_del.Text = "قطع همکاری";
            this.doc_del.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.doc_del.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            // 
            // chart_amend
            // 
            this.chart_amend.Image = global::Dina_QAS.Properties.Resources.Org_chart2;
            this.chart_amend.ImageAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.chart_amend.Name = "chart_amend";
            this.chart_amend.Text = "تغییرات چارت";
            this.chart_amend.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.chart_amend.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            // 
            // radRibbonBarGroup2
            // 
            this.radRibbonBarGroup2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.radRibbonBarGroup2.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radRibbonBarButtonGroup3});
            this.radRibbonBarGroup2.Name = "radRibbonBarGroup2";
            this.radRibbonBarGroup2.Text = "گزارشات پرسنلی";
            // 
            // radRibbonBarButtonGroup3
            // 
            this.radRibbonBarButtonGroup3.Alignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.radRibbonBarButtonGroup3.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.radRibbonBarButtonGroup3.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.per_general_report,
            this.birthday_report});
            this.radRibbonBarButtonGroup3.Name = "radRibbonBarButtonGroup3";
            this.radRibbonBarButtonGroup3.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.radRibbonBarButtonGroup3.Text = "radRibbonBarButtonGroup3";
            // 
            // per_general_report
            // 
            this.per_general_report.Image = global::Dina_QAS.Properties.Resources.reports_final;
            this.per_general_report.ImageAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.per_general_report.Name = "per_general_report";
            this.per_general_report.Text = "گزارش جامع پرسنلی";
            this.per_general_report.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.per_general_report.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            // 
            // birthday_report
            // 
            this.birthday_report.Image = global::Dina_QAS.Properties.Resources.reports_final;
            this.birthday_report.ImageAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.birthday_report.Name = "birthday_report";
            this.birthday_report.Text = "گزارش اعلامیه تولد";
            this.birthday_report.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.birthday_report.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            // 
            // radRibbonBarGroup3
            // 
            this.radRibbonBarGroup3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.radRibbonBarGroup3.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radRibbonBarButtonGroup4});
            this.radRibbonBarGroup3.Name = "radRibbonBarGroup3";
            this.radRibbonBarGroup3.Text = "اطلاع رسانی";
            // 
            // radRibbonBarButtonGroup4
            // 
            this.radRibbonBarButtonGroup4.Alignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.radRibbonBarButtonGroup4.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.radRibbonBarButtonGroup4.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.score_email,
            this.score_sms});
            this.radRibbonBarButtonGroup4.Name = "radRibbonBarButtonGroup4";
            this.radRibbonBarButtonGroup4.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.radRibbonBarButtonGroup4.Text = "radRibbonBarButtonGroup4";
            // 
            // score_email
            // 
            this.score_email.Image = global::Dina_QAS.Properties.Resources.gmail;
            this.score_email.Name = "score_email";
            this.score_email.Text = "ایمیل امتیازات شغلی";
            this.score_email.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.score_email.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            // 
            // score_sms
            // 
            this.score_sms.Image = global::Dina_QAS.Properties.Resources.SMS2;
            this.score_sms.ImageAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.score_sms.Name = "score_sms";
            this.score_sms.Text = "پیامک امتیازات شغلی";
            this.score_sms.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.score_sms.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            // 
            // pass_change
            // 
            this.pass_change.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass_change.Image = global::Dina_QAS.Properties.Resources.key_16;
            this.pass_change.Name = "pass_change";
            this.pass_change.Text = "تغییر کلمه عبور";
            this.pass_change.Click += new System.EventHandler(this.pass_change_Click);
            // 
            // layout
            // 
            this.layout.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layout.Image = global::Dina_QAS.Properties.Resources.compress;
            this.layout.Name = "layout";
            this.layout.Text = "منو فشرده";
            this.layout.Click += new System.EventHandler(this.layout_Click);
            // 
            // radMenuSeparatorItem1
            // 
            this.radMenuSeparatorItem1.Name = "radMenuSeparatorItem1";
            this.radMenuSeparatorItem1.Text = "radMenuSeparatorItem1";
            this.radMenuSeparatorItem1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // app_exit
            // 
            this.app_exit.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.app_exit.Image = global::Dina_QAS.Properties.Resources.exit_24;
            this.app_exit.Name = "app_exit";
            this.app_exit.Text = "خروج";
            // 
            // radStatusStrip1
            // 
            this.radStatusStrip1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.radStatusStrip1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radLabelElement1,
            this.lbl_username,
            this.commandBarSeparator1,
            this.radLabelElement2,
            this.lbl_date_time,
            this.commandBarSeparator2,
            this.radLabelElement3,
            this.lbl_workstation,
            this.commandBarSeparator3,
            this.radLabelElement4,
            this.lbl_ip});
            this.radStatusStrip1.Location = new System.Drawing.Point(0, 647);
            this.radStatusStrip1.Name = "radStatusStrip1";
            this.radStatusStrip1.Size = new System.Drawing.Size(1378, 25);
            this.radStatusStrip1.SizingGrip = false;
            this.radStatusStrip1.TabIndex = 2;
            this.radStatusStrip1.ThemeName = "Windows8";
            // 
            // radLabelElement1
            // 
            this.radLabelElement1.Name = "radLabelElement1";
            this.radStatusStrip1.SetSpring(this.radLabelElement1, false);
            this.radLabelElement1.Text = "نام کاربر:";
            this.radLabelElement1.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.radLabelElement1.TextWrap = true;
            this.radLabelElement1.UseCompatibleTextRendering = false;
            // 
            // lbl_username
            // 
            this.lbl_username.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lbl_username.ForeColor = System.Drawing.Color.Teal;
            this.lbl_username.Name = "lbl_username";
            this.radStatusStrip1.SetSpring(this.lbl_username, false);
            this.lbl_username.Text = "Username";
            this.lbl_username.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.lbl_username.TextWrap = true;
            this.lbl_username.UseCompatibleTextRendering = false;
            // 
            // commandBarSeparator1
            // 
            this.commandBarSeparator1.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.commandBarSeparator1.Name = "commandBarSeparator1";
            this.radStatusStrip1.SetSpring(this.commandBarSeparator1, false);
            this.commandBarSeparator1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.commandBarSeparator1.UseCompatibleTextRendering = false;
            this.commandBarSeparator1.VisibleInOverflowMenu = false;
            // 
            // radLabelElement2
            // 
            this.radLabelElement2.Name = "radLabelElement2";
            this.radStatusStrip1.SetSpring(this.radLabelElement2, false);
            this.radLabelElement2.Text = "ورود:";
            this.radLabelElement2.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.radLabelElement2.TextWrap = true;
            this.radLabelElement2.UseCompatibleTextRendering = false;
            // 
            // lbl_date_time
            // 
            this.lbl_date_time.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lbl_date_time.ForeColor = System.Drawing.Color.Teal;
            this.lbl_date_time.Name = "lbl_date_time";
            this.radStatusStrip1.SetSpring(this.lbl_date_time, false);
            this.lbl_date_time.Text = "Date/Time";
            this.lbl_date_time.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.lbl_date_time.TextWrap = true;
            this.lbl_date_time.UseCompatibleTextRendering = false;
            // 
            // commandBarSeparator2
            // 
            this.commandBarSeparator2.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.commandBarSeparator2.Name = "commandBarSeparator2";
            this.radStatusStrip1.SetSpring(this.commandBarSeparator2, false);
            this.commandBarSeparator2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.commandBarSeparator2.UseCompatibleTextRendering = false;
            this.commandBarSeparator2.VisibleInOverflowMenu = false;
            // 
            // radLabelElement3
            // 
            this.radLabelElement3.Name = "radLabelElement3";
            this.radStatusStrip1.SetSpring(this.radLabelElement3, false);
            this.radLabelElement3.Text = "ایستگاه کاری:";
            this.radLabelElement3.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.radLabelElement3.TextWrap = true;
            this.radLabelElement3.UseCompatibleTextRendering = false;
            // 
            // lbl_workstation
            // 
            this.lbl_workstation.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lbl_workstation.ForeColor = System.Drawing.Color.Teal;
            this.lbl_workstation.Name = "lbl_workstation";
            this.radStatusStrip1.SetSpring(this.lbl_workstation, false);
            this.lbl_workstation.Text = "Workstation";
            this.lbl_workstation.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.lbl_workstation.TextWrap = true;
            this.lbl_workstation.UseCompatibleTextRendering = false;
            // 
            // commandBarSeparator3
            // 
            this.commandBarSeparator3.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.commandBarSeparator3.Name = "commandBarSeparator3";
            this.radStatusStrip1.SetSpring(this.commandBarSeparator3, false);
            this.commandBarSeparator3.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.commandBarSeparator3.UseCompatibleTextRendering = false;
            this.commandBarSeparator3.VisibleInOverflowMenu = false;
            // 
            // radLabelElement4
            // 
            this.radLabelElement4.Name = "radLabelElement4";
            this.radStatusStrip1.SetSpring(this.radLabelElement4, false);
            this.radLabelElement4.Text = "IP:";
            this.radLabelElement4.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.radLabelElement4.TextWrap = true;
            this.radLabelElement4.UseCompatibleTextRendering = false;
            // 
            // lbl_ip
            // 
            this.lbl_ip.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lbl_ip.ForeColor = System.Drawing.Color.Teal;
            this.lbl_ip.Name = "lbl_ip";
            this.radStatusStrip1.SetSpring(this.lbl_ip, false);
            this.lbl_ip.Text = "172.0.0.1";
            this.lbl_ip.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.lbl_ip.TextWrap = true;
            this.lbl_ip.UseCompatibleTextRendering = false;
            // 
            // oleDbCommand1
            // 
            this.oleDbCommand1.Connection = this.oleDbConnection1;
            // 
            // Main_Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Dina_QAS.Properties.Resources.main_background3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1378, 672);
            this.Controls.Add(this.radStatusStrip1);
            this.Controls.Add(this.radRibbonBar1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "Main_Panel";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ThemeName = "Windows8";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_Panel_FormClosed);
            this.Load += new System.EventHandler(this.Main_Panel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radRibbonBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadRibbonBar radRibbonBar1;
        private Telerik.WinControls.Themes.Windows8Theme windows8Theme1;
        private Telerik.WinControls.UI.RadStatusStrip radStatusStrip1;
        private Telerik.WinControls.UI.RadLabelElement radLabelElement1;
        public Telerik.WinControls.UI.RadLabelElement lbl_username;
        private Telerik.WinControls.UI.CommandBarSeparator commandBarSeparator1;
        private Telerik.WinControls.UI.RadLabelElement radLabelElement2;
        public Telerik.WinControls.UI.RadLabelElement lbl_date_time;
        private Telerik.WinControls.UI.CommandBarSeparator commandBarSeparator2;
        private Telerik.WinControls.UI.RadLabelElement radLabelElement3;
        public Telerik.WinControls.UI.RadLabelElement lbl_workstation;
        private Telerik.WinControls.UI.CommandBarSeparator commandBarSeparator3;
        private Telerik.WinControls.UI.RadLabelElement radLabelElement4;
        public Telerik.WinControls.UI.RadLabelElement lbl_ip;
        private System.Data.OleDb.OleDbConnection oleDbConnection1;
        private System.Data.OleDb.OleDbCommand oleDbCommand1;
        private Telerik.WinControls.UI.RibbonTab ribbonTab1;
        private Telerik.WinControls.UI.RibbonTab ribbonTab2;
        private Telerik.WinControls.UI.RadRibbonBarGroup radRibbonBarGroup1;
        private Telerik.WinControls.UI.RadRibbonBarButtonGroup radRibbonBarButtonGroup1;
        private Telerik.WinControls.UI.RadButtonElement new_doc;
        private Telerik.WinControls.UI.RadButtonElement doc_amend;
        private Telerik.WinControls.UI.RadRibbonBarButtonGroup radRibbonBarButtonGroup2;
        private Telerik.WinControls.UI.RadButtonElement doc_del;
        private Telerik.WinControls.UI.RadButtonElement chart_amend;
        private Telerik.WinControls.UI.RadRibbonBarGroup radRibbonBarGroup2;
        private Telerik.WinControls.UI.RadRibbonBarButtonGroup radRibbonBarButtonGroup3;
        private Telerik.WinControls.UI.RadButtonElement per_general_report;
        private Telerik.WinControls.UI.RadButtonElement birthday_report;
        private Telerik.WinControls.UI.RadRibbonBarGroup radRibbonBarGroup3;
        private Telerik.WinControls.UI.RadRibbonBarButtonGroup radRibbonBarButtonGroup4;
        private Telerik.WinControls.UI.RadButtonElement score_email;
        private Telerik.WinControls.UI.RadButtonElement score_sms;
        private Telerik.WinControls.UI.RadMenuItem pass_change;
        private Telerik.WinControls.UI.RadMenuSeparatorItem radMenuSeparatorItem1;
        private Telerik.WinControls.UI.RadMenuItem app_exit;
        private Telerik.WinControls.UI.RadMenuItem layout;
    }
}
