namespace Ex01;

using System;
using System.Threading.Tasks;
using System.Numerics;

internal class Program {
	static void Main(string[] args)
	{
		// we wanna simplify the code.
		// step two.
		doIt(); //we dont wait to doIt func finish its works its asyncronous.
		Thread.Sleep(1000);
	}
	/*
	 * we can use await keyword in a aync function
	 * the async function also tells other that it might
	 * still be working after the control returns to origin.
	 */
	static async void doIt()
	{
		var res1 = await calculateFact(333);
		Console.WriteLine($"333! = {res1}");
		var res2 = await calculateFact(444);
		Console.WriteLine($"333! = {res2}");
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