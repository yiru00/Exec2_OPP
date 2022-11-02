using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
		public string[] answer = new string[4];
		public string[] GetAns() 
		{
			string[]ans=new string[] {"0","1","2","3","4","5","6","7","8","9" };
			for (int i=0; i<ans.Length; i++)
			{
				//取隨機亂數
				int seed=Guid.NewGuid().GetHashCode();
				var random = new Random(seed);
				int radomNumber = random.Next(0, 10);
				
				//依序和其他索引值交換(洗牌)
				string temp =ans[i];
				ans[i] = ans[radomNumber];
				ans[radomNumber] = temp;
			}
			for (int j = 0; j < 4; j++)
			{
				this.answer[j] = ans[j];
			}
			return answer; 
		}
		
		public int IsFourNum(string input)
		{
			bool isInt=int.TryParse(input, out int num);

			//檢查輸入字串的長度&是否為數字
			if (!isInt ||input.Length!=4 )
			{
				throw new Exception("請輸入四個數字");
			}

			//檢查數字是否重複
			for (int i = 0; i < 3; i++)
			{
				for (int j = i+1; j < 4; j++)
				{
					if (input[i] == input[j])
					{
						throw new Exception("請輸入四個不同的數字");
					}
				}
				
			}
			return num;
		}

		public int[] GetResult(string[] inputArray, string[]answer) 
		{
			int a=0;
			int b=0;
			
			for (int i = 0; i < inputArray.Length; i++)
			{
				if (inputArray[i] == answer[i])
				{
					a++;
					continue;
				}
				for (int k = 0; k < inputArray.Length; k++)
				{
					if (inputArray[i] == answer[k])
					{
						 b++;
					}
				}
			}

			return new int[] { a, b };
		}

	}
}
