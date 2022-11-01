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
		private string[] answer;
		public Form1()
		{
			InitializeComponent();

		}
		

        private void button1_Click(object sender, EventArgs e)
        {
			var newGame = new Class1();
			this.answer = newGame.GetAns();
		}

		private void buttonSend_Click(object sender, EventArgs e)
		{
			string input =textBoxInput.Text;
			var newGame = new Class1();
			newGame.answer=this.answer;
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
			for(int i = 0; i < inputArray.Length; i++)
			{
				inputArray[i] = input[i].ToString();
			}
			

			int[] answer = newGame.GetResult(inputArray, this.answer);
			textBoxResult.Text += $"{this.answer[0]}{this.answer[1]}{this.answer[2]}{this.answer[3]}\r\n{answer[0]}A{answer[1]}B\r\n";

			
		}

		
	}
}
