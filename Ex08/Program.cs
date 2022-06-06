namespace Ex01;

using System;
using System.Threading.Tasks;

internal class Program {
	/*
	 * Whenever you start a thread, a few hundred microseconds are spent.
	 * The thread pool cuts this overhead by having a pool of pre-created recyclable threads.
	 * Thread pooling is essential for efficient parallel programming and fine-grained concurrency.
	 * The easiest way to explicitly run something on a pooled thread is to use Task.Run.
	 * Note that : 
	 *	1. You cannot set the Name of a pooled thread, making debugging more difficult.
	 *	2. Pooled threads are always background threads (as well as tasks).
	 */
	static void Main(string[] args)
	{
		Task.Run(() => Console.WriteLine("Hello from the thread pool"));
	}
}
