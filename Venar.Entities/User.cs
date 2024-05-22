using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Venar.Entities
{
    public class User 
    {
        
        public Guid Id { get; set; } 
        public string userName { get; set; }
        public string name { get; set; }
        public string lastName { get; set; }
        public string dni { get; set; }
        public string mail { get; set; }        
        public string password { get; set; }
        public int userType { get; set; }


    }
}
