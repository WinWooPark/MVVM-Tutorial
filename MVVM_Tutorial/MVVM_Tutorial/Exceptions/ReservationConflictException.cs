using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using MVVM_Tutorial.Model;

namespace MVVM_Tutorial.Exceptions
{
    public class ReservationConflictException : Exception
    {
        public Reservation ExistiongReservation { get; }
        public Reservation IncomingReservation { get; }

        public ReservationConflictException(Reservation existiongReservation, Reservation incomingReservation)
        {
            ExistiongReservation = existiongReservation;
            IncomingReservation = incomingReservation;
        }
        public ReservationConflictException(string message, Reservation existiongReservation, Reservation incomingReservation) : base(message)
        {
            ExistiongReservation = existiongReservation;
            IncomingReservation = incomingReservation;
        }

        public ReservationConflictException(string message, Exception innerExeption, Reservation existiongReservation, Reservation incomingReservation) : base(message, innerExeption)
        {
            ExistiongReservation = existiongReservation;
            IncomingReservation = incomingReservation;
        }

      
    }
}
