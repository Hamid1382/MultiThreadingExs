namespace Ex01;

using System;
using System.Threading.Tasks;

internal class Program {
	static void Main(string[] args)
	{
		//why doest the next loop work as expected? (print 123)
		for (int i = 1;i < 4;i++)
			Task.Run(() => Console.Write(i));
		Thread.Sleep(1000);

		//its because tasks first initals and i goes from 1 to 4
		//(to make loop condition false) then task start with same variable( i = 4)

		for (int j = 1;j < 4;j++)
		{
			int copy = j;
			Task.Run(() => Console.Write(copy));
		}
		Thread.Sleep(1000);
		// now its runs correctly because each task has his own copy.

	}
}
