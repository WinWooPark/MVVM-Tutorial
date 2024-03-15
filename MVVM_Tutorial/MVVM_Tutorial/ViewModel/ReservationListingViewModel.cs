using MVVM_Tutorial.Commands;
using MVVM_Tutorial.Model;
using MVVM_Tutorial.Stores;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MVVM_Tutorial.Services;

namespace MVVM_Tutorial.ViewModel
{
    public class ReservationListingViewModel : ViewModelBase
    {
        private readonly ObservableCollection<ReservationViewModel> _reservation;
        private Hotel _hotel;
        private NavigationService navigationService;

        public IEnumerable<ReservationViewModel> Reservations => _reservation;
        
        public ICommand MakeReservationCommand { get;}

        public ReservationListingViewModel(Hotel hotel, NavigationService makeReservationNavigationService)
        {
            _hotel = hotel; 
            _reservation = new ObservableCollection<ReservationViewModel>();
            MakeReservationCommand = new NavigateCommand(makeReservationNavigationService);

            UpdataReservation();
        }

        private void UpdataReservation()
        {
            _reservation.Clear();

            foreach (var reservation in _hotel.GetAllReservations()) 
            {
                ReservationViewModel reservationViewModel = new ReservationViewModel(reservation);
                _reservation.Add(reservationViewModel);
            }

        }
    }
}
