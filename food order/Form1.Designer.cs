namespace food_order
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txt_username = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txt_password = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btn_login = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label_forgot = new MaterialSkin.Controls.MaterialLabel();
            this.label_signin = new MaterialSkin.Controls.MaterialLabel();
            this.check_showhide = new MaterialSkin.Controls.MaterialCheckBox();
            this.check_remember = new MaterialSkin.Controls.MaterialCheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_username
            // 
            this.txt_username.Depth = 0;
            this.txt_username.Hint = "Email";
            this.txt_username.Location = new System.Drawing.Point(70, 144);
            this.txt_username.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_username.Name = "txt_username";
            this.txt_username.PasswordChar = '\0';
            this.txt_username.SelectedText = "";
            this.txt_username.SelectionLength = 0;
            this.txt_username.SelectionStart = 0;
            this.txt_username.Size = new System.Drawing.Size(234, 23);
            this.txt_username.TabIndex = 0;
            this.txt_username.UseSystemPasswordChar = false;
            // 
            // txt_password
            // 
            this.txt_password.Depth = 0;
            this.txt_password.Hint = "Password";
            this.txt_password.Location = new System.Drawing.Point(70, 193);
            this.txt_password.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '\0';
            this.txt_password.SelectedText = "";
            this.txt_password.SelectionLength = 0;
            this.txt_password.SelectionStart = 0;
            this.txt_password.Size = new System.Drawing.Size(234, 23);
            this.txt_password.TabIndex = 1;
            this.txt_password.UseSystemPasswordChar = true;
            this.txt_password.Click += new System.EventHandler(this.Txt_password_Click);
            // 
            // btn_login
            // 
            this.btn_login.Depth = 0;
            this.btn_login.Location = new System.Drawing.Point(232, 252);
            this.btn_login.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_login.Name = "btn_login";
            this.btn_login.Primary = true;
            this.btn_login.Size = new System.Drawing.Size(72, 29);
            this.btn_login.TabIndex = 2;
            this.btn_login.Text = "LOGIN";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.Btn_login_Click);
            // 
            // label_forgot
            // 
            this.label_forgot.AutoSize = true;
            this.label_forgot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_forgot.Depth = 0;
            this.label_forgot.Font = new System.Drawing.Font("Roboto", 11F);
            this.label_forgot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label_forgot.Location = new System.Drawing.Point(64, 274);
            this.label_forgot.MouseState = MaterialSkin.MouseState.HOVER;
            this.label_forgot.Name = "label_forgot";
            this.label_forgot.Size = new System.Drawing.Size(147, 19);
            this.label_forgot.TabIndex = 4;
            this.label_forgot.Text = "forgotten password?";
            this.label_forgot.Click += new System.EventHandler(this.Label_forgot_Click);
            // 
            // label_signin
            // 
            this.label_signin.AutoSize = true;
            this.label_signin.Depth = 0;
            this.label_signin.Font = new System.Drawing.Font("Roboto", 11F);
            this.label_signin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label_signin.Location = new System.Drawing.Point(250, 300);
            this.label_signin.MouseState = MaterialSkin.MouseState.HOVER;
            this.label_signin.Name = "label_signin";
            this.label_signin.Size = new System.Drawing.Size(60, 19);
            this.label_signin.TabIndex = 5;
            this.label_signin.Text = "Sign Up";
            this.label_signin.Click += new System.EventHandler(this.Label_signin_Click);
            // 
            // check_showhide
            // 
            this.check_showhide.AutoSize = true;
            this.check_showhide.Depth = 0;
            this.check_showhide.Font = new System.Drawing.Font("Roboto", 10F);
            this.check_showhide.Location = new System.Drawing.Point(279, 189);
            this.check_showhide.Margin = new System.Windows.Forms.Padding(0);
            this.check_showhide.MouseLocation = new System.Drawing.Point(-1, -1);
            this.check_showhide.MouseState = MaterialSkin.MouseState.HOVER;
            this.check_showhide.Name = "check_showhide";
            this.check_showhide.Ripple = true;
            this.check_showhide.Size = new System.Drawing.Size(26, 30);
            this.check_showhide.TabIndex = 7;
            this.check_showhide.UseVisualStyleBackColor = true;
            this.check_showhide.CheckedChanged += new System.EventHandler(this.Check_showhide_CheckedChanged);
            // 
            // check_remember
            // 
            this.check_remember.AutoSize = true;
            this.check_remember.Depth = 0;
            this.check_remember.Font = new System.Drawing.Font("Roboto", 10F);
            this.check_remember.Location = new System.Drawing.Point(64, 229);
            this.check_remember.Margin = new System.Windows.Forms.Padding(0);
            this.check_remember.MouseLocation = new System.Drawing.Point(-1, -1);
            this.check_remember.MouseState = MaterialSkin.MouseState.HOVER;
            this.check_remember.Name = "check_remember";
            this.check_remember.Ripple = true;
            this.check_remember.Size = new System.Drawing.Size(120, 30);
            this.check_remember.TabIndex = 6;
            this.check_remember.Text = "Remember me";
            this.check_remember.UseVisualStyleBackColor = true;
            this.check_remember.CheckedChanged += new System.EventHandler(this.Check_remember_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(240, 333);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 459);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.check_showhide);
            this.Controls.Add(this.check_remember);
            this.Controls.Add(this.label_signin);
            this.Controls.Add(this.label_forgot);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_username);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField txt_username;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_password;
        private MaterialSkin.Controls.MaterialRaisedButton btn_login;
        private MaterialSkin.Controls.MaterialLabel label_forgot;
        private MaterialSkin.Controls.MaterialLabel label_signin;
        private MaterialSkin.Controls.MaterialCheckBox check_showhide;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialCheckBox check_remember;
    }
}

