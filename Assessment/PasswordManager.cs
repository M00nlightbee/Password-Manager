using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assessment
{
	public partial class PasswordManager : Form
	{
		public string PasswordDisplay { get; set; }
		public string PasswordName { get; set; }
		public PasswordManager()
		{
			InitializeComponent();
		}

		private void backButton_Click(object sender, EventArgs e)
		{
			frmMain frmMain = new frmMain();
			frmMain.Show();
			this.Close();
		}

		private void PasswordManager_Load(object sender, EventArgs e)
		{
			// Use the passed values (if needed)
			if (!string.IsNullOrEmpty(PasswordDisplay))
			{
				// Display or process PasswordDisplay
			}

			if (!string.IsNullOrEmpty(PasswordName))
			{
				// Display or process PasswordName
			}
		}
	}
}
