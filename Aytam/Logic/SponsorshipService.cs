using System;
using Aytam.Data;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Aytam.Logic
{
    public class SponsorshipService
    {
        private ApplicationDbContext _db;
        private InvoiceService _invoiceService;
        public SponsorshipService(ApplicationDbContext dbContext, InvoiceService invoiceService)
        {
            _db = dbContext;
            _invoiceService = invoiceService;
        }

        public async Task<List<Sponsorship>> GetAllSponsorships()
        {
            return await _db.Sponsorships
                .Include(s => s.Orphan)
                .Include(s => s.Sponsor)
                .ToListAsync();
        }

        public async Task<Sponsorship> GetSponsorship(int Id)
        {
            return await _db.Sponsorships.FindAsync(Id);
        }

        public async Task<Sponsorship> DeleteSponsorship(int Id)
        {
            var sponsorship = await _db.Sponsorships.FindAsync(Id);
            if (sponsorship == null)
            {
                throw new System.Exception($"Cannot find a sponsorship with the following id: {Id}");
            }
            if (sponsorship.Invoices.Any(i => i.Payments.Count > 0))
            {

                throw new System.Exception("Cannot delete this sponsorship as it has payments attached");
            }
            else
            {
                _db.Sponsorships.Remove(sponsorship);
                await _db.SaveChangesAsync();

                return sponsorship;
            }
        }

        public async Task<Sponsorship> AddSponsorship(Sponsorship sponsorship)
        {
            var invoicesDates = GenerateDates(sponsorship.StartDate, sponsorship.EndDate, sponsorship.PaymentFrequency);
            foreach (var date in invoicesDates)
            {
                sponsorship.Invoices.Add(new Invoice
                {
                    IssueDate = date,
                    DueDate = date.AddDays(1),
                    TotalAmount = sponsorship.Amount
                });
            }
            _db.Attach(sponsorship.Orphan);
            _db.Attach(sponsorship.Sponsor);
            _db.Sponsorships.Add(sponsorship);
            await _db.SaveChangesAsync();
            return sponsorship;
        }

        private List<DateTime> GenerateDates(DateTime start, DateTime end, PaymentFrequency frequency)
        {
            List<DateTime> dateTimes = new List<DateTime>();
            DateTime nextDate = start;
            do
            {
                dateTimes.Add(nextDate);
                switch (frequency)
                {
                    case PaymentFrequency.Annualy:
                        nextDate = nextDate.AddYears(1);
                        break;
                    case PaymentFrequency.HalfYearly:
                        nextDate = nextDate.AddMonths(6);
                        break;
                    case PaymentFrequency.Quarterly:
                        nextDate = nextDate.AddMonths(3);
                        break;
                    case PaymentFrequency.Monthly:
                        nextDate = nextDate.AddMonths(1);
                        break;
                    case PaymentFrequency.Fortnightly:
                        nextDate = nextDate.AddDays(14);
                        break;
                    case PaymentFrequency.Weekly:
                        nextDate = nextDate.AddDays(7);
                        break;
                    default:
                        nextDate = end;
                        break;
                }
            } while (nextDate <= end);
            return dateTimes;
        }
    }

}