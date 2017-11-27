using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Mosh called this consumer code
            var cookie = new HttpCookie();
            cookie["name"] = "Ed";
            Console.WriteLine(cookie["name"]);
        }
    }
}
