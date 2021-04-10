using System;
using System.Collections.Generic;

namespace Aytam.Data
{
    /// <summary>
    /// defines a commitment between sponsors and orphans with the sponsorship ammount and payment frequency
    /// invoices will be issued according to that
    /// </summary>
    public class Sponsorship
    {
        public int ID { get; set; }
        public Orphan Orphan { get; set; }
        public Sponsor Sponsor { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal Amount { get; set; }
        public PaymentFrequency PaymentFrequency { get; set; }
        public List<Invoice> Invoices { get; set; }
        public string Notes { get; set; }
    }
}