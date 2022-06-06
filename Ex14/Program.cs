namespace Ex01;

using System;
using System.Threading.Tasks;
using System.Numerics;

internal class Program {
	static void Main(string[] args)
	{
		// we wanna simplify the code.
		// step one.
		var awaiter1 = calculateFact(333).GetAwaiter();
		var awaiter2 = calculateFact(444).GetAwaiter();
		awaiter1.OnCompleted(() => Console.WriteLine($"333! = {awaiter1.GetResult()}"));
		awaiter2.OnCompleted(() => Console.WriteLine($"444! = {awaiter2.GetResult()}"));
		Thread.Sleep(1000);
	}
	static Task<BigInteger> calculateFact(uint num)
	{
		return Task.Run(() =>
		{
			BigInteger res = 1;
			for (int i = 1;i < num;i++)
				res *= i;
			return res;
		});
	}
}