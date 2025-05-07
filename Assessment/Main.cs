using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Microsoft.VisualBasic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Assessment
{
	public partial class frmMain : Form
	{
		Image toggleOn;
		Image toggleOff;

		public frmMain()
		{
			InitializeComponent();
			toggleOn = Image.FromFile("SwitchOn.png");
			toggleOff = Image.FromFile("SwitchOff.png");
			llValue.Hide();
			ulValue.Hide();
			scValue.Hide();
			numValue.Hide();


		}

		//target pictureBox to toggle (https://stackoverflow.com/questions/13412605/get-picturebox-name)
		//public void toggle(object sender, EventArgs e)
		//{
		//    Character c = new Character();
		//    ArrayList password = new ArrayList();
		//    foreach (var item in $"{c.lowerCase}{c.upperCase}{c.number}{c.symbol}")
		//    {
		//        password.Add(item);
		//    };

		//    if (sender is PictureBox)
		//    {
		//        if (((PictureBox)sender).Image != toggleOn)
		//        {
		//            ((PictureBox)sender).Image = toggleOn;
		//        }
		//        else
		//        {
		//            ((PictureBox)sender).Image = toggleOff;
		//        }
		//    }

		//}

		private void swOne_MouseClick(object sender, MouseEventArgs e)
		{

			if (e.Button == MouseButtons.Left)
			{
				if (swOne.Image != toggleOn)
				{
					swOne.Image = toggleOn;
					llValue.Show();
				}
				else
				{
					swOne.Image = toggleOff;
					llValue.Clear();
					llValue.Hide();
				}
			}
		}

		private void swTwo_MouseClick(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				if (swTwo.Image != toggleOn)
				{
					swTwo.Image = toggleOn;
					ulValue.Show();
				}
				else
				{
					swTwo.Image = toggleOff;
					ulValue.Clear();
					ulValue.Hide();
				}
			}
		}

		private void swThree_MouseClick(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				if (swThree.Image != toggleOn)
				{
					swThree.Image = toggleOn;
					scValue.Show();
				}
				else
				{
					swThree.Image = toggleOff;
					scValue.Clear();
					scValue.Hide();
				}
			}
		}

		private void swFour_MouseClick(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				if (swFour.Image != toggleOn)
				{
					swFour.Image = toggleOn;
					numValue.Show();
				}
				else
				{
					swFour.Image = toggleOff;
					numValue.Clear();
					numValue.Hide();
				}
			}
		}
		private void btnPassword_Click(object sender, EventArgs e)
		{
			Character c = new Character();
			ArrayList password = new ArrayList();
			foreach (char item in $"{c.lowerCase}{c.upperCase}{c.number}{c.symbol}")
			{
				password.Add(item);
			}
			;

			//ordered password
			string oPassword = "";

			int llCase;
			while ((!int.TryParse(llValue.Text, out llCase) || llCase < 0 || llCase > c.lowerCase.Length) && llValue.Text.Length > 0)
			{
				MessageBox.Show($"Number of LOWER CASES is INVALID .\nENTER a valid integer between 1 and {c.lowerCase.Length}");
				break;
			}
			int ulCase;
			while ((!int.TryParse(ulValue.Text, out ulCase) || llCase < 0 || ulCase > c.upperCase.Length) && ulValue.Text.Length > 0)
			{
				MessageBox.Show($"Number of UPPER CASES is INVALID.\nENTER a valid integer between 1 and {c.upperCase.Length}");
				break;
			}
			int scCase;
			while ((!int.TryParse(scValue.Text, out scCase) || scCase < 0 || scCase > c.symbol.Length) && scValue.Text.Length > 0)
			{
				MessageBox.Show($"Number of SPECIAL CHARATERS is INVALID.\nENTER a valid integer between 1 and {c.symbol.Length}");
				break;
			}
			int numCase;
			while ((!int.TryParse(numValue.Text, out numCase) || numCase < 0 || numCase > c.number.Length) && numValue.Text.Length > 0)
			{
				MessageBox.Show($"Number of NUMBERS is INVALID.\nENTER a valid integer between 1 and {c.number.Length}");
				break;
			}

			//for (int i = 0; i < llCase - 1; i++)
			//{
			//	if (llCase < c.lowerCase.Length)
			//	{
			//		oPassword += $"{c.lowerCase[i]}";
			//		password.RemoveAt(i);
			//	}
			//}
			//for (int i = 0; i < ulCase - 1; i++)
			//{
			//	if (llCase < c.upperCase.Length)
			//	{
			//		oPassword += $"{c.upperCase[i]}";
			//		password.RemoveAt(i);
			//	}
			//}
			//for (int i = 0; i < scCase - 1; i++)
			//{
			//	if (llCase < c.symbol.Length)
			//	{
			//		oPassword += $"{c.symbol[i]}";
			//		password.RemoveAt(i);
			//	}
			//}
			//for (int i = 0; i < numCase - 1; i++)
			//{
			//	if (llCase < c.number.Length)
			//	{
			//		oPassword += $"{c.number[i]}";
			//		password.RemoveAt(i);
			//	}
			//}

			//int llCase;
			//int ulCase;
			//int scCase;
			//int numCase;

			//while ((!int.TryParse(llValue.Text, out llCase) || llCase < 0 || llCase > 6) && llValue.Text.Length > 0)
			//{
			//	MessageBox.Show($"Number of LOWER CASES is INVALID .\nENTER a valid integer between 1 and 6");
			//	break;
			//}

			//while ((!int.TryParse(ulValue.Text, out ulCase) || llCase < 0 || ulCase > 6) && ulValue.Text.Length > 0)
			//{
			//	MessageBox.Show($"Number of UPPER CASES is INVALID.\nENTER a valid integer between 1 and 6");
			//	break;
			//}

			//while ((!int.TryParse(scValue.Text, out scCase) || scCase < 0 || scCase > 7) && scValue.Text.Length > 0)
			//{
			//	MessageBox.Show($"Number of SPECIAL CHARATERS is INVALID.\nENTER a valid integer between 1 and 7");
			//	break;
			//}

			//while ((!int.TryParse(numValue.Text, out numCase) || numCase < 0 || numCase > 7) && numValue.Text.Length > 0)
			//{
			//	MessageBox.Show($"Number of NUMBERS is INVALID.\nENTER a valid integer between 1 and 7");
			//	break;
			//}

			for (int i = 0; i < llCase; i++)
			{
				if (llCase < c.lowerCase.Length)
				{
					oPassword += $"{c.lowerCase[i]}";
					password.RemoveAt(i);
				}
			}
			for (int i = 0; i < ulCase; i++)
			{
				if (ulCase < c.upperCase.Length)
				{
					oPassword += $"{c.upperCase[i]}";
					password.RemoveAt(i);
				}
			}
			for (int i = 0; i < scCase; i++)
			{
				if (scCase < c.symbol.Length)
				{
					oPassword += $"{c.symbol[i]}";
					password.RemoveAt(i);
				}
			}
			for (int i = 0; i < numCase; i++)
			{
				if (numCase < c.number.Length)
				{
					oPassword += $"{c.number[i]}";
					password.RemoveAt(i);
				}
			}

			//randomise password
			ArrayList GeneratedPassword = new ArrayList();

			foreach (char item in $"{oPassword}")
			{
				GeneratedPassword.Add(item);
			}

			string randPassword = "";

			Random r = new Random();

			while (GeneratedPassword.Count > 0)
			{
				int index = r.Next(0, GeneratedPassword.Count);
				randPassword += GeneratedPassword[index];
				GeneratedPassword.RemoveAt(index);
			}

			if (randPassword.Length <= 0)
			{
				MessageBox.Show("Choose at least 2 from the above to generate password");
			}
			else if (randPassword.Length > 26)
			{
				MessageBox.Show("Password too long Max Length is 26");
			}
			else
			{
				pwDisplay.Text = randPassword;
			}

			//show total length of password
			plValue.Text = Convert.ToString(llCase + ulCase + scCase + numCase);
		}


		private void Save_Click(object sender, EventArgs e)
		{
			string userInput = passwordName.Text;
			string passwordValue = pwDisplay.Text;

			// Check if the user input is empty
			if (string.IsNullOrWhiteSpace(userInput))
			{
				MessageBox.Show("Please enter a name for the password.");
				return;
			}

			PasswordManager passwordManager = new PasswordManager
			{
				PasswordDisplay = passwordValue,
				PasswordName = userInput
			};

			passwordManager.Show();
			this.Hide();

		}

		//private void pwHolder_Paint(object sender, PaintEventArgs e)
		//{

		//}
	}
}
