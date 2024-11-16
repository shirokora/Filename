namespace TextFile
{
	partial class FrmRegistration
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
			txtstudentNo = new TextBox();
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			txtLastName = new TextBox();
			txtAge = new TextBox();
			label5 = new Label();
			label6 = new Label();
			label7 = new Label();
			label8 = new Label();
			label9 = new Label();
			dtpBirthday = new DateTimePicker();
			cbProgram = new ComboBox();
			txtFirstName = new TextBox();
			txtMI = new TextBox();
			cbGender = new ComboBox();
			txtContactNo = new TextBox();
			btnRegister = new Button();
			btnrecord = new Button();
			SuspendLayout();
			// 
			// txtstudentNo
			// 
			txtstudentNo.Location = new Point(120, 31);
			txtstudentNo.Name = "txtstudentNo";
			txtstudentNo.Size = new Size(196, 27);
			txtstudentNo.TabIndex = 0;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(12, 34);
			label1.Name = "label1";
			label1.Size = new Size(87, 20);
			label1.TabIndex = 1;
			label1.Text = "Student No.";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(12, 98);
			label2.Name = "label2";
			label2.Size = new Size(79, 20);
			label2.TabIndex = 2;
			label2.Text = "Last Name";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(55, 154);
			label3.Name = "label3";
			label3.Size = new Size(36, 20);
			label3.TabIndex = 3;
			label3.Text = "Age";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(27, 223);
			label4.Name = "label4";
			label4.Size = new Size(64, 20);
			label4.TabIndex = 4;
			label4.Text = "Birthday";
			// 
			// txtLastName
			// 
			txtLastName.Location = new Point(120, 95);
			txtLastName.Name = "txtLastName";
			txtLastName.Size = new Size(196, 27);
			txtLastName.TabIndex = 0;
			// 
			// txtAge
			// 
			txtAge.Location = new Point(120, 154);
			txtAge.Name = "txtAge";
			txtAge.Size = new Size(154, 27);
			txtAge.TabIndex = 0;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(451, 38);
			label5.Name = "label5";
			label5.Size = new Size(66, 20);
			label5.TabIndex = 5;
			label5.Text = "Program";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(437, 102);
			label6.Name = "label6";
			label6.Size = new Size(80, 20);
			label6.TabIndex = 6;
			label6.Text = "First Name";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(460, 161);
			label7.Name = "label7";
			label7.Size = new Size(57, 20);
			label7.TabIndex = 7;
			label7.Text = "Gender";
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Location = new Point(430, 223);
			label8.Name = "label8";
			label8.Size = new Size(87, 20);
			label8.TabIndex = 8;
			label8.Text = "Contact No.";
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Location = new Point(715, 106);
			label9.Name = "label9";
			label9.Size = new Size(32, 20);
			label9.TabIndex = 9;
			label9.Text = "M.I.";
			// 
			// dtpBirthday
			// 
			dtpBirthday.Location = new Point(120, 218);
			dtpBirthday.Name = "dtpBirthday";
			dtpBirthday.Size = new Size(250, 27);
			dtpBirthday.TabIndex = 10;
			// 
			// cbProgram
			// 
			cbProgram.FormattingEnabled = true;
			cbProgram.Items.AddRange(new object[] { "BS information technology", "BS computer Science", "BS computer Engineering", "BS civil Engineering" });
			cbProgram.Location = new Point(523, 31);
			cbProgram.Name = "cbProgram";
			cbProgram.Size = new Size(307, 28);
			cbProgram.TabIndex = 11;
			// 
			// txtFirstName
			// 
			txtFirstName.Location = new Point(523, 98);
			txtFirstName.Name = "txtFirstName";
			txtFirstName.Size = new Size(175, 27);
			txtFirstName.TabIndex = 0;
			// 
			// txtMI
			// 
			txtMI.Location = new Point(753, 99);
			txtMI.Name = "txtMI";
			txtMI.Size = new Size(63, 27);
			txtMI.TabIndex = 0;
			// 
			// cbGender
			// 
			cbGender.FormattingEnabled = true;
			cbGender.Items.AddRange(new object[] { "Male", "Female" });
			cbGender.Location = new Point(523, 158);
			cbGender.Name = "cbGender";
			cbGender.Size = new Size(175, 28);
			cbGender.TabIndex = 11;
			// 
			// txtContactNo
			// 
			txtContactNo.Location = new Point(523, 218);
			txtContactNo.Name = "txtContactNo";
			txtContactNo.Size = new Size(224, 27);
			txtContactNo.TabIndex = 0;
			// 
			// btnRegister
			// 
			btnRegister.Location = new Point(333, 302);
			btnRegister.Name = "btnRegister";
			btnRegister.Size = new Size(184, 60);
			btnRegister.TabIndex = 12;
			btnRegister.Text = "Register";
			btnRegister.UseVisualStyleBackColor = true;
			btnRegister.Click += btnRegister_Click;
			// 
			// btnrecord
			// 
			btnrecord.Location = new Point(666, 317);
			btnrecord.Name = "btnrecord";
			btnrecord.Size = new Size(150, 45);
			btnrecord.TabIndex = 13;
			btnrecord.Text = "Records";
			btnrecord.UseVisualStyleBackColor = true;
			btnrecord.Click += btnrecord_Click;
			// 
			// FrmRegistration
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(866, 381);
			Controls.Add(btnrecord);
			Controls.Add(btnRegister);
			Controls.Add(cbGender);
			Controls.Add(cbProgram);
			Controls.Add(dtpBirthday);
			Controls.Add(label9);
			Controls.Add(label8);
			Controls.Add(label7);
			Controls.Add(label6);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(txtMI);
			Controls.Add(txtContactNo);
			Controls.Add(txtFirstName);
			Controls.Add(txtAge);
			Controls.Add(txtLastName);
			Controls.Add(txtstudentNo);
			Name = "FrmRegistration";
			Text = "FrmRegistration";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox txtstudentNo;
		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private TextBox txtLastName;
		private TextBox txtAge;
		private Label label5;
		private Label label6;
		private Label label7;
		private Label label8;
		private Label label9;
		private DateTimePicker dtpBirthday;
		private ComboBox cbProgram;
		private TextBox txtFirstName;
		private TextBox txtMI;
		private ComboBox cbGender;
		private TextBox txtContactNo;
		private Button btnRegister;
		private Button btnrecord;
	}
}