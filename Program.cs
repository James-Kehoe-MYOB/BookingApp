using System;

namespace BookingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            BookingService myBookingService = new BookingService();
            var firstofJan20009am = new DateTime(2000, 1, 1, 9, 0, 0);
            var firstofJan2000930am = new DateTime(2000, 1, 1, 9, 30, 0);
            var onehour = new TimeSpan(1, 0, 0);
            var booking1 = new Booking(firstofJan20009am, onehour);
            var booking2 = new Booking(firstofJan2000930am, onehour);

            try {
                if (myBookingService.Book(booking1)) {
                    Console.WriteLine("booked!");
                }
                else {
                    Console.WriteLine("not booked!");
                }

                if (myBookingService.Book(booking2)) {
                    Console.WriteLine("booked 2!");
                }
                else {
                    Console.WriteLine("not booked 2!");
                }
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
            }
        }
        
        
    }
}
