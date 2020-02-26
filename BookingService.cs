using System;
using System.Collections.Generic;
using System.Linq;

namespace BookingApp {
    public class BookingService {
        
        List<ServiceProvider> ServiceProviders = new List<ServiceProvider>();

        public BookingService() {
            ServiceProviders.Add(new ServiceProvider("Heather Graham", "AEST"));
            ServiceProviders.Add(new ServiceProvider("Troy Yates", "AEST"));
            ServiceProviders.Add(new ServiceProvider("Aimee Pearce", "AEST"));
        }

        public Tuple<bool, ServiceProvider> Book(Booking booking) {
            foreach (var provider in ServiceProviders) {
                if (provider.Book(booking)) {
                    return new Tuple<bool, ServiceProvider>(true, provider);
                }
                else {
                    
                }
            }

            return new Tuple<bool, ServiceProvider>(false, null);

        }
        
        
    }
}