using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Model1Container db = new Model1Container();
            Entity1 user = new Entity1();

            user.DOB = DateTime.Now;

        }
    }
}
