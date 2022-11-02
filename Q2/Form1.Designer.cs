namespace Q2
{
	partial class Form1
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
			this.DiceGameButton = new System.Windows.Forms.Button();
			this.answerLabel = new System.Windows.Forms.Label();
			this.diceResultLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// DiceGameButton
			// 
			this.DiceGameButton.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.DiceGameButton.Location = new System.Drawing.Point(105, 127);
			this.DiceGameButton.Name = "DiceGameButton";
			this.DiceGameButton.Size = new System.Drawing.Size(129, 59);
			this.DiceGameButton.TabIndex = 0;
			this.DiceGameButton.Text = "DiceGame";
			this.DiceGameButton.UseVisualStyleBackColor = true;
			this.DiceGameButton.Click += new System.EventHandler(this.DiceGameButton_Click);
			// 
			// answerLabel
			// 
			this.answerLabel.AutoSize = true;
			this.answerLabel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.answerLabel.Location = new System.Drawing.Point(141, 220);
			this.answerLabel.Name = "answerLabel";
			this.answerLabel.Size = new System.Drawing.Size(57, 20);
			this.answerLabel.TabIndex = 1;
			this.answerLabel.Text = "得幾點";
			// 
			// diceResultLabel
			// 
			this.diceResultLabel.AutoSize = true;
			this.diceResultLabel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.diceResultLabel.Location = new System.Drawing.Point(141, 274);
			this.diceResultLabel.Name = "diceResultLabel";
			this.diceResultLabel.Size = new System.Drawing.Size(57, 20);
			this.diceResultLabel.TabIndex = 2;
			this.diceResultLabel.Text = "骰子數";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(339, 420);
			this.Controls.Add(this.diceResultLabel);
			this.Controls.Add(this.answerLabel);
			this.Controls.Add(this.DiceGameButton);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

        #endregion

        private Button DiceGameButton;
        private Label answerLabel;
        private Label diceResultLabel;
    }
}