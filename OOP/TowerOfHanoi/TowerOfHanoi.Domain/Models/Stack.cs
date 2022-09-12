﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerOfHanoi.Domain.Models
{
    public class Stack
    {
        // constructors
        public Stack() { }

        public Stack(List<Disk> disks)
        {
            Disks = disks;
        }

        // methods
        public int CountDisks()
        {
            var result = Disks.Count();

            return result;
        }

        public Disk RemoveDisk()
        {
            var disk = Disks.Last();  

            Disks.Remove(disk);

            return disk;
        }

        public void AddDisk(Disk disk)
        {
            Disks.Insert(0, disk);
        }

        public Disk GetDisk(int index)
        {
            if (index < Disks.Count())
            {
                return Disks[index];
            }

            else
            {
                return new Disk();
            }     
        }

        // properties
        public List<Disk> Disks { get; set; } = new List<Disk> { };
    }
}
