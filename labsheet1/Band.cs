using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labsheet1
{
    public abstract class Band : IComparable
    {
        public string BandName { get; set; }

        public int YearFormed { get; set; }

        public string Members { get; set; }

        public album[] Albums { get; set; }
        
        public Band()
        {

        }

        public Band(string bandname, int yearformed, string members)
        {
            BandName = bandname;
            YearFormed = yearformed;
            Members = members;
            
        }

        public int CompareTo(object obj)
        {
            //get name for thing beside current activity
            //this sorts the data beside it.
            //for example if the data was C,A,B - it will sort itself to form A,B,C.
            Band objectBeside = obj as Band;
            return this.BandName.CompareTo(objectBeside.BandName);
        }
        public override string ToString()
        {
          
            return $"{BandName}";
        }

        

        
    }//end of class



    public class RockBand : Band
    {
        public RockBand()
            {

            }
        public override string ToString()
        {
            return (this.BandName + "- rock");
        }
    }

    public class PopBand : Band
    {
        public PopBand()
        {
        }
        public override string ToString()
        {
            return (this.BandName + "- Pop");
        }
    }

    public class IndieBand : Band
    {
        public IndieBand()
        {
        }
        public override string ToString()
        {
            return (this.BandName + "-Indie");
        }
    }

    public class album
    {
        public string AlbumName { get; set; }

        public DateTime Released { get; set; }

        public decimal Sales { get; set; }

       

        Random rng = new Random();

      
        public album()
        {

        }
        public album(string albumname, DateTime released, decimal sales)
        {
            AlbumName = albumname;
            Released = released;
            Sales = sales;
        }
        public override string ToString()
        {
            return (this.AlbumName + "-" + (DateTime.Now.Year - Released.Year) +"-€" + this.Sales);
        }
    }
}
