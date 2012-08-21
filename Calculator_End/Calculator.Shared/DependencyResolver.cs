using StructureMap;

namespace Calculator.Shared {

    public static class DependencyResolver {
        public static T GetConcreteInstanceOf<T>() {
            return ObjectFactory.GetInstance<T>();
        }
    }
}