namespace Ex1;
using System;
using System.Threading;

internal class Program {
	static void Main(string[] args)
	{
		/*
		 *	A thread is foreground by defualt; a foreground thread keep program alive
		 *	while a background one does not. if all foreground threads finnish their work
		 *	all background threads will terminate.
		 */
		Thread b = new Thread(background);
		b.Name = "Background";
		b.IsBackground = true;
		b.Start();
		Thread f = new Thread(foreground);
		f.Name = "Foreground";
		f.Start();
	}
	static void background()
	{
		string? name = Thread.CurrentThread.Name; // we can obtain current running thread by CurrentThread property
		while (true)
		{
			Console.WriteLine($"{name} thread says: Hello!");
			Thread.Sleep(20); // this thread will wait for 20ms consuming almost no cpu time.
		}
	}
	static void foreground()
	{
		string? name = Thread.CurrentThread.Name;
		for (int i = 10 - 1;i >= 0;i--)
		{
			Thread.Sleep(1000);
			Console.WriteLine($"{name} thread says: {i}");
		}
	}
}
