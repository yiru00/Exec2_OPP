using ClassLibrary1;
namespace Q2
{
	public partial class Form1 : Form
	{
		public int[] DiceNum { get; set; }=new int[3];
		public Form1()
		{
			InitializeComponent();
		}

        private void DiceGameButton_Click(object sender, EventArgs e)
        {
			var DiceGame = new Class2();
			
			//睹计眔翴计
			this.DiceNum= DiceGame.GetRandomDice();
			diceResultLabel.Text = $"{DiceNum[0]}{DiceNum[1]}{DiceNum[2]}{DiceNum[3]}";

			//耞琌Τ狡ㄢΩ翴计
			int same = 0;
			for (int j = 0; j < DiceNum.Length; j++)
			{
				for (int k = j + 1; k < DiceNum.Length; k++)
				{
					if (DiceNum[j] == DiceNum[k]) { same++; }
				}
			}
			if (same ==0) { 
				MessageBox.Show("浑");
				return;
			}

			//璸衡翴计





			
		}

		
	}
}