using Ninject.Modules;
using TheTvdbDotNet.Authentication;
using TheTvdbDotNet.Http;
using TheTvdbDotNet.Repositories;

namespace TheTvdbDotNet.Ninject
{
    public class TheTvdbDotNetModule(string apiKey) : NinjectModule
    {
        private readonly string apiKey = apiKey;

        public override void Load()
        {
            Bind<IAuthenticationToken>().To<AuthenticationToken>()
                .InSingletonScope();
            Bind<IAuthenticator>().To<Authenticator>()
                .InSingletonScope()
                .WithConstructorArgument("apiKey", apiKey);

            Bind<ITvdbHttpClient>().To<TvdbHttpClient>()
                .InSingletonScope();
            Bind<IAuthenticatedTvdbHttpClient>().To<AuthenticatedTvdbHttpClient>()
                .InSingletonScope();
            Bind<ITvdbBannersHttpClient>().To<TvdbBannersHttpClient>()
                .InSingletonScope();

            Bind<ITvdbSeries>().To<TvdbSeriesRepository>()
                .InSingletonScope();
            Bind<ITvdbSearch>().To<TvdbSearchRepository>()
                .InSingletonScope();
            Bind<ITvdbUpdate>().To<TvdbUpdateRepository>()
                .InSingletonScope();
        }
    }
}
