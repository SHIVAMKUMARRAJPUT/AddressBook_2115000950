﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer.DTO
{
    public class Addresses
    {

        public int Id { get; set; }

        public string FullName { get; set; }

    
        public string Email { get; set; }

       
        public long PhoneNumber { get; set; }

        public string Address { get; set; }

      
        public string UserEmail { get; set; }
    }
}
