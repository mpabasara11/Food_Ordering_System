namespace food_order
{
    partial class Form5
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
            this.txt_email = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txt_code = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btn_send = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_verify = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // txt_email
            // 
            this.txt_email.Depth = 0;
            this.txt_email.Hint = "Enter Your Email ";
            this.txt_email.Location = new System.Drawing.Point(97, 150);
            this.txt_email.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_email.Name = "txt_email";
            this.txt_email.PasswordChar = '\0';
            this.txt_email.SelectedText = "";
            this.txt_email.SelectionLength = 0;
            this.txt_email.SelectionStart = 0;
            this.txt_email.Size = new System.Drawing.Size(186, 23);
            this.txt_email.TabIndex = 0;
            this.txt_email.UseSystemPasswordChar = false;
            // 
            // txt_code
            // 
            this.txt_code.Depth = 0;
            this.txt_code.Hint = "Enter Verification Code";
            this.txt_code.Location = new System.Drawing.Point(97, 274);
            this.txt_code.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_code.Name = "txt_code";
            this.txt_code.PasswordChar = '\0';
            this.txt_code.SelectedText = "";
            this.txt_code.SelectionLength = 0;
            this.txt_code.SelectionStart = 0;
            this.txt_code.Size = new System.Drawing.Size(186, 23);
            this.txt_code.TabIndex = 1;
            this.txt_code.UseSystemPasswordChar = false;
            // 
            // btn_send
            // 
            this.btn_send.Depth = 0;
            this.btn_send.Location = new System.Drawing.Point(137, 179);
            this.btn_send.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_send.Name = "btn_send";
            this.btn_send.Primary = true;
            this.btn_send.Size = new System.Drawing.Size(98, 39);
            this.btn_send.TabIndex = 2;
            this.btn_send.Text = "Send Code";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.Btn_send_Click);
            // 
            // btn_verify
            // 
            this.btn_verify.Depth = 0;
            this.btn_verify.Location = new System.Drawing.Point(137, 303);
            this.btn_verify.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_verify.Name = "btn_verify";
            this.btn_verify.Primary = true;
            this.btn_verify.Size = new System.Drawing.Size(98, 39);
            this.btn_verify.TabIndex = 3;
            this.btn_verify.Text = "Verify";
            this.btn_verify.UseVisualStyleBackColor = true;
            this.btn_verify.Click += new System.EventHandler(this.Btn_verify_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 459);
            this.Controls.Add(this.btn_verify);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.txt_code);
            this.Controls.Add(this.txt_email);
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField txt_email;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_code;
        private MaterialSkin.Controls.MaterialRaisedButton btn_send;
        private MaterialSkin.Controls.MaterialRaisedButton btn_verify;
    }
}