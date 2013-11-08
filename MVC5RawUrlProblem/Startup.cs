using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC5RawUrlProblem.Startup))]
namespace MVC5RawUrlProblem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
