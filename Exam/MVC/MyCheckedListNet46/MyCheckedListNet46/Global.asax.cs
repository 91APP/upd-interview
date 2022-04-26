using Autofac;
using Autofac.Integration.Mvc;
using MyCheckedListNet46.BusinessLogic;
using MyCheckedListNet46.Data;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace MyCheckedListNet46
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            var builder = new ContainerBuilder();

            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            builder.RegisterType<MyCheckListContext>().InstancePerRequest();
            builder.RegisterType<ItemRepository>().As<IItemRepository>();
            builder.RegisterType<ItemService>().As<IItemService>();
            builder.RegisterType<MemberRepository>().As<IMemberRepository>();
            builder.RegisterType<MemberService>().As<IMemberService>();

            IContainer container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}
