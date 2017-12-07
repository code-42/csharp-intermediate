using System;
using System.Collections.Generic;

namespace Database_Connection
{
    // Base class
    public abstract class DbConnection
        {
            // base class called DbConnection. This class should have two properties:
            public string _connectionString { get; set; }
            private TimeSpan _timeout { get; set; }
            
            // Declare abstract methods for abstract class
            public abstract void OpenConnection(string ConnectionString, TimeSpan Timeout);
            public abstract void CloseConnection();
        }
}
