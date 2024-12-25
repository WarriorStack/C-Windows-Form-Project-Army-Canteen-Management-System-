namespace ArmyCanteenManagementSystemTyProject.Supplier
{
    partial class SupplierDashboard
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
            this.addProductButton = new Guna.UI2.WinForms.Guna2Button();
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
            this.leftPanel.Controls.Add(this.addProductButton);
            this.leftPanel.Controls.Add(this.homeButton);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(221, 489);
            this.leftPanel.TabIndex = 1;
            // 
            // accountSettingButton
            // 
            this.accountSettingButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.accountSettingButton.Animated = true;
            this.accountSettingButton.AutoRoundedCorners = true;
            this.accountSettingButton.BackColor = System.Drawing.Color.Transparent;
            this.accountSettingButton.BorderRadius = 28;
            this.accountSettingButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.accountSettingButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.accountSettingButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.accountSettingButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.accountSettingButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.accountSettingButton.FillColor = System.Drawing.Color.Transparent;
            this.accountSettingButton.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.accountSettingButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.accountSettingButton.ForeColor = System.Drawing.Color.White;
            this.accountSettingButton.HoverState.FillColor = System.Drawing.Color.White;
            this.accountSettingButton.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.accountSettingButton.Location = new System.Drawing.Point(0, 381);
            this.accountSettingButton.Name = "accountSettingButton";
            this.accountSettingButton.Size = new System.Drawing.Size(236, 58);
            this.accountSettingButton.TabIndex = 7;
            this.accountSettingButton.Text = "Account Settings";
            this.accountSettingButton.UseTransparentBackground = true;
            this.accountSettingButton.Click += new System.EventHandler(this.accountSettingButton_Click);
            // 
            // addProductButton
            // 
            this.addProductButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.addProductButton.Animated = true;
            this.addProductButton.AutoRoundedCorners = true;
            this.addProductButton.BackColor = System.Drawing.Color.Transparent;
            this.addProductButton.BorderRadius = 27;
            this.addProductButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.addProductButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addProductButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addProductButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addProductButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addProductButton.FillColor = System.Drawing.Color.Transparent;
            this.addProductButton.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.addProductButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.addProductButton.ForeColor = System.Drawing.Color.White;
            this.addProductButton.HoverState.FillColor = System.Drawing.Color.White;
            this.addProductButton.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.addProductButton.Location = new System.Drawing.Point(0, 297);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(233, 56);
            this.addProductButton.TabIndex = 5;
            this.addProductButton.Text = "Add Products";
            this.addProductButton.UseTransparentBackground = true;
            this.addProductButton.Click += new System.EventHandler(this.addProductButton_Click);
            // 
            // homeButton
            // 
            this.homeButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.homeButton.Animated = true;
            this.homeButton.AutoRoundedCorners = true;
            this.homeButton.BackColor = System.Drawing.Color.Transparent;
            this.homeButton.BorderRadius = 26;
            this.homeButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.homeButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.homeButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.homeButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.homeButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.homeButton.FillColor = System.Drawing.Color.Transparent;
            this.homeButton.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.homeButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.homeButton.ForeColor = System.Drawing.Color.White;
            this.homeButton.HoverState.FillColor = System.Drawing.Color.White;
            this.homeButton.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.homeButton.Location = new System.Drawing.Point(0, 221);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(236, 55);
            this.homeButton.TabIndex = 3;
            this.homeButton.Text = "Home";
            this.homeButton.UseTransparentBackground = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // guna2CirclePictureBox2
            // 
            this.guna2CirclePictureBox2.Image = global::ArmyCanteenManagementSystemTyProject.Properties.Resources._4;
            this.guna2CirclePictureBox2.ImageRotate = 0F;
            this.guna2CirclePictureBox2.Location = new System.Drawing.Point(33, 24);
            this.guna2CirclePictureBox2.Name = "guna2CirclePictureBox2";
            this.guna2CirclePictureBox2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox2.Size = new System.Drawing.Size(166, 147);
            this.guna2CirclePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox2.TabIndex = 156;
            this.guna2CirclePictureBox2.TabStop = false;
            // 
            // SupplierDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 489);
            this.Controls.Add(this.leftPanel);
            this.IsMdiContainer = true;
            this.Name = "SupplierDashboard";
            this.Text = "SupplierDashboard";
            this.leftPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel leftPanel;
        private Guna.UI2.WinForms.Guna2Button accountSettingButton;
        private Guna.UI2.WinForms.Guna2Button addProductButton;
        private Guna.UI2.WinForms.Guna2Button homeButton;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox2;
    }
}