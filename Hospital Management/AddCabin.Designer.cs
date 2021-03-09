namespace Hospital_Management
{
    partial class AddCabin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCabin));
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.patNameBox = new Guna.UI.WinForms.GunaTextBox();
            this.docIDLabel = new Guna.UI.WinForms.GunaLabel();
            this.patComboBox = new Guna.UI.WinForms.GunaComboBox();
            this.saveButton = new Guna.UI.WinForms.GunaButton();
            this.statusLabel = new Guna.UI.WinForms.GunaLabel();
            this.statusBox = new Guna.UI.WinForms.GunaTextBox();
            this.nameLabel = new Guna.UI.WinForms.GunaLabel();
            this.ImageButton1 = new Guna.UI.WinForms.GunaImageButton();
            this.CategoryBox = new Guna.UI.WinForms.GunaTextBox();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.idLabel = new Guna.UI.WinForms.GunaLabel();
            this.idBox = new Guna.UI.WinForms.GunaTextBox();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.gunaLabel1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gunaLabel1.Location = new System.Drawing.Point(32, 354);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(94, 30);
            this.gunaLabel1.TabIndex = 24;
            this.gunaLabel1.Text = "P Name:";
            // 
            // patNameBox
            // 
            this.patNameBox.BackColor = System.Drawing.Color.Transparent;
            this.patNameBox.BaseColor = System.Drawing.Color.White;
            this.patNameBox.BorderColor = System.Drawing.Color.Silver;
            this.patNameBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.patNameBox.FocusedBaseColor = System.Drawing.Color.White;
            this.patNameBox.FocusedBorderColor = System.Drawing.Color.Transparent;
            this.patNameBox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.patNameBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.patNameBox.Location = new System.Drawing.Point(146, 348);
            this.patNameBox.Name = "patNameBox";
            this.patNameBox.PasswordChar = '\0';
            this.patNameBox.Radius = 17;
            this.patNameBox.ReadOnly = true;
            this.patNameBox.Size = new System.Drawing.Size(238, 43);
            this.patNameBox.TabIndex = 23;
            // 
            // docIDLabel
            // 
            this.docIDLabel.AutoSize = true;
            this.docIDLabel.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.docIDLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.docIDLabel.Location = new System.Drawing.Point(19, 286);
            this.docIDLabel.Name = "docIDLabel";
            this.docIDLabel.Size = new System.Drawing.Size(110, 30);
            this.docIDLabel.TabIndex = 22;
            this.docIDLabel.Text = "Patient ID:";
            // 
            // patComboBox
            // 
            this.patComboBox.BackColor = System.Drawing.Color.Transparent;
            this.patComboBox.BaseColor = System.Drawing.Color.White;
            this.patComboBox.BorderColor = System.Drawing.Color.Silver;
            this.patComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.patComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.patComboBox.FocusedColor = System.Drawing.Color.Empty;
            this.patComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.patComboBox.ForeColor = System.Drawing.Color.Black;
            this.patComboBox.FormattingEnabled = true;
            this.patComboBox.Location = new System.Drawing.Point(146, 285);
            this.patComboBox.Name = "patComboBox";
            this.patComboBox.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.patComboBox.OnHoverItemForeColor = System.Drawing.Color.White;
            this.patComboBox.Size = new System.Drawing.Size(238, 31);
            this.patComboBox.TabIndex = 21;
            this.patComboBox.SelectedIndexChanged += new System.EventHandler(this.patComboBox_SelectedIndexChanged);
            this.patComboBox.Click += new System.EventHandler(this.patComboBox_Click);
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
            this.saveButton.Location = new System.Drawing.Point(170, 442);
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
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.statusLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.statusLabel.Location = new System.Drawing.Point(51, 212);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(75, 30);
            this.statusLabel.TabIndex = 12;
            this.statusLabel.Text = "Status:";
            // 
            // statusBox
            // 
            this.statusBox.BackColor = System.Drawing.Color.Transparent;
            this.statusBox.BaseColor = System.Drawing.Color.White;
            this.statusBox.BorderColor = System.Drawing.Color.Silver;
            this.statusBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.statusBox.FocusedBaseColor = System.Drawing.Color.White;
            this.statusBox.FocusedBorderColor = System.Drawing.Color.Transparent;
            this.statusBox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.statusBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.statusBox.Location = new System.Drawing.Point(146, 206);
            this.statusBox.Name = "statusBox";
            this.statusBox.PasswordChar = '\0';
            this.statusBox.Radius = 17;
            this.statusBox.Size = new System.Drawing.Size(238, 43);
            this.statusBox.TabIndex = 11;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.nameLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.nameLabel.Location = new System.Drawing.Point(19, 139);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(107, 30);
            this.nameLabel.TabIndex = 10;
            this.nameLabel.Text = "Category:";
            // 
            // ImageButton1
            // 
            this.ImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.ImageButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ImageButton1.BackgroundImage")));
            this.ImageButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ImageButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ImageButton1.Image = null;
            this.ImageButton1.ImageSize = new System.Drawing.Size(64, 64);
            this.ImageButton1.Location = new System.Drawing.Point(381, 0);
            this.ImageButton1.Name = "ImageButton1";
            this.ImageButton1.OnHoverImage = null;
            this.ImageButton1.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.ImageButton1.Size = new System.Drawing.Size(52, 63);
            this.ImageButton1.TabIndex = 8;
            this.ImageButton1.Click += new System.EventHandler(this.ImageButton1_Click);
            // 
            // CategoryBox
            // 
            this.CategoryBox.BackColor = System.Drawing.Color.Transparent;
            this.CategoryBox.BaseColor = System.Drawing.Color.White;
            this.CategoryBox.BorderColor = System.Drawing.Color.Silver;
            this.CategoryBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CategoryBox.FocusedBaseColor = System.Drawing.Color.White;
            this.CategoryBox.FocusedBorderColor = System.Drawing.Color.Transparent;
            this.CategoryBox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.CategoryBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CategoryBox.Location = new System.Drawing.Point(146, 133);
            this.CategoryBox.Name = "CategoryBox";
            this.CategoryBox.PasswordChar = '\0';
            this.CategoryBox.Radius = 17;
            this.CategoryBox.Size = new System.Drawing.Size(238, 43);
            this.CategoryBox.TabIndex = 9;
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.idLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.idLabel.Location = new System.Drawing.Point(87, 68);
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
            this.idBox.Location = new System.Drawing.Point(146, 62);
            this.idBox.Name = "idBox";
            this.idBox.PasswordChar = '\0';
            this.idBox.Radius = 17;
            this.idBox.ReadOnly = true;
            this.idBox.Size = new System.Drawing.Size(238, 43);
            this.idBox.TabIndex = 7;
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.Controls.Add(this.gunaLabel1);
            this.gunaPanel1.Controls.Add(this.patNameBox);
            this.gunaPanel1.Controls.Add(this.docIDLabel);
            this.gunaPanel1.Controls.Add(this.patComboBox);
            this.gunaPanel1.Controls.Add(this.saveButton);
            this.gunaPanel1.Controls.Add(this.statusLabel);
            this.gunaPanel1.Controls.Add(this.statusBox);
            this.gunaPanel1.Controls.Add(this.nameLabel);
            this.gunaPanel1.Controls.Add(this.CategoryBox);
            this.gunaPanel1.Controls.Add(this.idLabel);
            this.gunaPanel1.Controls.Add(this.idBox);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 69);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(433, 525);
            this.gunaPanel1.TabIndex = 7;
            this.gunaPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.gunaPanel1_Paint);
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this.gunaLabel3;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.gunaLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(92)))));
            this.gunaLabel3.Location = new System.Drawing.Point(23, 9);
            this.gunaLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(361, 41);
            this.gunaLabel3.TabIndex = 6;
            this.gunaLabel3.Text = "Add/Edit Cabin Booking\r\n";
            this.gunaLabel3.Click += new System.EventHandler(this.gunaLabel3_Click);
            // 
            // AddCabin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 594);
            this.Controls.Add(this.ImageButton1);
            this.Controls.Add(this.gunaPanel1);
            this.Controls.Add(this.gunaLabel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddCabin";
            this.Text = "AddCabin";
            this.Load += new System.EventHandler(this.AddCabin_Load);
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaTextBox patNameBox;
        private Guna.UI.WinForms.GunaLabel docIDLabel;
        private Guna.UI.WinForms.GunaComboBox patComboBox;
        private Guna.UI.WinForms.GunaButton saveButton;
        private Guna.UI.WinForms.GunaLabel statusLabel;
        private Guna.UI.WinForms.GunaTextBox statusBox;
        private Guna.UI.WinForms.GunaLabel nameLabel;
        private Guna.UI.WinForms.GunaImageButton ImageButton1;
        private Guna.UI.WinForms.GunaTextBox CategoryBox;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaLabel idLabel;
        private Guna.UI.WinForms.GunaTextBox idBox;
        internal Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
    }
}