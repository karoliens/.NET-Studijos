using SQLDB.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLDB.Infrastructure.Interfaces
{
    public interface IBloggingRepository
    {
        public void AddPerson(Person person);
        public void AddPerson(string firstName, string lastName, DateTime birthDate);
        public void PrintAllPersons();
    }
}
