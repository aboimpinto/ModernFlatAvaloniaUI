using System.Windows.Input;
using ReactiveUI;

namespace ModernFlatAvaloniaUI.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private ViewModelBase _navigationContent = new DashboardViewModel();
        private bool _closeAppTrigger;

        public bool CloseAppTrigger 
        { 
            get => this._closeAppTrigger;
            set => this.RaiseAndSetIfChanged(ref this._closeAppTrigger, value);
        }

        public ICommand DashboardButtonClicked { get; }

        public ICommand HelpButtonClicked { get; }

        public ICommand CloseButtonClicked { get; }

        public ViewModelBase NavigationContent 
        { 
            get => this._navigationContent;
            set => this.RaiseAndSetIfChanged(ref this._navigationContent, value);
        }

        public MainWindowViewModel()
        {
            this.DashboardButtonClicked = ReactiveCommand.Create(this.OnDashboardButtonClicked);
            this.HelpButtonClicked = ReactiveCommand.Create(this.OnHelpButtonClicked);
            this.CloseButtonClicked = ReactiveCommand.Create(this.OnCloseButton);
        }

        private void OnDashboardButtonClicked()
        {
            this.NavigationContent = new DashboardViewModel();
        }

        private void OnHelpButtonClicked()
        {
            this.NavigationContent = new HelpViewModel();
        }

        private void OnCloseButton()
        {
            this.CloseAppTrigger =  true;
        }
    }
}
