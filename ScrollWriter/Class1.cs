using System;
using System.Threading;

namespace ScrollWriter
{
	public class ScrollWriter
	{
		public void Write(string text, int waitPeriod = 50)
		{
			//	Goes through each character in the input text, writes it and waits the amount of miliseconds set in waitPeriod and then writes the next character
			foreach (char character in text)
			{
				Console.Write(character);
				Thread.Sleep(waitPeriod);
			}
		}
		
		public void WriteLine(string text, int waitPeriod = 50)
		{
			text += "\n";   // Adds a new line at the end of the input text

			//	Goes through each character in the input text, writes it and waits the amount of miliseconds set in waitPeriod and then writes the next character
			foreach (char character in text)
			{
				Console.Write(character);
				Thread.Sleep(waitPeriod);
			}
		}
		public void WriteVertical(string text, int waitPeriod = 50)
		{
			//	Goes through each character in the input text, writes it and waits the amount of miliseconds set in waitPeriod and then writes the next character
			foreach (char character in text)
			{
				Console.WriteLine(character);
				Thread.Sleep(waitPeriod);
			}
		}
		public void WriteVerticalN(string text, int waitPeriod = 50)
		{
			text += "\n";	// Adds a new line at the end of the input text

			//	Goes through each character in the input text, writes it and waits the amount of miliseconds set in waitPeriod and then writes the next character
			foreach (char character in text)
			{
				Console.WriteLine(character);
				Thread.Sleep(waitPeriod);
			}
		}
	}
}
