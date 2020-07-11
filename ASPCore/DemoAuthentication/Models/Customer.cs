using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoAuthentication.Models
{
    public class Customer
    {
        public Guid Id { get; set; }
        public String FullName { get; set; }
        public String Phone { get; set; }
        public String Email { get; set; }
    }
}
