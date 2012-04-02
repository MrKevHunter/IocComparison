using System;

namespace IocComparison.Drinks
{
	public class TitaniumCan : ICan
	{
		public void Crush()
		{
			Console.WriteLine("Boing");
		}
	}
}