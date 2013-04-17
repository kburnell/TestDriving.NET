using StructureMap;

namespace Calculator.Console {
    public static class IoCBootstrapper {

       
        public static void Bootstrap()  {
            ObjectFactory.Initialize(registry => registry.Scan(x => {
                x.AssembliesFromApplicationBaseDirectory();
                x.WithDefaultConventions();
            }));
        }
    }
}