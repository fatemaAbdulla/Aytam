using System;
using System.Collections.Generic;
#nullable enable
namespace Aytam.Data
{
    public class Payment
    {
        public Payment() { }
        public Payment(decimal amount, bool isExpense)
        {
            Amount = amount;
            IsExpense = isExpense;
            Date = DateTime.UtcNow;
        }
        public int ID { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; } = DateTime.UtcNow;
        /// <summary>
        /// this is the type of payment e.g (Online, Bank Transfer..)
        /// </summary>
        public PaymentMethod PaymentMethod { get; set; } = PaymentMethod.NotSpecified;
        public Person? PaidBy { get; set; }
        public Person? RecievedBy { get; set; }
        public Person? RecievedOnBehalfOf { get; set; }
        public string ChequeNumber { get; set; } = "";
        public String Notes { get; set; } = "";
        /// <summary>
        /// true if this payment is expense, false if it's income
        /// </summary>
        public bool IsExpense { get; set; }
        public List<Document>? Documents { get; set; }
        public PaymentType? PaymentType { get; set; }

    }
}
