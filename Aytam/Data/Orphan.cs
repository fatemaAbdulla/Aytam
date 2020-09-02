using System;
using System.Collections;
using System.Collections.Generic;

namespace Aytam.Data
{
    public class Orphan
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }
        public int CPR { get; set; }
        public int Phone { get; set; }
        public DateTime DOB { get; set; }
        public Address Address { get; set; }
        public Person Father { get; set; }
        public Person Mother { get; set; }
        public Person Guardian { get; set; }
        public ICollection<Person> Sponsers { get; set; }




    }
}
