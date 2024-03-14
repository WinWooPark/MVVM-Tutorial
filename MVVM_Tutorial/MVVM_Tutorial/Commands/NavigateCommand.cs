using MVVM_Tutorial.Services;
using MVVM_Tutorial.Stores;
using MVVM_Tutorial.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MVVM_Tutorial.Commands
{
    public class NavigateCommand : CommandBase
    {
        private readonly NavigationService _navigationService;
        public override void Execute(object? parameter)
        {
            _navigationService.Navigate();

        }
    }
}
