namespace Dina_QAS.SYSTEM
{
    partial class Intro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Intro));
            this.fluentTheme1 = new Telerik.WinControls.Themes.FluentTheme();
            this.radProgressBar1 = new Telerik.WinControls.UI.RadProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_version = new System.Windows.Forms.Label();
            this.lbl_loading = new System.Windows.Forms.Label();
            this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
            this.oleDbCommand1 = new System.Data.OleDb.OleDbCommand();
            ((System.ComponentModel.ISupportInitialize)(this.radProgressBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radProgressBar1
            // 
            this.radProgressBar1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.radProgressBar1.Location = new System.Drawing.Point(132, 154);
            this.radProgressBar1.Name = "radProgressBar1";
            this.radProgressBar1.Size = new System.Drawing.Size(196, 15);
            this.radProgressBar1.TabIndex = 0;
            this.radProgressBar1.Text = "radProgressBar1";
            this.radProgressBar1.ThemeName = "Fluent";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_version
            // 
            this.lbl_version.BackColor = System.Drawing.Color.Transparent;
            this.lbl_version.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lbl_version.Location = new System.Drawing.Point(356, 176);
            this.lbl_version.Name = "lbl_version";
            this.lbl_version.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_version.Size = new System.Drawing.Size(92, 18);
            this.lbl_version.TabIndex = 1;
            this.lbl_version.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_loading
            // 
            this.lbl_loading.BackColor = System.Drawing.Color.Transparent;
            this.lbl_loading.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lbl_loading.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbl_loading.Location = new System.Drawing.Point(132, 133);
            this.lbl_loading.Name = "lbl_loading";
            this.lbl_loading.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_loading.Size = new System.Drawing.Size(196, 18);
            this.lbl_loading.TabIndex = 2;
            this.lbl_loading.Text = "Loading...";
            this.lbl_loading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // oleDbCommand1
            // 
            this.oleDbCommand1.Connection = this.oleDbConnection1;
            // 
            // Intro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(450, 250);
            this.Controls.Add(this.lbl_loading);
            this.Controls.Add(this.lbl_version);
            this.Controls.Add(this.radProgressBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Intro";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.ShowItemToolTips = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Intro";
            this.ThemeName = "Fluent";
            this.Load += new System.EventHandler(this.Intro_Load);
            this.Shown += new System.EventHandler(this.Intro_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.radProgressBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.Themes.FluentTheme fluentTheme1;
        private Telerik.WinControls.UI.RadProgressBar radProgressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_version;
        private System.Windows.Forms.Label lbl_loading;
        private System.Data.OleDb.OleDbConnection oleDbConnection1;
        private System.Data.OleDb.OleDbCommand oleDbCommand1;
    }
}