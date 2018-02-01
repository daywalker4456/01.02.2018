using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3.Model
{
    public class User
    {
        public int UserId { get; set; }
        public string SID { get; set; }
        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }
        public int Email { get; set; }
        public int locatId { get; set; }
        //public Nullable<int> locatId { get; set; }
        //public int? locatId { get; set; }
    }
}
