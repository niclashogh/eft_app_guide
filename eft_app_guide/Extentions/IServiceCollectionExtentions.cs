using eft_app_guide.Services;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace eft_app_guide.Extentions
{
    public static class IServiceCollectionExtentions
    {
        public static IServiceCollection AddDependencyInjections(this IServiceCollection service)
        {
            Assembly assembly = typeof(App).Assembly;
            foreach (Type type in assembly.GetTypes())
            {
                DIAutoRegisterAttribute? attr = type.GetCustomAttribute<DIAutoRegisterAttribute>();
                if (attr ==  null) continue;
                service.Add(new ServiceDescriptor(type, type, attr.Lifetime));
            }

            return service;
        }
    }
}
