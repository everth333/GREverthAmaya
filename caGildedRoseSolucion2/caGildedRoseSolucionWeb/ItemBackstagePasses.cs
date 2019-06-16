using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace caGildedRoseSolucionWeb
{
    public class ItemBackstagePasses : iGRstrategy
    {

        public void UpdateItem(Item i)
        {
            i.restSellIn();

            if (i.Quality < 50)
            {
                if (i.SellIn < 0)
                    i.notQuality();
                else if (i.SellIn < 6)
                {
                    i.sumQuality();
                    i.sumQuality();
                    i.sumQuality();
                }
                else if (i.SellIn < 11)
                {
                    i.sumQuality();
                    i.sumQuality();
                }
                else
                    i.sumQuality();
            }
        }

    }
}
