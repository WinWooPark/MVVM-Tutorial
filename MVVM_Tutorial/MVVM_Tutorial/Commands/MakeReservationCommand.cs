using MVVM_Tutorial.Exceptions;
using MVVM_Tutorial.Model;
using MVVM_Tutorial.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MVVM_Tutorial.Commands
{
    public class MakeReservationCommand : CommandBase
    {
        private readonly MakeReservationViewModel _makeReservationViewModel;
        private readonly Hotel _hotel;

        public MakeReservationCommand(MakeReservationViewModel makeReservationViewModel, Hotel hotel)
        {
            _makeReservationViewModel = makeReservationViewModel;
            _hotel = hotel;
            _makeReservationViewModel.PropertyChanged += OnViewModelPropertyChanged;
        }

        private void OnViewModelPropertyChanged(object? sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(_makeReservationViewModel.UserName)) 
            {
                OnCanExecutedChanged();
            }
        }

        public override bool CanExecute(object? parameter)
        {
            return !string.IsNullOrEmpty(_makeReservationViewModel.UserName) && base.CanExecute(parameter);
        }

        public override void Execute(object? parameter)
        {
            Reservation reservation = new Reservation
            (
                new RoomID(_makeReservationViewModel.FloorNumber, _makeReservationViewModel.RoomNumber),
                _makeReservationViewModel.UserName,
                _makeReservationViewModel.StartDate,
                _makeReservationViewModel.EndDate
            );

            try
            {
                _hotel.MakeReservation(reservation);
            }
            catch (ReservationConflictException) 
            {
                MessageBox.Show("This room is already taken.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
           
        }
    }
}
