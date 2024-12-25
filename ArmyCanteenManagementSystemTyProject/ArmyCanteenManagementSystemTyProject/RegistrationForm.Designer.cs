namespace ArmyCanteenManagementSystemTyProject
{
    partial class RegistrationForm
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
            this.leftPanel = new System.Windows.Forms.Panel();
            this.backButton = new Guna.UI2.WinForms.Guna2Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnClose = new System.Windows.Forms.Button();
            this.registerButton = new Guna.UI2.WinForms.Guna2GradientButton();
            this.personalInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.UplodeButton = new Guna.UI2.WinForms.Guna2Button();
            this.CardImageBox = new Guna.UI2.WinForms.Guna2PictureBox();
            this.birthDatePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.mobileNuTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.cardNuTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.fullNameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.postComboBox = new System.Windows.Forms.ComboBox();
            this.cardNuLabel = new System.Windows.Forms.Label();
            this.ageLabel = new System.Windows.Forms.Label();
            this.mobleNuLabel = new System.Windows.Forms.Label();
            this.fullNamelabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.repassTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.passTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.repasslabel = new System.Windows.Forms.Label();
            this.passLabel = new System.Windows.Forms.Label();
            this.fullNameErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.mobileNuErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.ageErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.cardNuErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.passErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.repassErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.leftPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.personalInfoGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CardImageBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fullNameErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mobileNuErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardNuErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repassErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.leftPanel.Controls.Add(this.backButton);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(120, 604);
            this.leftPanel.TabIndex = 0;
            // 
            // backButton
            // 
            this.backButton.Animated = true;
            this.backButton.BackColor = System.Drawing.Color.Transparent;
            this.backButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.backButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.backButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.backButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.backButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.backButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.backButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.backButton.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.backButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.backButton.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.backButton.Location = new System.Drawing.Point(0, 0);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(120, 604);
            this.backButton.TabIndex = 17;
            this.backButton.Text = "Back To Login";
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.White;
            this.mainPanel.Controls.Add(this.guna2HtmlLabel1);
            this.mainPanel.Controls.Add(this.btnClose);
            this.mainPanel.Controls.Add(this.registerButton);
            this.mainPanel.Controls.Add(this.personalInfoGroupBox);
            this.mainPanel.Controls.Add(this.groupBox1);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(120, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(921, 604);
            this.mainPanel.TabIndex = 1;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(292, 12);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(301, 39);
            this.guna2HtmlLabel1.TabIndex = 152;
            this.guna2HtmlLabel1.Text = "Enter Your Details : ";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(174)))), ((int)(((byte)(75)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Transparent;
            this.btnClose.Location = new System.Drawing.Point(869, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 39);
            this.btnClose.TabIndex = 151;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // registerButton
            // 
            this.registerButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.registerButton.Animated = true;
            this.registerButton.AutoRoundedCorners = true;
            this.registerButton.BackColor = System.Drawing.Color.Transparent;
            this.registerButton.BorderRadius = 21;
            this.registerButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.registerButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.registerButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.registerButton.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.registerButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.registerButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.registerButton.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.registerButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerButton.ForeColor = System.Drawing.Color.White;
            this.registerButton.HoverState.FillColor = System.Drawing.Color.White;
            this.registerButton.HoverState.FillColor2 = System.Drawing.Color.White;
            this.registerButton.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.registerButton.IndicateFocus = true;
            this.registerButton.Location = new System.Drawing.Point(32, 548);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(858, 44);
            this.registerButton.TabIndex = 19;
            this.registerButton.Text = "Register";
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // personalInfoGroupBox
            // 
            this.personalInfoGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.personalInfoGroupBox.BackColor = System.Drawing.Color.White;
            this.personalInfoGroupBox.Controls.Add(this.UplodeButton);
            this.personalInfoGroupBox.Controls.Add(this.CardImageBox);
            this.personalInfoGroupBox.Controls.Add(this.birthDatePicker);
            this.personalInfoGroupBox.Controls.Add(this.mobileNuTextBox);
            this.personalInfoGroupBox.Controls.Add(this.cardNuTextBox);
            this.personalInfoGroupBox.Controls.Add(this.fullNameTextBox);
            this.personalInfoGroupBox.Controls.Add(this.label1);
            this.personalInfoGroupBox.Controls.Add(this.postComboBox);
            this.personalInfoGroupBox.Controls.Add(this.cardNuLabel);
            this.personalInfoGroupBox.Controls.Add(this.ageLabel);
            this.personalInfoGroupBox.Controls.Add(this.mobleNuLabel);
            this.personalInfoGroupBox.Controls.Add(this.fullNamelabel);
            this.personalInfoGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personalInfoGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.personalInfoGroupBox.Location = new System.Drawing.Point(6, 83);
            this.personalInfoGroupBox.Name = "personalInfoGroupBox";
            this.personalInfoGroupBox.Size = new System.Drawing.Size(905, 271);
            this.personalInfoGroupBox.TabIndex = 0;
            this.personalInfoGroupBox.TabStop = false;
            this.personalInfoGroupBox.Text = "Personal Information";
            // 
            // UplodeButton
            // 
            this.UplodeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UplodeButton.Animated = true;
            this.UplodeButton.AutoRoundedCorners = true;
            this.UplodeButton.BorderRadius = 28;
            this.UplodeButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.UplodeButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.UplodeButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.UplodeButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.UplodeButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.UplodeButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.UplodeButton.ForeColor = System.Drawing.Color.White;
            this.UplodeButton.HoverState.FillColor = System.Drawing.Color.White;
            this.UplodeButton.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.UplodeButton.IndicateFocus = true;
            this.UplodeButton.Location = new System.Drawing.Point(701, 174);
            this.UplodeButton.Name = "UplodeButton";
            this.UplodeButton.Size = new System.Drawing.Size(150, 58);
            this.UplodeButton.TabIndex = 19;
            this.UplodeButton.Text = "Upload Card Image";
            this.UplodeButton.Click += new System.EventHandler(this.UplodeButton_Click);
            // 
            // CardImageBox
            // 
            this.CardImageBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CardImageBox.BackColor = System.Drawing.Color.Transparent;
            this.CardImageBox.FillColor = System.Drawing.Color.DarkGray;
            this.CardImageBox.Image = global::ArmyCanteenManagementSystemTyProject.Properties.Resources.user;
            this.CardImageBox.ImageRotate = 0F;
            this.CardImageBox.Location = new System.Drawing.Point(684, 34);
            this.CardImageBox.Name = "CardImageBox";
            this.CardImageBox.Size = new System.Drawing.Size(183, 121);
            this.CardImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CardImageBox.TabIndex = 18;
            this.CardImageBox.TabStop = false;
            this.CardImageBox.UseTransparentBackground = true;
            // 
            // birthDatePicker
            // 
            this.birthDatePicker.Animated = true;
            this.birthDatePicker.AutoRoundedCorners = true;
            this.birthDatePicker.BackColor = System.Drawing.Color.Transparent;
            this.birthDatePicker.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.birthDatePicker.BorderRadius = 17;
            this.birthDatePicker.Checked = true;
            this.birthDatePicker.FillColor = System.Drawing.Color.White;
            this.birthDatePicker.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.birthDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.birthDatePicker.Location = new System.Drawing.Point(32, 144);
            this.birthDatePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.birthDatePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.birthDatePicker.Name = "birthDatePicker";
            this.birthDatePicker.Size = new System.Drawing.Size(297, 36);
            this.birthDatePicker.TabIndex = 17;
            this.birthDatePicker.Value = new System.DateTime(2024, 9, 10, 14, 30, 53, 128);
            // 
            // mobileNuTextBox
            // 
            this.mobileNuTextBox.Animated = true;
            this.mobileNuTextBox.AutoRoundedCorners = true;
            this.mobileNuTextBox.BackColor = System.Drawing.Color.White;
            this.mobileNuTextBox.BorderRadius = 15;
            this.mobileNuTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mobileNuTextBox.DefaultText = "";
            this.mobileNuTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.mobileNuTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.mobileNuTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.mobileNuTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.mobileNuTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.mobileNuTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mobileNuTextBox.ForeColor = System.Drawing.Color.Blue;
            this.mobileNuTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.mobileNuTextBox.Location = new System.Drawing.Point(350, 64);
            this.mobileNuTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.mobileNuTextBox.MaxLength = 10;
            this.mobileNuTextBox.Name = "mobileNuTextBox";
            this.mobileNuTextBox.PasswordChar = '\0';
            this.mobileNuTextBox.PlaceholderForeColor = System.Drawing.Color.Cyan;
            this.mobileNuTextBox.PlaceholderText = "Mobile Number";
            this.mobileNuTextBox.SelectedText = "";
            this.mobileNuTextBox.Size = new System.Drawing.Size(305, 33);
            this.mobileNuTextBox.TabIndex = 16;
            // 
            // cardNuTextBox
            // 
            this.cardNuTextBox.Animated = true;
            this.cardNuTextBox.AutoRoundedCorners = true;
            this.cardNuTextBox.BackColor = System.Drawing.Color.White;
            this.cardNuTextBox.BorderRadius = 15;
            this.cardNuTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cardNuTextBox.DefaultText = "";
            this.cardNuTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.cardNuTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.cardNuTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.cardNuTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.cardNuTextBox.Enabled = false;
            this.cardNuTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cardNuTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cardNuTextBox.ForeColor = System.Drawing.Color.Blue;
            this.cardNuTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cardNuTextBox.Location = new System.Drawing.Point(350, 147);
            this.cardNuTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.cardNuTextBox.Name = "cardNuTextBox";
            this.cardNuTextBox.PasswordChar = '\0';
            this.cardNuTextBox.PlaceholderForeColor = System.Drawing.Color.Cyan;
            this.cardNuTextBox.PlaceholderText = "Card Number";
            this.cardNuTextBox.SelectedText = "";
            this.cardNuTextBox.Size = new System.Drawing.Size(305, 33);
            this.cardNuTextBox.TabIndex = 15;
            // 
            // fullNameTextBox
            // 
            this.fullNameTextBox.Animated = true;
            this.fullNameTextBox.AutoRoundedCorners = true;
            this.fullNameTextBox.BackColor = System.Drawing.Color.White;
            this.fullNameTextBox.BorderRadius = 15;
            this.fullNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fullNameTextBox.DefaultText = "";
            this.fullNameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.fullNameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.fullNameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.fullNameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.fullNameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.fullNameTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.fullNameTextBox.ForeColor = System.Drawing.Color.Blue;
            this.fullNameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.fullNameTextBox.Location = new System.Drawing.Point(28, 64);
            this.fullNameTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.fullNameTextBox.Name = "fullNameTextBox";
            this.fullNameTextBox.PasswordChar = '\0';
            this.fullNameTextBox.PlaceholderForeColor = System.Drawing.Color.Cyan;
            this.fullNameTextBox.PlaceholderText = "Full Name";
            this.fullNameTextBox.SelectedText = "";
            this.fullNameTextBox.Size = new System.Drawing.Size(301, 33);
            this.fullNameTextBox.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Select Your Post";
            // 
            // postComboBox
            // 
            this.postComboBox.BackColor = System.Drawing.Color.White;
            this.postComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.postComboBox.FormattingEnabled = true;
            this.postComboBox.Items.AddRange(new object[] {
            "",
            "Admin",
            "Counter_Staff",
            "Customer",
            "Army_Officer",
            "Nevy_Officer",
            "Civil_Officer",
            "Supplier"});
            this.postComboBox.Location = new System.Drawing.Point(350, 218);
            this.postComboBox.Name = "postComboBox";
            this.postComboBox.Size = new System.Drawing.Size(305, 32);
            this.postComboBox.TabIndex = 5;
            // 
            // cardNuLabel
            // 
            this.cardNuLabel.AutoSize = true;
            this.cardNuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardNuLabel.Location = new System.Drawing.Point(350, 117);
            this.cardNuLabel.Name = "cardNuLabel";
            this.cardNuLabel.Size = new System.Drawing.Size(124, 24);
            this.cardNuLabel.TabIndex = 6;
            this.cardNuLabel.Text = "Card Number";
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageLabel.Location = new System.Drawing.Point(28, 117);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(90, 24);
            this.ageLabel.TabIndex = 4;
            this.ageLabel.Text = "Birth Date";
            // 
            // mobleNuLabel
            // 
            this.mobleNuLabel.AutoSize = true;
            this.mobleNuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobleNuLabel.Location = new System.Drawing.Point(346, 34);
            this.mobleNuLabel.Name = "mobleNuLabel";
            this.mobleNuLabel.Size = new System.Drawing.Size(141, 24);
            this.mobleNuLabel.TabIndex = 2;
            this.mobleNuLabel.Text = "Mobile Number";
            // 
            // fullNamelabel
            // 
            this.fullNamelabel.AutoSize = true;
            this.fullNamelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullNamelabel.Location = new System.Drawing.Point(28, 34);
            this.fullNamelabel.Name = "fullNamelabel";
            this.fullNamelabel.Size = new System.Drawing.Size(97, 24);
            this.fullNamelabel.TabIndex = 0;
            this.fullNamelabel.Text = "Full Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.repassTextBox);
            this.groupBox1.Controls.Add(this.passTextBox);
            this.groupBox1.Controls.Add(this.repasslabel);
            this.groupBox1.Controls.Add(this.passLabel);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.groupBox1.Location = new System.Drawing.Point(6, 372);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(903, 150);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Password ";
            // 
            // repassTextBox
            // 
            this.repassTextBox.Animated = true;
            this.repassTextBox.AutoRoundedCorners = true;
            this.repassTextBox.BorderRadius = 15;
            this.repassTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.repassTextBox.DefaultText = "";
            this.repassTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.repassTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.repassTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.repassTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.repassTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.repassTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.repassTextBox.ForeColor = System.Drawing.Color.Blue;
            this.repassTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.repassTextBox.Location = new System.Drawing.Point(368, 73);
            this.repassTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.repassTextBox.MaxLength = 4;
            this.repassTextBox.Name = "repassTextBox";
            this.repassTextBox.PasswordChar = '*';
            this.repassTextBox.PlaceholderForeColor = System.Drawing.Color.Cyan;
            this.repassTextBox.PlaceholderText = "Re-Enter Password";
            this.repassTextBox.SelectedText = "";
            this.repassTextBox.Size = new System.Drawing.Size(356, 33);
            this.repassTextBox.TabIndex = 18;
            // 
            // passTextBox
            // 
            this.passTextBox.Animated = true;
            this.passTextBox.AutoRoundedCorners = true;
            this.passTextBox.BorderRadius = 15;
            this.passTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passTextBox.DefaultText = "";
            this.passTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.passTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.passTextBox.ForeColor = System.Drawing.Color.Blue;
            this.passTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passTextBox.Location = new System.Drawing.Point(32, 73);
            this.passTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.passTextBox.MaxLength = 4;
            this.passTextBox.Name = "passTextBox";
            this.passTextBox.PasswordChar = '*';
            this.passTextBox.PlaceholderForeColor = System.Drawing.Color.Cyan;
            this.passTextBox.PlaceholderText = "Password";
            this.passTextBox.SelectedText = "";
            this.passTextBox.Size = new System.Drawing.Size(298, 33);
            this.passTextBox.TabIndex = 17;
            // 
            // repasslabel
            // 
            this.repasslabel.AutoSize = true;
            this.repasslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repasslabel.Location = new System.Drawing.Point(364, 43);
            this.repasslabel.Name = "repasslabel";
            this.repasslabel.Size = new System.Drawing.Size(172, 24);
            this.repasslabel.TabIndex = 2;
            this.repasslabel.Text = "Re-Enter Password";
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passLabel.Location = new System.Drawing.Point(28, 43);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(142, 24);
            this.passLabel.TabIndex = 0;
            this.passLabel.Text = "Enter Password";
            // 
            // fullNameErrorProvider
            // 
            this.fullNameErrorProvider.ContainerControl = this;
            // 
            // mobileNuErrorProvider
            // 
            this.mobileNuErrorProvider.ContainerControl = this;
            // 
            // ageErrorProvider
            // 
            this.ageErrorProvider.ContainerControl = this;
            // 
            // cardNuErrorProvider
            // 
            this.cardNuErrorProvider.ContainerControl = this;
            // 
            // passErrorProvider
            // 
            this.passErrorProvider.ContainerControl = this;
            // 
            // repassErrorProvider
            // 
            this.repassErrorProvider.ContainerControl = this;
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 604);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.leftPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistrationForm";
            this.leftPanel.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.personalInfoGroupBox.ResumeLayout(false);
            this.personalInfoGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CardImageBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fullNameErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mobileNuErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardNuErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repassErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.GroupBox personalInfoGroupBox;
        private System.Windows.Forms.Label fullNamelabel;
        private System.Windows.Forms.Label cardNuLabel;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.Label mobleNuLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label repasslabel;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox postComboBox;
        private System.Windows.Forms.ErrorProvider fullNameErrorProvider;
        private System.Windows.Forms.ErrorProvider mobileNuErrorProvider;
        private System.Windows.Forms.ErrorProvider ageErrorProvider;
        private System.Windows.Forms.ErrorProvider cardNuErrorProvider;
        private System.Windows.Forms.ErrorProvider passErrorProvider;
        private System.Windows.Forms.ErrorProvider repassErrorProvider;
        private Guna.UI2.WinForms.Guna2TextBox mobileNuTextBox;
        private Guna.UI2.WinForms.Guna2TextBox cardNuTextBox;
        private Guna.UI2.WinForms.Guna2TextBox fullNameTextBox;
        private Guna.UI2.WinForms.Guna2TextBox repassTextBox;
        private Guna.UI2.WinForms.Guna2TextBox passTextBox;
        private Guna.UI2.WinForms.Guna2GradientButton registerButton;
        private Guna.UI2.WinForms.Guna2Button backButton;
        private Guna.UI2.WinForms.Guna2DateTimePicker birthDatePicker;
        private Guna.UI2.WinForms.Guna2PictureBox CardImageBox;
        private Guna.UI2.WinForms.Guna2Button UplodeButton;
        private System.Windows.Forms.Button btnClose;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
    }
}