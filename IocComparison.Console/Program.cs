

using System;
using Autofac;
using IocComparison.Containers.Autofac;
using IocComparison.Containers.StructureMap;
using IocComparison.Drinks;

namespace IocComparison.Console
{
	class Program
	{
		static void Main(string[] args)
		{
			//RunStructureMap();
			RunAutoFac();
			System.Console.ReadLine();
		}

		private static void RunAutoFac()
		{
			try
			{
				var  autoFacContainer = new AutoFacSetup().AutoFacContainer;
				var drPepper = autoFacContainer.ResolveNamed<IPop>("DrPepper");
				drPepper.Drink();
				drPepper.Crush();

				var cocaCola = autoFacContainer.ResolveNamed<IPop>("CocaCola");
				cocaCola.Drink();
				cocaCola.Crush();
			}
			catch (Exception e)
			{
				System.Console.WriteLine(e);
			}
		}

		private static void RunStructureMap()
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
