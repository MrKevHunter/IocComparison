using Autofac;
using IocComparison.Drinks;

namespace IocComparison.Containers.Autofac
{
	public class AutoFacSetup
	{
		private IContainer _container;
		private ContainerBuilder _containerBuilder;

		public IContainer AutoFacContainer
		{
			get
			{
				if (_container == null)
				{
					BootStrap();
					_container = _containerBuilder.Build();
				}
				return _container;
			}
		}

		private void BootStrap()
		{
			_containerBuilder = new ContainerBuilder();
			_containerBuilder.RegisterType<TitaniumCan>().As<ICan>().Named<ICan>("Titanium");
			_containerBuilder.RegisterType<AluminumCan>().As<ICan>().Named<ICan>("Aluminum");
			_containerBuilder.Register((context, parameters) => new DrPepper(context.ResolveNamed<ICan>("Titanium"))).Named<IPop>("DrPepper");
			_containerBuilder.Register((context, parameters) => new CocaCola(context.ResolveNamed<ICan>("Aluminum"))).Named<IPop>("CocaCola");
		}
	}
}