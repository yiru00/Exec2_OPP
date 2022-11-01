using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
		public string[] answer;
		public string[] GetAns() 
		{
			this.answer = new string[4];
			string[]ans=new string[] {"0","1","2","3","4","5","6","7","8","9" };
			for (int i=0; i<ans.Length; i++)
			{
				int seed=Guid.NewGuid().GetHashCode();
				var random = new Random(seed);
				int radomNumber = random.Next(0, 10);
				string temp =ans[i];
				ans[i] = ans[radomNumber];
				ans[radomNumber] = temp;
			}
			return answer; //answer{1,2,3,4}
		}
		
		public int IsFourNum(string input)
		{
			bool isInt=int.TryParse(input, out int num);
			if (isInt==false ||input.Length!=4 )
			{
				throw new Exception("請輸入四個數字");
			}
			
			return num;
		}

		public int[] GetResult(string[] inputArray, string[] Answer) 
		{
			int a=0;
			int b=0;
			for (int i = 0; i < inputArray.Length; i++)
			{
				for (int k = 0; k < Answer.Length; k++)
				{
					if (inputArray[i] == Answer[i])
					{
						a++;
					}
					else if (inputArray[i] == Answer[k])
					{
						b++;
					}
					
				}
				
			}
			
			return new int[] { a, b };
		}

	}
}
