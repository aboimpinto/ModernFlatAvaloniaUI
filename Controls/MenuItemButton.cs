using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Styling;
using MaterialDesign.Avalonia.PackIcon;

namespace ModernFlatAvaloniaUI.Controls
{
    public class MenuItemButton : RadioButton, IStyleable
    {
        Type IStyleable.StyleKey => typeof(ToggleButton);

        public static readonly AvaloniaProperty KindProperty = 
            AvaloniaProperty.Register<MenuItemButton, PackIconKind>(nameof(Kind));

        public PackIconKind Kind 
        { 
            get => (PackIconKind)GetValue(KindProperty);
            set => SetValue(KindProperty, value);
        }

        public MenuItemButton()
        {
            this.Kind = PackIconKind.None;
        }
    }
}
