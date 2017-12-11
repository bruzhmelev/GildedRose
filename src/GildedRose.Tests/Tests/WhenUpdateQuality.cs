using System.Collections.Generic;
using GildedRose.Console;
using NUnit.Framework;

namespace GildedRose.Tests.Tests
{
    [TestFixture]
    public class WhenUpdateQuality
    {
        [Test]
        public void ItsNormalItem_ThenMakeLowerBothValuesForEveryItem()
        {
            var app = new Program()
            {
                Items = new List<Item>
                {
                    new Item {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20}
                }
            };

            app.UpdateQuality();
            
            Assert.AreEqual(9, app.Items[0].SellIn, "SellIn");
            Assert.AreEqual(19, app.Items[0].Quality, "Quality");
        }
        
        [Test]
        public void UpdetedOneHundredTimes_ThenNotNegative()
        {
            var app = new Program()
            {
                Items = new List<Item>
                {
                    new Item {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20}
                }
            };
            
            for (var i = 0; i < 100; i++)
            {
                app.UpdateQuality();
            }
            
            Assert.IsTrue(app.Items[0].Quality >= 0, $"Expected Quality {app.Items[0].Quality} >= 0");
        }

        /// <summary>
        /// Conjured” items degrade in Quality twice as fast as normal items
        /// </summary>
        [Test]
        public void ConjuredItemDegradeOneTime_ThenTwiceFaster()
        {
            var app = new Program()
            {
                Items = new List<Item>
                {
                    new Item {Name = "Conjured Mana Cake", SellIn = 3, Quality = 6}
                }
            };

            app.UpdateQuality();
            
            Assert.AreEqual(2, app.Items[0].SellIn, "SellIn");
            Assert.AreEqual(4, app.Items[0].Quality, "Quality");
        }
    }
}