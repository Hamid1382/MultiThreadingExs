namespace Ex01;

using System;
using System.Threading.Tasks;

internal class Program {
	static void Main(string[] args)
	{
		/*
		 * if the code in your task throws an unhandled exception (your task faults), 
		 * that exception is automatically rethrown to whoever calls Wait() or accesses the
		 * Result property of a Task<TResult>.
		 */
		Task task = Task.Run(() => throw new Exception("My Exception")); //VS will break here click continue to see the message.
		try
		{
			task.Wait();
		}
		catch (AggregateException ex)
		//The CLR wraps the exception in an AggregateException in order to play well with parallel programming scenarios.
		{
			if(ex.InnerException?.Message == "My Exception")
				Console.WriteLine("As Expected");
		}
	}
}
