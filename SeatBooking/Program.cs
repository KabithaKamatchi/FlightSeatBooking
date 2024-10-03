using FlightSeatBooking;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("1. Show Available Seats");
            Console.WriteLine("2. Book a Seat");
            Console.WriteLine("3. Show Booked Seats");          
            Console.WriteLine("4. Exit");
            Console.Write("Choose an option: ");

            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    FlightBooking.ShowAvailableTickets();
                    break;
             
                case 2:
                    Console.Write("Enter Passenger Name: ");
                    string name = Console.ReadLine();

                    Console.Write("Enter Passenger Gender (M/F): ");
                    string gender = Console.ReadLine();

                    Console.Write("Enter Passenger Age: ");
                    int age = int.Parse(Console.ReadLine());

                    Console.Write("Enter Row Number (1-10): ");
                    int row = int.Parse(Console.ReadLine());

                    Console.Write("Enter Seat Number (1-5): ");
                    int seat = int.Parse(Console.ReadLine());

                    Passenger passenger = new Passenger(name, gender, age);
                    FlightBooking.BookSeat(row, seat, passenger);
                    break;

                case 3:
                    FlightBooking.ShowBookedSeats();
                    break;

                case 4:
                    return; 

                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}
