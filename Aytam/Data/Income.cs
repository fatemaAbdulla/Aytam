using System;

namespace Aytam.Data
{
    /// <summary>
    /// used for guardian's income
    /// </summary>
    public class Income
    {
        public int ID { get; set; }
        public decimal Amount { get; set; }
        public IncomeType Type { get; set; }
        public string Notes { get; set; }

    }
}