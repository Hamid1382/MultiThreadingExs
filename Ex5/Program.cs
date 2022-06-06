namespace Ex1;
using System;
using System.Threading;

internal class Program {
	static void Main(string[] args)
	{
		// way 2 to send data to a thread
		Thread t = new Thread(_ => WriteMessage("Hello multiverse!")); //We can send a single object nothing else.
		t.Start();
		t.Join();
	}
	static void WriteMessage(string message)
	{
		for (int i = 0;i < 100;i++)
			Console.WriteLine(message);
	}
}
