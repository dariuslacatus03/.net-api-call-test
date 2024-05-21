using dotnetApiCallTest.Services;

namespace dotnetApiCallTest
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var userService = new UserService();

            // Store userService in a service locator or dependency injection container
            DependencyService.RegisterSingleton(userService);

            MainPage = new MainPage();
        }
    }
}
