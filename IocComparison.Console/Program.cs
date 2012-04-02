

using System;
using IocComparison.Containers.StructureMap;
using IocComparison.Drinks;

namespace IocComparison.Console
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				var instance1 = new StructureMapContainer().Container.GetInstance<IPop>("DrPepper");
				instance1.Drink();
				instance1.Crush();
				
				var instance2 = new StructureMapContainer().Container.GetInstance<IPop>("CocaCola");
				instance2.Drink();
				instance2.Crush();

			}
			catch (Exception e)
			{
				System.Console.WriteLine(e);
			}
			System.Console.ReadLine();
		}
	}
}
