using Ishod1.Repository;
using System;
using System.Reflection;

namespace Ishod1.Factory
{
    static class RepositoryFactory
    {
        public static IRepository GetInstance(Type type) =>
            Activator.CreateInstance(type) is IRepository repository
            ? repository
            : throw new Exception($"{type} is not {(MethodBase.GetCurrentMethod() as MethodInfo).ReturnType.Name}");
    }
}
