using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repository.Base
{
    public class BaseRepository:IBaseRepository
    {
        public string ConnectionString { get; set; }
        public int CommandTimeout { get; set; }
        public string Name
        {
            get { throw new NotImplementedException(); }
        }
    }
}
