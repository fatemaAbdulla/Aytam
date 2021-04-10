using System;
using System.Collections;
using System.Collections.Generic;

namespace Aytam.Data
{
    public class Orphan : Person
    {
        public Parent Father { get; set; }
        public Parent Mother { get; set; }
        public Parent Guardian { get; set; }
        public List<Sponsorship> Sponsorships { get; set; }
        public bool isSayed { get; set; }
        
    }
}
