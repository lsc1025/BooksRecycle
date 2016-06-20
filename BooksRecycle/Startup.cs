using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BooksRecycle.Startup))]
namespace BooksRecycle
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
