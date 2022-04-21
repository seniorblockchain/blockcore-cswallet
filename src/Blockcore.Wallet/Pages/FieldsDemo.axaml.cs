using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Blockcore.Wallet.ViewModels;

namespace Blockcore.Wallet.Pages
{
    public class FieldsDemo : UserControl
    {
        public FieldsDemo()
        {
            this.InitializeComponent();

            DataContext = new TextFieldsViewModel();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
