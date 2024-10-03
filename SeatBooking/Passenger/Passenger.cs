using System;

namespace FlightSeatBooking
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
  }

