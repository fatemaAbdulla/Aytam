using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Aytam.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            
        }
        
        public DbSet<Country> Countries { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<IncomeType> IncomeTypes { get; set; }
        public DbSet<DocumentType> DocumentTypes { get; set; }
        public DbSet<PaymentType> PaymentTypes { get; set; }
        public DbSet<Income> Incomes { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<JobTitle> JobTitles { get; set; }
        public DbSet<Guardian> Guardians { get; set; }
        public DbSet<Orphan> Orphans { get; set; }
        public DbSet<Parent> Parents { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<Sponser> Sponsers { get; set; }
        public DbSet<Sponsership> Sponserships { get; set; }




        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            
        }
    }

   
}
