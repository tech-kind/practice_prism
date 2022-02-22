using Prism.Mvvm;
using Prism.Commands;
using System;
using UsingCompositeCommands.Core;

namespace ModuleA.ViewModels
{
    public class TabViewModel : BindableBase
    {
        IApplicationCommands _applicationCommands;

        private string? _title;
        public string? Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        private bool _canUpdate = true;
        public bool CanUpdate
        {
            get { return _canUpdate; }
            set { SetProperty(ref _canUpdate, value); }
        }

        private string? _updateText;
        public string? UpdateText
        {
            get { return _updateText; }
            set { SetProperty(ref _updateText, value); }
        }

        public DelegateCommand UpdateCommand { get; private set; }

        public TabViewModel(IApplicationCommands applicationCommands)
        {
            _applicationCommands = applicationCommands;

            UpdateCommand = new DelegateCommand(Update).ObservesCanExecute(() => CanUpdate);

            _applicationCommands.SaveCommand.RegisterCommand(UpdateCommand);
        }

        private void Update()
        {
            UpdateText = $"Update: {DateTime.Now}";
        }
    }
}
