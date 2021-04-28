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
            .Include(i => i.Sponsorship.Sponsor).ToListAsync();
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
    }
}