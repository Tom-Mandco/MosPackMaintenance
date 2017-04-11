namespace MCO.Data.MosPackMaintenance.Classes
{
    using Interfaces;
    using Data;

    public class OracleRepository : OracleBase, IRepository
    {
        public OracleRepository(string connectionString)
    : base(connectionString)
        {
        }
    }
}
