using System;

namespace Database_Connection
{
    // Derived class
    public class OracleConnection : DbConnection
        {
            // Override the abstract OpenConnection() method declared in the DbConnection class
            public override void OpenConnection(string ConnectionString, TimeSpan Timeout)
            {
                if (!string.IsNullOrEmpty(ConnectionString))
                {
                    Console.WriteLine("Opened Oracle Connection");
                    Console.WriteLine("ConnectionString: " + ConnectionString);
                }
                else
                {
                    Console.WriteLine("Error: the ConnectionString is empty");
                }
            }

            public override void CloseConnection()
            {
                Console.WriteLine("Closed Oracle Connection");
            }
        }
    //}
}
