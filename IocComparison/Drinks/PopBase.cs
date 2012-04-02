namespace IocComparison.Drinks
{
	public abstract class PopBase : IPop
	{
		private readonly ICan _can;

		protected PopBase(ICan can)
		{
			_can = can;
		}

		public abstract void Drink();


		public void Crush()
		{
			_can.Crush();
		}
	}
}