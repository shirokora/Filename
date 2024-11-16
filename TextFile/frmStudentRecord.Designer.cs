namespace TextFile
{
	partial class frmStudentRecord
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
			lvShowText = new ListView();
			btnRegister = new Button();
			btnFind = new Button();
			btnUpload = new Button();
			openFileDialog1 = new OpenFileDialog();
			label1 = new Label();
			SuspendLayout();
			// 
			// lvShowText
			// 
			lvShowText.Location = new Point(12, 59);
			lvShowText.Name = "lvShowText";
			lvShowText.Size = new Size(543, 308);
			lvShowText.TabIndex = 0;
			lvShowText.UseCompatibleStateImageBehavior = false;
			lvShowText.View = View.List;
			// 
			// btnRegister
			// 
			btnRegister.Location = new Point(571, 62);
			btnRegister.Name = "btnRegister";
			btnRegister.Size = new Size(154, 39);
			btnRegister.TabIndex = 1;
			btnRegister.Text = "Register";
			btnRegister.UseVisualStyleBackColor = true;
			btnRegister.Click += btnRegister_Click;
			// 
			// btnFind
			// 
			btnFind.Location = new Point(571, 107);
			btnFind.Name = "btnFind";
			btnFind.Size = new Size(154, 39);
			btnFind.TabIndex = 1;
			btnFind.Text = "Find";
			btnFind.UseVisualStyleBackColor = true;
			btnFind.Click += btnFind_Click;
			// 
			// btnUpload
			// 
			btnUpload.Location = new Point(571, 152);
			btnUpload.Name = "btnUpload";
			btnUpload.Size = new Size(154, 39);
			btnUpload.TabIndex = 1;
			btnUpload.Text = "Upload";
			btnUpload.UseVisualStyleBackColor = true;
			btnUpload.Click += btnUpload_Click;
			// 
			// openFileDialog1
			// 
			openFileDialog1.FileName = "openFileDialog1";
			openFileDialog1.FileOk += openFileDialog1_FileOk;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.Location = new Point(30, 9);
			label1.Name = "label1";
			label1.Size = new Size(179, 38);
			label1.TabIndex = 2;
			label1.Text = "View Record";
			// 
			// frmStudentRecord
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(737, 384);
			Controls.Add(label1);
			Controls.Add(btnUpload);
			Controls.Add(btnFind);
			Controls.Add(btnRegister);
			Controls.Add(lvShowText);
			Name = "frmStudentRecord";
			Text = "frmStudentRecord";
			Load += frmStudentRecord_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private ListView lvShowText;
		private Button btnRegister;
		private Button btnFind;
		private Button btnUpload;
		private OpenFileDialog openFileDialog1;
		private Label label1;
	}
}