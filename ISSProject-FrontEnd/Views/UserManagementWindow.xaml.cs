using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ISSProject
{
    /// <summary>
    /// Interaction logic for DashboardWindow.xaml
    /// </summary>
    public partial class UserManagementWindow : Window
    {
        private ObservableCollection<User> users = new ObservableCollection<User>();
        private ObservableCollection<User> allUsers = new ObservableCollection<User>();

        ApiService apiService = new ApiService("http://localhost:5006/", "C:\\Users\\vdeniss\\Documents\\GitHub\\frontend\\temp");

        public UserManagementWindow()
        {
            ConfigurationHelper.InitializeConfiguration();
            string apiBaseUrl = ConfigurationHelper.GetApiBaseUrl();
            string destinationFolder = ConfigurationHelper.GetDestinationFolderPath();
            InitializeComponent();
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void textUsername_MouseDown(object sender, MouseButtonEventArgs e)
        {
            txtUsername.Focus();
        }

        private void txtUsername_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUsername.Text) && txtUsername.Text.Length > 0)
            {
                textUsername.Visibility = Visibility.Collapsed;
            }
            else
            {
                textUsername.Visibility = Visibility.Visible;
            }
        }

        private void textPassword_MouseDown(object sender, MouseButtonEventArgs e)
        {
            txtPassword.Focus();
        }

        private void txtPassword_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPassword.Password) && txtPassword.Password.Length > 0)
            {
                textPassword.Visibility = Visibility.Collapsed;
            }
            else
            {
                textPassword.Visibility = Visibility.Visible;
            }
        }

        // select user on left click 
        private void rowSelect(object sender, MouseButtonEventArgs e)
            {
                DataGridRow row = sender as DataGridRow;
                User user = (User)row.Item;
                // select user
                usersDataGrid.SelectedItem = user;

            }

            private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
            {

            }

            private async void ClickDelete(object sender, RoutedEventArgs e)
            {
                // delete selected user
                await apiService.DeleteUserAsync(int.Parse(textUsername.Text));
                RefreshUsers();
            }

        private async void RefreshUsers()
        {
            users.Clear();
            users = new ObservableCollection<User>(await apiService.GetAllUsersAsync());
            DataContext = users;
        }



        private void DataGrid_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
            {
                var dep = (DependencyObject)e.OriginalSource;

                // Find the clicked row
                while (dep != null && !(dep is DataGridRow))
                {
                    dep = VisualTreeHelper.GetParent(dep);
                }

                if (dep is DataGridRow row)
                {
                    // Select the clicked row
                    if (!row.IsSelected)
                    {
                        row.IsSelected = true;
                    }

                    User user = (User)row.Item;
                    usersDataGrid.SelectedItem = user;

                }
            }

          

        private void ClickSignOut(object sender, RoutedEventArgs e)
        {
            SignInWindow signinWindow = new SignInWindow();
            this.Close();
            signinWindow.Show();
        }
    }
}
