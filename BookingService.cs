using System.Collections.Generic;
using System.Linq;

namespace BookingApp {
    public class BookingService {
        
        List<ServiceProvider> ServiceProviders = new List<ServiceProvider>();

        public BookingService() {
            ServiceProviders.Add(new ServiceProvider("Heather Graham", "AEST"));
            // ServiceProviders.Add(new ServiceProvider("Troy Yates", "AEST"));
            // ServiceProviders.Add(new ServiceProvider("Aimee Pearce", "AEST"));
        }

        public bool Book(Booking booking) {
            return ServiceProviders.First().Book(booking);
        }
        
        
    }
}