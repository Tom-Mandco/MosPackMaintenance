namespace MCO.Applications.MOSPackMaintenance.Classes
{
    using Interfaces;

    public class App : IApp
    {
        private readonly ILog logger;

        #region Initialization
        public App(ILog logger)
        {
            this.logger = logger;
        }
        #endregion




    }
}
