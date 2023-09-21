using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Grind.Content.Recipes
{
    public class CraftingStations : ModSystem
    {
        public override void PostAddRecipes() {
            
            Recipe.Create(ItemID.WorkBench)
                .AddIngredient(ItemID.Wood, 30)
                .AddIngredient(ItemID.WoodPlatform, 50)
                .AddIngredient(ItemID.Acorn, 10)
                .AddIngredient(ItemID.ClayBlock, 25)
                .AddTile(TileID.Trees)
                .Register();
            Recipe.Create(ItemID.Furnace)
                .AddIngredient(ItemID.StoneBlock, 200)
                .AddIngredient(ItemID.Torch, 20)
                .AddRecipeGroup("Grind:CopperTinOre", 20)
                .AddTile(TileID.WorkBenches)
                .Register();
            Recipe.Create(ItemID.IronAnvil)
                .AddIngredient(ItemID.IronBar, 15)
                .AddIngredient(ItemID.GrayBrick, 50)
                .AddIngredient(ItemID.WoodenHammer)
                .AddTile(TileID.WorkBenches)
                .Register();
            Recipe.Create(ItemID.LeadAnvil)
                .AddIngredient(ItemID.LeadBar, 15)
                .AddIngredient(ItemID.GrayBrick, 50)
                .AddIngredient(ItemID.WoodenHammer)
                .AddTile(TileID.WorkBenches)
                .Register();
            Recipe.Create(ItemID.Sawmill)
                .AddIngredient(ItemID.SpikyBall)
                .AddIngredient(ItemID.WorkBench)
                .AddRecipeGroup("Grind:Wood", 50)
                .AddIngredient(ItemID.Chain, 25)
                .AddTile(TileID.Anvils)
                .Register();
            Recipe.Create(ItemID.Loom)
                .AddRecipeGroup("Grind:Wood", 50)
                .AddIngredient(ItemID.Cobweb, 100)
                .AddIngredient(ItemID.RedDye)
                .AddIngredient(ItemID.BlueDye)
                .AddIngredient(ItemID.PinkDye)
                .AddRecipeGroup("Grind:IronLeadBar", 5)
                .AddTile(TileID.Sawmill)
                .Register();
            Recipe.Create(ItemID.HeavyWorkBench)
                .AddRecipeGroup("Grind:IronLeadBar", 50)
                .AddRecipeGroup("Grind:GoldPlatinumHammer")
                .AddIngredient(ItemID.Chain, 20)
                .AddRecipeGroup("Grind:Anvils")
                .AddTile(TileID.Sawmill)
                .AddTile(TileID.Anvils)
                .Register();
            Recipe.Create(ItemID.CookingPot)
                .AddRecipeGroup("Grind:IronLeadBar", 25)
                .AddIngredient(ItemID.WaterBucket, 5)
                .AddIngredient(ItemID.Torch, 25)
                .AddIngredient(ItemID.Campfire)
                .AddTile(TileID.HeavyWorkBench)
                .Register();
            Recipe.Create(ItemID.DyeVat)
                .AddRecipeGroup("Grind:IronLeadBar", 10)
                .AddRecipeGroup("Grind:Wood", 50)
                .AddIngredient(ItemID.Ruby, 3)
                .AddIngredient(ItemID.Sapphire, 3)
                .AddIngredient(ItemID.Emerald, 3)
                .AddIngredient(ItemID.GrapplingHook)
                .AddTile(TileID.HeavyWorkBench)
                .Register();
            Recipe.Create(ItemID.Keg)
                .AddRecipeGroup("Grind:IronLeadBar", 10)
                .AddRecipeGroup("Grind:Wood", 35)
                .AddIngredient(ItemID.Barrel)
                .AddIngredient(ItemID.Mug, 5)
                .AddTile(TileID.HeavyWorkBench)
                .AddTile(TileID.Sawmill)
                .Register();
        }
    }
}