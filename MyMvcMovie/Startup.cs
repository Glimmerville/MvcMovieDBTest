using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyMvcMovie.Startup))]
namespace MyMvcMovie
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
