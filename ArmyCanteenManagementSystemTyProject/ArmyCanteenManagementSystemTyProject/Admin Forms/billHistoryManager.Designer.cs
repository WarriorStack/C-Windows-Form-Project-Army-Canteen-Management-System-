namespace ArmyCanteenManagementSystemTyProject.Admin_Forms
{
    partial class billHistoryManager
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
            this.todayRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.alltimeRadioButton = new System.Windows.Forms.RadioButton();
            this.weakRadioButton = new System.Windows.Forms.RadioButton();
            this.billhistoryDataGridView = new System.Windows.Forms.DataGridView();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblHiUsername = new System.Windows.Forms.Label();
            this.SortByLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.billhistoryDataGridView)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // todayRadioButton
            // 
            this.todayRadioButton.AutoSize = true;
            this.todayRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todayRadioButton.Location = new System.Drawing.Point(44, 35);
            this.todayRadioButton.Name = "todayRadioButton";
            this.todayRadioButton.Size = new System.Drawing.Size(95, 29);
            this.todayRadioButton.TabIndex = 1;
            this.todayRadioButton.Text = "Today";
            this.todayRadioButton.UseVisualStyleBackColor = true;
            this.todayRadioButton.CheckedChanged += new System.EventHandler(this.todayRadioButton_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.alltimeRadioButton);
            this.groupBox1.Controls.Add(this.weakRadioButton);
            this.groupBox1.Controls.Add(this.todayRadioButton);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.groupBox1.Location = new System.Drawing.Point(0, 130);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(821, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // alltimeRadioButton
            // 
            this.alltimeRadioButton.AutoSize = true;
            this.alltimeRadioButton.Checked = true;
            this.alltimeRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alltimeRadioButton.Location = new System.Drawing.Point(655, 35);
            this.alltimeRadioButton.Name = "alltimeRadioButton";
            this.alltimeRadioButton.Size = new System.Drawing.Size(115, 29);
            this.alltimeRadioButton.TabIndex = 3;
            this.alltimeRadioButton.TabStop = true;
            this.alltimeRadioButton.Text = "All Time";
            this.alltimeRadioButton.UseVisualStyleBackColor = true;
            this.alltimeRadioButton.CheckedChanged += new System.EventHandler(this.alltimeRadioButton_CheckedChanged);
            // 
            // weakRadioButton
            // 
            this.weakRadioButton.AutoSize = true;
            this.weakRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weakRadioButton.Location = new System.Drawing.Point(320, 35);
            this.weakRadioButton.Name = "weakRadioButton";
            this.weakRadioButton.Size = new System.Drawing.Size(141, 29);
            this.weakRadioButton.TabIndex = 2;
            this.weakRadioButton.TabStop = true;
            this.weakRadioButton.Text = "This Weak";
            this.weakRadioButton.UseVisualStyleBackColor = true;
            this.weakRadioButton.CheckedChanged += new System.EventHandler(this.weakRadioButton_CheckedChanged);
            // 
            // billhistoryDataGridView
            // 
            this.billhistoryDataGridView.AllowUserToAddRows = false;
            this.billhistoryDataGridView.AllowUserToDeleteRows = false;
            this.billhistoryDataGridView.AllowUserToResizeColumns = false;
            this.billhistoryDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.billhistoryDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.billhistoryDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.billhistoryDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.billhistoryDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.billhistoryDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.billhistoryDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.billhistoryDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.billhistoryDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.billhistoryDataGridView.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.billhistoryDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.billhistoryDataGridView.EnableHeadersVisualStyles = false;
            this.billhistoryDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.billhistoryDataGridView.Location = new System.Drawing.Point(0, 236);
            this.billhistoryDataGridView.Name = "billhistoryDataGridView";
            this.billhistoryDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.billhistoryDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.billhistoryDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.billhistoryDataGridView.Size = new System.Drawing.Size(821, 234);
            this.billhistoryDataGridView.TabIndex = 3;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.guna2Panel1.Controls.Add(this.lblHiUsername);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(821, 80);
            this.guna2Panel1.TabIndex = 37;
            // 
            // lblHiUsername
            // 
            this.lblHiUsername.AutoSize = true;
            this.lblHiUsername.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHiUsername.ForeColor = System.Drawing.Color.White;
            this.lblHiUsername.Location = new System.Drawing.Point(18, 18);
            this.lblHiUsername.Name = "lblHiUsername";
            this.lblHiUsername.Size = new System.Drawing.Size(352, 35);
            this.lblHiUsername.TabIndex = 31;
            this.lblHiUsername.Text = "* All Customer Bill History *";
            // 
            // SortByLabel
            // 
            this.SortByLabel.AutoSize = true;
            this.SortByLabel.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SortByLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.SortByLabel.Location = new System.Drawing.Point(32, 92);
            this.SortByLabel.Name = "SortByLabel";
            this.SortByLabel.Size = new System.Drawing.Size(151, 35);
            this.SortByLabel.TabIndex = 32;
            this.SortByLabel.Text = "Sort By : -";
            // 
            // billHistoryManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(821, 470);
            this.Controls.Add(this.SortByLabel);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.billhistoryDataGridView);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "billHistoryManager";
            this.Text = "Bill History";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.billhistoryDataGridView)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton todayRadioButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton alltimeRadioButton;
        private System.Windows.Forms.RadioButton weakRadioButton;
        private System.Windows.Forms.DataGridView billhistoryDataGridView;
        private Guna.UI2.WinForms.Guna2DataGridViewStyler guna2DataGridViewStyler1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label lblHiUsername;
        private System.Windows.Forms.Label SortByLabel;
        private Guna.UI2.WinForms.Guna2DataGridViewStyler guna2DataGridViewStyler2;
    }
}