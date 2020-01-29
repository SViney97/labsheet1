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
using System.IO;
using static System.Console;

namespace labsheet1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Band> Bands = new List<Band>();
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
                Released = RandomDate(),
                Sales = rng.Next(10, 30)
            };
            album album2 = new album()
            {
                AlbumName = "tyui",
                //Released = rng.Next(1960,2020),
                Released = RandomDate(),
                Sales = rng.Next(10, 30)
            };
            album album3 = new album()
            {
                AlbumName = "aeiou",
                //Released = rng.Next(1960,2020),
                Released = RandomDate(),
                Sales = rng.Next(10, 30)
            };
            album album4 = new album()
            {
                AlbumName = "qwerty",
                //Released = rng.Next(1960,2020),
                Released = RandomDate(),
                Sales = rng.Next(10, 30)
            };
            album album5 = new album()
            {
                AlbumName = "asdf",
                //Released = rng.Next(1960,2020),
                Released = RandomDate(),
                Sales = rng.Next(10, 30)
            };
            album album6 = new album()
            {
                AlbumName = "awsd",
                //Released = rng.Next(1960,2020),
                Released = RandomDate(),
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
            cbxGenre.ItemsSource = new string[] { "All", "Indie", "Pop", "Rock" };



        }

        private Random rngdate = new Random();
        DateTime RandomDate()
        {
            DateTime startdate = new DateTime(1960, 1, 1);
            int daterange = (DateTime.Today - startdate).Days;
            return startdate.AddDays(rngdate.Next(daterange));
        }
        private void RefreshList()
        {
            lbxBand.ItemsSource = null;
            lbxBand.ItemsSource = Bands;

            lbxAlbums.ItemsSource = null;
            lbxAlbums.ItemsSource = Albums;

            Bands.Sort();


        }//end of RefreshList

        private void CbxGenre_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //i dont undertand how to filter the bands from a combobox.

            //string[] filter = Bands.ToArray();
            //Band[] filteredBands = new Band[2];

            filteredBands.Clear();

         
            if (cbxGenre.SelectedItem != null)
            {
                lbxBand.ItemsSource = Bands;
            }
            else if (cbxGenre.SelectedItem == "All")
            {
                Bands.ToArray();
                lbxBand.ItemsSource = Bands;
            }
            else if (cbxGenre.SelectedItem == "Indie")
            {

                foreach (Band filtered in Bands)
                {
                    Bands.ToArray();
                    //if(filtered == IndieBand)
                    filteredBands[counter] = filtered;
                    counter++;
                }

            }
            else if (cbxGenre.SelectedItem == "Rock")
            {

                foreach (Band filtered in Bands)
                {
                    Bands.ToArray();
                    //if(filtered == RockBand)
                    filteredBands[counter] = filtered;
                    counter++;
                }

            }
            else if (cbxGenre.SelectedItem == "Pop")
            {

                foreach (Band filtered in Bands)
                {
                    Bands.ToArray();
                    //if(filtered == PopBand)
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
            /*used the link below to help [27/01/2020]
            https://stackoverflow.com/questions/15300572/saving-lists-to-txt-file
            */
            using (TextWriter text = new StreamWriter("Bands.txt"))
            {
                foreach (Band input in Bands)
                {
                    text.WriteLine(input);

                }
            }

            /* string linein;
             int element = 0;

             FileStream fs3 = new FileStream("Bands.txt", FileMode.Open, FileAccess.Write);
             StreamReader inputStream = new StreamReader(fs3);

             linein = inputStream.ReadLine();
             WriteLine();
             while (linein != null)
             {
                 linein = inputStream.ReadLine();

                 element++;
             }
             inputStream.Close();
         }*/
        }

    }
}
