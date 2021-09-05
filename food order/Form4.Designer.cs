namespace food_order
{
    partial class Form4
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
            this.admintab_controller = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.btn_delete = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialSingleLineTextField13 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txt_dispaly = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialSingleLineTextField12 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialSingleLineTextField10 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialSingleLineTextField11 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialSingleLineTextField9 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialSingleLineTextField7 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialSingleLineTextField8 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.panel1 = new System.Windows.Forms.Panel();
            this.materialSingleLineTextField6 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txt_neapolitan = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialSingleLineTextField1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialSingleLineTextField4 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialSingleLineTextField2 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialSingleLineTextField3 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.btn_logout = new MaterialSkin.Controls.MaterialRaisedButton();
            this.admintab_controller.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // admintab_controller
            // 
            this.admintab_controller.Controls.Add(this.tabPage1);
            this.admintab_controller.Controls.Add(this.tabPage2);
            this.admintab_controller.Controls.Add(this.tabPage3);
            this.admintab_controller.Depth = 0;
            this.admintab_controller.Location = new System.Drawing.Point(1, 104);
            this.admintab_controller.MouseState = MaterialSkin.MouseState.HOVER;
            this.admintab_controller.Name = "admintab_controller";
            this.admintab_controller.SelectedIndex = 0;
            this.admintab_controller.Size = new System.Drawing.Size(930, 517);
            this.admintab_controller.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.materialFlatButton1);
            this.tabPage1.Controls.Add(this.btn_delete);
            this.tabPage1.Controls.Add(this.materialSingleLineTextField13);
            this.tabPage1.Controls.Add(this.txt_dispaly);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(922, 491);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Client Edit";
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Location = new System.Drawing.Point(873, 446);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(41, 36);
            this.materialFlatButton1.TabIndex = 4;
            this.materialFlatButton1.Text = "EXIT";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.MaterialFlatButton1_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Depth = 0;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Location = new System.Drawing.Point(93, 425);
            this.btn_delete.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Primary = true;
            this.btn_delete.Size = new System.Drawing.Size(146, 39);
            this.btn_delete.TabIndex = 3;
            this.btn_delete.Text = "DELETE USER";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.Btn_delete_Click);
            // 
            // materialSingleLineTextField13
            // 
            this.materialSingleLineTextField13.Depth = 0;
            this.materialSingleLineTextField13.Hint = "ENTER AN EMAIL ADDRESS TO DELETE USER";
            this.materialSingleLineTextField13.Location = new System.Drawing.Point(7, 396);
            this.materialSingleLineTextField13.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField13.Name = "materialSingleLineTextField13";
            this.materialSingleLineTextField13.PasswordChar = '\0';
            this.materialSingleLineTextField13.SelectedText = "";
            this.materialSingleLineTextField13.SelectionLength = 0;
            this.materialSingleLineTextField13.SelectionStart = 0;
            this.materialSingleLineTextField13.Size = new System.Drawing.Size(320, 23);
            this.materialSingleLineTextField13.TabIndex = 2;
            this.materialSingleLineTextField13.UseSystemPasswordChar = false;
            // 
            // txt_dispaly
            // 
            this.txt_dispaly.Depth = 0;
            this.txt_dispaly.Location = new System.Drawing.Point(768, 361);
            this.txt_dispaly.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_dispaly.Name = "txt_dispaly";
            this.txt_dispaly.Primary = true;
            this.txt_dispaly.Size = new System.Drawing.Size(146, 39);
            this.txt_dispaly.TabIndex = 1;
            this.txt_dispaly.Text = "Refresh";
            this.txt_dispaly.UseVisualStyleBackColor = true;
            this.txt_dispaly.Click += new System.EventHandler(this.Txt_dispaly_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(919, 355);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(922, 491);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Price Update";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.materialRaisedButton1);
            this.panel2.Controls.Add(this.materialSingleLineTextField12);
            this.panel2.Controls.Add(this.materialSingleLineTextField10);
            this.panel2.Controls.Add(this.materialSingleLineTextField11);
            this.panel2.Controls.Add(this.materialSingleLineTextField9);
            this.panel2.Controls.Add(this.materialSingleLineTextField7);
            this.panel2.Controls.Add(this.materialSingleLineTextField8);
            this.panel2.Location = new System.Drawing.Point(445, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(447, 388);
            this.panel2.TabIndex = 1;
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(337, 339);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(75, 34);
            this.materialRaisedButton1.TabIndex = 12;
            this.materialRaisedButton1.Text = "update";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.MaterialRaisedButton1_Click);
            // 
            // materialSingleLineTextField12
            // 
            this.materialSingleLineTextField12.Depth = 0;
            this.materialSingleLineTextField12.Hint = "Rockstar New Price";
            this.materialSingleLineTextField12.Location = new System.Drawing.Point(51, 316);
            this.materialSingleLineTextField12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField12.Name = "materialSingleLineTextField12";
            this.materialSingleLineTextField12.PasswordChar = '\0';
            this.materialSingleLineTextField12.SelectedText = "";
            this.materialSingleLineTextField12.SelectionLength = 0;
            this.materialSingleLineTextField12.SelectionStart = 0;
            this.materialSingleLineTextField12.Size = new System.Drawing.Size(213, 23);
            this.materialSingleLineTextField12.TabIndex = 5;
            this.materialSingleLineTextField12.UseSystemPasswordChar = false;
            // 
            // materialSingleLineTextField10
            // 
            this.materialSingleLineTextField10.Depth = 0;
            this.materialSingleLineTextField10.Hint = "Cocacola New Price";
            this.materialSingleLineTextField10.Location = new System.Drawing.Point(51, 41);
            this.materialSingleLineTextField10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField10.Name = "materialSingleLineTextField10";
            this.materialSingleLineTextField10.PasswordChar = '\0';
            this.materialSingleLineTextField10.SelectedText = "";
            this.materialSingleLineTextField10.SelectionLength = 0;
            this.materialSingleLineTextField10.SelectionStart = 0;
            this.materialSingleLineTextField10.Size = new System.Drawing.Size(213, 23);
            this.materialSingleLineTextField10.TabIndex = 0;
            this.materialSingleLineTextField10.UseSystemPasswordChar = false;
            // 
            // materialSingleLineTextField11
            // 
            this.materialSingleLineTextField11.Depth = 0;
            this.materialSingleLineTextField11.Hint = "Redbull New Price";
            this.materialSingleLineTextField11.Location = new System.Drawing.Point(51, 261);
            this.materialSingleLineTextField11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField11.Name = "materialSingleLineTextField11";
            this.materialSingleLineTextField11.PasswordChar = '\0';
            this.materialSingleLineTextField11.SelectedText = "";
            this.materialSingleLineTextField11.SelectionLength = 0;
            this.materialSingleLineTextField11.SelectionStart = 0;
            this.materialSingleLineTextField11.Size = new System.Drawing.Size(213, 23);
            this.materialSingleLineTextField11.TabIndex = 4;
            this.materialSingleLineTextField11.UseSystemPasswordChar = false;
            // 
            // materialSingleLineTextField9
            // 
            this.materialSingleLineTextField9.Depth = 0;
            this.materialSingleLineTextField9.Hint = "Sprite New Price";
            this.materialSingleLineTextField9.Location = new System.Drawing.Point(51, 206);
            this.materialSingleLineTextField9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField9.Name = "materialSingleLineTextField9";
            this.materialSingleLineTextField9.PasswordChar = '\0';
            this.materialSingleLineTextField9.SelectedText = "";
            this.materialSingleLineTextField9.SelectionLength = 0;
            this.materialSingleLineTextField9.SelectionStart = 0;
            this.materialSingleLineTextField9.Size = new System.Drawing.Size(213, 23);
            this.materialSingleLineTextField9.TabIndex = 3;
            this.materialSingleLineTextField9.UseSystemPasswordChar = false;
            // 
            // materialSingleLineTextField7
            // 
            this.materialSingleLineTextField7.Depth = 0;
            this.materialSingleLineTextField7.Hint = "Monster New Price";
            this.materialSingleLineTextField7.Location = new System.Drawing.Point(51, 151);
            this.materialSingleLineTextField7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField7.Name = "materialSingleLineTextField7";
            this.materialSingleLineTextField7.PasswordChar = '\0';
            this.materialSingleLineTextField7.SelectedText = "";
            this.materialSingleLineTextField7.SelectionLength = 0;
            this.materialSingleLineTextField7.SelectionStart = 0;
            this.materialSingleLineTextField7.Size = new System.Drawing.Size(213, 23);
            this.materialSingleLineTextField7.TabIndex = 2;
            this.materialSingleLineTextField7.UseSystemPasswordChar = false;
            // 
            // materialSingleLineTextField8
            // 
            this.materialSingleLineTextField8.Depth = 0;
            this.materialSingleLineTextField8.Hint = "Pepsi New Price";
            this.materialSingleLineTextField8.Location = new System.Drawing.Point(51, 96);
            this.materialSingleLineTextField8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField8.Name = "materialSingleLineTextField8";
            this.materialSingleLineTextField8.PasswordChar = '\0';
            this.materialSingleLineTextField8.SelectedText = "";
            this.materialSingleLineTextField8.SelectionLength = 0;
            this.materialSingleLineTextField8.SelectionStart = 0;
            this.materialSingleLineTextField8.Size = new System.Drawing.Size(213, 23);
            this.materialSingleLineTextField8.TabIndex = 1;
            this.materialSingleLineTextField8.UseSystemPasswordChar = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.materialSingleLineTextField6);
            this.panel1.Controls.Add(this.txt_neapolitan);
            this.panel1.Controls.Add(this.materialSingleLineTextField1);
            this.panel1.Controls.Add(this.materialSingleLineTextField4);
            this.panel1.Controls.Add(this.materialSingleLineTextField2);
            this.panel1.Controls.Add(this.materialSingleLineTextField3);
            this.panel1.Location = new System.Drawing.Point(28, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 388);
            this.panel1.TabIndex = 0;
            // 
            // materialSingleLineTextField6
            // 
            this.materialSingleLineTextField6.Depth = 0;
            this.materialSingleLineTextField6.Hint = "Pizza Mushroom New Price";
            this.materialSingleLineTextField6.Location = new System.Drawing.Point(49, 316);
            this.materialSingleLineTextField6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField6.Name = "materialSingleLineTextField6";
            this.materialSingleLineTextField6.PasswordChar = '\0';
            this.materialSingleLineTextField6.SelectedText = "";
            this.materialSingleLineTextField6.SelectionLength = 0;
            this.materialSingleLineTextField6.SelectionStart = 0;
            this.materialSingleLineTextField6.Size = new System.Drawing.Size(213, 23);
            this.materialSingleLineTextField6.TabIndex = 5;
            this.materialSingleLineTextField6.UseSystemPasswordChar = false;
            // 
            // txt_neapolitan
            // 
            this.txt_neapolitan.Depth = 0;
            this.txt_neapolitan.Hint = "Pizza Neapolitan New Price";
            this.txt_neapolitan.Location = new System.Drawing.Point(49, 41);
            this.txt_neapolitan.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_neapolitan.Name = "txt_neapolitan";
            this.txt_neapolitan.PasswordChar = '\0';
            this.txt_neapolitan.SelectedText = "";
            this.txt_neapolitan.SelectionLength = 0;
            this.txt_neapolitan.SelectionStart = 0;
            this.txt_neapolitan.Size = new System.Drawing.Size(213, 23);
            this.txt_neapolitan.TabIndex = 0;
            this.txt_neapolitan.UseSystemPasswordChar = false;
            // 
            // materialSingleLineTextField1
            // 
            this.materialSingleLineTextField1.Depth = 0;
            this.materialSingleLineTextField1.Hint = "Pizza Pepperoni New Price";
            this.materialSingleLineTextField1.Location = new System.Drawing.Point(49, 96);
            this.materialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField1.Name = "materialSingleLineTextField1";
            this.materialSingleLineTextField1.PasswordChar = '\0';
            this.materialSingleLineTextField1.SelectedText = "";
            this.materialSingleLineTextField1.SelectionLength = 0;
            this.materialSingleLineTextField1.SelectionStart = 0;
            this.materialSingleLineTextField1.Size = new System.Drawing.Size(213, 23);
            this.materialSingleLineTextField1.TabIndex = 1;
            this.materialSingleLineTextField1.UseSystemPasswordChar = false;
            // 
            // materialSingleLineTextField4
            // 
            this.materialSingleLineTextField4.Depth = 0;
            this.materialSingleLineTextField4.Hint = "Pizza Mexican New Price";
            this.materialSingleLineTextField4.Location = new System.Drawing.Point(49, 261);
            this.materialSingleLineTextField4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField4.Name = "materialSingleLineTextField4";
            this.materialSingleLineTextField4.PasswordChar = '\0';
            this.materialSingleLineTextField4.SelectedText = "";
            this.materialSingleLineTextField4.SelectionLength = 0;
            this.materialSingleLineTextField4.SelectionStart = 0;
            this.materialSingleLineTextField4.Size = new System.Drawing.Size(213, 23);
            this.materialSingleLineTextField4.TabIndex = 4;
            this.materialSingleLineTextField4.UseSystemPasswordChar = false;
            // 
            // materialSingleLineTextField2
            // 
            this.materialSingleLineTextField2.Depth = 0;
            this.materialSingleLineTextField2.Hint = "Pizza Hawaiian New Price";
            this.materialSingleLineTextField2.Location = new System.Drawing.Point(49, 151);
            this.materialSingleLineTextField2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField2.Name = "materialSingleLineTextField2";
            this.materialSingleLineTextField2.PasswordChar = '\0';
            this.materialSingleLineTextField2.SelectedText = "";
            this.materialSingleLineTextField2.SelectionLength = 0;
            this.materialSingleLineTextField2.SelectionStart = 0;
            this.materialSingleLineTextField2.Size = new System.Drawing.Size(213, 23);
            this.materialSingleLineTextField2.TabIndex = 2;
            this.materialSingleLineTextField2.UseSystemPasswordChar = false;
            // 
            // materialSingleLineTextField3
            // 
            this.materialSingleLineTextField3.Depth = 0;
            this.materialSingleLineTextField3.Hint = "Pizza Seafood New Price";
            this.materialSingleLineTextField3.Location = new System.Drawing.Point(49, 206);
            this.materialSingleLineTextField3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField3.Name = "materialSingleLineTextField3";
            this.materialSingleLineTextField3.PasswordChar = '\0';
            this.materialSingleLineTextField3.SelectedText = "";
            this.materialSingleLineTextField3.SelectionLength = 0;
            this.materialSingleLineTextField3.SelectionStart = 0;
            this.materialSingleLineTextField3.Size = new System.Drawing.Size(213, 23);
            this.materialSingleLineTextField3.TabIndex = 3;
            this.materialSingleLineTextField3.UseSystemPasswordChar = false;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(922, 491);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Daily Report";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.admintab_controller;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(-5, 64);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(936, 34);
            this.materialTabSelector1.TabIndex = 1;
            this.materialTabSelector1.Text = "materialTabSelector1";
            this.materialTabSelector1.Click += new System.EventHandler(this.MaterialTabSelector1_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.Depth = 0;
            this.btn_logout.Location = new System.Drawing.Point(844, 35);
            this.btn_logout.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Primary = true;
            this.btn_logout.Size = new System.Drawing.Size(75, 23);
            this.btn_logout.TabIndex = 3;
            this.btn_logout.Text = "logout";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.Btn_logout_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 623);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.admintab_controller);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WELCOME (Admin view)";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.admintab_controller.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl admintab_controller;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialRaisedButton txt_dispaly;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialRaisedButton btn_delete;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField13;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private MaterialSkin.Controls.MaterialRaisedButton btn_logout;
        public MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField6;
        public MaterialSkin.Controls.MaterialSingleLineTextField txt_neapolitan;
        public MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField1;
        public MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField4;
        public MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField2;
        public MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField3;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private System.Windows.Forms.Panel panel2;
        public MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField12;
        public MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField10;
        public MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField11;
        public MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField9;
        public MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField7;
        public MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField8;
    }
}