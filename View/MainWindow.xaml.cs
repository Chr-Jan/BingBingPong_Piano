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

        private void Note1_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"D:\GitHub\Personlige Projekter\PianoMEME\sound\boing-1.wav");
            player.Load();
            player.Play();
        }

        private void Note2_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"D:\\GitHub\\Personlige Projekter\\HomeProjects\\PianoMeme\\sound\\jews-harp.wav");
            player.Load();
            player.Play();
        }

        private void Note3_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"D:\\GitHub\\Personlige Projekter\\HomeProjects\\PianoMeme\\sound\\comedic-boing.wav");
            player.Load();
            player.Play();
        }

        private void Note4_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"D:\\GitHub\\Personlige Projekter\\HomeProjects\\PianoMeme\\sound\\juskiddink__boing.wav");
            player.Load();
            player.Play();
        }

        private void Note5_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"D:\\GitHub\\Personlige Projekter\\HomeProjects\\PianoMeme\\sound\\springboard-b.wav");
            player.Load();
            player.Play();
        }

        private void Note1Shift_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"D:\\GitHub\\Personlige Projekter\\HomeProjects\\PianoMeme\\sound\\foam-pluck.wav");
            player.Load();
            player.Play();
        }
        private void Note2Shift_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"D:\\GitHub\\Personlige Projekter\\HomeProjects\\PianoMeme\\sound\\popsicle-stick-pluck.wav");
            player.Load();
            player.Play();
        }

        private void Note3Shift_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"D:\\GitHub\\Personlige Projekter\\HomeProjects\\PianoMeme\\sound\\funny-boing.wav");
            player.Load();
            player.Play();
        }

        private void Note4Shift_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer player = new SoundPlayer(@"D:\\GitHub\\Personlige Projekter\\HomeProjects\\PianoMeme\\sound\\battery-compartment-spring.wav");
            player.Load();
            player.Play();
        }

        private void MainWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.D1)
            {
                SoundPlayer player = new SoundPlayer(@"D:\\GitHub\\Personlige Projekter\\HomeProjects\\PianoMeme\\sound\\boing-1.wav");
                player.Load();
                player.Play();
            }

            if (e.Key == Key.D2)
            {
                SoundPlayer player = new SoundPlayer(@"D:\\GitHub\\Personlige Projekter\\HomeProjects\\PianoMeme\\sound\\jews-harp.wav");
                player.Load();
                player.Play();
            }

            if (e.Key == Key.D3)
            {
                SoundPlayer player = new SoundPlayer(@"D:\\GitHub\\Personlige Projekter\\HomeProjects\\PianoMeme\\sound\\comedic-boing.wav");
                player.Load();
                player.Play();
            }

            if (e.Key == Key.D4)
            {
                SoundPlayer player = new SoundPlayer(@"D:\\GitHub\\Personlige Projekter\\HomeProjects\\PianoMeme\\sound\\juskiddink__boing.wav");
                player.Load();
                player.Play();
            }

            if (e.Key == Key.D5)
            {
                SoundPlayer player = new SoundPlayer(@"D:\\GitHub\\Personlige Projekter\\HomeProjects\\PianoMeme\\sound\\springboard-b.wav");
                player.Load();
                player.Play();
            }

            if (e.Key == Key.D1 && Keyboard.Modifiers == ModifierKeys.Shift)
            {
                SoundPlayer player = new SoundPlayer(@"D:\\GitHub\\Personlige Projekter\\HomeProjects\\PianoMeme\\sound\\foam-pluck.wav");
                player.Load();
                player.Play();
            }

            if (e.Key == Key.D2 && Keyboard.Modifiers == ModifierKeys.Shift)
            {
                SoundPlayer player = new SoundPlayer(@"D:\\GitHub\\Personlige Projekter\\HomeProjects\\PianoMeme\\sound\\popsicle-stick-pluck.wav");
                player.Load();
                player.Play();
            }

            if (e.Key == Key.D3 && Keyboard.Modifiers == ModifierKeys.Shift)
            {
                SoundPlayer player = new SoundPlayer(@"D:\\GitHub\\Personlige Projekter\\HomeProjects\\PianoMeme\\sound\\funny-boing.wav");
                player.Load();
                player.Play();
            }

            if (e.Key == Key.D4 && Keyboard.Modifiers == ModifierKeys.Shift)
            {
                SoundPlayer player = new SoundPlayer(@"D:\\GitHub\\Personlige Projekter\\HomeProjects\\PianoMeme\\sound\\battery-compartment-spring.wav");
                player.Load();
                player.Play();
            }
        }
    }
}
