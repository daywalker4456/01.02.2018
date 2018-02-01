using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            hMalServerEntities db = new hMalServerEntities();
            foreach (AT_Citys item in db.AT_Citys)
            {
                Console.WriteLine(item.CityID + " " + item.CityName);
            }

            AT_Citys city = new AT_Citys();
            city.CityName = "Pupa-pipa";
            db.AT_Citys.Add(city);
            db.SaveChanges();
        }
    }
}
