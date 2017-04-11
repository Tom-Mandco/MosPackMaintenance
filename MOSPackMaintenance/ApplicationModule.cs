namespace MCO.Applications.MOSPackMaintenance
{
    using Classes;
    using Interfaces;
    using Ninject.Modules;
    using NLog;
    using System;
    using System.Configuration;
    using MCO.Data.MosPackMaintenance.Classes;
    using MCO.Data.MosPackMaintenance.Interfaces;

    class ApplicationModule : NinjectModule
    {
        public override void Load()
        {
            string connectionString = "";
            try
            {
                connectionString = ConfigurationManager.AppSettings["OracleConnection"];
            }
            catch (Exception ex)
            {

            }

            Bind<ILog>().ToMethod(x =>
            {
                var scope = x.Request.ParentRequest.Service.FullName;
                var log = (ILog)LogManager.GetLogger(scope, typeof(Log));
                return log;
            });

            Bind(typeof(IApp)).To(typeof(App));
            Bind(typeof(IRepository)).To(typeof(OracleRepository)).InSingletonScope().WithConstructorArgument("connectionString", connectionString);



        }
    }
}
