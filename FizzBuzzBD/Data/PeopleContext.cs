using Microsoft.EntityFrameworkCore;
using System;
using FizzBuzzBD.Forms;


namespace FizzBuzzBD.Data
{
    public class PeopleContext : DbContext
    {
        public PeopleContext(DbContextOptions options) : base(options) { }
        public DbSet<FizzBuzzForm> Person { get; set; }
    }
}
