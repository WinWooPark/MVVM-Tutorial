﻿using MVVM_Tutorial.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_Tutorial.ViewModel
{
    public class ReservationViewModel : ViewModelBase
    {
        private readonly Reservation _reservation;
        public string RoomID => _reservation.RoomID.ToString();
        public string Username => _reservation.Username;
        public DateTime StartDate => _reservation.StartTime.Date;
        public DateTime EndDate => _reservation.EndTime.Date;

        public ReservationViewModel(Reservation reservation)
        {
            _reservation = reservation;
        }
    }
}
