using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Blockcore.Wallet.Pages
{
    public class ListsDemo : UserControl
    {
        public ListsDemo()
        {
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
