using StructureMap;

namespace Calculator.Console.Utility {

    public static class IoCBootstrapper {

        public static void Bootstrap() {
            ObjectFactory.Initialize(registry => registry.Scan(x => {
                x.AssembliesFromApplicationBaseDirectory();
                x.WithDefaultConventions();
            }));
        }
    }
}