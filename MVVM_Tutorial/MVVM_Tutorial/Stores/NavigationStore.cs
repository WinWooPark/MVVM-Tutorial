using MVVM_Tutorial.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_Tutorial.Stores
{
    public class NavigationStore
    {
        private ViewModelBase _crrentViewModel;
        public ViewModelBase CrrentViewModel 
        {
            get => _crrentViewModel;
            set
            {
                if (_crrentViewModel != value)
                {
                    _crrentViewModel = value;
                    OnCurrentViewModelChanged();
                }
            }
        }

        private void OnCurrentViewModelChanged() 
        {
            CurrentViewModelChanged?.Invoke();
        }

        public event Action CurrentViewModelChanged;
    }
}
