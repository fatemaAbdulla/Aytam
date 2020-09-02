using System;

namespace Aytam.Data
{
    public class Person
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string MiddleNames { get; set; }
        public string LastName { get; set; }
        public string CPR { get; set; }
        public Gender Gender { get; set; }
        public DateTime DOB { get; set; }
        
        public ContactInfo ContactInfo { get; set; }


    }
}