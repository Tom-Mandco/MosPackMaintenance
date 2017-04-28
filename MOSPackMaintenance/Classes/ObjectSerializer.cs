namespace MCO.Applications.MOSPackMaintenance.Classes
{
    using Interfaces;

    public class ObjectSerializer : ISerializeObjects
    {
        private readonly ILog logger;

        public ObjectSerializer(ILog logger)
        {
            this.logger = logger;
        }

    }
}
