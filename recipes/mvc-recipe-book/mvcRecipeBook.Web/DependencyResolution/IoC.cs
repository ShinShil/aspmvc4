using mvcRecipeBook.Domain;
using mvcRecipeBook.Web.Infrastructure;
using StructureMap;
namespace mvcRecipeBook.Web {
    public static class IoC {
        public static IContainer Initialize() {
            ObjectFactory.Initialize(x =>
                        {
                            x.Scan(scan =>
                                    {
                                        scan.TheCallingAssembly();
                                        scan.WithDefaultConventions();
                                    });
                            x.For<IRecipeBookDataSource>().HttpContextScoped().Use<RecipeBookDbContext>();
                        });
            return ObjectFactory.Container;
        }
    }
}