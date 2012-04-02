using IocComparison.Drinks;
using StructureMap.Configuration.DSL;

namespace IocComparison.Containers.StructureMap
{
	public class SmRegistry : Registry
	{
		public SmRegistry()
		{
			For<IPop>().Use<DrPepper>().Named("DrPepper").Ctor<ICan>().Is<TitaniumCan>();
			For<IPop>().Use<CocaCola>().Named("CocaCola").Ctor<ICan>().Is<AluminumCan>();

		}
	}
}