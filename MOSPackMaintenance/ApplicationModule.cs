namespace MCO.Applications.MOSPackMaintenance
{
    using Classes;
    using Interfaces;
    using Ninject.Modules;
    using NLog;
    using System.Configuration;
    using Data.MosPackMaintenance.Classes;
    using Data.MosPackMaintenance.Interfaces;
    using Service.MosPackMaintenance.Classes;
    using Service.MosPackMaintenance.Interfaces;

    class ApplicationModule : NinjectModule
    {
        public override void Load()
        {
            string connectionString = "";
            try
            {
                connectionString = ConfigurationManager.AppSettings["OracleConnection"];
            }
            catch
            {
                
            }

            Bind<ILog>().ToMethod(x =>
            {
                var scope = x.Request.ParentRequest.Service.FullName;
                var log = (ILog)LogManager.GetLogger(scope, typeof(Log));
                return log;
            });

            Bind(typeof(IApp)).To(typeof(App));
            Bind(typeof(IDataHandler)).To(typeof(DataHandler));
            Bind(typeof(IAdaptData)).To(typeof(DataAdapter));
            Bind(typeof(IPerformLookup)).To(typeof(PerformLookup));
            Bind(typeof(IDataTableFactory)).To(typeof(DataTableFactory));
            Bind(typeof(ISerializeObjects)).To(typeof(ObjectSerializer));
            Bind(typeof(IRepository)).To(typeof(OracleRepository)).InSingletonScope().WithConstructorArgument("connectionString", connectionString);



        }
    }
}
