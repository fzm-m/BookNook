﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using BookNook.Data;

namespace BookNook.Data
{
    public class BookNookContext(DbContextOptions<BookNookContext> options) : IdentityDbContext<BookNookUser>(options)
    {
        public DbSet<BookNook.Domain.Item> Item { get; set; } = default!;
        public DbSet<BookNook.Domain.Cart> Cart { get; set; } = default!;
        public DbSet<BookNook.Domain.Membership> Membership { get; set; } = default!;
        public DbSet<BookNook.Domain.Order> Order { get; set; } = default!;
        public DbSet<BookNook.Domain.Payment> Payment { get; set; } = default!;
        public DbSet<BookNook.Domain.Review> Review { get; set; } = default!;
        public DbSet<BookNook.Domain.Promotion> Promotion { get; set; } = default!;
        public DbSet<BookNook.Domain.OrderDetails> OrderDetails { get; set; } = default!;
        public DbSet<BookNook.Domain.Shipment> Shipment { get; set; } = default!;
        public DbSet<BookNook.Domain.MembershipLevel> MembershipLevel { get; set; } = default!;
        public DbSet<BookNook.Domain.Wishlist> Wishlist { get; set; } = default!;
        public DbSet<BookNook.Domain.ViewHistory> ViewHistory { get; set; } = default!;
        public DbSet<BookNook.Domain.User> User { get; set; } = default!;

    }
}
