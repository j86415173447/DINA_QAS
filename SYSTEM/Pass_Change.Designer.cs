namespace Dina_QAS.SYSTEM
{
    partial class Pass_Change
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
            this.components = new System.ComponentModel.Container();
            this.fluentTheme1 = new Telerik.WinControls.Themes.FluentTheme();
            this.save = new Telerik.WinControls.UI.RadMenuItem();
            this.Exit = new Telerik.WinControls.UI.RadMenuItem();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.new_pass_1 = new Telerik.WinControls.UI.RadTextBox();
            this.roundRectShape1 = new Telerik.WinControls.RoundRectShape(this.components);
            this.new_pass_2 = new Telerik.WinControls.UI.RadTextBox();
            this.username = new Telerik.WinControls.UI.RadTextBox();
            this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
            this.oleDbCommand1 = new System.Data.OleDb.OleDbCommand();
            this.Menu_Bar = new Telerik.WinControls.UI.RadMenu();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.new_pass_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.new_pass_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.username)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Menu_Bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // save
            // 
            this.save.Font = new System.Drawing.Font("Tahoma", 9F);
            this.save.Image = global::Dina_QAS.Properties.Resources.tick_24;
            this.save.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.save.Name = "save";
            this.save.Text = "  ذخیره  ";
            this.save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Tahoma", 9F);
            this.Exit.Image = global::Dina_QAS.Properties.Resources.cross_24;
            this.Exit.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.Exit.Name = "Exit";
            this.Exit.Text = "  خروج  ";
            this.Exit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.radLabel1.Location = new System.Drawing.Point(192, 65);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(58, 17);
            this.radLabel1.TabIndex = 1;
            this.radLabel1.Text = "نام کاربری:";
            this.radLabel1.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // radLabel4
            // 
            this.radLabel4.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.radLabel4.Location = new System.Drawing.Point(167, 99);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(83, 17);
            this.radLabel4.TabIndex = 3;
            this.radLabel4.Text = "کلمه عبور جدید:";
            this.radLabel4.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // radLabel5
            // 
            this.radLabel5.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.radLabel5.Location = new System.Drawing.Point(169, 132);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(81, 17);
            this.radLabel5.TabIndex = 4;
            this.radLabel5.Text = "تکرار کلمه عبور:";
            this.radLabel5.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // new_pass_1
            // 
            this.new_pass_1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.new_pass_1.Location = new System.Drawing.Point(10, 96);
            this.new_pass_1.Name = "new_pass_1";
            this.new_pass_1.PasswordChar = '●';
            this.new_pass_1.Size = new System.Drawing.Size(149, 21);
            this.new_pass_1.TabIndex = 6;
            this.new_pass_1.UseSystemPasswordChar = true;
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.new_pass_1.GetChildAt(0))).Text = "";
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.new_pass_1.GetChildAt(0))).Shape = this.roundRectShape1;
            // 
            // roundRectShape1
            // 
            this.roundRectShape1.IsRightToLeft = false;
            // 
            // new_pass_2
            // 
            this.new_pass_2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.new_pass_2.Location = new System.Drawing.Point(10, 129);
            this.new_pass_2.Name = "new_pass_2";
            this.new_pass_2.PasswordChar = '●';
            this.new_pass_2.Size = new System.Drawing.Size(149, 21);
            this.new_pass_2.TabIndex = 7;
            this.new_pass_2.UseSystemPasswordChar = true;
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.new_pass_2.GetChildAt(0))).Text = "";
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.new_pass_2.GetChildAt(0))).Shape = this.roundRectShape1;
            // 
            // username
            // 
            this.username.Enabled = false;
            this.username.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.username.Location = new System.Drawing.Point(10, 63);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(149, 21);
            this.username.TabIndex = 6;
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.username.GetChildAt(0))).Text = "";
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.username.GetChildAt(0))).Shape = this.roundRectShape1;
            // 
            // oleDbCommand1
            // 
            this.oleDbCommand1.Connection = this.oleDbConnection1;
            // 
            // Menu_Bar
            // 
            this.Menu_Bar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.Menu_Bar.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.Menu_Bar.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.save,
            this.Exit});
            this.Menu_Bar.Location = new System.Drawing.Point(0, 0);
            this.Menu_Bar.Name = "Menu_Bar";
            this.Menu_Bar.Size = new System.Drawing.Size(256, 48);
            this.Menu_Bar.TabIndex = 0;
            this.Menu_Bar.ThemeName = "Fluent";
            // 
            // Pass_Change
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 163);
            this.Controls.Add(this.username);
            this.Controls.Add(this.new_pass_2);
            this.Controls.Add(this.new_pass_1);
            this.Controls.Add(this.radLabel5);
            this.Controls.Add(this.radLabel4);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.Menu_Bar);
            this.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Pass_Change";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تغییر کلمه عبور";
            this.ThemeName = "Fluent";
            this.Load += new System.EventHandler(this.Pass_Change_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.new_pass_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.new_pass_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.username)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Menu_Bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.Themes.FluentTheme fluentTheme1;
        private Telerik.WinControls.UI.RadMenuItem save;
        private Telerik.WinControls.UI.RadMenuItem Exit;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private Telerik.WinControls.UI.RadTextBox new_pass_1;
        private Telerik.WinControls.UI.RadTextBox new_pass_2;
        private Telerik.WinControls.UI.RadMenu Menu_Bar;
        private System.Data.OleDb.OleDbConnection oleDbConnection1;
        private System.Data.OleDb.OleDbCommand oleDbCommand1;
        public Telerik.WinControls.UI.RadTextBox username;
        private Telerik.WinControls.RoundRectShape roundRectShape1;
    }
}
