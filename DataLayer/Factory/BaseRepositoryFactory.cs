using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Factory
{
    public abstract class BaseRepositoryFactory
    {
        protected string ConnectionString;
        protected int CommandTimeout;

    }
}
