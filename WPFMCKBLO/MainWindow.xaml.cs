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

namespace WPFMCKBLO
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var sri = Application.GetResourceStream(new Uri("pack://application:,,,/Music/01-Diablo-Intro.wav"));
            if (sri != null)
            {
                using (var s = sri.Stream)
                {
                    System.Media.SoundPlayer MusicPlayer = new System.Media.SoundPlayer(s);
                    MusicPlayer.Load();
                    MusicPlayer.Play();
                    MusicPlayer.PlayLooping();
                }
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Frame.NavigationService.Navigate(new StartPage()) ; //переходы на следующую страницу
        }
    }
}