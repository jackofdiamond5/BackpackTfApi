namespace BackpackTfApi.SteamUser.UserInventory.Models
{
    public class InventoryItem
    {
        public InventoryItem(Asset asset, Description description)
        {
            this.Asset = asset;
            this.Description = description;
        }

        public Asset Asset { get; internal set; }

        public Description Description { get; internal set; }
    }
}
