namespace Ex1;
using System;
using System.Threading;

internal class Program {

	/*
	 * Sometimes, you need a thread to wait until receiving notification(s) from other
	 *	thread(s). This is called signaling.
	 */
	static ManualResetEvent signal = new(false);
	static void Main(string[] args)
	{
		Thread t = new Thread(Signaled);
		t.Start();
		Thread.Sleep(2000);
		signal.Set();
	}
	static void Signaled()
	{
		Console.WriteLine("Waiting for signal...");
		signal.WaitOne(); //thread would use almost no cpu time(thread is blocked).
		signal.Dispose();
		Console.WriteLine("Got signal!");
	}
}
