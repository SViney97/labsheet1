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
        public MainWindow()
        {
            InitializeComponent();



        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            RockBand band1 = new RockBand()
            {
                BandName = "Panic at the disco",
                YearFormed = 2006,
                Members = "Brendan Uire"
            };

            IndieBand band2 = new IndieBand()
            {
                BandName = "fall out boy",
                YearFormed = 2000,
                Members = "tom"
            };

             RockBand band3 = new RockBand()
            {
                BandName = "linkin park",
                YearFormed = 2000,
                Members = "mike,chester"
            };
            PopBand band4 = new PopBand()
            {
                BandName = "genesis",
                YearFormed = 1967,
                Members = "phil collins,"
            };
            PopBand band5 = new PopBand()
            {
                BandName = "abba",
                YearFormed = 1976,
                Members = "tina"
            };
            RockBand band6 = new RockBand()
            {
                BandName = "Queen",
                YearFormed = 1970,
                Members = "freddy"
            };

            Bands.Add(band1);
            Bands.Add(band2);
            Bands.Add(band3);
            Bands.Add(band4);
            Bands.Add(band5);
            Bands.Add(band6);

            RefreshList();
            lbxBand.ItemsSource = Bands;
        }
        private void RefreshList()
        {
            lbxBand.ItemsSource = null;
            lbxBand.ItemsSource = Bands;

  
            //sorts the bands in bands listbox by band name 
            //display in order
            Bands.Sort();
            
        }//end of RefreshList

    }

}
