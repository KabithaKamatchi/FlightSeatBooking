namespace FlightBookingSystem
{
    public class Program
    {
        public static void Main(string[] args)
        {

            FlightBooking flightBooking = new FlightBooking(5, 5);

            while (true)
            {
                flightBooking.ShowAvailableSeatNumber();

                if (flightBooking.IsFullyBooked())
                {
                    Console.WriteLine("The flight is fully booked.");
                    break;
                }

                Console.WriteLine("Enter passenger name: ");
                string passengerName = Console.ReadLine();

                Console.WriteLine("Enter passenger gender (Male/Female): ");
                string passengerGender = Console.ReadLine();

                Console.WriteLine("Enter passenger age: ");
                if (!int.TryParse(Console.ReadLine(), out int passengerAge))
                {
                    Console.WriteLine("Invalid age entered. Please enter a number.");
                    continue;
                }

                Console.WriteLine("Enter seat row number: ");
                if (!int.TryParse(Console.ReadLine(), out int seatRow) || seatRow < 1 || seatRow > 5)
                {
                    Console.WriteLine("Invalid row number. Please enter a number between 1 and 5.");
                    continue;
                }

                Console.WriteLine("Enter seat column number : ");
                if (!int.TryParse(Console.ReadLine(), out int seatColumn) || seatColumn < 1 || seatColumn > 5 )
                {
                    Console.WriteLine("Invalid column number. Please enter a number between 1 and 10.");
                    continue;
                }

                Passenger passenger = new Passenger(passengerName, passengerGender, passengerAge);
                flightBooking.BookSeat(seatRow, seatColumn, passenger);
            }
        }
    }
    }

        