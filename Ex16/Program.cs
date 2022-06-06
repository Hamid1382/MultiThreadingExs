namespace Ex01;

using System;
using System.Threading.Tasks;
using System.Numerics;

internal class Program {
	static void Main(string[] args)
	{
		// we wanna simplify the code.
		// step three.
		var a = doIt().Result; // if we dont do this results will never being written.
	}

	static async Task<bool> doIt() 
	{
		var res1 = await calculateFact(333);
		Console.WriteLine($"333! = {res1}");
		var res2 = await calculateFact(444);
		Console.WriteLine($"333! = {res2}");
		return true;
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