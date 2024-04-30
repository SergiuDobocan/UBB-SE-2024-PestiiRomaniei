using Newtonsoft.Json;
using System.ComponentModel;
using System.Net.Http;
using System.Text;
using System.Windows.Input;

namespace ISSProject.ViewModels
{
    public class SignInViewModel : INotifyPropertyChanged
    {
        private string _username;
        private string _password;

        public string Username
        {
            get { return _username; }
            set
            {
                _username = value;
                OnPropertyChanged(nameof(Username));
            }
        }

        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                OnPropertyChanged(nameof(Password));
            }
        }

        public ICommand SignInCommand { get; private set; }

        public SignInViewModel()
        {
            SignInCommand = new RelayCommand(SignIn, CanSignIn);
        }

        private bool CanSignIn(object parameter)
        {
            return !string.IsNullOrEmpty(Username) && !string.IsNullOrEmpty(Password);
        }

        private void SignIn(object parameter)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    
                    client.BaseAddress = new Uri("")
                    string endpoint = "/signin";

                   
                    var requestData = new { Username, Password };
                    string jsonData = JsonConvert.SerializeObject(requestData);
                    var content = new StringContent(jsonData, Encoding.UTF8, "application/json");

                    
                    HttpResponseMessage response = await client.PostAsync(endpoint, content);
                    if (response.IsSuccessStatusCode)
                    {
                        string responseBody = await response.Content.ReadAsStringAsync();
                        MessageBox.Show($"Successfully signed in. Response: {responseBody}");

                        Username = "";
                        Password = "";
                    }
                    else
                    {
                        string errorBody = await response.Content.ReadAsStringAsync();
                        MessageBox.Show($"Error signing in: {errorBody}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error signing in: {ex.Message}");
            }
        }
    }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
