using System;
using System.Collections.Generic;

namespace Database_Connection
{
    //partial class Program
    //{
    // Base class
    public abstract class DbConnection
        {
            // base class called DbConnection. This class should have two properties:
            public string _connectionString { get; set; }
            private TimeSpan _timeout { get; set; }

        public abstract void OpenConnection(string SQLconnectionString, TimeSpan Timeout); // { Console.WriteLine("Default open implementation\n"); }
        public abstract void CloseConnection(); // { Console.WriteLine("Default close implementation\n"); }
        }

        //public class Connection
        //{
        //    string SQLconnectionString;
        //    TimeSpan Timeout;

        //    public void Connect(List<DbConnection> connections)
        //    {
        //        foreach (var connection in connections)
        //        {
        //            connection.OpenConnection(SQLconnectionString, Timeout);
        //        }
        //    }
        //}
    //}
}
