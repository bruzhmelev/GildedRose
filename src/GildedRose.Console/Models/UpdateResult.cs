namespace GildedRose.Console
{
    public class UpdateResult
    {
        public bool Success { get;}
        public Item Item { get;}

        public UpdateResult(bool success, Item item)
        {
            Success = success;
            Item = item;
        }
    }
}