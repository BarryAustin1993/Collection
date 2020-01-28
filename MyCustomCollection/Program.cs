using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCustomCollection
{
    class Program
    {
        static void Main(string[] args)
        {


                Collection<string> collection1 = new Collection<string>() { "1", "3", "5" };
                Collection<string> collection2 = new Collection<string>() { "2", "4", "6", "8", "10" };
                Collection<string> collection3 = new Collection<string>();

                collection3 = Collection<string>.Zip(collection1, collection2);

        


        }
    }
}
