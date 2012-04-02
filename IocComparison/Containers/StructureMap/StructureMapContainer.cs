using StructureMap;

namespace IocComparison.Containers.StructureMap
{
	public class StructureMapContainer
	{
		private IContainer _container;

		public IContainer Container
		{
			get
			{
				if (_container == null)
				{
					BootStrap();
				}
				return _container;
			}
		}

		private void BootStrap()
		{
			_container = new Container();
			/*// rather than using a registry this could be done here like

			_container.Configure(x=>x.For<IPop>().Use<DrPepper>().Named("DrPepper").Ctor<ICan>().Is<TitaniumCan>());
			_container.Configure(x=>x.For<IPop>().Use<CocaCola>().Named("CocaCola").Ctor<ICan>().Is<AluminumCan>());*/

			_container.Configure(x => x.AddRegistry(new SmRegistry()));
		}
	}
}