namespace Assessment
{
	partial class PasswordManager
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
			backButton = new Button();
			listView1 = new ListView();
			SuspendLayout();
			// 
			// backButton
			// 
			backButton.Location = new Point(356, 43);
			backButton.Name = "backButton";
			backButton.Size = new Size(211, 65);
			backButton.TabIndex = 0;
			backButton.Text = "Generate New Password";
			backButton.UseVisualStyleBackColor = true;
			backButton.Click += backButton_Click;
			// 
			// listView1
			// 
			listView1.Location = new Point(85, 130);
			listView1.Name = "listView1";
			listView1.Size = new Size(813, 506);
			listView1.TabIndex = 1;
			listView1.UseCompatibleStateImageBehavior = false;
			// 
			// PasswordManager
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(962, 673);
			Controls.Add(listView1);
			Controls.Add(backButton);
			MaximizeBox = false;
			Name = "PasswordManager";
			Text = "Password Manager";
			ResumeLayout(false);
		}

		#endregion

		private Button backButton;
		private ListView listView1;
	}
}