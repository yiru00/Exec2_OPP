using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
	public class Class2
	{
		public int[] GetRandomDice()
		{
			
			int[] diceNum=new int[4];
			for (int i = 0; i < diceNum.Length; i++)
			{
				int seed = Guid.NewGuid().GetHashCode();
				var random = new Random(seed);
				int randomNum = random.Next(1, 7);
				diceNum[i] = randomNum;

			}

			
			return diceNum;
		}


	}
}
