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
                    string strName = Console.ReadLine();

                    Console.Write("Enter Passenger Gender (M/F): ");
                    string strGender = Console.ReadLine();

                    Console.Write("Enter Passenger Age: ");
                    int nAge = int.Parse(Console.ReadLine());

                    Console.Write("Enter Row Number (1-10): ");
                    int nSeatRow = int.Parse(Console.ReadLine());

                    Console.Write("Enter Seat Number (1-5): ");
                    int nSeatNumber = int.Parse(Console.ReadLine());

                    Passenger passenger = new Passenger(strName, strGender, nAge);
                    FlightBooking.BookSeat(nSeatRow, nSeatNumber, passenger);               
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
