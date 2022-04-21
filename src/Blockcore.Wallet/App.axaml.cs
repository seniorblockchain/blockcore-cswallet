using Avalonia;
using Avalonia.Markup.Xaml;

namespace Blockcore.Wallet {
    public class App : Application {
        public override void Initialize() {
            AvaloniaXamlLoader.Load(this);
        }
    }
}