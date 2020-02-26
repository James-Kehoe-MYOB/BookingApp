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
                Tuple<bool, ServiceProvider> result1 = myBookingService.Book(booking1);
                Tuple<bool, ServiceProvider> result2 = myBookingService.Book(booking2);
                
                if (result1.Item1) {
                    Console.WriteLine($"booked by {result1.Item2.name}!");
                }
                else {
                    Console.WriteLine("not booked!");
                }

                if (result2.Item1) {
                    Console.WriteLine($"booked by {result2.Item2.name}!");
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
