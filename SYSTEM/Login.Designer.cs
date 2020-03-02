namespace Dina_QAS.SYSTEM
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.fluentTheme1 = new Telerik.WinControls.Themes.FluentTheme();
            this.btn_enter = new Telerik.WinControls.UI.RadButton();
            this.btn_cancel = new Telerik.WinControls.UI.RadButton();
            this.oleDbCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
            this.txt_user = new Telerik.WinControls.UI.RadTextBox();
            this.roundRectShape1 = new Telerik.WinControls.RoundRectShape(this.components);
            this.ellipseShape1 = new Telerik.WinControls.EllipseShape();
            this.circleShape1 = new Telerik.WinControls.CircleShape();
            this.donutShape1 = new Telerik.WinControls.Tests.DonutShape();
            this.officeShape1 = new Telerik.WinControls.UI.OfficeShape();
            this.qaShape1 = new Telerik.WinControls.Tests.QAShape();
            this.txt_pass = new Telerik.WinControls.UI.RadTextBox();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btn_enter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_user)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_pass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_enter
            // 
            this.btn_enter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_enter.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.btn_enter.Image = global::Dina_QAS.Properties.Resources.tick_blue_16;
            this.btn_enter.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_enter.Location = new System.Drawing.Point(364, 149);
            this.btn_enter.Name = "btn_enter";
            this.btn_enter.Size = new System.Drawing.Size(70, 24);
            this.btn_enter.TabIndex = 0;
            this.btn_enter.Text = "ورود";
            this.btn_enter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_enter.Click += new System.EventHandler(this.btn_enter_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_cancel.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.btn_cancel.Image = global::Dina_QAS.Properties.Resources.cross_blue_16;
            this.btn_cancel.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_cancel.Location = new System.Drawing.Point(283, 149);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(70, 24);
            this.btn_cancel.TabIndex = 1;
            this.btn_cancel.Text = "انصراف";
            this.btn_cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            // 
            // oleDbCommand1
            // 
            this.oleDbCommand1.Connection = this.oleDbConnection1;
            // 
            // txt_user
            // 
            this.txt_user.AutoSize = false;
            this.txt_user.BackColor = System.Drawing.Color.Transparent;
            this.txt_user.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.txt_user.Location = new System.Drawing.Point(157, 63);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(196, 22);
            this.txt_user.TabIndex = 4;
            this.txt_user.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            ((Telerik.WinControls.UI.RadTextBoxItem)(this.txt_user.GetChildAt(0).GetChildAt(0))).NullText = "";
            ((Telerik.WinControls.UI.RadTextBoxItem)(this.txt_user.GetChildAt(0).GetChildAt(0))).BorderHighlightColor = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.UI.RadTextBoxItem)(this.txt_user.GetChildAt(0).GetChildAt(0))).Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            ((Telerik.WinControls.UI.RadTextBoxItem)(this.txt_user.GetChildAt(0).GetChildAt(0))).Alignment = System.Drawing.ContentAlignment.MiddleCenter;
            ((Telerik.WinControls.UI.RadTextBoxItem)(this.txt_user.GetChildAt(0).GetChildAt(0))).AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.FitToAvailableSize;
            ((Telerik.WinControls.UI.RadTextBoxItem)(this.txt_user.GetChildAt(0).GetChildAt(0))).Shape = null;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.txt_user.GetChildAt(0).GetChildAt(1))).BackColor2 = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.txt_user.GetChildAt(0).GetChildAt(1))).BackColor3 = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.txt_user.GetChildAt(0).GetChildAt(1))).BackColor4 = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.txt_user.GetChildAt(0).GetChildAt(2))).Shape = this.roundRectShape1;
            // 
            // roundRectShape1
            // 
            this.roundRectShape1.IsRightToLeft = false;
            // 
            // ellipseShape1
            // 
            this.ellipseShape1.IsRightToLeft = false;
            // 
            // circleShape1
            // 
            this.circleShape1.IsRightToLeft = false;
            // 
            // donutShape1
            // 
            this.donutShape1.IsRightToLeft = false;
            // 
            // officeShape1
            // 
            this.officeShape1.IsRightToLeft = false;
            // 
            // qaShape1
            // 
            this.qaShape1.IsRightToLeft = false;
            // 
            // txt_pass
            // 
            this.txt_pass.AutoSize = false;
            this.txt_pass.BackColor = System.Drawing.Color.Transparent;
            this.txt_pass.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.txt_pass.Location = new System.Drawing.Point(157, 106);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.PasswordChar = '●';
            this.txt_pass.Size = new System.Drawing.Size(196, 22);
            this.txt_pass.TabIndex = 5;
            this.txt_pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_pass.UseSystemPasswordChar = true;
            ((Telerik.WinControls.UI.RadTextBoxElement)(this.txt_pass.GetChildAt(0))).Text = "";
            ((Telerik.WinControls.UI.RadTextBoxItem)(this.txt_pass.GetChildAt(0).GetChildAt(0))).NullText = "";
            ((Telerik.WinControls.UI.RadTextBoxItem)(this.txt_pass.GetChildAt(0).GetChildAt(0))).BorderHighlightColor = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.UI.RadTextBoxItem)(this.txt_pass.GetChildAt(0).GetChildAt(0))).Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            ((Telerik.WinControls.UI.RadTextBoxItem)(this.txt_pass.GetChildAt(0).GetChildAt(0))).Alignment = System.Drawing.ContentAlignment.MiddleCenter;
            ((Telerik.WinControls.UI.RadTextBoxItem)(this.txt_pass.GetChildAt(0).GetChildAt(0))).AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.FitToAvailableSize;
            ((Telerik.WinControls.UI.RadTextBoxItem)(this.txt_pass.GetChildAt(0).GetChildAt(0))).Shape = null;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.txt_pass.GetChildAt(0).GetChildAt(1))).BackColor2 = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.txt_pass.GetChildAt(0).GetChildAt(1))).BackColor3 = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.txt_pass.GetChildAt(0).GetChildAt(1))).BackColor4 = System.Drawing.Color.Transparent;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.txt_pass.GetChildAt(0).GetChildAt(2))).Shape = this.roundRectShape1;
            // 
            // radButton1
            // 
            this.radButton1.BackColor = System.Drawing.Color.LemonChiffon;
            this.radButton1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.radButton1.Image = global::Dina_QAS.Properties.Resources.question2;
            this.radButton1.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.radButton1.Location = new System.Drawing.Point(157, 149);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(115, 24);
            this.radButton1.TabIndex = 2;
            this.radButton1.Text = "بازیابی کلمه عبور";
            this.radButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(364, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Version: 1.0.1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(116, 149);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(450, 250);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radButton1);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_user);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_enter);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Login";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Login_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.btn_enter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_user)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_pass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.Themes.FluentTheme fluentTheme1;
        private Telerik.WinControls.UI.RadButton btn_enter;
        private Telerik.WinControls.UI.RadButton btn_cancel;
        private System.Data.OleDb.OleDbCommand oleDbCommand1;
        private System.Data.OleDb.OleDbConnection oleDbConnection1;
        private Telerik.WinControls.UI.RadTextBox txt_user;
        private Telerik.WinControls.RoundRectShape roundRectShape1;
        private Telerik.WinControls.EllipseShape ellipseShape1;
        private Telerik.WinControls.CircleShape circleShape1;
        private Telerik.WinControls.Tests.DonutShape donutShape1;
        private Telerik.WinControls.UI.OfficeShape officeShape1;
        private Telerik.WinControls.Tests.QAShape qaShape1;
        private Telerik.WinControls.UI.RadTextBox txt_pass;
        private Telerik.WinControls.UI.RadButton radButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
