namespace TextFile
{
    partial class FrmLab1
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
			txtInput = new TextBox();
			btnCreate = new Button();
			SuspendLayout();
			// 
			// txtInput
			// 
			txtInput.Location = new Point(52, 51);
			txtInput.Multiline = true;
			txtInput.Name = "txtInput";
			txtInput.Size = new Size(260, 140);
			txtInput.TabIndex = 0;
			// 
			// btnCreate
			// 
			btnCreate.Location = new Point(97, 243);
			btnCreate.Name = "btnCreate";
			btnCreate.Size = new Size(165, 74);
			btnCreate.TabIndex = 1;
			btnCreate.Text = "Create";
			btnCreate.UseVisualStyleBackColor = true;
			btnCreate.Click += btnCreate_Click;
			// 
			// FrmLab1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(376, 344);
			Controls.Add(btnCreate);
			Controls.Add(txtInput);
			Name = "FrmLab1";
			Text = "Form1";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox txtInput;
		private Button btnCreate;
	}
}
