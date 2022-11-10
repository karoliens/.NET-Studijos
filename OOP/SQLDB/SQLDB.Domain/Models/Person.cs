﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLDB.Domain.Models
{
    public class Person
    {
        public Person()
        {
        }

        public Person(string firstName, string lastName, DateTime birthDate, double weight)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
            Weight = weight;
        }

        [Key]
        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        // public int Age { get; set;
        public DateTime? BirthDate { get; set; } 
        public string? Email { get; set; } 
        public double? Height { get; set; } 
        public double Weight { get; set; } 
        public string? Biography { get; set; } 
    }
}
