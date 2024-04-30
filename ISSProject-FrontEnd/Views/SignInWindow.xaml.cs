using ISSProject.ViewModels;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ISSProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class SignInWindow : Window
    {
        private ObservableCollection<User> users = new ObservableCollection<User>();
        private ObservableCollection<User> allUsers = new ObservableCollection<User>();

        public SignInWindow()
        {
            InitializeComponent();
            DataContext = new SignInViewModel();
        }

        private void textUsername_MouseDown(object sender, MouseButtonEventArgs e)
        {
            txtUsername.Focus();
        }

        private void txtUsername_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(!string.IsNullOrEmpty(txtUsername.Text)&& txtUsername.Text.Length>0) 
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

        private void Button_click(object sender, RoutedEventArgs e)
        {
            if(!string.IsNullOrEmpty(txtUsername.Text)&& !string.IsNullOrEmpty(txtPassword.Password))
            {
                MessageBox.Show("Succesfully signed in");
            }
            SignUpWindow signUpWindow = new SignUpWindow();
            this.Close();
            signUpWindow.Show();
            
        }


        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

    }
}