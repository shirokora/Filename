namespace TextFile
{
	partial class FrmFileName
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
			btnOkay = new Button();
			txtFileName = new TextBox();
			SuspendLayout();
			// 
			// btnOkay
			// 
			btnOkay.Location = new Point(136, 140);
			btnOkay.Name = "btnOkay";
			btnOkay.Size = new Size(135, 45);
			btnOkay.TabIndex = 0;
			btnOkay.Text = "Okay";
			btnOkay.UseVisualStyleBackColor = true;
			btnOkay.Click += btnOkay_Click;
			// 
			// txtFileName
			// 
			txtFileName.Location = new Point(31, 37);
			txtFileName.Multiline = true;
			txtFileName.Name = "txtFileName";
			txtFileName.Size = new Size(349, 45);
			txtFileName.TabIndex = 1;
			// 
			// FrmFileName
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(428, 197);
			Controls.Add(txtFileName);
			Controls.Add(btnOkay);
			Name = "FrmFileName";
			Text = "FrmFileName";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btnOkay;
		private TextBox txtFileName;
	}
}