﻿using AimsCarRentals.Context;
using AimsCarRentals.Interfaces;
using AimsCarRentals.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AimsCarRentals.Repositories
{
    public class PaymentRepository : IPaymentRepository
    {
        public readonly AimsDbContext aimsDbContext;
        public PaymentRepository(AimsDbContext aimsDbContext)
        {
            this.aimsDbContext = aimsDbContext;
        }
        public Payment AddPayment(Payment payment)
        {
            aimsDbContext.Payments.Add(payment);
            aimsDbContext.SaveChanges();
            return payment;
        }
       
        public Payment Find(int id)
        {
            return aimsDbContext.Payments.Include(c => c.Bookings).Include(c => c.Car).FirstOrDefault(c => c.Id == id);
        }
        public Payment Delete(int id)
        {
            var payment = Find(id);
            if (payment != null)
            {
                aimsDbContext.Payments.Remove(payment);
                aimsDbContext.SaveChanges();
            }
            return null;
        }
        public List<Payment> GetAll()
        {
            return aimsDbContext.Payments.ToList();
        }
       /* public List<Bookings> BookingHistory(int userId)
        {
            return aimsDbContext.Bookings.Where(c => c.UserId == userId).Include(c => c.User).ToList();
        } */
        public Payment FindPaymentByBookingRef(string booking_ref)
        {
            return aimsDbContext.Payments.Find(booking_ref);
        }

    }
}
