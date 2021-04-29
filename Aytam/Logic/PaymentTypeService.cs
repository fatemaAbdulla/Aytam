using Aytam.Data;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;


namespace Aytam.Logic
{
    public class PaymentTypeService
    {
        private readonly ApplicationDbContext _db;
        public PaymentTypeService(ApplicationDbContext dbContext)
        {
            _db = dbContext;
        }
        public async Task<IEnumerable<PaymentType>> GetAllPaymentTypes()
        {
            return await _db.PaymentTypes.ToListAsync();

        }
        public async Task<PaymentType> AddNewPaymentType(PaymentType paymentType)
        {
            await _db.PaymentTypes.AddAsync(paymentType);
            await _db.SaveChangesAsync();
            return paymentType;
        }

        public async Task<PaymentType> UpdatePaymentType(PaymentType paymentType)
        {
            var pt = await _db.PaymentTypes.FindAsync(paymentType.ID);
            if (pt == null)
            {
                throw new System.Exception("Payment Type not found");

            }
            pt.isExpense = paymentType.isExpense;
            pt.Notes = paymentType.Notes;
            pt.Type = paymentType.Type;
            await _db.SaveChangesAsync();
            return pt;
        }

    }

}