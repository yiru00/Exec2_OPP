namespace Q1
{
	partial class Form1
	{
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			this.buttonNewGame = new System.Windows.Forms.Button();
			this.textBoxInput = new System.Windows.Forms.TextBox();
			this.buttonSend = new System.Windows.Forms.Button();
			this.textBoxResult = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// buttonNewGame
			// 
			this.buttonNewGame.Location = new System.Drawing.Point(160, 87);
			this.buttonNewGame.Name = "buttonNewGame";
			this.buttonNewGame.Size = new System.Drawing.Size(75, 23);
			this.buttonNewGame.TabIndex = 0;
			this.buttonNewGame.Text = "新遊戲";
			this.buttonNewGame.UseVisualStyleBackColor = true;
			this.buttonNewGame.Click += new System.EventHandler(this.button1_Click);
			// 
			// textBoxInput
			// 
			this.textBoxInput.Location = new System.Drawing.Point(147, 142);
			this.textBoxInput.Name = "textBoxInput";
			this.textBoxInput.Size = new System.Drawing.Size(100, 22);
			this.textBoxInput.TabIndex = 1;
			// 
			// buttonSend
			// 
			this.buttonSend.Location = new System.Drawing.Point(160, 196);
			this.buttonSend.Name = "buttonSend";
			this.buttonSend.Size = new System.Drawing.Size(75, 23);
			this.buttonSend.TabIndex = 2;
			this.buttonSend.Text = "送出";
			this.buttonSend.UseVisualStyleBackColor = true;
			this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
			// 
			// textBoxResult
			// 
			this.textBoxResult.Location = new System.Drawing.Point(109, 251);
			this.textBoxResult.Multiline = true;
			this.textBoxResult.Name = "textBoxResult";
			this.textBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBoxResult.Size = new System.Drawing.Size(177, 131);
			this.textBoxResult.TabIndex = 3;
			this.textBoxResult.WordWrap = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(126, 416);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(33, 12);
			this.label1.TabIndex = 4;
			this.label1.Text = "label1";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(395, 468);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBoxResult);
			this.Controls.Add(this.buttonSend);
			this.Controls.Add(this.textBoxInput);
			this.Controls.Add(this.buttonNewGame);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

        #endregion

        private System.Windows.Forms.Button buttonNewGame;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Label label1;
    }
}

