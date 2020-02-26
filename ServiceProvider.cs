using System;
using System.Collections.Generic;
using System.Linq;

namespace BookingApp {
    public class ServiceProvider {
        private string name;
        private string timezone;


        List<Booking> Bookings = new List<Booking>();

        public ServiceProvider(string name, string timezone) {
            this.name = name;
            this.timezone = timezone;
        }

        public bool Book(Booking booking) {
            DateTime startTime = new DateTime(booking.startTime.Year, booking.startTime.Month, booking.startTime.Day, 9, 0, 0); 
            DateTime endTime = new DateTime(booking.startTime.Year, booking.startTime.Month, booking.startTime.Day, 17, 0, 0);
            if (!(booking.startTime >= startTime && booking.endTime <= endTime)) {
                return false;
            }
            
            if (Bookings.Contains(booking, new BookingComparer())) {
                return false;
            }
            else {
                Bookings.Add(booking);
                return true;
            }
        }

    }

    class BookingComparer : IEqualityComparer<Booking> {
        public bool Equals(Booking x, Booking y) {
            if (x == null || y == null) {
                return false;
            }

            if (x.startTime == y.startTime) {
                return true;
            } 
            
            if (x.startTime < y.startTime && y.startTime < x.endTime) {
                return true;
            }

            return false;
        }

        public int GetHashCode(Booking obj) {
            throw new System.NotImplementedException();
        }
    }
}