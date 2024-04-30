using System.Collections.ObjectModel;
using System.ComponentModel;
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
using WMPLib;

namespace spookify
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private WindowsMediaPlayer player = new WindowsMediaPlayer();


        private ObservableCollection<Song> songs = new ObservableCollection<Song>();
        private ObservableCollection<Song> allSongs = new ObservableCollection<Song>();


        ApiService apiService = new ApiService("http://localhost:5006/", "C:\\Users\\vdeniss\\Documents\\GitHub\\frontend\\temp");

        public MainWindow()
        {

            ConfigurationHelper.InitializeConfiguration();
            string apiBaseUrl = ConfigurationHelper.GetApiBaseUrl();
            string destinationFolder = ConfigurationHelper.GetDestinationFolderPath();



            InitializeComponent();

            
            // get song with id 1

            Loaded += async (s, e) =>
            {
                allSongs = new ObservableCollection<Song>(await apiService.GetAllSongsAsync());
                foreach (Song song in allSongs)
                {
                    songs.Add(
                        new Song
                        {
                            songID = song.songID,
                            name = song.name,
                            artist = song.artist,
                            album = song.album,
                            filename = song.filename,
                            streams = song.streams
                        }
                    );

                }
                DataContext = songs;
            };

        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }

        // select song on left click 
        private void rowSelect(object sender, MouseButtonEventArgs e)
        {
            DataGridRow row = sender as DataGridRow;
            Song song = (Song)row.Item;
            // select song
            songsDataGrid.SelectedItem = song;

            setCurrentSong(song);
            
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            
        }

        private void ClickUpdate(object sender, RoutedEventArgs e)
        {
            
            UpdateWindow updateWindow = new UpdateWindow(int.Parse(currentId.Text));
            
            updateWindow.Show();
            
            updateWindow.Closed += (s, e) =>
            {
                RefreshSongs();
            };

        }

        private void ClickCreate(object sender, RoutedEventArgs e)
        {
            
            CreateWindow createWindow = new CreateWindow();
            
            createWindow.Show();
            
            createWindow.Closed += (s, e) =>
            {
                RefreshSongs();
            };

        }

        private async void ClickDelete(object sender, RoutedEventArgs e)
        {
            // delete selected song
            await apiService.DeleteSongAsync(int.Parse(currentId.Text));
            RefreshSongs();
        }

        private async void ClickPlay(object sender, RoutedEventArgs e)
        {

            await apiService.DownloadSongFileAsync(new Song
            {
                songID = int.Parse(currentId.Text),
                name = currentTitle.Text,
                artist = currentArtist.Text,
                album = currentAlbum.Text,
                filename = currentFilename.Text,
                streams = int.Parse(currentStreams.Text)
            });

            Song song = (Song)songsDataGrid.SelectedItem;

            player.URL = "C:\\Users\\sergi\\Documents\\GitHub\\UBB-SE-2024-PestiiRomaniei\\Lab5\\api\\Audiofiles\\" + song.filename;

            player.controls.play();
            

        }

        private void ClickPause(object sender, RoutedEventArgs e)
        {
            player.controls.stop();
        }

        private async void RefreshSongs()
        {
            songs.Clear();
            songs = new ObservableCollection<Song>(await apiService.GetAllSongsAsync());
            DataContext = songs;
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
                
                Song song = (Song)row.Item;
                songsDataGrid.SelectedItem = song;

                setCurrentSong(song);
            }
        }

        private void setCurrentSong(Song song)
        {
            currentTitle.Text = song.name;
            currentArtist.Text = song.artist;
            currentAlbum.Text = song.album;
            currentId.Text = song.songID.ToString();
            currentFilename.Text = song.filename;
            currentStreams.Text = song.streams.ToString();
        }
    }
}