using System;
using System.Collections.Generic;
using System.Linq;
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

namespace spookify
{
    /// <summary>
    /// Interaction logic for UpdateWindow.xaml
    /// </summary>
    public partial class UpdateWindow : Window
    {
        private int id { get; set; }

        ApiService apiService = new ApiService("http://localhost:5006/", "C:\\Users\\vdeniss\\Documents\\GitHub\\frontend\\temp");

        //public UpdateWindow(Song song)
        public UpdateWindow(int id)
        {
            this.id = id;
            InitializeComponent();
        }

        private async void ClickUpdateSong(object sender, RoutedEventArgs e)
        {
            // update song in allSongs

            await apiService.UpdateSongAsync(new Song
            {
                songID = this.id,
                name = nameInput.Text,
                artist = artistInput.Text,
                album = albumInput.Text,
                filename = filenameInput.Text,
            });

            this.Close();
        }
    }
}
