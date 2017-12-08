using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_34___Extensibility
{
    class Program
    {
        static void Main(string[] args)
        {
            // var dbMigrator = new DbMigrator(new ConsoleLogger());
            // var dbMigrator = new DbMigrator(new ConsoleLogger(@"C:\MyDox\C_sharp_projects\csharp-intermediate\Section 6 - Interfaces\log.txt"));
            var dbMigrator = new DbMigrator(new FileLogger(@"C:\MyDox\C_sharp_projects\csharp-intermediate\Section 6 - Interfaces\Lecture 34 - Extensibility\log.txt"));
            dbMigrator.Migrate();
        }
    }
}
