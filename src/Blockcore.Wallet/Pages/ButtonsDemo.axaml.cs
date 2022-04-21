using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Blockcore.Wallet.Pages
{
    public class ButtonsDemo : UserControl
    {
        public ButtonsDemo()
        {
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
