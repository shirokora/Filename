using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TextFile
{
	public partial class FrmRegistration : Form
	{
		public FrmRegistration()
		{
			InitializeComponent();
		}
		
		
		private void btnRegister_Click(object sender, EventArgs e)
		{
			


			long studentno = long.Parse(txtstudentNo.Text);
			string studno = studentno.ToString();
			string fullname = txtLastName.Text + "," + txtFirstName.Text + "," + txtMI.Text;

			int Age = int.Parse(txtAge.Text);
			string age = Age.ToString(); 

			string program = cbProgram.Text;
			string gender = cbGender.Text;
			string date = dtpBirthday.Text;

			long contact = long.Parse(txtContactNo.Text);
			string cont = contact.ToString();


			string [] register =
			{
				"Student No. " + studno,
				"FullName. " + fullname,
				"Program "+ program,
				"Gender " + gender,
				"Date " + date,
				"ContactNo. " + cont
			};

			string docPath =
			Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
			using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath,
			studno +".txt")))
			{
				foreach (string final in register)
				{
					outputFile.WriteLine(final);
					Console.WriteLine(final);
				}
			}
			MessageBox.Show("Successfully!");

		}
	}
}
