using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Grind.Content.Recipes
{
    public class Sand : ModSystem
    {
        public override void PostAddRecipes() {
            
            Recipe.Create(ItemID.Glass)
                .AddIngredient(ItemID.SandBlock, 4)
                .AddRecipeGroup("Grind:CopperTinOre")
                .AddTile(TileID.Hellforge)
                .Register();
        }
    }
}