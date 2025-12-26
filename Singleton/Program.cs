namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter db choice: 1.SqlServer 2.MySqlServer 3.OracleServer");
                int dbChoice = Convert.ToInt32(Console.ReadLine()); 

                DatabaseFactory factory = new DatabaseFactory();    
                Database someDb = factory.GetDatabase(dbChoice);
                Console.WriteLine("Enter db operation choice: 1.Insert 2.Update 3.Delete");
                int opChoice = Convert.ToInt32(Console.ReadLine());

                switch (opChoice)
                {
                    case 1:
                        someDb.Insert();
                        break;
                    case 2:
                        someDb.Update();
                        break;
                    case 3:
                        someDb.Delete();
                        break;
                    default:
                        Console.WriteLine("Invalid Db choice");
                        break;
                }
            }
        }
    }

    public abstract class Database
    {
        public Logger _logger = null;

        public Database()
        {
            _logger = Logger.GetLogger();
        }
        protected abstract void DoInsert();
        protected abstract void DoUpdate();
        protected abstract void DoDelete();
        protected abstract string GetDatabaseName();

        public void Insert()
        {
            DoInsert();
            _logger.Log($"Insert from {GetDatabaseName()} done.");
        }
        public void Update()
        {
            DoUpdate();
            _logger.Log($"Update from {GetDatabaseName()} done.");
        }
        public void Delete()
        {
            DoDelete();
            _logger.Log($"Delete from {GetDatabaseName()} done.");
        }
    }

    public class DatabaseFactory
    {
        public Database GetDatabase(int dbChoice)
        {
            Database db = null;
            switch(dbChoice)
            {
                case 1:
                    db = new SqlServer();
                    break;
                case 2:
                    db = new MySqlServer();
                    break;
                case 3:
                    db = new OracleServer();
                    break;
                default:
                    db = null;
                    break;
            }
            return db;
        }
    }

    public class MySqlServer : Database
    {
        protected override string GetDatabaseName()
        {
            return "MySqlServer";
        }
        protected override void DoInsert()
        {
            Console.WriteLine("Record inserted successfully in MySqlServer");
        }
        protected override void DoUpdate()
        {
            Console.WriteLine("Record updated successfully in MySqlServer");
        }
        protected override void DoDelete()
        {
            Console.WriteLine("Record deleted successfully in MySqlServer");
        }
    }
    public class SqlServer : Database
    {
        protected override string GetDatabaseName()
        {
            return "SqlServer";
        }
        protected override void DoInsert()
        {
            Console.WriteLine("Record inserted successfully in SqlServer");
        }
        protected override void DoUpdate()
        {
            Console.WriteLine("Record updated successfully in SqlServer");
        }
        protected override void DoDelete()
        {
            Console.WriteLine("Record deleted successfully in SqlServer");
        }
    }
    public class OracleServer : Database
    {
        protected override string GetDatabaseName()
        {
            return "OracleServer";
        }
        protected override void DoInsert()
        {
            Console.WriteLine("Record inserted successfully in MySqlServer");
        }
        protected override void DoUpdate()
        {
            Console.WriteLine("Record updated successfully in OracleServer");
        }
        protected override void DoDelete()
        {
            Console.WriteLine("Record deleted successfully in OracleServer");
        }
    }

    public class Logger
    {
        private static readonly Logger _logger = new Logger();
        private Logger()
        {
            Console.WriteLine("Logger object created first time");
        }

        public static Logger GetLogger()
        {
            return _logger;
        }

        public void Log(string msg)
        {
            Console.WriteLine("---Logged at{0}, massage: {1}",DateTime.Now.ToString(),msg);
        }
    }
}
