using System;
using System.Collections.Generic;

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
        public DateTime DOB { get; set; } = DateTime.Now.AddYears(-20);
        public ContactInfo ContactInfo { get; set; }
        public MaritalStatus MaritalStatus { get; set; }
        public List<Payment> Payments { get; set; }
        public string Notes { get; set; }
        public string image { get; set; }
        public List<Document> Documents { get; set; }
            

        public string FullName
        {
            get
            {
                if (string.IsNullOrWhiteSpace(MiddleNames))
                {
                    return FirstName + " " + LastName;
                }

                return FirstName + " " + MiddleNames + " " + LastName;
            }
        }

        public int Age
        {
            get
            {
                return (int)(DateTime.UtcNow.Subtract(DOB).TotalDays / 365);
            }
        }

        

    }
}