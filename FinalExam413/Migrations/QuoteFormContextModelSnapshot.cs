﻿// <auto-generated />
using FinalExam413.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FinalExam413.Migrations
{
    [DbContext(typeof(QuoteFormContext))]
    partial class QuoteFormContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.24");

            modelBuilder.Entity("FinalExam413.Models.QuoteResponse", b =>
                {
                    b.Property<int>("QuoteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Citation")
                        .HasColumnType("TEXT");

                    b.Property<string>("Date")
                        .HasColumnType("TEXT");

                    b.Property<string>("Quote")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Subject")
                        .HasColumnType("TEXT");

                    b.HasKey("QuoteId");

                    b.ToTable("Quotes");

                    b.HasData(
                        new
                        {
                            QuoteId = 1,
                            Author = "Lao Tzu",
                            Citation = "https://www.keepinspiring.me/famous-quotes/",
                            Date = "Unknown",
                            Quote = "The journey of a thousand miles begins with one step.",
                            Subject = "Inspiration"
                        },
                        new
                        {
                            QuoteId = 2,
                            Author = "Buddha",
                            Citation = "https://wisdomquotes.com/famous-quotes/",
                            Date = "Unknown",
                            Quote = "All that we are is the result of what we have thought.",
                            Subject = "Inspiration"
                        },
                        new
                        {
                            QuoteId = 3,
                            Author = "Spencer",
                            Citation = "My memory",
                            Date = "Several Ocassions",
                            Quote = "Are you ready? Are you ready? Let's go to war.",
                            Subject = "Inspiration"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
