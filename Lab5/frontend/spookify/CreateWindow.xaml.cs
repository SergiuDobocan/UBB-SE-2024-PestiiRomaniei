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
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class CreateWindow : Window
    {

        ApiService apiService = new ApiService("http://localhost:5006/", "C:\\Users\\vdeniss\\Documents\\GitHub\\frontend\\temp");

        public CreateWindow()
        {
            InitializeComponent();
        }

        private async void ClickCreateSong(object sender, RoutedEventArgs e)
        {
            // add song to allSongs
            Song song = new Song
            {
                name = titleInput.Text,
                artist = artistInput.Text,
                album = albumInput.Text,
                filename = filenameInput.Text,
            };

            await apiService.AddSongAsync(song);

            this.Close();
        }

    }
}
