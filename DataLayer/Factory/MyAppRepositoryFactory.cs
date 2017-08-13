using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Repository.Base;

namespace DataLayer.Factory
{
    public class MyAppRepositoryFactory:BaseRepositoryFactory
    {
        public MyAppRepositoryFactory(string sqlConnectionString, int commandTimeout)
        {
            ConnectionString = sqlConnectionString;
            CommandTimeout = commandTimeout;
        }
        public T Create<T>() where T : IMyAppBaseRepository
        {
            var repo = RepositoryContainer.GetRepository<T>();
            repo.ConnectionString = ConnectionString;
            repo.CommandTimeout = CommandTimeout;
            return repo;
        }
    }
}


