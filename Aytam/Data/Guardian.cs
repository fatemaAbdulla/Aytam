using System.Collections.Generic;

namespace Aytam.Data
{
    public class Guardian : Person
    {
        public JobTitle JobTitle { get; set; }
        public FinancialStatus FinancialStatus { get; set; }
        /// <summary>
        /// income monthly
        /// </summary>
        public List<Income> Incomes { get; set; }

    }
}