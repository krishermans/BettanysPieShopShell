
using BethanysPieShop.Mobile.Core.Constants;
using BethanysPieShop.Mobile.Core.Views;
using Xamarin.Forms;

namespace BethanysPieShop.Mobile.Core
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            BuildShellLayout();
        }

        private void BuildShellLayout()
        {
            var homeSection = new ShellSection()
            {
                Title = "Home",
                Route = NavigationRouteConstants.HomeRoute,
                FlyoutIcon = "ic_home.png"
            };
            homeSection.Items.Add(new ShellContent()
            {
                Content = new HomeView()
            });
            this.Items.Add(homeSection);

            var pieSection = new ShellSection()
            {
                Title = "Pies",
                Route = NavigationRouteConstants.PieCatalogRoute,
                FlyoutIcon = "ic_pies.png"
            };
            pieSection.Items.Add(new ShellContent()
            {
                Content = new PieCatalogView()
            });
            this.Items.Add(pieSection);

            var cartSection = new ShellSection()
            {
                Title = "Cart",
                Route = NavigationRouteConstants.ShoppingCartRoute,
                FlyoutIcon = "ic_cart.png"
            };
            cartSection.Items.Add(new ShellContent()
            {
                Content = new MainPage()
            });
            this.Items.Add(cartSection);

            var contactSection = new ShellSection()
            {
                Title = "Contact us",
                Route = NavigationRouteConstants.ContactRoute,
                FlyoutIcon = "ic_contact.png"
            };
            contactSection.Items.Add(new ShellContent()
            {
                Content = new MainPage()
            });
            this.Items.Add(contactSection);

            var logoutSection = new ShellSection()
            {
                Title = "Logout",
                Route = NavigationRouteConstants.LoginRoute,
                FlyoutIcon = "ic_logout.png"
            };
            logoutSection.Items.Add(new ShellContent()
            {
                Content = new MainPage()
            });
            this.Items.Add(logoutSection);
        }

    }
}