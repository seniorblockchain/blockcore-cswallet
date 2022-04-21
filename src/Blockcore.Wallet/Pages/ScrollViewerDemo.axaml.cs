using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Blockcore.Wallet.Pages
{
    public class ScrollViewerDemo : UserControl
    {
        public ScrollViewerDemo()
        {
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
