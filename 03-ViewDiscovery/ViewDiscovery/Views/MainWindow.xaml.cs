using System.Windows;
using Prism.Regions;

namespace ViewDiscovery.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow(IRegionManager regionManager)
        {
            InitializeComponent();
            // view discovery
            regionManager.RegisterViewWithRegion("ContentRegion", typeof(ViewA));
        }
    }
}
