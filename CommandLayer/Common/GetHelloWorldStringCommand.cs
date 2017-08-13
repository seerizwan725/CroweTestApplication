using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandLayer.Shared;
using DataLayer.Repository;

namespace CommandLayer.Common
{
    public class GetHelloWorldStringCommand : BaseCommand
    {
        public string Execute()
        {
            try
            {
                var myRepo = DBRepositoryFactory.Create<IMyTestObjectRepository>();
                //Call Repository function here to get data from DB
                var myreturnString = myRepo.GetHelloWorldFromDatabase();
                return myreturnString;
            }
            catch(Exception exc)
            {
                return "Error occured." + exc.Message;
            }
        }
    }
}
