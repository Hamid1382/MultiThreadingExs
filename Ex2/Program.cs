namespace Ex1;
using System;
using System.Threading;

internal class Program {
	static void Main(string[] args)
	{
		Thread t = new Thread(WriteY);
		t.Start(); 
		for (int i = 0;i < 100;i++)
			Console.Write("x");
		Console.WriteLine("Waiting for WriteY");
		t.Join(); //we will wait for thread t to end.
	}
	static void WriteY()
	{
		for (int i = 0;i < 1000;i++)
			Console.Write("y");
	}
}
