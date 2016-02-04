namespace Sfa.Eds.Das.Web.DependencyResolution
{
    using log4net;

    using Sfa.Eds.Das.Core;
    using Sfa.Eds.Das.Core.BusinessLogic.Services;
    using Sfa.Eds.Das.Core.BusinessLogic.Services.Factories;
    using Sfa.Eds.Das.Core.Interfaces;
    using Sfa.Eds.Das.Core.Interfaces.Search;
    using Sfa.Eds.Das.Core.Search;

    using StructureMap.Configuration.DSL;

    public class SearchRegistry : Registry
    {
        public SearchRegistry()
        {
            this.For<ISearchService>().Use<SearchService>();
            this.For<IElasticsearchClientFactory>().Use<ElasticsearchClientFactory>();
            this.For<IApplicationSettings>().Use<ApplicationSettings>();
            this.For<ILog>().Use(LogManager.GetLogger(Log4NetSettings.LoggerName));
        }
    }
}