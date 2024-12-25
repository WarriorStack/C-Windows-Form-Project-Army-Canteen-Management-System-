namespace ArmyCanteenManagementSystemTyProject.Admin_Forms
{
    partial class orderManagementAndHistoryForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.SearchButton = new Guna.UI2.WinForms.Guna2CircleButton();
            this.SearchTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.updateStateButton = new Guna.UI2.WinForms.Guna2Button();
            this.sortergroupBox = new System.Windows.Forms.GroupBox();
            this.TodayradioButton = new System.Windows.Forms.RadioButton();
            this.ThisWeekradioButton = new System.Windows.Forms.RadioButton();
            this.thisMonthradioButton = new System.Windows.Forms.RadioButton();
            this.alltimeradioButton = new System.Windows.Forms.RadioButton();
            this.orderHistoryDataGridView = new System.Windows.Forms.DataGridView();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblHiUsername = new System.Windows.Forms.Label();
            this.sortergroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderHistoryDataGridView)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SearchButton
            // 
            this.SearchButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SearchButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SearchButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SearchButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SearchButton.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.SearchButton.ForeColor = System.Drawing.Color.White;
            this.SearchButton.Location = new System.Drawing.Point(297, 214);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.SearchButton.Size = new System.Drawing.Size(93, 37);
            this.SearchButton.TabIndex = 6;
            this.SearchButton.Text = "Search";
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Animated = true;
            this.SearchTextBox.BorderRadius = 10;
            this.SearchTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SearchTextBox.DefaultText = "";
            this.SearchTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SearchTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SearchTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SearchTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SearchTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SearchTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.SearchTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SearchTextBox.Location = new System.Drawing.Point(15, 214);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.PasswordChar = '\0';
            this.SearchTextBox.PlaceholderText = "Search By its State";
            this.SearchTextBox.SelectedText = "";
            this.SearchTextBox.Size = new System.Drawing.Size(254, 41);
            this.SearchTextBox.TabIndex = 5;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchButton_Click);
            // 
            // updateStateButton
            // 
            this.updateStateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.updateStateButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.updateStateButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.updateStateButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.updateStateButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.updateStateButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.updateStateButton.ForeColor = System.Drawing.Color.White;
            this.updateStateButton.Location = new System.Drawing.Point(635, 200);
            this.updateStateButton.Name = "updateStateButton";
            this.updateStateButton.Size = new System.Drawing.Size(194, 55);
            this.updateStateButton.TabIndex = 7;
            this.updateStateButton.Text = "Update State";
            this.updateStateButton.Click += new System.EventHandler(this.updateStateButton_Click);
            // 
            // sortergroupBox
            // 
            this.sortergroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sortergroupBox.BackColor = System.Drawing.Color.White;
            this.sortergroupBox.Controls.Add(this.TodayradioButton);
            this.sortergroupBox.Controls.Add(this.ThisWeekradioButton);
            this.sortergroupBox.Controls.Add(this.thisMonthradioButton);
            this.sortergroupBox.Controls.Add(this.alltimeradioButton);
            this.sortergroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.sortergroupBox.Location = new System.Drawing.Point(3, 86);
            this.sortergroupBox.Name = "sortergroupBox";
            this.sortergroupBox.Size = new System.Drawing.Size(838, 94);
            this.sortergroupBox.TabIndex = 8;
            this.sortergroupBox.TabStop = false;
            // 
            // TodayradioButton
            // 
            this.TodayradioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TodayradioButton.AutoSize = true;
            this.TodayradioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TodayradioButton.Location = new System.Drawing.Point(632, 37);
            this.TodayradioButton.Name = "TodayradioButton";
            this.TodayradioButton.Size = new System.Drawing.Size(81, 28);
            this.TodayradioButton.TabIndex = 11;
            this.TodayradioButton.Text = "Today";
            this.TodayradioButton.UseVisualStyleBackColor = true;
            this.TodayradioButton.CheckedChanged += new System.EventHandler(this.TodayradioButton_CheckedChanged);
            // 
            // ThisWeekradioButton
            // 
            this.ThisWeekradioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ThisWeekradioButton.AutoSize = true;
            this.ThisWeekradioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThisWeekradioButton.Location = new System.Drawing.Point(460, 37);
            this.ThisWeekradioButton.Name = "ThisWeekradioButton";
            this.ThisWeekradioButton.Size = new System.Drawing.Size(118, 28);
            this.ThisWeekradioButton.TabIndex = 10;
            this.ThisWeekradioButton.Text = "This Week";
            this.ThisWeekradioButton.UseVisualStyleBackColor = true;
            this.ThisWeekradioButton.CheckedChanged += new System.EventHandler(this.ThisWeekradioButton_CheckedChanged);
            // 
            // thisMonthradioButton
            // 
            this.thisMonthradioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.thisMonthradioButton.AutoSize = true;
            this.thisMonthradioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thisMonthradioButton.Location = new System.Drawing.Point(276, 37);
            this.thisMonthradioButton.Name = "thisMonthradioButton";
            this.thisMonthradioButton.Size = new System.Drawing.Size(122, 28);
            this.thisMonthradioButton.TabIndex = 9;
            this.thisMonthradioButton.Text = "This Month";
            this.thisMonthradioButton.UseVisualStyleBackColor = true;
            this.thisMonthradioButton.CheckedChanged += new System.EventHandler(this.thisMonthradioButton_CheckedChanged);
            // 
            // alltimeradioButton
            // 
            this.alltimeradioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.alltimeradioButton.AutoSize = true;
            this.alltimeradioButton.Checked = true;
            this.alltimeradioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alltimeradioButton.Location = new System.Drawing.Point(103, 37);
            this.alltimeradioButton.Name = "alltimeradioButton";
            this.alltimeradioButton.Size = new System.Drawing.Size(97, 28);
            this.alltimeradioButton.TabIndex = 8;
            this.alltimeradioButton.TabStop = true;
            this.alltimeradioButton.Text = "All Time";
            this.alltimeradioButton.UseVisualStyleBackColor = true;
            this.alltimeradioButton.CheckedChanged += new System.EventHandler(this.alltimeradioButton_CheckedChanged);
            // 
            // orderHistoryDataGridView
            // 
            this.orderHistoryDataGridView.AllowUserToAddRows = false;
            this.orderHistoryDataGridView.AllowUserToDeleteRows = false;
            this.orderHistoryDataGridView.AllowUserToResizeColumns = false;
            this.orderHistoryDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.orderHistoryDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.orderHistoryDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.orderHistoryDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.orderHistoryDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.orderHistoryDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.orderHistoryDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.orderHistoryDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.orderHistoryDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.orderHistoryDataGridView.ColumnHeadersHeight = 35;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.orderHistoryDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.orderHistoryDataGridView.EnableHeadersVisualStyles = false;
            this.orderHistoryDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.orderHistoryDataGridView.Location = new System.Drawing.Point(3, 294);
            this.orderHistoryDataGridView.Name = "orderHistoryDataGridView";
            this.orderHistoryDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.orderHistoryDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.orderHistoryDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.orderHistoryDataGridView.Size = new System.Drawing.Size(835, 213);
            this.orderHistoryDataGridView.TabIndex = 9;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.guna2Panel1.Controls.Add(this.lblHiUsername);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(838, 80);
            this.guna2Panel1.TabIndex = 36;
            // 
            // lblHiUsername
            // 
            this.lblHiUsername.AutoSize = true;
            this.lblHiUsername.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHiUsername.ForeColor = System.Drawing.Color.White;
            this.lblHiUsername.Location = new System.Drawing.Point(18, 18);
            this.lblHiUsername.Name = "lblHiUsername";
            this.lblHiUsername.Size = new System.Drawing.Size(403, 35);
            this.lblHiUsername.TabIndex = 31;
            this.lblHiUsername.Text = "*  Purchase Order Mangements *";
            // 
            // orderManagementAndHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(838, 505);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.orderHistoryDataGridView);
            this.Controls.Add(this.sortergroupBox);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.updateStateButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "orderManagementAndHistoryForm";
            this.Text = "orderManagementAndHistoryForm";
            this.sortergroupBox.ResumeLayout(false);
            this.sortergroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderHistoryDataGridView)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2CircleButton SearchButton;
        private Guna.UI2.WinForms.Guna2TextBox SearchTextBox;
        private Guna.UI2.WinForms.Guna2Button updateStateButton;
        private System.Windows.Forms.GroupBox sortergroupBox;
        private System.Windows.Forms.RadioButton TodayradioButton;
        private System.Windows.Forms.RadioButton ThisWeekradioButton;
        private System.Windows.Forms.RadioButton thisMonthradioButton;
        private System.Windows.Forms.RadioButton alltimeradioButton;
        private System.Windows.Forms.DataGridView orderHistoryDataGridView;
        private Guna.UI2.WinForms.Guna2DataGridViewStyler guna2DataGridViewStyler1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label lblHiUsername;
    }
}