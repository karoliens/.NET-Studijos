using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAndPolymorphism
{
    public class Employee : IPayable
    {
        public Employee() { }

        public Employee(int salary)
        {
            Salary = salary;
        }

        public Employee(string mailingAddress)
        {
            MailingAddress = mailingAddress;
        }

        private int Salary { get; set; }
        public string MailingAddress { get; private set; }

        public int IsgautiAlga()
        {
            return Salary;
        }

        public string IsgautiUzmokescioAdresa()
        {
            return MailingAddress;
        }

        public int PadidintiAlga(int priedas)
        {
            return Salary + priedas;
        }
    }
}
