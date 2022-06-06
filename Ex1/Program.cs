namespace Ex1;
using System;
using System.Threading;

internal class Program {
	static void Main(string[] args)
	{
		/*
		 * beforce this, All our programs were running on a 
		 * single thread which called main.
		 * We can Creat another thread to do something else.
		 */
		Thread t = new Thread(WriteY);
		t.Start(); //start ruuning method WriteY
		for (int i = 0;i < 10000;i++)
			Console.Write("x");
	}
	static void WriteY()
	{
		for (int i = 0;i < 10000;i++)
			Console.Write("y");
	}		
}
