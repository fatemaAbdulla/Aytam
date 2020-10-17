using System;

namespace Aytam.Data
{
    public class Income
    {
        public int ID { get; set; }
        public decimal Amount { get; set; }
        public IncomeType Type { get; set; }
        public string Notes { get; set; }

    }
}