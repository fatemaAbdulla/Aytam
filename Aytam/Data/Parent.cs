using System;
using System.Collections.Generic;

namespace Aytam.Data
{
    public class Parent : Person
    {
        public Parent()
        {
            DateOfDeath = null;
        }

        public DateTime? DateOfDeath { get; set; }
        public List<Orphan> Children { get; set; }

        public bool IsDead
        {
            get
            {
                return DateOfDeath != null;
            }

        }
    }
}