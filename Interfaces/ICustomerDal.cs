using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface ICustomerDal
    {
        void Add();
        void Updated();
        void Delete();
    }

    class SqlServerCustomerDal : ICustomerDal
    {
          public void Add()
          {
                Console.WriteLine("Sql Added");
          }
          public void Updated()
            {
                    Console.WriteLine("Sql Updated");
            }
            public void Delete()
                {
                        Console.WriteLine("Sql Deleted");
                }
    }

    class OracleCustomerDal : ICustomerDal
    {
        public void Add()
        {
            System.Console.WriteLine("Oracle Added");
        }

        public void Delete()
        {
            System.Console.WriteLine("Oracle Deleted");
        }

        public void Updated()
        {
            System.Console.WriteLine("Oracle Updated");
        }
    }
}