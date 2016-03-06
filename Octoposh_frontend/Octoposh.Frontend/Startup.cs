using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Octoposh.Frontend.Startup))]
namespace Octoposh.Frontend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            
        }
    }
}
