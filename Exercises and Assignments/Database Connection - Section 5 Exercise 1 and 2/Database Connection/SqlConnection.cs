using System;

namespace Database_Connection
{
    // Need base class constructor
    // ReSharper is not installed - creates permissions errors

    // Derived class
    public class SqlConnection : DbConnection
        {
            // Override the abstract OpenConnection() method declared in the DbConnection class
            public override void OpenConnection(string SQLconnectionString, TimeSpan Timeout)
            {
                Console.WriteLine("Opened SQL Connection");
            }

            public override void CloseConnection()
            {
                Console.WriteLine("Closed SQL Connection");
            }
        }
    //}
}
