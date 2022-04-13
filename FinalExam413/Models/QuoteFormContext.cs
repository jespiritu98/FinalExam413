using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalExam413.Models
{
    public class QuoteFormContext : DbContext
    {
        //Constructor
        public QuoteFormContext(DbContextOptions<QuoteFormContext> options) : base(options)
        {
        }

        public DbSet<QuoteResponse> Quotes { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<QuoteResponse>().HasData(
            new QuoteResponse
            {
                QuoteId = 1,
                Quote = "The journey of a thousand miles begins with one step.",
                Author = "Lao Tzu",
                Date = "Unknown",
                Subject = "Inspiration",
                Citation = "https://www.keepinspiring.me/famous-quotes/"

            },
            new QuoteResponse
            {
                QuoteId = 2,
                Quote = "All that we are is the result of what we have thought.",
                Author = "Buddha",
                Date = "Unknown",
                Subject = "Inspiration",
                Citation = "https://wisdomquotes.com/famous-quotes/"

            },
            new QuoteResponse
            {
                QuoteId = 3,
                Quote = "Are you ready? Are you ready? Let's go to war.",
                Author = "Spencer Hilton",
                Date = "Several Ocassions",
                Subject = "Inspiration",
                Citation = "My memory"

            }
         );
        }
    }
}
