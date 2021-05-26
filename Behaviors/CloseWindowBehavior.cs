using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Xaml.Interactivity;

namespace ModernFlatAvaloniaUI.Behaviors
{
    public class CloseWindowBehavior : Behavior<Window>
    {
        public bool CloseTrigger 
        { 
            get { return (bool)GetValue(CloseTriggerProperty); }
            set { SetValue(CloseTriggerProperty, value); }
        }

        public static readonly AvaloniaProperty CloseTriggerProperty = 
            AvaloniaProperty.Register<CloseWindowBehavior, bool>("CloseTrigger");

        static CloseWindowBehavior()
        {
            CloseTriggerProperty.Changed.Subscribe(OnCloseTriggerChanged);
        }

        private static void OnCloseTriggerChanged(AvaloniaPropertyChangedEventArgs obj)
        {
            var behavior = obj.Sender as CloseWindowBehavior;
            if (behavior == null)
            {
                return;
            }

            behavior.OnCloseTriggerChanged();
        }

        private void OnCloseTriggerChanged()
        {
            if (this.CloseTrigger)
            {
                this.AssociatedObject?.Close();
            }
        }
    }
}
