using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ModernDesign.MVVM.ViewModel;

namespace ModernDesign.MVVM.View {
    /// <summary>
    /// DiscoveryView.xaml 的互動邏輯
    /// </summary>
    public partial class DiscoveryView : UserControl {
        public DiscoveryView() {
            InitializeComponent();
        }

        private void btn_Search(object sender , RoutedEventArgs e)
        {
           Debug.WriteLine( SearchBox.Text);
        }
    }
}
