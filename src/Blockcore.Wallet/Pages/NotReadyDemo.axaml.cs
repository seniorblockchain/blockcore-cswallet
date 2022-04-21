using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Blockcore.Wallet.Pages
{
    public class NotReadyDemo : UserControl
    {
        public NotReadyDemo()
        {
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
