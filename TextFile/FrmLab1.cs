namespace TextFile
{
	public partial class FrmLab1 : Form
	{
		public FrmLab1()
		{
			InitializeComponent();
		}

		private void btnCreate_Click(object sender, EventArgs e)
		{
			FrmFileName filename = new FrmFileName();
			filename.ShowDialog();
			string getInput = txtInput.Text;

			string docPath =
			Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
			using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath,
			FrmFileName.SetFileName)))
			{
				outputFile.WriteLine(getInput);
				Console.WriteLine(getInput);
			}
			MessageBox.Show("Successfully!");
			this.Close();
		}
	}
}
