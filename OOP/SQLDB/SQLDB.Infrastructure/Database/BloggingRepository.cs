using SQLDB.Domain.Models;
using SQLDB.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLDB.Infrastructure.Database
{
    public class BloggingRepository : IBloggingRepository
    {
        public BloggingRepository()
        {
            using var context = new BloggingContext();
            context.Database.EnsureCreated();
        }

        public void AddPerson(Person person)
        {
            using var context = new BloggingContext();
            context.Persons.Add(person);
            context.SaveChanges();
        }

        public void AddPerson(string firstName, string lastName, DateTime birthDate)
        {
            using var context = new BloggingContext();

            Person person = new Person
            {
                FirstName = firstName,
                LastName = lastName,
                BirthDate = birthDate
            };

            context.Persons.Add(person);
            context.SaveChanges();
        }

        public void PrintAllPersons()
        {
            using var context = new BloggingContext();

            var persons = context.Persons;

            foreach(var person in persons)
            {
                Console.WriteLine($"{person.PersonId}. {person.FirstName} {person.LastName}");
            }
        }
    }
}
