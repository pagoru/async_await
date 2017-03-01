using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace async_await
{
    class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Gender { get; set; }
        public string Company { get; set; }
        public string Email { get; set; }
        public string Country { get; set; }

        public string ToPureString()
        {
            return $"{Name}{Surname}{Gender}{Company}{Email}{Country}";
        }

        public override string ToString()
        {
            return $"{Name} - {Surname} - {Gender} - {Company} - {Email} - {Country}";
        }
    }
}
