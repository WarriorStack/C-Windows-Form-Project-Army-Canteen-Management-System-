namespace ArmyCanteenManagementSystemTyProject.Customer_Forms
{
    partial class CustomerBilling
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerBilling));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.SalesAmtpanel = new System.Windows.Forms.Panel();
            this.totalProductTextBox = new System.Windows.Forms.TextBox();
            this.AfterDiscountBillTextBox = new System.Windows.Forms.TextBox();
            this.totalBillTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CdsBillAmt = new System.Windows.Forms.Label();
            this.totalBilllabel = new System.Windows.Forms.Label();
            this.customerBillLabel = new System.Windows.Forms.Label();
            this.AvailableproductLabel = new System.Windows.Forms.Label();
            this.BottomBorderPanel = new System.Windows.Forms.Panel();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.productListGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.CustomerBillGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.addButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.updateButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.deleteButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.procedToPayButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.TypeComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblHiUsername = new System.Windows.Forms.Label();
            this.ProductImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.SalesAmtpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productListGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerBillGridView)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductImage)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchLabel
            // 
            this.SearchLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.SearchLabel.Location = new System.Drawing.Point(45, 185);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(76, 24);
            this.SearchLabel.TabIndex = 3;
            this.SearchLabel.Text = "Search";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextBox.Location = new System.Drawing.Point(143, 183);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(298, 26);
            this.searchTextBox.TabIndex = 4;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // SalesAmtpanel
            // 
            this.SalesAmtpanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SalesAmtpanel.Controls.Add(this.totalProductTextBox);
            this.SalesAmtpanel.Controls.Add(this.AfterDiscountBillTextBox);
            this.SalesAmtpanel.Controls.Add(this.totalBillTextBox);
            this.SalesAmtpanel.Controls.Add(this.label2);
            this.SalesAmtpanel.Controls.Add(this.CdsBillAmt);
            this.SalesAmtpanel.Controls.Add(this.totalBilllabel);
            this.SalesAmtpanel.Location = new System.Drawing.Point(420, 388);
            this.SalesAmtpanel.Name = "SalesAmtpanel";
            this.SalesAmtpanel.Size = new System.Drawing.Size(318, 201);
            this.SalesAmtpanel.TabIndex = 9;
            // 
            // totalProductTextBox
            // 
            this.totalProductTextBox.Enabled = false;
            this.totalProductTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalProductTextBox.Location = new System.Drawing.Point(174, 155);
            this.totalProductTextBox.Name = "totalProductTextBox";
            this.totalProductTextBox.Size = new System.Drawing.Size(127, 26);
            this.totalProductTextBox.TabIndex = 5;
            // 
            // AfterDiscountBillTextBox
            // 
            this.AfterDiscountBillTextBox.Enabled = false;
            this.AfterDiscountBillTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AfterDiscountBillTextBox.Location = new System.Drawing.Point(171, 88);
            this.AfterDiscountBillTextBox.Name = "AfterDiscountBillTextBox";
            this.AfterDiscountBillTextBox.Size = new System.Drawing.Size(130, 26);
            this.AfterDiscountBillTextBox.TabIndex = 4;
            // 
            // totalBillTextBox
            // 
            this.totalBillTextBox.Enabled = false;
            this.totalBillTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalBillTextBox.Location = new System.Drawing.Point(171, 20);
            this.totalBillTextBox.Name = "totalBillTextBox";
            this.totalBillTextBox.Size = new System.Drawing.Size(130, 26);
            this.totalBillTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.label2.Location = new System.Drawing.Point(13, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Total Product";
            // 
            // CdsBillAmt
            // 
            this.CdsBillAmt.AutoSize = true;
            this.CdsBillAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CdsBillAmt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.CdsBillAmt.Location = new System.Drawing.Point(13, 96);
            this.CdsBillAmt.Name = "CdsBillAmt";
            this.CdsBillAmt.Size = new System.Drawing.Size(135, 20);
            this.CdsBillAmt.TabIndex = 1;
            this.CdsBillAmt.Text = "After Discount Bill";
            // 
            // totalBilllabel
            // 
            this.totalBilllabel.AutoSize = true;
            this.totalBilllabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalBilllabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.totalBilllabel.Location = new System.Drawing.Point(13, 28);
            this.totalBilllabel.Name = "totalBilllabel";
            this.totalBilllabel.Size = new System.Drawing.Size(68, 20);
            this.totalBilllabel.TabIndex = 0;
            this.totalBilllabel.Text = "Total Bill";
            // 
            // customerBillLabel
            // 
            this.customerBillLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customerBillLabel.AutoSize = true;
            this.customerBillLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerBillLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.customerBillLabel.Location = new System.Drawing.Point(867, 287);
            this.customerBillLabel.Name = "customerBillLabel";
            this.customerBillLabel.Size = new System.Drawing.Size(152, 25);
            this.customerBillLabel.TabIndex = 11;
            this.customerBillLabel.Text = "Customer Bill";
            // 
            // AvailableproductLabel
            // 
            this.AvailableproductLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AvailableproductLabel.AutoSize = true;
            this.AvailableproductLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvailableproductLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.AvailableproductLabel.Location = new System.Drawing.Point(99, 287);
            this.AvailableproductLabel.Name = "AvailableproductLabel";
            this.AvailableproductLabel.Size = new System.Drawing.Size(197, 25);
            this.AvailableproductLabel.TabIndex = 12;
            this.AvailableproductLabel.Text = "Available Product";
            // 
            // BottomBorderPanel
            // 
            this.BottomBorderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.BottomBorderPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomBorderPanel.Location = new System.Drawing.Point(0, 689);
            this.BottomBorderPanel.Name = "BottomBorderPanel";
            this.BottomBorderPanel.Size = new System.Drawing.Size(1157, 25);
            this.BottomBorderPanel.TabIndex = 15;
            // 
            // printPreviewDialog
            // 
            this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog.Enabled = true;
            this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
            this.printPreviewDialog.Name = "printPreviewDialog";
            this.printPreviewDialog.Visible = false;
            // 
            // productListGridView
            // 
            this.productListGridView.AllowUserToAddRows = false;
            this.productListGridView.AllowUserToDeleteRows = false;
            this.productListGridView.AllowUserToResizeColumns = false;
            this.productListGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.productListGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.productListGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.productListGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.productListGridView.ColumnHeadersHeight = 35;
            this.productListGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productListGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.productListGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.productListGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.productListGridView.Location = new System.Drawing.Point(0, 329);
            this.productListGridView.Name = "productListGridView";
            this.productListGridView.ReadOnly = true;
            this.productListGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productListGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.productListGridView.RowHeadersVisible = false;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productListGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.productListGridView.RowTemplate.Height = 33;
            this.productListGridView.ShowCellToolTips = false;
            this.productListGridView.Size = new System.Drawing.Size(412, 345);
            this.productListGridView.TabIndex = 211;
            this.productListGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.productListGridView.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productListGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.productListGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.productListGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.productListGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.productListGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.productListGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.productListGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.productListGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productListGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.productListGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.productListGridView.ThemeStyle.HeaderStyle.Height = 35;
            this.productListGridView.ThemeStyle.ReadOnly = true;
            this.productListGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.productListGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.productListGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productListGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.productListGridView.ThemeStyle.RowsStyle.Height = 33;
            this.productListGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.productListGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.productListGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productListGridView_CellClick);
            // 
            // CustomerBillGridView
            // 
            this.CustomerBillGridView.AllowUserToAddRows = false;
            this.CustomerBillGridView.AllowUserToDeleteRows = false;
            this.CustomerBillGridView.AllowUserToResizeColumns = false;
            this.CustomerBillGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.CustomerBillGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.CustomerBillGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.CustomerBillGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.CustomerBillGridView.ColumnHeadersHeight = 35;
            this.CustomerBillGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CustomerBillGridView.DefaultCellStyle = dataGridViewCellStyle8;
            this.CustomerBillGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.CustomerBillGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CustomerBillGridView.Location = new System.Drawing.Point(744, 329);
            this.CustomerBillGridView.Name = "CustomerBillGridView";
            this.CustomerBillGridView.ReadOnly = true;
            this.CustomerBillGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CustomerBillGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.CustomerBillGridView.RowHeadersVisible = false;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerBillGridView.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.CustomerBillGridView.RowTemplate.Height = 33;
            this.CustomerBillGridView.ShowCellToolTips = false;
            this.CustomerBillGridView.Size = new System.Drawing.Size(412, 345);
            this.CustomerBillGridView.TabIndex = 212;
            this.CustomerBillGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.CustomerBillGridView.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerBillGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.CustomerBillGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.CustomerBillGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.CustomerBillGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.CustomerBillGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CustomerBillGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.CustomerBillGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.CustomerBillGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerBillGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.CustomerBillGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.CustomerBillGridView.ThemeStyle.HeaderStyle.Height = 35;
            this.CustomerBillGridView.ThemeStyle.ReadOnly = true;
            this.CustomerBillGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.CustomerBillGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.CustomerBillGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerBillGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.CustomerBillGridView.ThemeStyle.RowsStyle.Height = 33;
            this.CustomerBillGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CustomerBillGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.CustomerBillGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustomerBillGridView_CellContentClick);
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addButton.BorderRadius = 20;
            this.addButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.addButton.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.addButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.addButton.ImageSize = new System.Drawing.Size(22, 22);
            this.addButton.Location = new System.Drawing.Point(491, 164);
            this.addButton.Name = "addButton";
            this.addButton.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.addButton.Size = new System.Drawing.Size(199, 45);
            this.addButton.TabIndex = 214;
            this.addButton.Text = "Add Item";
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.updateButton.BorderRadius = 20;
            this.updateButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.updateButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.updateButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.updateButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.updateButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.updateButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.updateButton.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.updateButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.ForeColor = System.Drawing.Color.White;
            this.updateButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.updateButton.ImageSize = new System.Drawing.Size(22, 22);
            this.updateButton.Location = new System.Drawing.Point(491, 233);
            this.updateButton.Name = "updateButton";
            this.updateButton.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.updateButton.Size = new System.Drawing.Size(199, 45);
            this.updateButton.TabIndex = 215;
            this.updateButton.Text = "Update Item";
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteButton.BorderRadius = 20;
            this.deleteButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.deleteButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.deleteButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.deleteButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.deleteButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.deleteButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.deleteButton.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.deleteButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.Color.White;
            this.deleteButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.deleteButton.ImageSize = new System.Drawing.Size(22, 22);
            this.deleteButton.Location = new System.Drawing.Point(491, 302);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.deleteButton.Size = new System.Drawing.Size(199, 45);
            this.deleteButton.TabIndex = 216;
            this.deleteButton.Text = "Delete Item";
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // procedToPayButton
            // 
            this.procedToPayButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.procedToPayButton.BorderRadius = 20;
            this.procedToPayButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.procedToPayButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.procedToPayButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.procedToPayButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.procedToPayButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.procedToPayButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.procedToPayButton.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.procedToPayButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.procedToPayButton.ForeColor = System.Drawing.Color.White;
            this.procedToPayButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.procedToPayButton.ImageSize = new System.Drawing.Size(22, 22);
            this.procedToPayButton.Location = new System.Drawing.Point(491, 629);
            this.procedToPayButton.Name = "procedToPayButton";
            this.procedToPayButton.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.procedToPayButton.Size = new System.Drawing.Size(199, 45);
            this.procedToPayButton.TabIndex = 217;
            this.procedToPayButton.Text = "Proced To Pay";
            this.procedToPayButton.Click += new System.EventHandler(this.procedToPayButton_Click);
            // 
            // TypeComboBox
            // 
            this.TypeComboBox.BackColor = System.Drawing.Color.Transparent;
            this.TypeComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.TypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypeComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TypeComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TypeComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TypeComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.TypeComboBox.ItemHeight = 30;
            this.TypeComboBox.Items.AddRange(new object[] {
            "All",
            "Toiletries",
            "Household Requisites",
            "General Items",
            "Watches & Stationery",
            "Liquor",
            "Food & Medicine"});
            this.TypeComboBox.Location = new System.Drawing.Point(143, 119);
            this.TypeComboBox.Name = "TypeComboBox";
            this.TypeComboBox.Size = new System.Drawing.Size(194, 36);
            this.TypeComboBox.TabIndex = 220;
            this.TypeComboBox.SelectedIndexChanged += new System.EventHandler(this.TypeComboBox_SelectedIndexChanged);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.guna2Panel1.Controls.Add(this.lblHiUsername);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1157, 80);
            this.guna2Panel1.TabIndex = 221;
            // 
            // lblHiUsername
            // 
            this.lblHiUsername.AutoSize = true;
            this.lblHiUsername.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHiUsername.ForeColor = System.Drawing.Color.White;
            this.lblHiUsername.Location = new System.Drawing.Point(42, 19);
            this.lblHiUsername.Name = "lblHiUsername";
            this.lblHiUsername.Size = new System.Drawing.Size(208, 38);
            this.lblHiUsername.TabIndex = 31;
            this.lblHiUsername.Text = "* Create Bill *";
            // 
            // ProductImage
            // 
            this.ProductImage.ImageRotate = 0F;
            this.ProductImage.Location = new System.Drawing.Point(744, 97);
            this.ProductImage.Name = "ProductImage";
            this.ProductImage.Size = new System.Drawing.Size(275, 165);
            this.ProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ProductImage.TabIndex = 222;
            this.ProductImage.TabStop = false;
            // 
            // CustomerBilling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1157, 714);
            this.Controls.Add(this.ProductImage);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.TypeComboBox);
            this.Controls.Add(this.procedToPayButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.CustomerBillGridView);
            this.Controls.Add(this.productListGridView);
            this.Controls.Add(this.BottomBorderPanel);
            this.Controls.Add(this.AvailableproductLabel);
            this.Controls.Add(this.customerBillLabel);
            this.Controls.Add(this.SalesAmtpanel);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.SearchLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerBilling";
            this.Text = "CusomerHome";
            this.SalesAmtpanel.ResumeLayout(false);
            this.SalesAmtpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productListGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerBillGridView)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Panel SalesAmtpanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label CdsBillAmt;
        private System.Windows.Forms.Label totalBilllabel;
        private System.Windows.Forms.TextBox totalProductTextBox;
        private System.Windows.Forms.TextBox AfterDiscountBillTextBox;
        private System.Windows.Forms.TextBox totalBillTextBox;
        private System.Windows.Forms.Label customerBillLabel;
        private System.Windows.Forms.Label AvailableproductLabel;
        private System.Windows.Forms.Panel BottomBorderPanel;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
        private Guna.UI2.WinForms.Guna2DataGridView productListGridView;
        private Guna.UI2.WinForms.Guna2DataGridView CustomerBillGridView;
        private Guna.UI2.WinForms.Guna2GradientButton addButton;
        private Guna.UI2.WinForms.Guna2GradientButton updateButton;
        private Guna.UI2.WinForms.Guna2GradientButton deleteButton;
        private Guna.UI2.WinForms.Guna2GradientButton procedToPayButton;
        private Guna.UI2.WinForms.Guna2ComboBox TypeComboBox;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label lblHiUsername;
        private Guna.UI2.WinForms.Guna2PictureBox ProductImage;
        private Guna.UI2.WinForms.Guna2DataGridViewStyler guna2DataGridViewStyler1;
    }
}