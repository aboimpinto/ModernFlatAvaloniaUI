using System;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Styling;

namespace ModernFlatAvaloniaUI.Controls
{
    public class MenuItemButton : RadioButton, IStyleable
    {
        Type IStyleable.StyleKey => typeof(ToggleButton);
    }
}
