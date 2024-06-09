using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfDataWorksApp
{
    public class Employee
    {
        public string Name { get; set; } = null!;
        public int Age { get; set; }
        public Company? Company { get; set; }
        public string Avatar { get; set; }

        public override string ToString()
        {
            return $"{Name} {Age}";
        }
    }

    public class Company
    {
        public string Title { get; set; } = null!;
    }
}
