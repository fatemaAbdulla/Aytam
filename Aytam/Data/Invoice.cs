using System;
using System.Collections.Generic;
using System.Linq;

namespace Aytam.Data
{
    
    public class Invoice
    {
        public int ID { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime DueDate { get; set; }
        public decimal TotalAmount { get; set; }
        public Sponsorship Sponsorship { get; set; }
        public decimal AmountPaid
        {
            get
            {
              return  Payments.Sum(payment => payment.Amount);
                
            }
        }
        public decimal AmountDue
        {
            get
            {
                return TotalAmount - AmountPaid;
            }
        }
        public List<Payment> Payments { get; set; } = new List<Payment>();
        public string Notes { get; set; }
        public InvoicePaymentStatus PaymentStatus
        {
            get
            {
                if (AmountDue > 0 && DateTime.UtcNow > DueDate)
                {
                    return InvoicePaymentStatus.Overdue;
                }
                else if (AmountDue == 0)
                {
                    return InvoicePaymentStatus.Paid;
                }
                else if (AmountDue < TotalAmount)
                {
                    return InvoicePaymentStatus.PartiallyPaid;
                }
                else 
                {
                    return InvoicePaymentStatus.UnPaid;
                }
                
            }
        }
        

    }
}