using System;
using System.Linq;

using BackpackTfApi.Static;
using BackpackTfApi.Exceptions;

namespace BackpackTfApi.SteamUser.UserInventory.Models
{
    /// <summary>
    /// A Steam inventory item.
    /// </summary>
    public class InventoryItem
    {
        private const string TargetTag = "quality";

        public InventoryItem(Asset asset, Description description)
        {
            this.Asset = asset;
            this.Description = description;
        }

        /// <summary>
        /// The name of the item.
        /// </summary>
        public string Name
        {
            get
            {
                if (string.IsNullOrWhiteSpace(this.Description.MarketHashName))
                {
                    throw new ItemNotFoundException(Messages.ItemNotFoundError);
                }

                return this.Description.MarketHashName;
            }
        }

        /// <summary>
        /// The quality name of the specified item.
        /// </summary>
        public string QualityName
        {
            get
            {
                try
                {
                    return this.Description
                        .Tags
                        .Where(t => t.Category.ToLower() == TargetTag)
                        .First()
                        .InternalName;
                }
                catch (InvalidOperationException)
                {
                    throw new ItemNotFoundException($"{Messages.ItemNotFoundError}");
                }
            }
        }

        /// <summary>
        /// The quality index of the specified item.
        /// </summary>
        public string QualityIndex => this.GetItemQualityIndex();

        /// <summary>
        /// The Steam inventory's asset object.
        /// </summary>
        public Asset Asset { get; internal set; }

        /// <summary>
        /// The Steam inventory's description object.
        /// </summary>
        public Description Description { get; internal set; }

        private string GetItemQualityIndex()
        {
            try
            {
                return this.GetIndex(this.QualityName);
            }
            catch (ItemNotFoundException)
            {
                return this.GetIndex(this.Name);
            }
        }

        private string GetIndex(string value)
        {
            var quality = value.Split().Take(1).ToArray()[0].ToLower();
            switch (quality)
            {
                case "normal":
                    return "0";
                case "genuine":
                    return "1";
                case "vintage":
                    return "3";
                case "unusual":
                    return "5";
                case "unique":
                    return "6";
                case "community":
                    return "7";
                case "valve":
                    return "8";
                case "self-made":
                    return "9";
                case "strange":
                    return "11";
                case "haunted":
                    return "13";
                case "collector's":
                    return "14";
                case "decorated":
                    return "15";
                default:
                    throw new ArgumentException(Messages.ItemQualityError);
            }
        }
    }
}
