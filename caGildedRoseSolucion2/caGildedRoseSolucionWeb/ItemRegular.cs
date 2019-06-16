using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace caGildedRoseSolucionWeb
{
    public class ItemRegular : iGRstrategy
    {

        public void UpdateItem(Item i)
        {
            i.restSellIn();

            if (i.Quality > 0)
                if (i.SellIn < 0)
                {
                    i.restQuality();
                    i.restQuality();
                }
                else
                    i.restQuality();

        }
    }
}
