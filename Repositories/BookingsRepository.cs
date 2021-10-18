using AimsCarRentals.Context;
using AimsCarRentals.Interfaces;
using AimsCarRentals.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AimsCarRentals.Repositories
{
    public class BookingsRepository:IBookingsRepository
    {
        public readonly AimsDbContext aimsDbContext;
        public BookingsRepository(AimsDbContext aimsDbContext)
        {
            this.aimsDbContext = aimsDbContext;
        }
        public Bookings AddBookings(Bookings bookings)
        {
            aimsDbContext.Bookings.Add(bookings);
            aimsDbContext.SaveChanges();
            return bookings;
        }
        public Bookings UpdateBookings(Bookings bookings)
        {
            aimsDbContext.Bookings.Update(bookings);
            aimsDbContext.SaveChanges();
            return bookings;
        }
        public Bookings Find(int id)
        {
            return aimsDbContext.Bookings.Find(id);
        }
        public Bookings Delete(int id)
        {
            var bookings = Find(id);
            if (bookings != null)
            {
                aimsDbContext.Bookings.Remove(bookings);
                aimsDbContext.SaveChanges();
            }
            return null;
        }
        public List<Bookings> GetAll()
        {
            return aimsDbContext.Bookings.ToList();
        }
    }
}

