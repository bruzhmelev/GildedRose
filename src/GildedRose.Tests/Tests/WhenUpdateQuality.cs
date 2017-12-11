using System.Collections.Generic;
using GildedRose.Console;
using NUnit.Framework;

namespace GildedRose.Tests.Tests
{
    [TestFixture]
    public class WhenUpdateQuality
    {
        [Test]
        public void IfItsNormalItem_ThenMakeLowerBothValuesForEveryItem()
        {
            var app = new Program()
            {
                Items = new List<Item>
                {
                    new Item {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20}
                }
            };

            app.UpdateQuality();
            
            Assert.AreEqual(9, app.Items[0].SellIn);
            Assert.AreEqual(19, app.Items[0].Quality);
        }
        
        [Test]
        public void IfUpdetedOneHundredTimes_NotNegative()
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
            
            Assert.IsTrue(app.Items[0].Quality >= 0, $"Expected {app.Items[0].Quality} >= 0");
        }
    }
}