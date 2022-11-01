using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;

namespace Q1
{
	public partial class Form1 : Form
	{
		public string[] answer;
		public Form1()
		{
			InitializeComponent();
			label1.Text = string.Empty;
			
		}
		

        private void button1_Click(object sender, EventArgs e)
        {
			var newGame = new Class1();
			this.answer = newGame.GetAns();
			textBoxResult.Text = string.Empty;
			textBoxInput.Text = string.Empty;
			label1.Text = $"{answer[0]}{answer[1]}{answer[2]}{answer[3]}";

		}

		private void buttonSend_Click(object sender, EventArgs e)
		{
			string input = textBoxInput.Text;
			var newGame = new Class1();
			
			try
			{
				int inputInt = newGame.IsFourNum(input);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return;
			}

			string[] inputArray = new string[4];
			for (int i = 0; i < inputArray.Length; i++)
			{
				inputArray[i] = input[i].ToString();
			}

			int[] result = newGame.GetResult(inputArray,this.answer);

			textBoxResult.Text += $"{input}，{result[0]}A{result[1]}B\r\n";
			
			if (result[0]==4)
			{
				MessageBox.Show("答對了!!");
			}
		}
	}
}
