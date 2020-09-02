using System;
using System.Collections;
using System.Collections.Generic;

namespace Aytam.Data
{
    public class Orphan : Person
    {
        public Parent Father { get; set; }
        public Parent Mother { get; set; }
        public Guardian Guardian { get; set; }
        public ICollection<Person> Sponsers { get; set; }
      




    }
}
