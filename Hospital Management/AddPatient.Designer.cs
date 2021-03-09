namespace Hospital_Management
{
    partial class AddPatient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPatient));
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.docNameBox = new Guna.UI.WinForms.GunaTextBox();
            this.docIDLabel = new Guna.UI.WinForms.GunaLabel();
            this.docComboBox = new Guna.UI.WinForms.GunaComboBox();
            this.phoneLabel = new Guna.UI.WinForms.GunaLabel();
            this.phoneBox = new Guna.UI.WinForms.GunaTextBox();
            this.saveButton = new Guna.UI.WinForms.GunaButton();
            this.addressLabel = new Guna.UI.WinForms.GunaLabel();
            this.addressBox = new Guna.UI.WinForms.GunaTextBox();
            this.datePicker = new Guna.UI.WinForms.GunaDateTimePicker();
            this.dateLabel = new Guna.UI.WinForms.GunaLabel();
            this.genderLabel = new Guna.UI.WinForms.GunaLabel();
            this.genderBox = new Guna.UI.WinForms.GunaTextBox();
            this.nameLabel = new Guna.UI.WinForms.GunaLabel();
            this.nameBox = new Guna.UI.WinForms.GunaTextBox();
            this.idLabel = new Guna.UI.WinForms.GunaLabel();
            this.idBox = new Guna.UI.WinForms.GunaTextBox();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.ImageButton1 = new Guna.UI.WinForms.GunaImageButton();
            this.gunaPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.gunaLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(92)))));
            this.gunaLabel3.Location = new System.Drawing.Point(89, 9);
            this.gunaLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(254, 41);
            this.gunaLabel3.TabIndex = 3;
            this.gunaLabel3.Text = "Add/Edit Patient\r\n";
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.Controls.Add(this.gunaLabel1);
            this.gunaPanel1.Controls.Add(this.docNameBox);
            this.gunaPanel1.Controls.Add(this.docIDLabel);
            this.gunaPanel1.Controls.Add(this.docComboBox);
            this.gunaPanel1.Controls.Add(this.phoneLabel);
            this.gunaPanel1.Controls.Add(this.phoneBox);
            this.gunaPanel1.Controls.Add(this.saveButton);
            this.gunaPanel1.Controls.Add(this.addressLabel);
            this.gunaPanel1.Controls.Add(this.addressBox);
            this.gunaPanel1.Controls.Add(this.datePicker);
            this.gunaPanel1.Controls.Add(this.dateLabel);
            this.gunaPanel1.Controls.Add(this.genderLabel);
            this.gunaPanel1.Controls.Add(this.genderBox);
            this.gunaPanel1.Controls.Add(this.nameLabel);
            this.gunaPanel1.Controls.Add(this.nameBox);
            this.gunaPanel1.Controls.Add(this.idLabel);
            this.gunaPanel1.Controls.Add(this.idBox);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 69);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(433, 525);
            this.gunaPanel1.TabIndex = 4;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.gunaLabel1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gunaLabel1.Location = new System.Drawing.Point(6, 409);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(120, 30);
            this.gunaLabel1.TabIndex = 24;
            this.gunaLabel1.Text = "Doc Name:";
            // 
            // docNameBox
            // 
            this.docNameBox.BackColor = System.Drawing.Color.Transparent;
            this.docNameBox.BaseColor = System.Drawing.Color.White;
            this.docNameBox.BorderColor = System.Drawing.Color.Silver;
            this.docNameBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.docNameBox.FocusedBaseColor = System.Drawing.Color.White;
            this.docNameBox.FocusedBorderColor = System.Drawing.Color.Transparent;
            this.docNameBox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.docNameBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.docNameBox.Location = new System.Drawing.Point(146, 403);
            this.docNameBox.Name = "docNameBox";
            this.docNameBox.PasswordChar = '\0';
            this.docNameBox.Radius = 17;
            this.docNameBox.ReadOnly = true;
            this.docNameBox.Size = new System.Drawing.Size(238, 43);
            this.docNameBox.TabIndex = 23;
            // 
            // docIDLabel
            // 
            this.docIDLabel.AutoSize = true;
            this.docIDLabel.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.docIDLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.docIDLabel.Location = new System.Drawing.Point(15, 362);
            this.docIDLabel.Name = "docIDLabel";
            this.docIDLabel.Size = new System.Drawing.Size(111, 30);
            this.docIDLabel.TabIndex = 22;
            this.docIDLabel.Text = "Doctor ID:";
            // 
            // docComboBox
            // 
            this.docComboBox.BackColor = System.Drawing.Color.Transparent;
            this.docComboBox.BaseColor = System.Drawing.Color.White;
            this.docComboBox.BorderColor = System.Drawing.Color.Silver;
            this.docComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.docComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.docComboBox.FocusedColor = System.Drawing.Color.Empty;
            this.docComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.docComboBox.ForeColor = System.Drawing.Color.Black;
            this.docComboBox.FormattingEnabled = true;
            this.docComboBox.Location = new System.Drawing.Point(146, 361);
            this.docComboBox.Name = "docComboBox";
            this.docComboBox.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.docComboBox.OnHoverItemForeColor = System.Drawing.Color.White;
            this.docComboBox.Size = new System.Drawing.Size(238, 31);
            this.docComboBox.TabIndex = 21;
            this.docComboBox.SelectedIndexChanged += new System.EventHandler(this.docComboBox_SelectedIndexChanged);
            this.docComboBox.Click += new System.EventHandler(this.docComboBox_Click);
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.phoneLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.phoneLabel.Location = new System.Drawing.Point(47, 226);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(79, 30);
            this.phoneLabel.TabIndex = 20;
            this.phoneLabel.Text = "Phone:";
            // 
            // phoneBox
            // 
            this.phoneBox.BackColor = System.Drawing.Color.Transparent;
            this.phoneBox.BaseColor = System.Drawing.Color.White;
            this.phoneBox.BorderColor = System.Drawing.Color.Silver;
            this.phoneBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.phoneBox.FocusedBaseColor = System.Drawing.Color.White;
            this.phoneBox.FocusedBorderColor = System.Drawing.Color.Transparent;
            this.phoneBox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.phoneBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.phoneBox.Location = new System.Drawing.Point(146, 220);
            this.phoneBox.Name = "phoneBox";
            this.phoneBox.PasswordChar = '\0';
            this.phoneBox.Radius = 17;
            this.phoneBox.Size = new System.Drawing.Size(238, 43);
            this.phoneBox.TabIndex = 19;
            // 
            // saveButton
            // 
            this.saveButton.AnimationHoverSpeed = 0.07F;
            this.saveButton.AnimationSpeed = 0.03F;
            this.saveButton.BackColor = System.Drawing.Color.Transparent;
            this.saveButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(92)))));
            this.saveButton.BorderColor = System.Drawing.Color.Black;
            this.saveButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.saveButton.FocusedColor = System.Drawing.Color.Empty;
            this.saveButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.saveButton.ForeColor = System.Drawing.Color.White;
            this.saveButton.Image = null;
            this.saveButton.ImageSize = new System.Drawing.Size(20, 20);
            this.saveButton.Location = new System.Drawing.Point(170, 467);
            this.saveButton.Name = "saveButton";
            this.saveButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.saveButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.saveButton.OnHoverForeColor = System.Drawing.Color.White;
            this.saveButton.OnHoverImage = null;
            this.saveButton.OnPressedColor = System.Drawing.Color.Black;
            this.saveButton.Radius = 12;
            this.saveButton.Size = new System.Drawing.Size(103, 31);
            this.saveButton.TabIndex = 18;
            this.saveButton.Text = "Save";
            this.saveButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.addressLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.addressLabel.Location = new System.Drawing.Point(30, 293);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(96, 30);
            this.addressLabel.TabIndex = 17;
            this.addressLabel.Text = "Address:";
            // 
            // addressBox
            // 
            this.addressBox.BackColor = System.Drawing.Color.Transparent;
            this.addressBox.BaseColor = System.Drawing.Color.White;
            this.addressBox.BorderColor = System.Drawing.Color.Silver;
            this.addressBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addressBox.FocusedBaseColor = System.Drawing.Color.White;
            this.addressBox.FocusedBorderColor = System.Drawing.Color.Transparent;
            this.addressBox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.addressBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.addressBox.Location = new System.Drawing.Point(146, 271);
            this.addressBox.MultiLine = true;
            this.addressBox.Name = "addressBox";
            this.addressBox.PasswordChar = '\0';
            this.addressBox.Radius = 17;
            this.addressBox.Size = new System.Drawing.Size(238, 74);
            this.addressBox.TabIndex = 16;
            // 
            // datePicker
            // 
            this.datePicker.BackColor = System.Drawing.Color.Transparent;
            this.datePicker.BaseColor = System.Drawing.Color.White;
            this.datePicker.BorderColor = System.Drawing.Color.Silver;
            this.datePicker.CustomFormat = "dd-MM-yyyy";
            this.datePicker.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.datePicker.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.datePicker.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.datePicker.ForeColor = System.Drawing.Color.Black;
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePicker.Location = new System.Drawing.Point(146, 180);
            this.datePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.datePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.datePicker.Name = "datePicker";
            this.datePicker.OnHoverBaseColor = System.Drawing.Color.White;
            this.datePicker.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.datePicker.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.datePicker.OnPressedColor = System.Drawing.Color.Black;
            this.datePicker.Radius = 5;
            this.datePicker.Size = new System.Drawing.Size(238, 30);
            this.datePicker.TabIndex = 15;
            this.datePicker.Text = "27-12-2019";
            this.datePicker.Value = new System.DateTime(2019, 12, 27, 21, 32, 11, 591);
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.dateLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dateLabel.Location = new System.Drawing.Point(67, 180);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(59, 30);
            this.dateLabel.TabIndex = 14;
            this.dateLabel.Text = "DoB:";
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.genderLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.genderLabel.Location = new System.Drawing.Point(36, 132);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(90, 30);
            this.genderLabel.TabIndex = 12;
            this.genderLabel.Text = "Gender:";
            // 
            // genderBox
            // 
            this.genderBox.BackColor = System.Drawing.Color.Transparent;
            this.genderBox.BaseColor = System.Drawing.Color.White;
            this.genderBox.BorderColor = System.Drawing.Color.Silver;
            this.genderBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.genderBox.FocusedBaseColor = System.Drawing.Color.White;
            this.genderBox.FocusedBorderColor = System.Drawing.Color.Transparent;
            this.genderBox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.genderBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.genderBox.Location = new System.Drawing.Point(146, 126);
            this.genderBox.Name = "genderBox";
            this.genderBox.PasswordChar = '\0';
            this.genderBox.Radius = 17;
            this.genderBox.Size = new System.Drawing.Size(238, 43);
            this.genderBox.TabIndex = 11;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.nameLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.nameLabel.Location = new System.Drawing.Point(50, 76);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(76, 30);
            this.nameLabel.TabIndex = 10;
            this.nameLabel.Text = "Name:";
            // 
            // nameBox
            // 
            this.nameBox.BackColor = System.Drawing.Color.Transparent;
            this.nameBox.BaseColor = System.Drawing.Color.White;
            this.nameBox.BorderColor = System.Drawing.Color.Silver;
            this.nameBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nameBox.FocusedBaseColor = System.Drawing.Color.White;
            this.nameBox.FocusedBorderColor = System.Drawing.Color.Transparent;
            this.nameBox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.nameBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nameBox.Location = new System.Drawing.Point(146, 70);
            this.nameBox.Name = "nameBox";
            this.nameBox.PasswordChar = '\0';
            this.nameBox.Radius = 17;
            this.nameBox.Size = new System.Drawing.Size(238, 43);
            this.nameBox.TabIndex = 9;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.idLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.idLabel.Location = new System.Drawing.Point(87, 20);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(39, 30);
            this.idLabel.TabIndex = 8;
            this.idLabel.Text = "ID:";
            // 
            // idBox
            // 
            this.idBox.BackColor = System.Drawing.Color.Transparent;
            this.idBox.BaseColor = System.Drawing.Color.White;
            this.idBox.BorderColor = System.Drawing.Color.Silver;
            this.idBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.idBox.FocusedBaseColor = System.Drawing.Color.White;
            this.idBox.FocusedBorderColor = System.Drawing.Color.Transparent;
            this.idBox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.idBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.idBox.Location = new System.Drawing.Point(146, 14);
            this.idBox.Name = "idBox";
            this.idBox.PasswordChar = '\0';
            this.idBox.Radius = 17;
            this.idBox.ReadOnly = true;
            this.idBox.Size = new System.Drawing.Size(238, 43);
            this.idBox.TabIndex = 7;
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this;
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this.gunaLabel3;
            // 
            // ImageButton1
            // 
            this.ImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.ImageButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ImageButton1.BackgroundImage")));
            this.ImageButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ImageButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ImageButton1.Image = null;
            this.ImageButton1.ImageSize = new System.Drawing.Size(64, 64);
            this.ImageButton1.Location = new System.Drawing.Point(369, -1);
            this.ImageButton1.Name = "ImageButton1";
            this.ImageButton1.OnHoverImage = null;
            this.ImageButton1.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.ImageButton1.Size = new System.Drawing.Size(64, 64);
            this.ImageButton1.TabIndex = 5;
            this.ImageButton1.Click += new System.EventHandler(this.gunaImageButton1_Click);
            // 
            // AddPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 594);
            this.Controls.Add(this.ImageButton1);
            this.Controls.Add(this.gunaPanel1);
            this.Controls.Add(this.gunaLabel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddPatient";
            this.Text = "AddPatient";
            this.Load += new System.EventHandler(this.AddPatient_Load);
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaLabel nameLabel;
        private Guna.UI.WinForms.GunaTextBox nameBox;
        private Guna.UI.WinForms.GunaLabel idLabel;
        private Guna.UI.WinForms.GunaTextBox idBox;
        private Guna.UI.WinForms.GunaDateTimePicker datePicker;
        private Guna.UI.WinForms.GunaLabel dateLabel;
        private Guna.UI.WinForms.GunaLabel genderLabel;
        private Guna.UI.WinForms.GunaTextBox genderBox;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaLabel addressLabel;
        private Guna.UI.WinForms.GunaTextBox addressBox;
        private Guna.UI.WinForms.GunaButton saveButton;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        private Guna.UI.WinForms.GunaImageButton ImageButton1;
        private Guna.UI.WinForms.GunaLabel phoneLabel;
        private Guna.UI.WinForms.GunaTextBox phoneBox;
        private Guna.UI.WinForms.GunaLabel docIDLabel;
        private Guna.UI.WinForms.GunaComboBox docComboBox;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaTextBox docNameBox;
    }
}