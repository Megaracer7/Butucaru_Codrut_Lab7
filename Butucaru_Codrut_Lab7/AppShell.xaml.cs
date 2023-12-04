using Microsoft.Maui.Controls;
namespace Butucaru_Codrut_Lab7;

    public partial class AppShell : Shell
    {
        public AppShell()
        {
        InitializeComponent();
        Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));
        Routing.RegisterRoute(nameof(AboutPage), typeof(AboutPage));
        Routing.RegisterRoute(nameof(ListEntryPage), typeof(ListEntryPage));
        }
    }

