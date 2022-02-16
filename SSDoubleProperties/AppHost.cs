using Funq;
using ServiceStack;
using SSDoubleProperties.ServiceInterface;

namespace SSDoubleProperties
{
    //VS.NET Template Info: https://servicestack.net/vs-templates/EmptyWindowService
    public class AppHost : AppSelfHostBase
    {
        /// <summary>
        /// Base constructor requires a Name and Assembly where web service implementation is located
        /// </summary>
        public AppHost()
            : base("SSTest", typeof(AppHost).Assembly) { } //We will manually add routes.

        /// <summary>
        /// Application specific configuration
        /// This method should initialize any IoC resources utilized by your web service classes.
        /// </summary>
        public override void Configure(Container container)
        {
            //Config examples
            //this.Plugins.Add(new PostmanFeature());
            //this.Plugins.Add(new CorsFeature());

            RegisterService<MyServices>();
            Routes.Add(typeof(SSDoubleProperties.ServiceModel.MovieGETRequest), "/Movie/{MovieID}", "GET", "Retrieves a movie record.", "");
            Routes.Add(typeof(SSDoubleProperties.ServiceModel.MoviePOSTRequest), "/Movie", "POST", "Creates a movie record.", "");
        }
    }
}
