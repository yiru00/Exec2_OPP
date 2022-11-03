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
			
			//亂數得點數
			this.DiceNum= DiceGame.GetRandomDice();
			diceResultLabel.Text = $"{DiceNum[0]}{DiceNum[1]}{DiceNum[2]}{DiceNum[3]}";


			//把答案按照順序排
			Array.Sort(DiceNum);

			//判斷是否有重複兩次以上的點數
			int same = 0;
			for (int j = 0; j < DiceNum.Length-1; j++)
			{
				if (DiceNum[j] == DiceNum[j+1]) { same++; }
			}
			if (same ==0) { 
				MessageBox.Show("重骰");
				return;
			}

			//計算點數





			
		}

		
	}
}