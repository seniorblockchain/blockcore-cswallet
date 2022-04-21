using Material.Colors;
using Material.Styles.Themes;
using Material.Styles.Themes.Base;
using System.Diagnostics;
using System.Threading.Tasks;
using Avalonia;
using Avalonia.Controls;

namespace Blockcore.Wallet
{
    public static class GlobalCommand {
        private static readonly MaterialTheme MaterialThemeStyles = Application.Current!.LocateMaterialTheme<MaterialTheme>();
        public static void UseMaterialUIDarkTheme() {
            MaterialThemeStyles.BaseTheme = BaseThemeMode.Dark;
        }
        public static void UseMaterialUILightTheme() {
            MaterialThemeStyles.BaseTheme = BaseThemeMode.Light;
        }

        public static void OpenProjectRepoLink() => OpenBrowserForVisitSite("https://Blockcore.net");

        public static void OpenBrowserForVisitSite(string link)
        {
            var param = new ProcessStartInfo
            {
                FileName = link,
                UseShellExecute = true,
                Verb = "open"
            };
            Process.Start(param);
        }

    }
}
