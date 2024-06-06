﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Venar.DTO
{
    public class UserDto 
    {
        
        public Guid Id { get; set; } 
        public string UserName { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Dni { get; set; }
        public string Mail { get; set; }        
        public string Password { get; set; }
        public DateTime CreatedAt { get; set; }
        //public int UserType { get; set; }


    }
}
