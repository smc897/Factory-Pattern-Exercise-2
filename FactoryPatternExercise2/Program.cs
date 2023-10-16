using System.Runtime.InteropServices;
using System.Xml.Serialization;

namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            int? choice = 0;
            do
            {
                Console.WriteLine("What type of database do you want? enter: 1 for sql, 2 for mongo, 3 for list");
                choice = Int32.Parse(Console.ReadLine());

                if (choice < 1) Console.WriteLine("That is too low,enter: 1 for sql, 2 for mongo, 3 for list ");
                else if(choice>3) Console.WriteLine("That is too high,enter: 1 for sql, 2 for mongo, 3 for list ");
            } while (choice < 1 || choice > 3);

            IDataAccess i = new MongoDataAccess(); ;

            switch (choice) {
                case 1: {
                        i = DataAccessFactory.GetDataAccessType("sql");
                        break;
                    }
                case 2:
                    {
                        i = DataAccessFactory.GetDataAccessType("mongo");
                        break;
                    }
                case 3:
                    {
                        i = DataAccessFactory.GetDataAccessType("list");
                        break;
                    }

            }

            i.SaveData();
            i.LoadData();
            }
    }
}
