namespace food_order
{
    partial class Form6
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
            this.txt_newpw = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txt_confirmpw = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btn_confirm = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // txt_newpw
            // 
            this.txt_newpw.Depth = 0;
            this.txt_newpw.Hint = "Enter New Password";
            this.txt_newpw.Location = new System.Drawing.Point(97, 175);
            this.txt_newpw.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_newpw.Name = "txt_newpw";
            this.txt_newpw.PasswordChar = '\0';
            this.txt_newpw.SelectedText = "";
            this.txt_newpw.SelectionLength = 0;
            this.txt_newpw.SelectionStart = 0;
            this.txt_newpw.Size = new System.Drawing.Size(186, 23);
            this.txt_newpw.TabIndex = 0;
            this.txt_newpw.UseSystemPasswordChar = false;
            // 
            // txt_confirmpw
            // 
            this.txt_confirmpw.Depth = 0;
            this.txt_confirmpw.Hint = "Confirm Password";
            this.txt_confirmpw.Location = new System.Drawing.Point(97, 229);
            this.txt_confirmpw.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_confirmpw.Name = "txt_confirmpw";
            this.txt_confirmpw.PasswordChar = '\0';
            this.txt_confirmpw.SelectedText = "";
            this.txt_confirmpw.SelectionLength = 0;
            this.txt_confirmpw.SelectionStart = 0;
            this.txt_confirmpw.Size = new System.Drawing.Size(186, 23);
            this.txt_confirmpw.TabIndex = 1;
            this.txt_confirmpw.UseSystemPasswordChar = false;
            // 
            // btn_confirm
            // 
            this.btn_confirm.Depth = 0;
            this.btn_confirm.Location = new System.Drawing.Point(139, 279);
            this.btn_confirm.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Primary = true;
            this.btn_confirm.Size = new System.Drawing.Size(98, 39);
            this.btn_confirm.TabIndex = 2;
            this.btn_confirm.Text = "Reset";
            this.btn_confirm.UseVisualStyleBackColor = true;
            this.btn_confirm.Click += new System.EventHandler(this.Btn_confirm_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.Black;
            this.materialLabel1.Location = new System.Drawing.Point(21, 84);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(38, 19);
            this.materialLabel1.TabIndex = 3;
            this.materialLabel1.Text = "Mail";
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 459);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.txt_confirmpw);
            this.Controls.Add(this.txt_newpw);
            this.Name = "Form6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RESET PASSWORD";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField txt_newpw;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_confirmpw;
        private MaterialSkin.Controls.MaterialRaisedButton btn_confirm;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}