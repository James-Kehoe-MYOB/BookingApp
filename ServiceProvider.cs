using System.Collections.Generic;
using System.Linq;

namespace BookingApp {
    public class ServiceProvider {
        public string name { get; private set; }
        private string timezone;
        
        List<Booking> Bookings = new List<Booking>();

        public ServiceProvider(string name, string timezone) {
            this.name = name;
            this.timezone = timezone;
        }

        public bool Book(Booking booking) {
            
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