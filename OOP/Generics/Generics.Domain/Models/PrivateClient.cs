﻿using Generics.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.DomainTests.Models
{
    public class PrivateClient : IUser
    {
        public int Id { get ; set ; }
        public string Name { get ; set ; }
    }
}
