using System;

namespace IocComparison.Drinks
{
	public class CocaCola : PopBase
	{
		public CocaCola(ICan can) : base(can)
		{
		}

		public override void Drink()
		{
			Console.WriteLine("Urgh, Coca Cola is too sweet");
		}
	}
}