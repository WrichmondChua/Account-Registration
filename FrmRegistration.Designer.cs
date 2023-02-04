
namespace Account_Registration
{
    partial class FrmRegistration
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Label_StudentNumber = new System.Windows.Forms.Label();
            this.Label_Program = new System.Windows.Forms.Label();
            this.txtbox_StudentNumber = new System.Windows.Forms.TextBox();
            this.ComboBox_Program = new System.Windows.Forms.ComboBox();
            this.Label_LastName = new System.Windows.Forms.Label();
            this.txtbox_LastName = new System.Windows.Forms.TextBox();
            this.Label_FirstName = new System.Windows.Forms.Label();
            this.txtbox_FirstName = new System.Windows.Forms.TextBox();
            this.Label_MiddleName = new System.Windows.Forms.Label();
            this.txtbox_MiddleName = new System.Windows.Forms.TextBox();
            this.Label_Age = new System.Windows.Forms.Label();
            this.txtbox_Age = new System.Windows.Forms.TextBox();
            this.Label_ContactNumber = new System.Windows.Forms.Label();
            this.txtbox_ContactNumber = new System.Windows.Forms.TextBox();
            this.Label_Address = new System.Windows.Forms.Label();
            this.txtbox_Address = new System.Windows.Forms.TextBox();
            this.btn_Next = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label_StudentNumber
            // 
            this.Label_StudentNumber.AutoSize = true;
            this.Label_StudentNumber.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label_StudentNumber.Location = new System.Drawing.Point(16, 9);
            this.Label_StudentNumber.Name = "Label_StudentNumber";
            this.Label_StudentNumber.Size = new System.Drawing.Size(90, 20);
            this.Label_StudentNumber.TabIndex = 0;
            this.Label_StudentNumber.Text = "Student No.:";
            this.Label_StudentNumber.Click += new System.EventHandler(this.label1_Click);
            // 
            // Label_Program
            // 
            this.Label_Program.AutoSize = true;
            this.Label_Program.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label_Program.Location = new System.Drawing.Point(183, 9);
            this.Label_Program.Name = "Label_Program";
            this.Label_Program.Size = new System.Drawing.Size(69, 20);
            this.Label_Program.TabIndex = 1;
            this.Label_Program.Text = "Program:";
            this.Label_Program.Click += new System.EventHandler(this.Program_Click);
            // 
            // txtbox_StudentNumber
            // 
            this.txtbox_StudentNumber.Location = new System.Drawing.Point(20, 32);
            this.txtbox_StudentNumber.Name = "txtbox_StudentNumber";
            this.txtbox_StudentNumber.Size = new System.Drawing.Size(148, 23);
            this.txtbox_StudentNumber.TabIndex = 2;
            // 
            // ComboBox_Program
            // 
            this.ComboBox_Program.FormattingEnabled = true;
            this.ComboBox_Program.Items.AddRange(new object[] {
            "BSIT"});
            this.ComboBox_Program.Location = new System.Drawing.Point(186, 32);
            this.ComboBox_Program.Name = "ComboBox_Program";
            this.ComboBox_Program.Size = new System.Drawing.Size(300, 23);
            this.ComboBox_Program.TabIndex = 3;
            // 
            // Label_LastName
            // 
            this.Label_LastName.AutoSize = true;
            this.Label_LastName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label_LastName.Location = new System.Drawing.Point(16, 69);
            this.Label_LastName.Name = "Label_LastName";
            this.Label_LastName.Size = new System.Drawing.Size(79, 20);
            this.Label_LastName.TabIndex = 4;
            this.Label_LastName.Text = "Last Name";
            this.Label_LastName.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txtbox_LastName
            // 
            this.txtbox_LastName.Location = new System.Drawing.Point(20, 92);
            this.txtbox_LastName.Name = "txtbox_LastName";
            this.txtbox_LastName.Size = new System.Drawing.Size(148, 23);
            this.txtbox_LastName.TabIndex = 5;
            // 
            // Label_FirstName
            // 
            this.Label_FirstName.AutoSize = true;
            this.Label_FirstName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label_FirstName.Location = new System.Drawing.Point(183, 69);
            this.Label_FirstName.Name = "Label_FirstName";
            this.Label_FirstName.Size = new System.Drawing.Size(80, 20);
            this.Label_FirstName.TabIndex = 6;
            this.Label_FirstName.Text = "First Name";
            this.Label_FirstName.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // txtbox_FirstName
            // 
            this.txtbox_FirstName.Location = new System.Drawing.Point(186, 92);
            this.txtbox_FirstName.Name = "txtbox_FirstName";
            this.txtbox_FirstName.Size = new System.Drawing.Size(186, 23);
            this.txtbox_FirstName.TabIndex = 7;
            // 
            // Label_MiddleName
            // 
            this.Label_MiddleName.AutoSize = true;
            this.Label_MiddleName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label_MiddleName.Location = new System.Drawing.Point(384, 69);
            this.Label_MiddleName.Name = "Label_MiddleName";
            this.Label_MiddleName.Size = new System.Drawing.Size(100, 20);
            this.Label_MiddleName.TabIndex = 8;
            this.Label_MiddleName.Text = "Middle Name";
            // 
            // txtbox_MiddleName
            // 
            this.txtbox_MiddleName.Location = new System.Drawing.Point(387, 92);
            this.txtbox_MiddleName.Name = "txtbox_MiddleName";
            this.txtbox_MiddleName.Size = new System.Drawing.Size(191, 23);
            this.txtbox_MiddleName.TabIndex = 9;
            this.txtbox_MiddleName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Label_Age
            // 
            this.Label_Age.AutoSize = true;
            this.Label_Age.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label_Age.Location = new System.Drawing.Point(16, 128);
            this.Label_Age.Name = "Label_Age";
            this.Label_Age.Size = new System.Drawing.Size(39, 20);
            this.Label_Age.TabIndex = 10;
            this.Label_Age.Text = "Age:";
            // 
            // txtbox_Age
            // 
            this.txtbox_Age.Location = new System.Drawing.Point(20, 151);
            this.txtbox_Age.Name = "txtbox_Age";
            this.txtbox_Age.Size = new System.Drawing.Size(148, 23);
            this.txtbox_Age.TabIndex = 11;
            // 
            // Label_ContactNumber
            // 
            this.Label_ContactNumber.AutoSize = true;
            this.Label_ContactNumber.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label_ContactNumber.Location = new System.Drawing.Point(183, 128);
            this.Label_ContactNumber.Name = "Label_ContactNumber";
            this.Label_ContactNumber.Size = new System.Drawing.Size(89, 20);
            this.Label_ContactNumber.TabIndex = 12;
            this.Label_ContactNumber.Text = "Contact.No.:";
            // 
            // txtbox_ContactNumber
            // 
            this.txtbox_ContactNumber.Location = new System.Drawing.Point(186, 151);
            this.txtbox_ContactNumber.Name = "txtbox_ContactNumber";
            this.txtbox_ContactNumber.Size = new System.Drawing.Size(184, 23);
            this.txtbox_ContactNumber.TabIndex = 13;
            // 
            // Label_Address
            // 
            this.Label_Address.AutoSize = true;
            this.Label_Address.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label_Address.Location = new System.Drawing.Point(17, 182);
            this.Label_Address.Name = "Label_Address";
            this.Label_Address.Size = new System.Drawing.Size(62, 20);
            this.Label_Address.TabIndex = 14;
            this.Label_Address.Text = "Address";
            // 
            // txtbox_Address
            // 
            this.txtbox_Address.Location = new System.Drawing.Point(20, 205);
            this.txtbox_Address.Multiline = true;
            this.txtbox_Address.Name = "txtbox_Address";
            this.txtbox_Address.Size = new System.Drawing.Size(568, 124);
            this.txtbox_Address.TabIndex = 15;
            // 
            // btn_Next
            // 
            this.btn_Next.Location = new System.Drawing.Point(232, 335);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(75, 32);
            this.btn_Next.TabIndex = 16;
            this.btn_Next.Text = "Next";
            this.btn_Next.UseVisualStyleBackColor = true;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.Location = new System.Drawing.Point(324, 335);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(75, 32);
            this.btn_Reset.TabIndex = 17;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // FrmRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 372);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.btn_Next);
            this.Controls.Add(this.txtbox_Address);
            this.Controls.Add(this.Label_Address);
            this.Controls.Add(this.txtbox_ContactNumber);
            this.Controls.Add(this.Label_ContactNumber);
            this.Controls.Add(this.txtbox_Age);
            this.Controls.Add(this.Label_Age);
            this.Controls.Add(this.txtbox_MiddleName);
            this.Controls.Add(this.Label_MiddleName);
            this.Controls.Add(this.txtbox_FirstName);
            this.Controls.Add(this.Label_FirstName);
            this.Controls.Add(this.txtbox_LastName);
            this.Controls.Add(this.Label_LastName);
            this.Controls.Add(this.ComboBox_Program);
            this.Controls.Add(this.txtbox_StudentNumber);
            this.Controls.Add(this.Label_Program);
            this.Controls.Add(this.Label_StudentNumber);
            this.Name = "FrmRegistration";
            this.Text = "FrmRegistration";
            this.Load += new System.EventHandler(this.FrmRegistration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_StudentNumber;
        private System.Windows.Forms.Label Label_Program;
        private System.Windows.Forms.TextBox txtbox_StudentNumber;
        private System.Windows.Forms.ComboBox ComboBox_Program;
        private System.Windows.Forms.Label Label_LastName;
        private System.Windows.Forms.TextBox txtbox_LastName;
        private System.Windows.Forms.Label Label_FirstName;
        private System.Windows.Forms.TextBox txtbox_FirstName;
        private System.Windows.Forms.Label Label_MiddleName;
        private System.Windows.Forms.TextBox txtbox_MiddleName;
        private System.Windows.Forms.Label Label_Age;
        private System.Windows.Forms.TextBox txtbox_Age;
        private System.Windows.Forms.Label Label_ContactNumber;
        private System.Windows.Forms.TextBox txtbox_ContactNumber;
        private System.Windows.Forms.Label Label_Address;
        private System.Windows.Forms.TextBox txtbox_Address;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.Button btn_Reset;
    }
}

