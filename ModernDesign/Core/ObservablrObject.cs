using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ModernDesign.Core {
    class ObservablrObject : INotifyPropertyChanged {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
