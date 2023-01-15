
using System.Configuration;

namespace PersonalFinanceAccounting.Library.PersonalFinanceDb
{
    public class PersonalFinanceDbContext
    {
        private readonly string connectionString = null;
        //private readonly string MyConnString = ConfigurationManager.ConnectionStrings["MyConnString"].ConnectionString;
        public PersonalFinanceDbContext()
        {
            connectionString = ConfigurationManager.ConnectionStrings["MyConnString"].ConnectionString;
        }
    }
}
