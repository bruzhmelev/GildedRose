namespace GildedRose.Console
{
    public class QualityUpdater
    {
        public static UpdateResult UpdateForConjured(Item item)
        {
            if (item.Name != "Conjured Mana Cake")
            {
                return new UpdateResult(false, item);
            }
            
            item.Quality -= 2;
            item.SellIn -= 1;
            return new UpdateResult(true, item);
        }
    }
}