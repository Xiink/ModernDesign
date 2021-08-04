using System;
using System.Collections.Generic;
using System.Text;
using ModernDesign.Core;

namespace ModernDesign.MVVM.ViewModel {
    class DiscoveryViewModel : ObservablrObject {

        private string _searchName = "";
        private double _myValue;

        public string SearchName
        {
            get => _searchName;
            set
            {
                _searchName = value; 
                OnPropertyChanged();
            }
            
        }

        public double MyValue {
            get => _myValue;
            set {
                _myValue = value;
                OnPropertyChanged();
            }
        }
    }
}
