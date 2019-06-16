using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace caGildedRoseSolucionWeb
{
    public class Program
    {
        List<Item> Items;

        public List<Item> GetItems
        {
            get { return Items; }
            set { Items = value; }
        }

        public Program(List<Item> items)
        {
            this.Items = items;
        }

        static void Main(string[] args)
        {
            System.Console.WriteLine("");
            System.Console.WriteLine("MODULO 1  > PATRONES DE DISENO");
            System.Console.WriteLine("DOCENTE   > ROBERTO PEREZ");
            System.Console.WriteLine("ALUMNO    > EVERTH AMAYA");
            System.Console.WriteLine("SOLUCION  > GILDED ROSE C#");
            System.Console.WriteLine("");

            #region comentario
            //List<Item> Items = new List<Item>()
            //                              {
            //                                  //new Item {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20},
            //                                  //new Item {Name = "Aged Brie", SellIn = 10, Quality = 20},//2,0
            //                                  //new Item {Name = "Elixir of the Mongoose", SellIn = 10, Quality = 20},//5,7
            //                                  //new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = 10, Quality = 20},//0,80
            //                                  new Item
            //                                      {
            //                                          Name = "Backstage passes to a TAFKAL80ETC concert",
            //                                          SellIn = 10,//15
            //                                          Quality = 20//20
            //                                      },
            //                                  //new Item {Name = "Conjured Mana Cake", SellIn = 10, Quality = 20}//3,6
            //                              };
            #endregion

            List<Item> Items = new List<Item>(6);

            Item i1 = new Item("+5 Dexterity Vest", 10, 20);
            Item i2 = new Item("Aged Brie", 10, 20);
            Item i3 = new Item("Elixir of the Mongoose", 10, 20);
            Item i4 = new Item("Sulfuras, Hand of Ragnaros", 10, 20);
            Item i5 = new Item("Backstage passes to a TAFKAL80ETC concert", 10, 20);
            Item i6 = new Item("Conjured Mana Cake", 10, 20);

            Items.Add(i1);
            Items.Add(i2);
            Items.Add(i3);
            Items.Add(i4);
            Items.Add(i5);
            Items.Add(i6);

            var app = new Program(Items);

            app.UpdateQuality();

            System.Console.Read();

        }

        public void UpdateQuality()
        {
            iGRstrategy iGR = new ItemRegular();

            for (var c = 0; c < 25; c++)
            {
                Console.WriteLine("-------- day " + c + " --------");
                Console.WriteLine("name, sellIn, quality");

                foreach (Item item in Items)
                {
                    Console.WriteLine(item.ToString());

                    if (item.Name.Contains("Aged"))
                        iGR = new ItemAgedBrew();
                    else if (item.Name.Contains("Backstage"))
                        iGR = new ItemBackstagePasses();
                    else if (item.Name.Contains("Sulfuras"))
                        iGR = new ItemLegendary();
                    else
                        iGR = new ItemRegular();

                    iGR.UpdateItem(item);

                }
                Console.WriteLine(""); Console.WriteLine("");
            }

            Console.Read();

        }

    }
}
