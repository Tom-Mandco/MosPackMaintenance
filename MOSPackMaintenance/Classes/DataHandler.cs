namespace MCO.Applications.MOSPackMaintenance.Classes
{
    using Interfaces;
    using Service.MosPackMaintenance.Interfaces;
    using Service.MosPackMaintenance.Models;

    public class DataHandler : IDataHandler
    {
        private readonly ILog logger;
        private readonly IPerformLookup performLookup;

        public DataHandler(ILog logger, IPerformLookup performLookup)
        {
            this.logger = logger;
            this.performLookup = performLookup;
        }
    }
}
