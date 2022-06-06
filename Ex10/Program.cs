namespace Ex01;

using System;
using System.Threading.Tasks;

internal class Program {
	static void Main(string[] args)
	{
		/*
		 * Task has a generic subclass called Task<TResult>, which allows a task to have a return value
		 */
		Task<List<int>> task = Task.Run(worker);
		Console.WriteLine(task.Result.Count); // if result are not ready main thread will block till it  become ready.
	}
	static List<int> worker()
	{
		List<int> Primes = new();
		for (int i = 2;i < 10000;i++)
		{
			bool isPrime = true;
			foreach (var prime in Primes)
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
			}
		}
		return Primes;
	}
}
