using Microsoft.Extensions.DependencyInjection;

namespace eft_app_guide.Services
{
    [AttributeUsage(AttributeTargets.Class)]
    public class DIAutoRegisterAttribute : Attribute
    {
        public ServiceLifetime Lifetime {  get; }

        public DIAutoRegisterAttribute(ServiceLifetime lifetime = ServiceLifetime.Transient)
        {
            this.Lifetime = lifetime;
        }
    }
}
