using MVVM_Tutorial.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_Tutorial.Commands
{
    public class CancelMakeReservationCommand : CommandBase
    {
        private MakeReservationViewModel _makeReservationViewModel;
        public override void Execute(object? parameter)
        {
            throw new NotImplementedException();
        }
        public CancelMakeReservationCommand(MakeReservationViewModel makeReservationViewModel)
        {
            _makeReservationViewModel = makeReservationViewModel;
        }
    }
}
