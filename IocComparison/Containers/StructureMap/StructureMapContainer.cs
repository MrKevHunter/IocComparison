using StructureMap;

namespace IocComparison.Containers.StructureMap
{
	public class StructureMapContainer
	{
		private IContainer _container;

		private void BootStrap()
		{
			_container = new Container();
			_container.Configure(x=>x.AddRegistry(new SmRegistry()));
		}

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
	}
}
