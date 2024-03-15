using System.Configuration;
using System.Data;
using System.Printing;
using System.Windows;
using System.Windows.Navigation;
using MVVM_Tutorial.Commands;
using MVVM_Tutorial.Model;
using MVVM_Tutorial.Stores;
using MVVM_Tutorial.ViewModel;

namespace MVVM_Tutorial
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly Hotel _hotel;
        private readonly NavigationStore _navigationStore;

        public App()
        {
            _hotel = new Hotel("singletonSean Suites");
            _navigationStore = new NavigationStore();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            _navigationStore.CrrentViewModel = CreateReservationListingViewModel();


            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(_navigationStore)
            };

            MainWindow.Show();

            base.OnStartup(e);
        }

        private MakeReservationViewModel CreateMakeReservationViewModel() 
        {
            return new MakeReservationViewModel(_hotel, new MVVM_Tutorial.Services.NavigationService(_navigationStore, CreateReservationListingViewModel));
        }

        private ReservationListingViewModel CreateReservationListingViewModel()
        {
            return new ReservationListingViewModel(_hotel,new MVVM_Tutorial.Services.NavigationService(_navigationStore, CreateMakeReservationViewModel));
        }
    }

}
