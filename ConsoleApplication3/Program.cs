using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication3.Model;

namespace ConsoleApplication3
{
    class Program
    {
        MSCEntity db = new MSCEntity();

        static void Main(string[] args)
        {
            using (MSCEntity db = new MSCEntity())
            {
                var users = db.Users;

                foreach (User user in users)
                {
                    Console.WriteLine(user.UserId);
                }
            }
        }
    }
}
