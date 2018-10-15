using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheatreBookingLib
{
    public class Seat
    {
        private bool _isVacant;
        private char _rowNumber;
        private int _seatNumber;

        public Seat(char rowNumber, int seatNumber)
        {
            _rowNumber = rowNumber;
            _seatNumber = seatNumber;
            _isVacant = true;
        }

        public bool IsVacant
        {
            get
            {
                return _isVacant;
            }
            set
            {
                _isVacant = value;
            }
        }

        public char RowNumber
        {
            get
            {
                return _rowNumber;
            }

        }

        public int SeatNumber
        {
            get
            {
                return _seatNumber;
            }
        }
    }
}
