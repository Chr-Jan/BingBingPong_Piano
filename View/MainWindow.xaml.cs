using System;
using System.Collections.Generic;
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

namespace PianoMeme.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void PlaySound(string soundFile)
        {
            using (SoundPlayer player = new SoundPlayer(soundFile))
            {
                player.Load();
                player.Play();
            }
        }
        private void Note1_Click(object sender, RoutedEventArgs e)
        {
            PlaySound(@"D:\GitHub\Personlige Projekter\PianoMEME\sound\boing.wav");
        }

        private void Note2_Click(object sender, RoutedEventArgs e)
        {
            PlaySound(@"D:\GitHub\Personlige Projekter\PianoMEME\sound\jews-harp.wav");
        }

        private void Note3_Click(object sender, RoutedEventArgs e)
        {
            PlaySound(@"D:\GitHub\Personlige Projekter\PianoMeme\sound\comedic-boing.wav");
        }

        private void Note4_Click(object sender, RoutedEventArgs e)
        {
            PlaySound(@"D:\GitHub\Personlige Projekter\PianoMeme\sound\juskiddink__boing.wav");
        }

        private void Note5_Click(object sender, RoutedEventArgs e)
        {
            PlaySound(@"D:\GitHub\Personlige Projekter\PianoMeme\sound\springboard-b.wav");
        }

        private void Note1Shift_Click(object sender, RoutedEventArgs e)
        {
            PlaySound(@"D:\GitHub\Personlige Projekter\PianoMeme\sound\foam-pluck.wav");
        }

        private void Note2Shift_Click(object sender, RoutedEventArgs e)
        {
            PlaySound(@"D:\GitHub\Personlige Projekter\PianoMeme\sound\popsicle-stick-pluck.wav");
        }

        private void Note3Shift_Click(object sender, RoutedEventArgs e)
        {
            PlaySound(@"D:\GitHub\Personlige Projekter\PianoMeme\sound\funny-boing.wav");
        }

        private void Note4Shift_Click(object sender, RoutedEventArgs e)
        {
            PlaySound(@"D:\GitHub\Personlige Projekter\PianoMeme\sound\battery-compartment-spring.wav");
        }

        private void MainWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.D1)
            {
                if (Keyboard.Modifiers == ModifierKeys.Shift)
                {
                    PlaySound(@"D:\GitHub\Personlige Projekter\PianoMeme\sound\foam-pluck.wav");
                }
                else
                {
                    PlaySound(@"D:\GitHub\Personlige Projekter\PianoMEME\sound\boing.wav");
                }
            }

            if (e.Key == Key.D2)
            {
                if (Keyboard.Modifiers == ModifierKeys.Shift)
                {
                    PlaySound(@"D:\GitHub\Personlige Projekter\PianoMeme\sound\popsicle-stick-pluck.wav");
                }
                else
                {
                    PlaySound(@"D:\GitHub\Personlige Projekter\PianoMEME\sound\jews-harp.wav");
                }
            }

            if (e.Key == Key.D3)
            {
                if (Keyboard.Modifiers == ModifierKeys.Shift)
                {
                    PlaySound(@"D:\GitHub\Personlige Projekter\PianoMeme\sound\funny-boing.wav");
                }
                else
                {
                    PlaySound(@"D:\GitHub\Personlige Projekter\PianoMeme\sound\comedic-boing.wav");
                }
            }

            if (e.Key == Key.D4)
            {
                if (Keyboard.Modifiers == ModifierKeys.Shift)
                {
                    PlaySound(@"D:\GitHub\Personlige Projekter\PianoMeme\sound\battery-compartment-spring.wav");
                }
                else
                {
                    PlaySound(@"D:\GitHub\Personlige Projekter\PianoMeme\sound\juskiddink__boing.wav");
                }
            }

            if (e.Key == Key.D5)
            {
                PlaySound(@"D:\GitHub\Personlige Projekter\PianoMeme\sound\springboard-b.wav");
            }
        }

    }
}

