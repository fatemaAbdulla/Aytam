using Aytam.Data;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Aytam.Logic
{
    public class InvoiceService
    {
        private ApplicationDbContext _db;

        public InvoiceService(ApplicationDbContext dbContext)
        {
            _db = dbContext;
        }

        public async Task<List<Invoice>> GetInvoices()
        {
            return await _db.Invoices
            .Include(i => i.Sponsorship.Sponsor)
            .Include(i => i.Payments)
            .ToListAsync();
        }

        public async Task<int> AddInvoice(Invoice invoice)
        {
            _db.Invoices.Add(invoice);
            return await _db.SaveChangesAsync();
        }

        public async Task<List<Invoice>> GetOverdueInvoices()
        {
            var invoices = await GetInvoices();
            return invoices.Where(i => i.PaymentStatus == InvoicePaymentStatus.Overdue).ToList();
        }

        public async Task<Payment> PayInvoice(int InvoiceId, decimal Amount)
        {
            if (Amount <= 0)
            {
                throw new System.Exception("Amount should be a positive number");
            }
            var invoice = await _db.Invoices.FindAsync(InvoiceId);
            if (invoice == null)
            {
                throw new System.Exception("Invoice not found");

            }
            if (invoice.AmountDue < Amount)
            {
                throw new System.Exception("Payment amount can't be more than the amount due");
            }
            var payment = new Payment(Amount, false);
            invoice.Payments.Add(payment);
            await _db.SaveChangesAsync();
            return payment;
        }
    }
}