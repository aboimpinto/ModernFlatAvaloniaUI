using System;
using System.Windows.Input;
using ReactiveUI;

namespace ModernFlatAvaloniaUI.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private ViewModelBase _navigationContent = new DashboardViewModel();

        public ICommand DashboardButtonClicked { get; }

        public ICommand HelpButtonClicked { get; }

        public ViewModelBase NavigationContent 
        { 
            get => this._navigationContent;
            set => this.RaiseAndSetIfChanged(ref this._navigationContent, value);
        }

        public MainWindowViewModel()
        {
            this.DashboardButtonClicked = ReactiveCommand.Create(this.OnDashboardButtonClicked);
            this.HelpButtonClicked = ReactiveCommand.Create(this.OnHelpButtonClicked);
        }

        private void OnDashboardButtonClicked()
        {
            this.NavigationContent = new DashboardViewModel();
        }

        private void OnHelpButtonClicked()
        {
            this.NavigationContent = new HelpViewModel();
        }
    }
}
