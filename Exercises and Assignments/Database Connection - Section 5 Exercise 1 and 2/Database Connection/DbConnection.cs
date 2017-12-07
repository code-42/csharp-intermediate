using System;
using System.Collections.Generic;

/*
Exercise 1: Design a database connection
To access a database, we need to open a connection to it first and close it once our job is done.
Connecting to a database depends on the type of the target database and the database
management system (DBMS). For example, connecting to a SQL Server database is different
from connecting to an Oracle database. But both these connections have a few things in
common:
• They have a connection string
• They can be opened
• They can be closed
• They may have a timeout attribute (so if the connection could not be opened within the
timeout, an exception will be thrown).

Your job is to represent these commonalities in a base class called DbConnection. This class
should have two properties:

ConnectionString : string
Timeout : TimeSpan

A DbConnection will not be in a valid state if it doesn’t have a connection string. So you need to
pass a connection string in the constructor of this class. Also, take into account the scenarios
where null or an empty string is sent as the connection string. Make sure to throw an exception
to guarantee that your class will always be in a valid state.

Our DbConnection should also have two methods for opening and closing a connection. We
don’t know how to open or close a connection in a DbConnection and this should be left to the
classes that derive from DbConnection. These classes (eg SqlConnection or OracleConnection)
will provide the actual implementation. So you need to declare these methods as abstract.
Derive two classes SqlConnection and OracleConnection from DbConnection and provide a
simple implementation of opening and closing connections using Console.WriteLine(). In the
real-world, SQL Server provides an API for opening or closing a connection to a database. But
for this exercise, we don’t need to worry about it.
*/

namespace Database_Connection
{
    partial class Program
    {
        // Base class
        public class DbConnection
        {
            // base class called DbConnection. This class should have two properties:
            public string _connectionString { get; set; }
            private TimeSpan _timeout { get; set; }

            public virtual void OpenConnection(string SQLconnectionString, TimeSpan Timeout) { Console.WriteLine("Default open implementation\n"); }
            public virtual void CloseConnection() { Console.WriteLine("Default close implementation\n"); }
        }

        // Need base class constructor
        // ReSharper is not installed - creates permissions errors

        // Derived class
        public class SqlConnection : DbConnection
        {
            public override void OpenConnection(string SQLconnectionString, TimeSpan Timeout)
            {
                Console.WriteLine("Opened SQL Connection");
            }

            public override void CloseConnection()
            {
                Console.WriteLine("Closed SQL Connection");
            }
        }

        // Derived class
        public class OracleConnection : DbConnection
        {
            public override void OpenConnection(string SQLconnectionString, TimeSpan Timeout)
            {
                Console.WriteLine("Opened Oracle Connection");
            }

            public override void CloseConnection()
            {
                Console.WriteLine("Closed Oracle Connection");
            }
        }

        public class Connection
        {
            string SQLconnectionString;
            TimeSpan Timeout;

            public void Connect(List<DbConnection> connections)
            {
                foreach (var connection in connections)
                {
                    connection.OpenConnection(SQLconnectionString, Timeout);
                }
            }
        }
    }
}
