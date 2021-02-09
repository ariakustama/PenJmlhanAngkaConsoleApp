using System;
using System.Linq;
using System.Collections.Generic;

namespace PenJmlhanAngkaConsoleApp
{
    class Program
    {
		public static void Main(string[] args)
		{
			string userInput;
			int intVal;

			Console.Write("Enter integer value: ");
			userInput = Console.ReadLine();
			intVal = Convert.ToInt32(userInput);

			for (int i = intVal; i > 0;)
			{
				if (i == intVal)
				{
					Console.WriteLine(i);
				}
				else
				{
					List<int> listNumber = new List<int>();
					for (int ii = i; ii > 0;)
					{
						listNumber.Add(ii);

						if (listNumber.Sum() > intVal)
						{
							listNumber.RemoveAt(listNumber.Count - 1);
							ii = ii - 1;
						}

						if (listNumber.Sum() == intVal)
						{
							String sep = ", ";
							String result;
							result = String.Join(sep, listNumber);
							Console.WriteLine(result);
							listNumber.Clear();
							break;
						}
					}
				}
				i = i - 1;
			}
		}
	}
}
