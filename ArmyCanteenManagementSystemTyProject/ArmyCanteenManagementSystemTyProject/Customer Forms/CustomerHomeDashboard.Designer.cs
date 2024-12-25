namespace ArmyCanteenManagementSystemTyProject.Customer_Forms
{
    partial class CustomerHomeDashboard
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
            this.leftPanel = new System.Windows.Forms.Panel();
            this.accountSettingButton = new Guna.UI2.WinForms.Guna2Button();
            this.billHistoryButton = new Guna.UI2.WinForms.Guna2Button();
            this.billButton = new Guna.UI2.WinForms.Guna2Button();
            this.homeButton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2CirclePictureBox2 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.leftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.leftPanel.Controls.Add(this.guna2CirclePictureBox2);
            this.leftPanel.Controls.Add(this.accountSettingButton);
            this.leftPanel.Controls.Add(this.billHistoryButton);
            this.leftPanel.Controls.Add(this.billButton);
            this.leftPanel.Controls.Add(this.homeButton);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(251, 532);
            this.leftPanel.TabIndex = 0;
            // 
            // accountSettingButton
            // 
            this.accountSettingButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.accountSettingButton.Animated = true;
            this.accountSettingButton.AutoRoundedCorners = true;
            this.accountSettingButton.BackColor = System.Drawing.Color.Transparent;
            this.accountSettingButton.BorderColor = System.Drawing.Color.White;
            this.accountSettingButton.BorderRadius = 31;
            this.accountSettingButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.accountSettingButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.accountSettingButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.accountSettingButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.accountSettingButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.accountSettingButton.FillColor = System.Drawing.Color.Empty;
            this.accountSettingButton.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.accountSettingButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.accountSettingButton.ForeColor = System.Drawing.Color.White;
            this.accountSettingButton.HoverState.FillColor = System.Drawing.Color.White;
            this.accountSettingButton.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.accountSettingButton.Location = new System.Drawing.Point(3, 422);
            this.accountSettingButton.Name = "accountSettingButton";
            this.accountSettingButton.Size = new System.Drawing.Size(262, 64);
            this.accountSettingButton.TabIndex = 7;
            this.accountSettingButton.Text = "Account Settings";
            this.accountSettingButton.UseTransparentBackground = true;
            this.accountSettingButton.Click += new System.EventHandler(this.accountSettingButton_Click);
            // 
            // billHistoryButton
            // 
            this.billHistoryButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.billHistoryButton.Animated = true;
            this.billHistoryButton.AutoRoundedCorners = true;
            this.billHistoryButton.BackColor = System.Drawing.Color.Transparent;
            this.billHistoryButton.BorderColor = System.Drawing.Color.White;
            this.billHistoryButton.BorderRadius = 29;
            this.billHistoryButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.billHistoryButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.billHistoryButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.billHistoryButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.billHistoryButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.billHistoryButton.FillColor = System.Drawing.Color.Empty;
            this.billHistoryButton.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.billHistoryButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.billHistoryButton.ForeColor = System.Drawing.Color.White;
            this.billHistoryButton.HoverState.FillColor = System.Drawing.Color.White;
            this.billHistoryButton.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.billHistoryButton.Location = new System.Drawing.Point(3, 355);
            this.billHistoryButton.Name = "billHistoryButton";
            this.billHistoryButton.Size = new System.Drawing.Size(262, 61);
            this.billHistoryButton.TabIndex = 6;
            this.billHistoryButton.Text = "Bill History";
            this.billHistoryButton.UseTransparentBackground = true;
            this.billHistoryButton.Click += new System.EventHandler(this.billHistoryButton_Click);
            // 
            // billButton
            // 
            this.billButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.billButton.Animated = true;
            this.billButton.AutoRoundedCorners = true;
            this.billButton.BackColor = System.Drawing.Color.Transparent;
            this.billButton.BorderColor = System.Drawing.Color.White;
            this.billButton.BorderRadius = 29;
            this.billButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.billButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.billButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.billButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.billButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.billButton.FillColor = System.Drawing.Color.Empty;
            this.billButton.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.billButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.billButton.ForeColor = System.Drawing.Color.White;
            this.billButton.HoverState.FillColor = System.Drawing.Color.White;
            this.billButton.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.billButton.Location = new System.Drawing.Point(3, 290);
            this.billButton.Name = "billButton";
            this.billButton.Size = new System.Drawing.Size(262, 61);
            this.billButton.TabIndex = 5;
            this.billButton.Text = "Create Bill";
            this.billButton.UseTransparentBackground = true;
            this.billButton.Click += new System.EventHandler(this.billButton_Click);
            // 
            // homeButton
            // 
            this.homeButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.homeButton.Animated = true;
            this.homeButton.AutoRoundedCorners = true;
            this.homeButton.BackColor = System.Drawing.Color.Transparent;
            this.homeButton.BorderColor = System.Drawing.Color.White;
            this.homeButton.BorderRadius = 29;
            this.homeButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.homeButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.homeButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.homeButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.homeButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.homeButton.FillColor = System.Drawing.Color.Empty;
            this.homeButton.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.homeButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.homeButton.ForeColor = System.Drawing.Color.White;
            this.homeButton.HoverState.FillColor = System.Drawing.Color.White;
            this.homeButton.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.homeButton.Location = new System.Drawing.Point(3, 224);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(262, 61);
            this.homeButton.TabIndex = 3;
            this.homeButton.Text = "Home";
            this.homeButton.UseTransparentBackground = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // guna2CirclePictureBox2
            // 
            this.guna2CirclePictureBox2.Image = global::ArmyCanteenManagementSystemTyProject.Properties.Resources._4;
            this.guna2CirclePictureBox2.ImageRotate = 0F;
            this.guna2CirclePictureBox2.Location = new System.Drawing.Point(47, 23);
            this.guna2CirclePictureBox2.Name = "guna2CirclePictureBox2";
            this.guna2CirclePictureBox2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox2.Size = new System.Drawing.Size(166, 147);
            this.guna2CirclePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox2.TabIndex = 156;
            this.guna2CirclePictureBox2.TabStop = false;
            // 
            // CustomerHomeDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 532);
            this.Controls.Add(this.leftPanel);
            this.IsMdiContainer = true;
            this.Name = "CustomerHomeDashboard";
            this.Text = "CustomerHomeDashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CustomerHomeDashboard_FormClosed);
            this.Leave += new System.EventHandler(this.CustomerHomeDashboard_Leave);
            this.leftPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel leftPanel;
        private Guna.UI2.WinForms.Guna2Button homeButton;
        private Guna.UI2.WinForms.Guna2Button billButton;
        private Guna.UI2.WinForms.Guna2Button billHistoryButton;
        private Guna.UI2.WinForms.Guna2Button accountSettingButton;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox2;
    }
}