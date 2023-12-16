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
        private string basePath;
        public MainWindow()
        {
            InitializeComponent();
            basePath = @"Change to the path for the Sound folder";
        }
        // soundFile bliver brugt til fil navnet
        private void PlaySound(string soundFile)
        {
            string fullPath = basePath + soundFile;
            using (SoundPlayer player = new SoundPlayer(fullPath))
            {
                player.Load();
                player.Play();
            }
        }
        private void Note1_Click(object sender, RoutedEventArgs e)
        {
            PlaySound("boing.wav");
        }

        private void Note2_Click(object sender, RoutedEventArgs e)
        {
            PlaySound("jews-harp.wav");
        }

        private void Note3_Click(object sender, RoutedEventArgs e)
        {
            PlaySound("comedic-boing.wav");
        }

        private void Note4_Click(object sender, RoutedEventArgs e)
        {
            PlaySound("juskiddink__boing.wav");
        }

        private void Note5_Click(object sender, RoutedEventArgs e)
        {
            PlaySound("springboard-b.wav");
        }

        private void Note1Shift_Click(object sender, RoutedEventArgs e)
        {
            PlaySound("foam-pluck.wav");
        }

        private void Note2Shift_Click(object sender, RoutedEventArgs e)
        {
            PlaySound("popsicle-stick-pluck.wav");
        }

        private void Note3Shift_Click(object sender, RoutedEventArgs e)
        {
            PlaySound("funny-boing.wav");
        }

        private void Note4Shift_Click(object sender, RoutedEventArgs e)
        {
            PlaySound("battery-compartment-spring.wav");
        }

        private void MainWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.D1)
            {
                if (Keyboard.Modifiers == ModifierKeys.Shift)
                {
                    PlaySound("foam-pluck.wav");
                }
                else
                {
                    PlaySound("boing.wav");
                }
            }

            if (e.Key == Key.D2)
            {
                if (Keyboard.Modifiers == ModifierKeys.Shift)
                {
                    PlaySound("popsicle-stick-pluck.wav");
                }
                else
                {
                    PlaySound("jews-harp.wav");
                }
            }

            if (e.Key == Key.D3)
            {
                if (Keyboard.Modifiers == ModifierKeys.Shift)
                {
                    PlaySound("funny-boing.wav");
                }
                else
                {
                    PlaySound("comedic-boing.wav");
                }
            }

            if (e.Key == Key.D4)
            {
                if (Keyboard.Modifiers == ModifierKeys.Shift)
                {
                    PlaySound("battery-compartment-spring.wav");
                }
                else
                {
                    PlaySound("juskiddink__boing.wav");
                }
            }

            if (e.Key == Key.D5)
            {
                PlaySound("springboard-b.wav");
            }
        }

    }
}

