using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace caGildedRoseSolucionWeb
{
    public class Item
    {

        public Item(string name, int sellIn, int quality)
        {
            this.Name = name;
            this.SellIn = sellIn;
            this.Quality = quality;
        }


        public string Name { get; set; }

        public int SellIn { get; set; }

        public int Quality { get; set; }
        


        public override string ToString()
        {
            return this.Name + ", " + this.SellIn + ", " + this.Quality;
        }



        public void sumQuality()
        {
            this.Quality = this.Quality + 1;
        }
        public void restQuality()
        {
            this.Quality = this.Quality - 1;
        }
        public void notQuality()
        {
            this.Quality = 0;
        }

        public void restSellIn()
        {
            this.SellIn = this.SellIn - 1;
        }



    }

}
