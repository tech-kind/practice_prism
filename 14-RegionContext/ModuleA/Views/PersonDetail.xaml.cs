using ModuleA.Business;
using ModuleA.ViewModels;
using Prism.Common;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ModuleA.Views
{
    /// <summary>
    /// PersonDetail.xaml の相互作用ロジック
    /// </summary>
    public partial class PersonDetail : UserControl
    {
        public PersonDetail()
        {
            InitializeComponent();
            RegionContext.GetObservableContext(this).PropertyChanged += PersonDetail_PropertyChanged;
        }

        private void PersonDetail_PropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (sender == null) return;
            var context = (ObservableObject<object>)sender;
            var selectedPerson = (Person)context.Value;

            var viewModel = DataContext as PersonDetailViewModel;
            if (viewModel == null) return;
            viewModel.SelectedPerson= selectedPerson;
        }
    }
}
