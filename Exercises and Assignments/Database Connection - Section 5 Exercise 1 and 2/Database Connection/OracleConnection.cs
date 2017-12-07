using System;

namespace Database_Connection
{
    // Derived class
    public class OracleConnection : DbConnection
        {
            // Override the abstract OpenConnection() method declared in the DbConnection class
            public override void OpenConnection(string SQLconnectionString, TimeSpan Timeout)
            {
                Console.WriteLine("Opened Oracle Connection");
            }

            public override void CloseConnection()
            {
                Console.WriteLine("Closed Oracle Connection");
            }
        }
    //}
}
