using Prism.Unity;
using Prism.Ioc;
using ViewModelLocator.Views;
using System.Windows;
using Prism.Mvvm;
using ViewModelLocator.ViewModels;

namespace ViewModelLocator
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }

        protected override void ConfigureViewModelLocator()
        {
            base.ConfigureViewModelLocator();

            ViewModelLocationProvider.Register<MainWindow, CustomViewModel>();
        }
    }
}
