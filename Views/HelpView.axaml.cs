using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace ModernFlatAvaloniaUI.Views
{
    public partial class HelpView : UserControl
    {
        public HelpView()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}