using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace criandoExcecoes.entities
{
    internal class reservation
    {
        public int roomNumber { get; set; }
        public DateTime checkIn { get; set; }
        public DateTime checkOut { get; set; }

        public reservation()
        {

        }

        public reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            this.roomNumber = roomNumber;
            this.checkIn = checkIn;
            this.checkOut = checkOut;
        }

        public int duration()
        {
            TimeSpan duration = checkOut.Subtract(checkIn);
            return (int)duration.TotalDays;
        }

        public string updateDates(DateTime checkIn, DateTime checkOut)
        {
            DateTime now = DateTime.Now;
            if (checkIn <= now || checkOut < now)
            {
                return "Error in reservation: Reservation dates for update must be future date";
            }
            if (checkOut <= checkIn)
            {
                return "Error in reservation: Check-out date must be after check-in date";
            }

            this.checkIn = checkIn;
            this.checkOut = checkOut;
            return null;
        }

        public override string ToString()
        {
            return $"Room {roomNumber}, check-in: {checkIn.ToString("dd/MM/yyyy")}, check-out: {checkOut.ToString("dd/MM/yyyy")}, {duration()} nights";
        }
    }
}
