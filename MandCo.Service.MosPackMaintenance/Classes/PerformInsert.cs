namespace MCO.Service.MosPackMaintenance.Classes
{
    using Interfaces;
    using Data.MosPackMaintenance.Interfaces;
    using Data.MosPackMaintenance.Models;
    using System;

    public class PerformInsert : IPerformInsert
    {
        private readonly IRepository oracleRepo;

        public PerformInsert(IRepository oracleRepo)
        {
            this.oracleRepo = oracleRepo;
        }

        public void Insert_NewPackDetail_ToDb(New_Pack newPack)
        {
            
        }

        public void Insert_NewPackHeader_ToDB(New_Pack newPack)
        {
            oracleRepo.Insert_NewPackHeader(newPack);
        }
    }
}
