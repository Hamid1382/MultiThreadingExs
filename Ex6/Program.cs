namespace Ex6;
using System;
using System.Threading;

internal class Program {
	static void Main(string[] args)
	{
		/*
		 *	Any try/catch/finally blocks in effect when a thread is created are of no relevance
		 *	to the thread when it starts executing.
		 */
		try
		{
			new Thread(Go).Start();
		}
		catch (Exception ex)
		{
			// We'll never get here!
			Console.WriteLine("Exception!");
		}
	}
	static void Go() { throw new NullReferenceException(); }
}
