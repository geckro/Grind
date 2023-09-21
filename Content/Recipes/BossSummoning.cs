using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Grind.Content.Recipes
{
    public class BossSummoning : ModSystem
    {
        public override void PostAddRecipes() {
            
            Recipe.Create(ItemID.SuspiciousLookingEye)
                .AddIngredient(ItemID.DemonEyeBanner)
                .AddIngredient(ItemID.BlackLens)
                .AddRecipeGroup("Grind:EvilMaterial", 15)
                .AddTile(TileID.DemonAltar)
                .Register();
            Recipe.Create(ItemID.BloodySpine)
                .AddIngredient(ItemID.FaceMonsterBanner)
                .AddIngredient(ItemID.CrimeraBanner)
                .AddIngredient(ItemID.BloodCrawlerBanner)
                .AddIngredient(ItemID.CrimstoneBlock, 200)
                .AddIngredient(ItemID.ViciousPowder, 50)
                .AddIngredient(ItemID.PigPetItem)
                .AddTile(TileID.DemonAltar)
                .Register();
            Recipe.Create(ItemID.WormFood)
                .AddIngredient(ItemID.EaterofSoulsBanner)
                .AddIngredient(ItemID.WormTooth, 50)
                .AddIngredient(ItemID.EbonstoneBlock, 200)
                .AddIngredient(ItemID.VilePowder, 50)
                .AddIngredient(ItemID.PigPetItem)
                .AddTile(TileID.DemonAltar)
                .Register();
            Recipe.Create(ItemID.Abeemination)
                .AddIngredient(ItemID.HornetBanner)
                .AddIngredient(ItemID.HoneyBlock, 50)
                .AddIngredient(ItemID.Hive, 100)
                .AddIngredient(ItemID.CrispyHoneyBlock, 50)
                .AddIngredient(ItemID.YellowDye, 5)
                .AddRecipeGroup("Grind:EvilBoss", 5)
                .AddTile(TileID.HoneyDispenser)
                .Register();
            Recipe.Create(ItemID.GuideVoodooDoll)
                .AddIngredient(ItemID.AshBlock, 1000)
                .AddIngredient(ItemID.HellstoneBar, 50)
                .AddIngredient(ItemID.Bone, 100)
                .AddIngredient(ItemID.ClothierVoodooDoll)
                .AddIngredient(ItemID.GreenCap)
                .AddIngredient(ItemID.DemonBanner)
                .AddCondition(Condition.NearLava)
                .AddCondition(Condition.PreHardmode)
                .AddTile(TileID.DemonAltar)
                .AddTile(TileID.Hellforge)
                .Register();
        }
    }
} 