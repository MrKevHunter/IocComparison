using System;

namespace IocComparison.Drinks
{
	public class AluminumCan : ICan
	{
		public void Crush()
		{
			Console.WriteLine("Crash");
		}
	}
}