using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
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
    /// Логика взаимодействия для SettingsPage.xaml
    /// </summary>
    public partial class SettingsPage : Page
    {
        public SettingsPage()
        {
            InitializeComponent();
        }

        private void GoBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void MusicOn_Click(object sender, RoutedEventArgs e)
        {
            var sri = Application.GetResourceStream(new Uri("pack://application:,,,/Music/01-Diablo-Intro.wav"));
            if (sri != null)
            {
                using (var s = sri.Stream)
                {
                    var MusicPlayer = new SoundPlayer(s);
                    MusicPlayer.Load();
                    MusicPlayer.Play();
                    MusicPlayer.PlayLooping();
                }
            }
        }

        private void MusicOff_Click(object sender, RoutedEventArgs e)
        {
            var MusicPlayer = new SoundPlayer();
            MusicPlayer.Stop();
        }
    }
}
