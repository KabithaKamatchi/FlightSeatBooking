using System;
using System.Xml;

namespace FlightSeatBooking
{
    public static class FlightBooking
    {
        public static SeatAvailable[][] seats;
        public static char[] cSeatLabels = { 'A', 'B', 'C', 'D', 'E' };
        const int nRows = 10;
        const int nSeatsPerRow = 5;

        static FlightBooking()
        {
            seats = new SeatAvailable[nRows][];

            for (int i = 0; i < nRows; i++)
            {
                seats[i] = new SeatAvailable[nSeatsPerRow];
                for (int j = 0; j < nSeatsPerRow; j++)
                {
                    seats[i][j] = new SeatAvailable();
                }
            }
        }

        public static bool BookSeat(int nSeatRow, int nSeatNumber, Passenger passenger)
        {
            if (passenger == null)
            {
                Console.WriteLine("Error: Passenger cannot be null");
                return false;
            }

            
            int nCheckingRowIndex = nSeatRow - 1;
            int nCheckingColumnIndex = nSeatNumber - 1;

            if (seats[nCheckingRowIndex][nCheckingColumnIndex].IsBooked)
            {
                Console.WriteLine($"Seat {nSeatRow} - {cSeatLabels[nCheckingColumnIndex]} is already booked");
                return false;
            }
            else
            {
                seats[nCheckingRowIndex][nCheckingColumnIndex].IsBooked = true;
                seats[nCheckingRowIndex][nCheckingColumnIndex].passenger = passenger;
                Console.WriteLine($"Booking successful! Passenger Details: Name: {passenger.strName}, Gender: {passenger.strGender}, Age: {passenger.nAge}, Booking Row: {nSeatRow}, Seat Number: {nSeatNumber} - {cSeatLabels[nCheckingColumnIndex]}");
                return true;
            }
        }

        public static void ShowAvailableTickets()
        {
            Console.WriteLine("| Window  | Middle | Aisle  | Aisle  | Middle | Window |");
            for (int i = 0; i < nRows; i++)
            {
                for (int j = 0; j < nSeatsPerRow; j++)
                {
                    if (!seats[i][j].IsBooked)
                    {
                        Console.Write($"{i + 1}{cSeatLabels[j]} A. ");
                    }
                    else
                    {
                        Console.Write($"{i + 1}{cSeatLabels[j]} X. ");                       
                    }
                }
                Console.WriteLine();
            }
            
        }

        public static void ShowBookedSeats()
        {
            bool bIsPassengerFound = false;
            Console.WriteLine("Booked Seats: ");
            for (int i = 0; i < nRows; i++)
            {
                Console.Write("|");
                for (int j = 0; j < nSeatsPerRow; j++)
                {
                    if (seats[i][j].IsBooked)
                    {
                        bIsPassengerFound = true;
                        Console.WriteLine($" {i + 1} {cSeatLabels[j]} (Passenger: {seats[i][j].passenger.strName})");                      
                    }
                 }                   
             }

            if (!bIsPassengerFound)
            {
                Console.WriteLine("No booked seats available.");
            }
        }
        }
    }

