using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
   public class ListDataAccess: IDataAccess
    {
        public List<Product> LoadData()
        {
            Console.WriteLine("Reading data from list...");
            List<Product> products = new List<Product>();
            return products;
        }
        public void SaveData()
        {
            Console.WriteLine("Saving data to list");
        }
    }
}
