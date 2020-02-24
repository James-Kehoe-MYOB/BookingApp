using System;

namespace BookingApp {
    public class Booking {
        private DateTime startTime;

        public Booking(DateTime startTime, TimeSpan duration) {
            this.startTime = startTime;
        }
    }
}