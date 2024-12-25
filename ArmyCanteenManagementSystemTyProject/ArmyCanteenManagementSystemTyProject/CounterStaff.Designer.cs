namespace ArmyCanteenManagementSystemTyProject
{
    partial class CounterStaff
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
            this.leftSidePanel = new System.Windows.Forms.Panel();
            this.homeButton = new System.Windows.Forms.Button();
            this.BillHistoryButton = new System.Windows.Forms.Button();
            this.CustomerLoginButton = new System.Windows.Forms.Button();
            this.AccountSettingButton = new System.Windows.Forms.Button();
            this.leftSidePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftSidePanel
            // 
            this.leftSidePanel.BackColor = System.Drawing.Color.LightGray;
            this.leftSidePanel.Controls.Add(this.AccountSettingButton);
            this.leftSidePanel.Controls.Add(this.CustomerLoginButton);
            this.leftSidePanel.Controls.Add(this.BillHistoryButton);
            this.leftSidePanel.Controls.Add(this.homeButton);
            this.leftSidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftSidePanel.Location = new System.Drawing.Point(0, 0);
            this.leftSidePanel.Name = "leftSidePanel";
            this.leftSidePanel.Size = new System.Drawing.Size(208, 464);
            this.leftSidePanel.TabIndex = 0;
            // 
            // homeButton
            // 
            this.homeButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.homeButton.FlatAppearance.BorderSize = 0;
            this.homeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeButton.ForeColor = System.Drawing.Color.White;
            this.homeButton.Location = new System.Drawing.Point(0, 97);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(208, 60);
            this.homeButton.TabIndex = 1;
            this.homeButton.Text = "Home";
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // BillHistoryButton
            // 
            this.BillHistoryButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BillHistoryButton.FlatAppearance.BorderSize = 0;
            this.BillHistoryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillHistoryButton.ForeColor = System.Drawing.Color.White;
            this.BillHistoryButton.Location = new System.Drawing.Point(0, 164);
            this.BillHistoryButton.Name = "BillHistoryButton";
            this.BillHistoryButton.Size = new System.Drawing.Size(208, 60);
            this.BillHistoryButton.TabIndex = 2;
            this.BillHistoryButton.Text = "Bill History";
            this.BillHistoryButton.UseVisualStyleBackColor = true;
            this.BillHistoryButton.Click += new System.EventHandler(this.BillHistoryButton_Click);
            // 
            // CustomerLoginButton
            // 
            this.CustomerLoginButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CustomerLoginButton.FlatAppearance.BorderSize = 0;
            this.CustomerLoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerLoginButton.ForeColor = System.Drawing.Color.White;
            this.CustomerLoginButton.Location = new System.Drawing.Point(0, 238);
            this.CustomerLoginButton.Name = "CustomerLoginButton";
            this.CustomerLoginButton.Size = new System.Drawing.Size(208, 60);
            this.CustomerLoginButton.TabIndex = 3;
            this.CustomerLoginButton.Text = "Customer Login";
            this.CustomerLoginButton.UseVisualStyleBackColor = true;
            this.CustomerLoginButton.Click += new System.EventHandler(this.CustomerLoginButton_Click);
            // 
            // AccountSettingButton
            // 
            this.AccountSettingButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AccountSettingButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.AccountSettingButton.FlatAppearance.BorderSize = 0;
            this.AccountSettingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountSettingButton.ForeColor = System.Drawing.Color.White;
            this.AccountSettingButton.Location = new System.Drawing.Point(0, 310);
            this.AccountSettingButton.Name = "AccountSettingButton";
            this.AccountSettingButton.Size = new System.Drawing.Size(208, 60);
            this.AccountSettingButton.TabIndex = 4;
            this.AccountSettingButton.Text = "Account Setting";
            this.AccountSettingButton.UseVisualStyleBackColor = true;
            this.AccountSettingButton.Click += new System.EventHandler(this.AccountSettingButton_Click);
            // 
            // CounterStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(978, 464);
            this.Controls.Add(this.leftSidePanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CounterStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CounterStaff";
            this.leftSidePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel leftSidePanel;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Button AccountSettingButton;
        private System.Windows.Forms.Button CustomerLoginButton;
        private System.Windows.Forms.Button BillHistoryButton;
    }
}