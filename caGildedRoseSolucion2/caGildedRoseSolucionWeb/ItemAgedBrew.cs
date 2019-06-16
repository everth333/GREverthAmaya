using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace caGildedRoseSolucionWeb
{
    public class ItemAgedBrew : iGRstrategy
    {
        public void UpdateItem(Item i)
        {
            i.restSellIn();

            if (i.Quality < 50)
                if (i.SellIn < 0)
                {
                    i.sumQuality();
                    i.sumQuality();
                }
                else
                    i.sumQuality();
        }

    }
}
