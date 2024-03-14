using MVVM_Tutorial.Model;
using MVVM_Tutorial.Stores;
using System.Windows.Navigation;

namespace MVVM_Tutorial.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private readonly NavigationStore _navigationStore;
        public ViewModelBase CurrentViewMdoel 
        {
            get { return _navigationStore.CrrentViewModel; }
            set 
            {
                if(_navigationStore.CrrentViewModel != value)
                    _navigationStore.CrrentViewModel = value;
            }
        }  
        public MainViewModel(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
            _navigationStore.CurrentViewModelChanged += onCurrentViewModelChanged;
        }

        private void onCurrentViewModelChanged()
        {
            OnPropertyChanged(nameof(CurrentViewMdoel));
        }
    }
}
