namespace Ex01;

using System;
using System.Threading.Tasks;
using System.Numerics;

internal class Program {
	static void Main(string[] args)
	{
		var task1 = Task.Run<BigInteger>(() => calculateFact(333));
		var task2 = Task.Run<BigInteger>(() => calculateFact(444));
		var awaiter1 = task1.GetAwaiter();
		var awaiter2 = task2.GetAwaiter();
		// result will print will print as its become ready.
		awaiter1.OnCompleted(() => Console.WriteLine($"333! = {awaiter1.GetResult()}"));
		awaiter2.OnCompleted(() => Console.WriteLine($"444! = {awaiter2.GetResult()}"));
		task1.Wait();
		task2.Wait();
		Thread.Sleep(1000);//however task.wait() does not actually wait and runtime terminates tasks.
	}
	static BigInteger calculateFact(uint num)
	{
		BigInteger res = 1;
		for (int i = 1;i < num;i++)
			res *= i;
		return res;
	}
}