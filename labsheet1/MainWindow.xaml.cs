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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace labsheet1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Band> Bands= new List<Band>();
        List<album> Albums = new List<album>();
        List<Band> filteredBands = new List<Band>();
        public MainWindow()
        {
            InitializeComponent();


        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            Random rng = new Random();
            RockBand band1 = new RockBand()
            {
                BandName = "Panic at the disco",
                YearFormed = rng.Next(1950, 2020),
                Members = "Brendan Uire"
            };

            IndieBand band2 = new IndieBand()
            {
                BandName = "fall out boy",
                YearFormed = rng.Next(1950, 2020),
                Members = "tom"
            };

            RockBand band3 = new RockBand()
            {
                BandName = "linkin park",
                YearFormed = rng.Next(1950, 2020),
                Members = "mike,chester"
            };
            PopBand band4 = new PopBand()
            {
                BandName = "genesis",
                YearFormed = rng.Next(1950, 2020),
                Members = "phil collins,"
            };
            PopBand band5 = new PopBand()
            {
                BandName = "abba",
                YearFormed = rng.Next(1950, 2020),
                Members = "tina"
            };
            RockBand band6 = new RockBand()
            {
                BandName = "Queen",
                YearFormed = rng.Next(1950, 2020),
                Members = "freddy"
            };

            Bands.Add(band1);
            Bands.Add(band2);
            Bands.Add(band3);
            Bands.Add(band4);
            Bands.Add(band5);
            Bands.Add(band6);


            album album1 = new album()
            {
                AlbumName = "abcd",
                //Released = rng.Next(1960,2020),
                Sales = rng.Next(10, 30)
            };
            album album2 = new album()
            {
                AlbumName = "tyui",
                //Released = rng.Next(1960,2020),
                Sales = rng.Next(10, 30)
            };
            album album3 = new album()
            {
                AlbumName = "aeiou",
                //Released = rng.Next(1960,2020),
                Sales = rng.Next(10, 30)
            };
            album album4 = new album()
            {
                AlbumName = "qwerty",
                //Released = rng.Next(1960,2020),
                Sales = rng.Next(10, 30)
            };
            album album5 = new album()
            {
                AlbumName = "asdf",
                //Released = rng.Next(1960,2020),
                Sales = rng.Next(10, 30)
            };
            album album6 = new album()
            {
                AlbumName = "awsd",
                //Released = rng.Next(1960,2020),
                Sales = rng.Next(10, 30)
            };
            Albums.Add(album1);
            Albums.Add(album2);
            Albums.Add(album3);
            Albums.Add(album4);
            Albums.Add(album5);
            Albums.Add(album6);

            RefreshList();
            lbxBand.ItemsSource = Bands;
            cbxGenre.ItemsSource = new string[] {"All Genre", "Indie","Pop", "Rock"};


            
        }
        private void RefreshList()
        {
            lbxBand.ItemsSource = null;
            lbxBand.ItemsSource = Bands;

            lbxAlbums.ItemsSource = null;
            lbxAlbums.ItemsSource = Albums;

            //sorts the bands in bands listbox by band name 
            //display in order
            Bands.Sort();
 
            
        }//end of RefreshList

        private void CbxGenre_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Band[] filteredBands = new Band[2];
            int counter = 0;
            if (cbxGenre.SelectedItem != null)
            {

            }
            else if (cbxGenre.SelectedItem == "Indie")
            {
                foreach (Band filtered in filteredBands)
                {

                    filteredBands[counter] = filtered;
                    counter++;
                }
            }
            lbxBand.ItemsSource = filteredBands;

            
            /*else if (cbxGenre.SelectedItem == "Indie Band")
            {
                foreach (Band currentBand in filteredBands)
                {
                    filteredBands[counter] = currentBand;
                    counter++;
                }
               
            }
            */
        }

        private void LbxBand_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Band selected = lbxBand.SelectedItem as Band;

            if (selected != null)
            {
                tbkInformation.Text = $"Year Formed-{selected.YearFormed} \t Memebers-{selected.Members}";
                //lbxAlbums.ItemsSource = $"{}";
            }
        }

        private void btnSAVE_Click(object sender, RoutedEventArgs e)
        {
  
        }
    }

}
