using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlintsToolkit.ViewModel
{
    public class FTViewModelBase : ViewModelBase
    {
        private bool _isBusy;
        public bool IsBusy
        {
            get { return _isBusy; }
            set
            {
                if (_isBusy == value) return;
                var old = _isBusy;
                _isBusy = value;
                RaisePropertyChanged("IsBusy");
            }
        }
    }
}
