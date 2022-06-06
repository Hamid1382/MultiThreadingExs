namespace Ex1;
using System;
using System.Threading;

internal class Program {
	static void Main(string[] args)
	{
		Thread t = new Thread(DoSomething);
		t.Name = "MyThread";
		t.Start();
		Thread.CurrentThread.Name = "MainTread";
		Console.WriteLine($"Message from {Thread.CurrentThread.Name}");
	}
	static void DoSomething()
	{
		Console.WriteLine($"Message from {Thread.CurrentThread.Name}");
		DoSomethingElse(); //this function will run on MyThread
	}
	static void DoSomethingElse()
	{
		Console.WriteLine($"Another Message from {Thread.CurrentThread.Name}");
	}
}
