using Microsoft.Extensions.DependencyInjection;

namespace eft_app_guide._Attributes
{
    [AttributeUsage(AttributeTargets.Class)]
    public class DependencyInjectionRegisterAttribute : Attribute
    {
        public ServiceLifetime Lifetime {  get; }

        public DependencyInjectionRegisterAttribute(ServiceLifetime lifetime = ServiceLifetime.Transient)
        {
            Lifetime = lifetime;
        }
    }
}
