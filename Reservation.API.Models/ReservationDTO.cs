using System;
using System.Collections.Generic;
using System.Text;

namespace Reservation.API.Models
{
    public class ReservationDTO
    {
        public int Id { get; set; }
        public int BkgNumber { get; set; }
        public DateTime CheckinDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public DateTime BkgDate { get; set; }
        public decimal Amount { get; set; }
        
    }
}
