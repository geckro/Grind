using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Grind.Common
{
    public class DisableRecipes : ModSystem
    {
        public override void PostAddRecipes() {
            for (int i = 0; i < Recipe.numRecipes; i++) {
                Recipe recipe = Main.recipe[i];

                if 
                (
                    recipe.HasResult(ItemID.WorkBench) ||
                    recipe.HasResult(ItemID.Furnace) ||
                    recipe.HasResult(ItemID.IronAnvil) ||
                    recipe.HasResult(ItemID.LeadAnvil) ||
                    recipe.HasResult(ItemID.Sawmill) ||
                    recipe.HasResult(ItemID.Loom) ||
                    recipe.HasResult(ItemID.HeavyWorkBench) ||
                    recipe.HasResult(ItemID.CookingPot) ||
                    recipe.HasResult(ItemID.Keg) ||
                    recipe.HasResult(ItemID.SuspiciousLookingEye) ||
                    recipe.HasResult(ItemID.WormFood) ||
                    recipe.HasResult(ItemID.BloodySpine) ||
                    recipe.HasResult(ItemID.Abeemination) ||
                    recipe.HasResult(ItemID.WoodenTable) ||
                    recipe.HasResult(ItemID.WoodenChair) ||
                    recipe.HasResult(ItemID.WoodenDoor) ||
                    recipe.HasResult(ItemID.Glass)
                )
                {
                    recipe.DisableRecipe();
                }
            }
        }
    }
}