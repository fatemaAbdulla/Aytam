using System;
using System.Collections.Generic;
#nullable enable
namespace Aytam.Data
{
    public class Payment
    {
        public Payment(decimal amount,bool isExpense, decimal oldBalance)
        {
            Amount = amount;
            IsExpense = isExpense;
            _Balance = isExpense ? oldBalance - amount : oldBalance + amount;

        }
        private decimal _Balance;
        public int ID { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; } = DateTime.UtcNow;
        /// <summary>
        /// this is the type of payment e.g (Online, Bank Transfer..)
        /// </summary>
        public PaymentType PaymentType { get; set; } = PaymentType.NotSpecified;
        public Person? PaidBy { get; set; }
        public Person? RecievedBy { get; set; }
        public Person? RecievedOnBehalfOf { get; set; }
        public string ChequeNumber { get; set; } = "";
        public String Notes { get; set; } = "";
        /// <summary>
        /// true if this payment is expense, false if it's income
        /// </summary>
        public bool IsExpense { get; set; }
        public List<Document> Documents { get; set; }
        /// <summary>
        /// if this payment is outgoing this is specified 
        /// </summary>
        public ExpenseType? ExpenseType { get; set; }
   
        public decimal BalanceAfterTransaction
        {
            get
            {
                return _Balance;
            }
        }


    }
}