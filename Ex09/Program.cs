namespace Ex01;

using System;
using System.Threading.Tasks;

internal class Program {
	static void Main(string[] args)
	{
		/*
		 * By default, the CLR runs tasks on pooled threads, which is ideal for short-running 
		 * compute-bound work. For longer-running and blocking operations you can prevent use 
		 * of a pooled thread.
		 */
		Task task = Task.Factory.StartNew(worker, TaskCreationOptions.LongRunning);//won't use pooled threads.
		task.Wait(); // we need to wait for task t finnish, otherwise it will terminate early.
	}
	static void worker()
	{
		List<int> Primes = new();
		for(int i = 2; i < 10000 ;i++)
		{
			bool isPrime = true;
			foreach(var prime in Primes)
			{
				if (i % prime == 0)
				{
					isPrime = false;
					break;
				}
				else if (prime > i / 2)
					break;
			}
			if (isPrime)
			{
				Primes.Add(i);
				Console.WriteLine(i);
			}
		}
		
	}
}
