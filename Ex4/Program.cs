namespace Ex1;
using System;
using System.Threading;

internal class Program {
	static void Main(string[] args)
	{
		// way 1 to send data to a thread
		Thread t = new Thread(WriteMessage); //We can send a single object nothing else.
		t.Start("Hi universe!");
		t.Join();
	}
	static void WriteMessage(object message)
	{
		string s = (string) message;
		for (int i = 0;i < 100;i++)
			Console.WriteLine(s);
	}
}
