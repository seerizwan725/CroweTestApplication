using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Models;

namespace DataLayer.Repository.Base
{
    public interface IMyAppBaseRepository : IBaseRepository
    {
    }
    public abstract class MyAppBaseRepository:BaseRepository,IMyAppBaseRepository
    {
        protected MyAppContext GetMyAppDataContext()
        {

            return new MyAppContext();

        }
    }
}
