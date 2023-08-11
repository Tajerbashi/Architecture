namespace WEB.API.IOCContainer
{
    public class IocContainer
    {
        public IocContainer() { }
    }

    public class Resolver
    {
        private Dictionary<Type,Type> Mapper = new Dictionary<Type, Type> ();
        public Resolver() { }

        public void Register<TFrom, TTo>()
        {
            var f = typeof(TFrom);
            var t = typeof(TTo);
            Mapper.Add(typeof(TFrom), typeof(TTo));
        }

        private object Resolve(Type interfaceType)
        {
            Type classType;

            if (!Mapper.TryGetValue(interfaceType, out classType))
            {
                throw new Exception($"Could Not resolve type {interfaceType.FullName}");
            }

            var ctr = classType.GetConstructors().First();
            var ctrParametr = ctr.GetParameters();
            if (!ctrParametr.Any())
            {
                return Activator.CreateInstance(classType);
            }
            List<object> parameters = new List<object> ();
            foreach (var item in ctrParametr)
            {
                parameters.Add(Resolve(item.ParameterType));
            }
            return ctr.Invoke(parameters.ToArray());
        }

        public T Resolve<T>()
        {
            return (T)Resolve(typeof(T));
        }
    }
}
