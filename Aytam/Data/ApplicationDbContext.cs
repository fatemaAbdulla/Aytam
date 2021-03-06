﻿using System;
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
        public DbSet<Orphan> Orphans { get; set; }
        public DbSet<Parent> Parents { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<Sponsor> Sponsors { get; set; }
        public DbSet<Sponsorship> Sponsorships { get; set; }
       



        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Parent>().HasMany(p => p.Children);
            builder.Entity<Orphan>().HasOne<Parent>(o => o.Father);
            builder.Entity<Orphan>().HasOne<Parent>(o => o.Mother);
            builder.Entity<Orphan>().HasOne<Parent>(o => o.Guardian);
            builder.Entity<Person>().HasMany(p => p.Payments);
            builder.Entity<Payment>().HasOne<Person>(p => p.PaidBy);
            builder.Entity<Payment>().HasOne<Person>(p => p.RecievedBy);
            builder.Entity<Payment>().HasOne<Person>(p => p.RecievedOnBehalfOf);
            builder.Entity<Person>().HasIndex(p => p.CPR).IsUnique();
        }
    }

   
}
