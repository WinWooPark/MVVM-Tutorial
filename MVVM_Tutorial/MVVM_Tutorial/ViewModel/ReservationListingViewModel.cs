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

namespace MVVM_Tutorial.ViewModel
{
    public class ReservationListingViewModel : ViewModelBase
    {
        private readonly ObservableCollection<ReservationViewModel> _reservation;
        
        public IEnumerable<ReservationViewModel> Reservations => _reservation;
        
        public ICommand MakeReservationCommand { get;}

        public ReservationListingViewModel(NavigationStore navigationStore,Func<MakeReservationViewModel> createMakeReservationViewModel)
        {
            _reservation = new ObservableCollection<ReservationViewModel>();
            MakeReservationCommand = new NavigateCommand(navigationStore, createMakeReservationViewModel);
        }
        
    }
}
