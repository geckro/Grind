using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Grind.Content.Recipes
{
    public class Wood : ModSystem
    {
        public override void PostAddRecipes() {
            
            Recipe.Create(ItemID.WoodenDoor)
                .AddIngredient(ItemID.Wood, 8)
                .AddRecipeGroup("Grind:IronLeadBar")
                .AddTile(TileID.WorkBenches)
                .Register();
            Recipe.Create(ItemID.WoodenTable)
                .AddIngredient(ItemID.Wood, 12)
                .AddIngredient(ItemID.WoodPlatform, 8)
                .AddTile(TileID.Sawmill)
                .Register();
            Recipe.Create(ItemID.WoodenChair)
                .AddIngredient(ItemID.Wood, 8)
                .AddIngredient(ItemID.Cobweb, 10)
                .AddTile(TileID.WorkBenches)
                .Register();
        }
    }
}