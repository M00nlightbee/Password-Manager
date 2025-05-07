namespace Assessment
{
    partial class frmMain
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
			topBoard = new Panel();
			lbTitle = new Label();
			logo = new PictureBox();
			logoName = new Label();
			swOne = new PictureBox();
			swTwo = new PictureBox();
			swThree = new PictureBox();
			swFour = new PictureBox();
			lbLower = new Label();
			lbUpper = new Label();
			lbSymbol = new Label();
			lbNumber = new Label();
			plLabel = new Label();
			llValue = new TextBox();
			btnPassword = new Button();
			ulValue = new TextBox();
			scValue = new TextBox();
			numValue = new TextBox();
			plHolder = new Panel();
			plValue = new Label();
			pwDisplay = new Label();
			pwHolder = new Panel();
			topBoard.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)logo).BeginInit();
			((System.ComponentModel.ISupportInitialize)swOne).BeginInit();
			((System.ComponentModel.ISupportInitialize)swTwo).BeginInit();
			((System.ComponentModel.ISupportInitialize)swThree).BeginInit();
			((System.ComponentModel.ISupportInitialize)swFour).BeginInit();
			plHolder.SuspendLayout();
			pwHolder.SuspendLayout();
			SuspendLayout();
			// 
			// topBoard
			// 
			topBoard.BackColor = Color.Black;
			topBoard.Controls.Add(lbTitle);
			topBoard.Controls.Add(logo);
			topBoard.Controls.Add(logoName);
			topBoard.Location = new Point(0, 0);
			topBoard.Name = "topBoard";
			topBoard.Size = new Size(965, 141);
			topBoard.TabIndex = 0;
			// 
			// lbTitle
			// 
			lbTitle.AutoSize = true;
			lbTitle.Font = new Font("Sitka Heading", 18F, FontStyle.Regular, GraphicsUnit.Point);
			lbTitle.ForeColor = Color.White;
			lbTitle.Location = new Point(290, 95);
			lbTitle.Name = "lbTitle";
			lbTitle.Size = new Size(427, 43);
			lbTitle.TabIndex = 12;
			lbTitle.Text = "Welcome to Password Generator";
			// 
			// logo
			// 
			logo.BackgroundImage = (Image)resources.GetObject("logo.BackgroundImage");
			logo.BackgroundImageLayout = ImageLayout.None;
			logo.Location = new Point(24, 45);
			logo.Name = "logo";
			logo.Size = new Size(51, 51);
			logo.TabIndex = 1;
			logo.TabStop = false;
			// 
			// logoName
			// 
			logoName.AutoSize = true;
			logoName.Font = new Font("Segoe UI Historic", 12F, FontStyle.Regular, GraphicsUnit.Point);
			logoName.ForeColor = Color.White;
			logoName.Location = new Point(81, 57);
			logoName.Name = "logoName";
			logoName.Size = new Size(187, 28);
			logoName.TabIndex = 1;
			logoName.Text = "Password Generator";
			// 
			// swOne
			// 
			swOne.BackgroundImage = Properties.Resources.SwitchOff;
			swOne.BackgroundImageLayout = ImageLayout.None;
			swOne.Location = new Point(623, 212);
			swOne.Name = "swOne";
			swOne.Size = new Size(57, 37);
			swOne.TabIndex = 2;
			swOne.TabStop = false;
			swOne.MouseClick += swOne_MouseClick;
			// 
			// swTwo
			// 
			swTwo.BackgroundImage = Properties.Resources.SwitchOff;
			swTwo.BackgroundImageLayout = ImageLayout.None;
			swTwo.Location = new Point(623, 255);
			swTwo.Name = "swTwo";
			swTwo.Size = new Size(57, 37);
			swTwo.TabIndex = 4;
			swTwo.TabStop = false;
			swTwo.MouseClick += swTwo_MouseClick;
			// 
			// swThree
			// 
			swThree.BackgroundImage = Properties.Resources.SwitchOff;
			swThree.BackgroundImageLayout = ImageLayout.None;
			swThree.Location = new Point(623, 297);
			swThree.Name = "swThree";
			swThree.Size = new Size(57, 37);
			swThree.TabIndex = 5;
			swThree.TabStop = false;
			swThree.MouseClick += swThree_MouseClick;
			// 
			// swFour
			// 
			swFour.BackgroundImage = Properties.Resources.SwitchOff;
			swFour.BackgroundImageLayout = ImageLayout.None;
			swFour.Location = new Point(623, 339);
			swFour.Name = "swFour";
			swFour.Size = new Size(57, 37);
			swFour.TabIndex = 6;
			swFour.TabStop = false;
			swFour.MouseClick += swFour_MouseClick;
			// 
			// lbLower
			// 
			lbLower.AutoSize = true;
			lbLower.Font = new Font("Segoe UI Historic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
			lbLower.Location = new Point(287, 212);
			lbLower.Name = "lbLower";
			lbLower.Size = new Size(150, 25);
			lbLower.TabIndex = 8;
			lbLower.Text = "Lowercase Letters";
			// 
			// lbUpper
			// 
			lbUpper.AutoSize = true;
			lbUpper.Font = new Font("Segoe UI Historic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
			lbUpper.Location = new Point(287, 255);
			lbUpper.Name = "lbUpper";
			lbUpper.Size = new Size(152, 25);
			lbUpper.TabIndex = 9;
			lbUpper.Text = "Uppercase Letters";
			// 
			// lbSymbol
			// 
			lbSymbol.AutoSize = true;
			lbSymbol.Font = new Font("Segoe UI Historic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
			lbSymbol.Location = new Point(287, 297);
			lbSymbol.Name = "lbSymbol";
			lbSymbol.Size = new Size(222, 25);
			lbSymbol.TabIndex = 10;
			lbSymbol.Text = "Special Character/Symbols";
			// 
			// lbNumber
			// 
			lbNumber.AutoSize = true;
			lbNumber.Font = new Font("Segoe UI Historic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
			lbNumber.Location = new Point(287, 339);
			lbNumber.Name = "lbNumber";
			lbNumber.Size = new Size(85, 25);
			lbNumber.TabIndex = 11;
			lbNumber.Text = "Numbers";
			// 
			// plLabel
			// 
			plLabel.AutoSize = true;
			plLabel.Font = new Font("Segoe UI Historic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
			plLabel.Location = new Point(289, 413);
			plLabel.Name = "plLabel";
			plLabel.Size = new Size(147, 25);
			plLabel.TabIndex = 12;
			plLabel.Text = "Password Length";
			// 
			// llValue
			// 
			llValue.Location = new Point(693, 213);
			llValue.Name = "llValue";
			llValue.Size = new Size(46, 27);
			llValue.TabIndex = 13;
			llValue.TextAlign = HorizontalAlignment.Center;
			// 
			// btnPassword
			// 
			btnPassword.BackColor = Color.Lime;
			btnPassword.FlatStyle = FlatStyle.Popup;
			btnPassword.Font = new Font("Segoe UI Historic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
			btnPassword.ForeColor = Color.White;
			btnPassword.Location = new Point(414, 581);
			btnPassword.Name = "btnPassword";
			btnPassword.Size = new Size(197, 53);
			btnPassword.TabIndex = 16;
			btnPassword.Text = "Generate Password";
			btnPassword.UseVisualStyleBackColor = false;
			btnPassword.Click += btnPassword_Click;
			// 
			// ulValue
			// 
			ulValue.Location = new Point(693, 256);
			ulValue.Name = "ulValue";
			ulValue.Size = new Size(46, 27);
			ulValue.TabIndex = 17;
			ulValue.TextAlign = HorizontalAlignment.Center;
			// 
			// scValue
			// 
			scValue.Location = new Point(693, 299);
			scValue.Name = "scValue";
			scValue.Size = new Size(46, 27);
			scValue.TabIndex = 18;
			scValue.TextAlign = HorizontalAlignment.Center;
			// 
			// numValue
			// 
			numValue.Location = new Point(693, 339);
			numValue.Name = "numValue";
			numValue.Size = new Size(46, 27);
			numValue.TabIndex = 19;
			numValue.TextAlign = HorizontalAlignment.Center;
			// 
			// plHolder
			// 
			plHolder.BackColor = Color.Black;
			plHolder.Controls.Add(plValue);
			plHolder.ForeColor = SystemColors.Window;
			plHolder.Location = new Point(442, 409);
			plHolder.Name = "plHolder";
			plHolder.Size = new Size(67, 29);
			plHolder.TabIndex = 23;
			// 
			// plValue
			// 
			plValue.AutoSize = true;
			plValue.ForeColor = SystemColors.ButtonHighlight;
			plValue.Location = new Point(11, 5);
			plValue.Name = "plValue";
			plValue.Size = new Size(0, 20);
			plValue.TabIndex = 0;
			plValue.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// pwDisplay
			// 
			pwDisplay.AutoSize = true;
			pwDisplay.BackColor = Color.Transparent;
			pwDisplay.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
			pwDisplay.ForeColor = SystemColors.ControlLightLight;
			pwDisplay.Location = new Point(29, 16);
			pwDisplay.Name = "pwDisplay";
			pwDisplay.Size = new Size(0, 27);
			pwDisplay.TabIndex = 21;
			pwDisplay.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// pwHolder
			// 
			pwHolder.BackColor = Color.Black;
			pwHolder.Controls.Add(pwDisplay);
			pwHolder.ForeColor = Color.Coral;
			pwHolder.Location = new Point(312, 490);
			pwHolder.Name = "pwHolder";
			pwHolder.Size = new Size(405, 59);
			pwHolder.TabIndex = 22;
			pwHolder.Tag = "";
			// 
			// frmMain
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ButtonHighlight;
			ClientSize = new Size(962, 673);
			Controls.Add(plHolder);
			Controls.Add(pwHolder);
			Controls.Add(numValue);
			Controls.Add(scValue);
			Controls.Add(ulValue);
			Controls.Add(btnPassword);
			Controls.Add(llValue);
			Controls.Add(plLabel);
			Controls.Add(lbNumber);
			Controls.Add(lbSymbol);
			Controls.Add(lbUpper);
			Controls.Add(lbLower);
			Controls.Add(swFour);
			Controls.Add(swThree);
			Controls.Add(swTwo);
			Controls.Add(swOne);
			Controls.Add(topBoard);
			MaximizeBox = false;
			Name = "frmMain";
			Text = "Main";
			topBoard.ResumeLayout(false);
			topBoard.PerformLayout();
			((System.ComponentModel.ISupportInitialize)logo).EndInit();
			((System.ComponentModel.ISupportInitialize)swOne).EndInit();
			((System.ComponentModel.ISupportInitialize)swTwo).EndInit();
			((System.ComponentModel.ISupportInitialize)swThree).EndInit();
			((System.ComponentModel.ISupportInitialize)swFour).EndInit();
			plHolder.ResumeLayout(false);
			plHolder.PerformLayout();
			pwHolder.ResumeLayout(false);
			pwHolder.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Panel topBoard;
        private Label logoName;
        private PictureBox logo;
        private PictureBox swOne;
        private PictureBox swTwo;
        private PictureBox swThree;
        private PictureBox swFour;
        private Label lbLower;
        private Label lbUpper;
        private Label lbSymbol;
        private Label lbNumber;
        private Label lbTitle;
        private Label plLabel;
        private TextBox llValue;
        private Button btnPassword;
        private TextBox ulValue;
        private TextBox scValue;
        private TextBox numValue;
        private Panel plHolder;
        private Label plValue;
		private Label pwDisplay;
		private Panel pwHolder;
	}
}