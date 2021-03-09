namespace Hospital_Management
{
    partial class LoginView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginView));
            this.Elipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.Login = new Guna.UI.WinForms.GunaPanel();
            this.dragpanel = new System.Windows.Forms.Panel();
            this.exitButton = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.GunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.GunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.lButton = new Guna.UI.WinForms.GunaGradientButton();
            this.textBox2 = new Guna.UI.WinForms.GunaTextBox();
            this.textBox1 = new Guna.UI.WinForms.GunaTextBox();
            this.DragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.Login.SuspendLayout();
            this.SuspendLayout();
            // 
            // Elipse1
            // 
            this.Elipse1.TargetControl = this;
            // 
            // Login
            // 
            this.Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(72)))), ((int)(((byte)(114)))));
            this.Login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Login.Controls.Add(this.dragpanel);
            this.Login.Controls.Add(this.exitButton);
            this.Login.Controls.Add(this.gunaLabel2);
            this.Login.Controls.Add(this.GunaLabel1);
            this.Login.Controls.Add(this.panel1);
            this.Login.Controls.Add(this.GunaButton1);
            this.Login.Controls.Add(this.lButton);
            this.Login.Controls.Add(this.textBox2);
            this.Login.Controls.Add(this.textBox1);
            this.Login.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Login.Location = new System.Drawing.Point(0, 0);
            this.Login.Margin = new System.Windows.Forms.Padding(4);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(403, 529);
            this.Login.TabIndex = 1;
            this.Login.Paint += new System.Windows.Forms.PaintEventHandler(this.pnLogin_Paint);
            // 
            // dragpanel
            // 
            this.dragpanel.Location = new System.Drawing.Point(3, 3);
            this.dragpanel.Name = "dragpanel";
            this.dragpanel.Size = new System.Drawing.Size(321, 21);
            this.dragpanel.TabIndex = 14;
            // 
            // exitButton
            // 
            this.exitButton.AnimationHoverSpeed = 0.07F;
            this.exitButton.AnimationSpeed = 0.03F;
            this.exitButton.BackColor = System.Drawing.Color.Transparent;
            this.exitButton.BaseColor = System.Drawing.Color.Transparent;
            this.exitButton.BorderColor = System.Drawing.Color.Black;
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.exitButton.FocusedColor = System.Drawing.Color.Red;
            this.exitButton.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Image = null;
            this.exitButton.ImageSize = new System.Drawing.Size(20, 20);
            this.exitButton.Location = new System.Drawing.Point(330, 3);
            this.exitButton.Name = "exitButton";
            this.exitButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.exitButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.exitButton.OnHoverForeColor = System.Drawing.Color.White;
            this.exitButton.OnHoverImage = null;
            this.exitButton.OnPressedColor = System.Drawing.Color.Black;
            this.exitButton.Size = new System.Drawing.Size(73, 32);
            this.exitButton.TabIndex = 13;
            this.exitButton.Text = "X";
            this.exitButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.exitButton.UseTransfarantBackground = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gunaLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(176)))), ((int)(((byte)(242)))));
            this.gunaLabel2.Location = new System.Drawing.Point(56, 320);
            this.gunaLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(85, 23);
            this.gunaLabel2.TabIndex = 12;
            this.gunaLabel2.Text = "Password";
            // 
            // GunaLabel1
            // 
            this.GunaLabel1.AutoSize = true;
            this.GunaLabel1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.GunaLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(176)))), ((int)(((byte)(242)))));
            this.GunaLabel1.Location = new System.Drawing.Point(56, 218);
            this.GunaLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GunaLabel1.Name = "GunaLabel1";
            this.GunaLabel1.Size = new System.Drawing.Size(89, 23);
            this.GunaLabel1.TabIndex = 10;
            this.GunaLabel1.Text = "Username";
            this.GunaLabel1.Click += new System.EventHandler(this.GunaLabel1_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Location = new System.Drawing.Point(87, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(237, 177);
            this.panel1.TabIndex = 11;
            // 
            // GunaButton1
            // 
            this.GunaButton1.AnimationHoverSpeed = 0.07F;
            this.GunaButton1.AnimationSpeed = 0.03F;
            this.GunaButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(24)))), ((int)(((byte)(74)))));
            this.GunaButton1.BorderColor = System.Drawing.Color.Black;
            this.GunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.GunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.GunaButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.GunaButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(176)))), ((int)(((byte)(242)))));
            this.GunaButton1.Image = ((System.Drawing.Image)(resources.GetObject("GunaButton1.Image")));
            this.GunaButton1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.GunaButton1.ImageSize = new System.Drawing.Size(22, 22);
            this.GunaButton1.Location = new System.Drawing.Point(971, 47);
            this.GunaButton1.Margin = new System.Windows.Forms.Padding(4);
            this.GunaButton1.Name = "GunaButton1";
            this.GunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(24)))), ((int)(((byte)(74)))));
            this.GunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.GunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.GunaButton1.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("GunaButton1.OnHoverImage")));
            this.GunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.GunaButton1.Size = new System.Drawing.Size(125, 39);
            this.GunaButton1.TabIndex = 9;
            this.GunaButton1.Text = "Sign Up";
            // 
            // lButton
            // 
            this.lButton.AnimationHoverSpeed = 0.07F;
            this.lButton.AnimationSpeed = 0.03F;
            this.lButton.BackColor = System.Drawing.Color.Transparent;
            this.lButton.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(36)))), ((int)(((byte)(177)))));
            this.lButton.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(54)))), ((int)(((byte)(252)))));
            this.lButton.BorderColor = System.Drawing.Color.Black;
            this.lButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.lButton.FocusedColor = System.Drawing.Color.Empty;
            this.lButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lButton.ForeColor = System.Drawing.Color.White;
            this.lButton.Image = null;
            this.lButton.ImageSize = new System.Drawing.Size(20, 20);
            this.lButton.Location = new System.Drawing.Point(107, 428);
            this.lButton.Margin = new System.Windows.Forms.Padding(4);
            this.lButton.Name = "lButton";
            this.lButton.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.lButton.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.lButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.lButton.OnHoverForeColor = System.Drawing.Color.White;
            this.lButton.OnHoverImage = null;
            this.lButton.OnPressedColor = System.Drawing.Color.Black;
            this.lButton.Radius = 21;
            this.lButton.Size = new System.Drawing.Size(201, 50);
            this.lButton.TabIndex = 7;
            this.lButton.Text = "Login";
            this.lButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lButton.Click += new System.EventHandler(this.lButton_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Transparent;
            this.textBox2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(92)))));
            this.textBox2.BorderColor = System.Drawing.Color.Transparent;
            this.textBox2.BorderSize = 0;
            this.textBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox2.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(86)))));
            this.textBox2.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.textBox2.FocusedForeColor = System.Drawing.Color.White;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(48, 358);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '●';
            this.textBox2.Radius = 18;
            this.textBox2.Size = new System.Drawing.Size(318, 46);
            this.textBox2.TabIndex = 6;
            this.textBox2.UseSystemPasswordChar = true;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Transparent;
            this.textBox1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(92)))));
            this.textBox1.BorderColor = System.Drawing.Color.Transparent;
            this.textBox1.BorderSize = 0;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox1.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(86)))));
            this.textBox1.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.textBox1.FocusedForeColor = System.Drawing.Color.White;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(48, 256);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '\0';
            this.textBox1.Radius = 18;
            this.textBox1.Size = new System.Drawing.Size(318, 46);
            this.textBox1.TabIndex = 4;
            // 
            // DragControl1
            // 
            this.DragControl1.TargetControl = this.dragpanel;
            // 
            // LoginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 529);
            this.Controls.Add(this.Login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginView";
            this.Text = "Form1";
            this.Login.ResumeLayout(false);
            this.Login.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaElipse Elipse1;
        internal Guna.UI.WinForms.GunaPanel Login;
        internal Guna.UI.WinForms.GunaButton GunaButton1;
        internal Guna.UI.WinForms.GunaGradientButton lButton;
        internal Guna.UI.WinForms.GunaTextBox textBox2;
        internal Guna.UI.WinForms.GunaTextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        internal Guna.UI.WinForms.GunaLabel gunaLabel2;
        internal Guna.UI.WinForms.GunaLabel GunaLabel1;
        private Guna.UI.WinForms.GunaButton exitButton;
        private Guna.UI.WinForms.GunaDragControl DragControl1;
        private System.Windows.Forms.Panel dragpanel;
    }
}

