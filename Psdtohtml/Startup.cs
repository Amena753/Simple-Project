using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Psdtohtml.Startup))]
namespace Psdtohtml
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
