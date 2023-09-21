using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Grind.Common
{
    public class RecipeGroups : ModSystem
    {
        public override void AddRecipeGroups()
        {
            // Bars
            RecipeGroup group = new RecipeGroup(() => "Copper or Tin Bar", ItemID.CopperBar, ItemID.TinBar);
            RecipeGroup.RegisterGroup("Grind:CopperTinBar", group);
            group = new RecipeGroup(() => "Iron or Lead Bar", ItemID.IronBar, ItemID.LeadBar);
            RecipeGroup.RegisterGroup("Grind:IronLeadBar", group);
            group = new RecipeGroup(() => "Silver or Tungsten Bar", ItemID.SilverBar, ItemID.TungstenBar);
            RecipeGroup.RegisterGroup("Grind:SilverTungstenBar", group);
            group = new RecipeGroup(() => "Gold or Platinum Bar", ItemID.GoldBar, ItemID.PlatinumBar);
            RecipeGroup.RegisterGroup("Grind:GoldPlatinumBar", group);
            group = new RecipeGroup(() => "Demonite or Crimtane Bar", ItemID.DemoniteBar, ItemID.CrimtaneBar);
            RecipeGroup.RegisterGroup("Grind:DemoniteCrimtaneBar", group);
            group = new RecipeGroup(() => "Cobalt or Palladium Bar", ItemID.CobaltBar, ItemID.PalladiumBar);
            RecipeGroup.RegisterGroup("Grind:CobaltPalladiumBar", group);
            group = new RecipeGroup(() => "Mythril or Orichalcum Bar", ItemID.MythrilBar, ItemID.OrichalcumBar);
            RecipeGroup.RegisterGroup("Grind:MythrilOrichalcumBar", group);
            group = new RecipeGroup(() => "Adamantite or Titanium Bar", ItemID.AdamantiteBar, ItemID.TitaniumBar);
            RecipeGroup.RegisterGroup("Grind:AdamantiteTitaniumBar", group);
            
            // Ores
            group = new RecipeGroup(() => "Copper or Tin Ore", ItemID.CopperOre, ItemID.TinOre);
            RecipeGroup.RegisterGroup("Grind:CopperTinOre", group);
            group = new RecipeGroup(() => "Iron or Lead Ore", ItemID.IronOre, ItemID.LeadOre);
            RecipeGroup.RegisterGroup("Grind:IronLeadOre", group);
            group = new RecipeGroup(() => "Silver or Tungsten Ore", ItemID.SilverOre, ItemID.TungstenOre);
            RecipeGroup.RegisterGroup("Grind:SilverTungstenOre", group);
            group = new RecipeGroup(() => "Gold or Platinum Ore", ItemID.GoldOre, ItemID.PlatinumOre);
            RecipeGroup.RegisterGroup("Grind:GoldPlatinumOre", group);
            group = new RecipeGroup(() => "Demonite or Crimtane Ore", ItemID.DemoniteOre, ItemID.CrimtaneOre);
            RecipeGroup.RegisterGroup("Grind:DemoniteCrimtaneOre", group);
            group = new RecipeGroup(() => "Cobalt or Palladium Ore", ItemID.CobaltOre, ItemID.PalladiumOre);
            RecipeGroup.RegisterGroup("Grind:CobaltPalladiumOre", group);
            group = new RecipeGroup(() => "Mythril or Orichalcum Ore", ItemID.MythrilOre, ItemID.OrichalcumOre);
            RecipeGroup.RegisterGroup("Grind:MythrilOrichalcumOre", group);
            group = new RecipeGroup(() => "Adamantite or Titanium Ore", ItemID.AdamantiteOre, ItemID.TitaniumOre);
            RecipeGroup.RegisterGroup("Grind:AdamantiteTitaniumOre", group);
            
            // Wood
            group = new RecipeGroup(() => "Any Wood", ItemID.Wood, ItemID.BorealWood, ItemID.PalmWood, ItemID.Ebonwood, ItemID.Shadewood, ItemID.RichMahogany, ItemID.AshWood, ItemID.Pearlwood);
            RecipeGroup.RegisterGroup("Grind:Wood", group);
            
            // Hammer
            group = new RecipeGroup(() => "Gold or Platinum Hammer", ItemID.GoldHammer, ItemID.PlatinumHammer);
            RecipeGroup.RegisterGroup("Grind:GoldPlatinumHammer", group);
            
            // Anvils
            group = new RecipeGroup(() => "Anvils", ItemID.IronAnvil, ItemID.LeadAnvil);
            RecipeGroup.RegisterGroup("Grind:Anvils", group);
            
            // Evil
            group = new RecipeGroup(() => "Rotten Chunk or Vertebrae", ItemID.RottenChunk, ItemID.Vertebrae);
            RecipeGroup.RegisterGroup("Grind:EvilMaterial", group);
            group = new RecipeGroup(() => "Shadow Scale or Tissue Sample", ItemID.ShadowScale, ItemID.TissueSample);
            RecipeGroup.RegisterGroup("Grind:EvilBoss", group);
        }
    }
}