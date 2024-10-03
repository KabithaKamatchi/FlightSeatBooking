using System;

namespace FlightBookingSystem
{
    public class Passenger
    {
        public string strName { get; set; }

        public string strGender { get; set; }

        public int nAge { get; set; }

        public Passenger(string strName, string strGender, int nAge)
        {
            this.strName = strName;
            this.strGender = strGender;
            this.nAge = nAge;
        }
    }

    public class SeatAvailable
    {
        public bool IsBooked { get; set; }

        public Passenger passenger { get; set; }

        public SeatAvailable()
        {
            IsBooked = false;
        }
    }

    public class FlightBooking
    {
        SeatAvailable[][] seats;
        char[] cSeatLabels = { 'A', 'B', 'C', 'D', 'E' };
        int nRows = 10 ;
        int nSeatsPerRow = 5;
        public FlightBooking(int nRows , int nSeatsPerRow )
        {
            this.nRows = nRows;
            this.nSeatsPerRow = nSeatsPerRow;
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

        public bool BookSeat(int nSeatRow, int nSeatNumber, Passenger passenger)
        {
            if (passenger == null)
            {
                Console.WriteLine("Error:Passenger cannot be null");
                return false;
            }

            int nCheckingRowIndex = nSeatRow - 1;
            int nCheckingColumnIndex = nSeatNumber - 1;

            if (seats[nCheckingRowIndex][nCheckingColumnIndex].IsBooked)
            {
                Console.WriteLine($"Seat{nSeatRow} - {cSeatLabels[nCheckingColumnIndex]} is already Booked");
                return false;
            }
            else
            {
                seats[nCheckingRowIndex][nCheckingColumnIndex].IsBooked = true;
                seats[nCheckingRowIndex][nCheckingColumnIndex].passenger = passenger;
                Console.WriteLine($"Seat {nSeatRow} - {nSeatNumber} booked successfully for {passenger.strName}");
                return true;
            }
        }

        public void ShowAvailableSeatNumber()
        {
            Console.WriteLine("Available Seats: ");
            for (int i = 0; i < nRows; i++)
            {
                for (int j = 0; j < nSeatsPerRow; j++)
                {
                    if (!seats[i][j].IsBooked)
                    {
                        Console.Write($"[{i + 1} {cSeatLabels[j]}");
                    }
                    Console.WriteLine(" ");
                }
            }
            Console.WriteLine();
        }

        public bool IsFullyBooked()
        {
            for (int i = 0; i < seats.Length; i++)
            {
                for (int j = 0; j <= seats[i].Length; j++)
                {
                    if (!seats[i][j].IsBooked)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}


      
 



  


       

