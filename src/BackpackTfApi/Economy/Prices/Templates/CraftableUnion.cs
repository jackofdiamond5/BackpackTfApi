using System.Collections.Generic;

using BackpackTfApi.Economy.Prices.Models;

namespace BackpackTfApi.Economy.Prices.Templates
{
    internal partial struct CraftableUnion
    {
        public ICollection<CraftableElement> CraftableElementArray;
        public Dictionary<string, CraftableElement> CraftableElementMap;

        public static implicit operator CraftableUnion(CraftableElement[] CraftableElementArray)
            => new CraftableUnion { CraftableElementArray = CraftableElementArray };

        public static implicit operator CraftableUnion(Dictionary<string, CraftableElement> CraftableElementMap)
            => new CraftableUnion { CraftableElementMap = CraftableElementMap };
    }
}
