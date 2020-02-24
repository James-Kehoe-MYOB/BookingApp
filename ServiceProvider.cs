using System.Collections.Generic;

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
            Bookings.Add(booking);
            return true;
        }

    }
}