using dotnetApiCallTest.Model;
using dotnetApiCallTest.Services;
using System.Collections.ObjectModel;

namespace dotnetApiCallTest
{
    public partial class MainPage : ContentPage
    {
        private readonly UserService _userService;
        public ObservableCollection<User> Users { get; set; } = new ObservableCollection<User>();

        public MainPage()
        {
            InitializeComponent();

            _userService = DependencyService.Get<UserService>();

            LoadUsers();
        }

        private async void LoadUsers()
        {
            var users = await _userService.GetAllUsersAsync();
            foreach (var user in users)
            {
                Users.Add(user);
            }

            UsersListView.ItemsSource = Users;
        }
    }

}
