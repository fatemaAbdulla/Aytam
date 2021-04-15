using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Aytam.Data
{
    public class Person
    {
        public int ID { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "First Name is Required")]
        public string FirstName { get; set; }
        public string MiddleNames { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Last Name is Required")]
        public string LastName { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "CPR is Required")]
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
                return string.Join(" ", FirstName ?? "", MiddleNames ?? "", LastName ?? "");

                //if (string.IsNullOrWhiteSpace(MiddleNames))
                //{
                //    return FirstName + " " + LastName;
                //}

                //return FirstName + " " + MiddleNames + " " + LastName;
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