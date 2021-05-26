using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace ModernFlatAvaloniaUI.Views
{
    public class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);

            this.FindControl<Control>("MainPanel").PointerPressed += (i, e) =>
            {
                PlatformImpl?.BeginMoveDrag(e);
            };
        }
    }
}