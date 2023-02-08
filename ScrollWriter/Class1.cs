using System;
using System.Threading;

namespace ScrollWriter
{
	public class ScrollWriter
	{
		public void Write(string text, int waitPeriod = 50)
		{
			foreach (char character in text)
			{
				Console.Write(character);
				Thread.Sleep(waitPeriod);
			}
		}
		
		public void WriteLine(string text, int waitPeriod = 50)
		{
			text += "\n";
			foreach (char character in text)
			{
				Console.Write(character);
				Thread.Sleep(waitPeriod);
			}
		}
		public void WriteVertical(string text, int waitPeriod = 50)
		{
			foreach (char character in text)
			{
				Console.WriteLine(character);
				Thread.Sleep(waitPeriod);
			}
		}
	}
}
