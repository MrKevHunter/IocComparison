using System;

namespace IocComparison.Drinks
{
	public class DrPepper : PopBase
	{
		public DrPepper(ICan can) : base(can)
		{
		}

		public override void Drink()
		{
			Console.WriteLine("Refreshing Dr Pepper");
		}
	}
}