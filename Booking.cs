using System;

namespace BookingApp {
    
    public class Booking {
        
        public DateTime startTime { get; private set; }
        public DateTime endTime { get; }

        public Booking(DateTime startTime, TimeSpan duration) {
            this.startTime = startTime;
            endTime = startTime.Add(duration);
        }
        
    }
    
}