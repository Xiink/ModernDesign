using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Media.Imaging;
using ModernDesign.Core;

namespace ModernDesign.MVVM.ViewModel {
    class MainViewModel : ObservablrObject
    {

        public  RelayCommand HomeViewCommand { get; set; }

        public  RelayCommand DSViewCommand { get; set; }

        public HomeViewModel Homevm { get; set; }

        public DiscoveryViewModel DSVM { get; set; }

        private object _currentView;

        public object CurrenView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            Homevm = new HomeViewModel();
            DSVM = new DiscoveryViewModel();
            CurrenView = Homevm;

            HomeViewCommand = new RelayCommand(o =>
            {
                CurrenView = Homevm;
            });

            DSViewCommand = new RelayCommand(o => {
                CurrenView = DSVM;
            });
        }
    }
}
