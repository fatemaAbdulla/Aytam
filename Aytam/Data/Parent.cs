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
        public JobTitle? JobTitle { get; set; }
        public FinancialStatus? FinancialStatus { get; set; }
        /// <summary>
        /// income monthly
        /// </summary>
        public List<Income> Incomes { get; set; }

        public bool IsDead
        {
            get
            {
                return DateOfDeath != null;
            }

        }
        
    }
   
}