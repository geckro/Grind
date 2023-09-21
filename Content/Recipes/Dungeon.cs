using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Grind.Content.Recipes
{
    public class Dungeon : ModSystem
    {
        public override void PostAddRecipes() {
            
            Recipe.Create(ItemID.NecroHelmet)
                .AddIngredient(ItemID.Bone, 200)
                .AddIngredient(ItemID.Skull)
                .AddIngredient(ItemID.Spike, 400)
                .AddTile(TileID.BoneWelder)
                .Register();
            Recipe.Create(ItemID.NecroBreastplate)
                .AddIngredient(ItemID.Bone, 300)
                .AddIngredient(ItemID.Spike, 600)
                .AddTile(TileID.BoneWelder)
                .Register();
            Recipe.Create(ItemID.NecroBreastplate)
                .AddIngredient(ItemID.Bone, 250)
                .AddIngredient(ItemID.Spike, 500)
                .AddTile(TileID.BoneWelder)
                .Register();
        }
    }
}