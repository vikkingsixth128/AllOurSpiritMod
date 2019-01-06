
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace AllOurSpiritMod.Items.swords
{
    public class ColorSword : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Color Sword");
            Tooltip.SetDefault("Oh... I'm getting confused...");

            //Traducciones - translates

            DisplayName.AddTranslation(GameCulture.Spanish, "Espada de colorín");    //Español - Spanish
            Tooltip.AddTranslation(GameCulture.Spanish, "Demonios... Me estoy mareando...");        //Español - Spanish
        }

        public override void SetDefaults()
        {
            item.damage = 230;
            item.melee = true;
            item.width = 33;
            item.height = 32;
            item.useTime = 3;
            item.useAnimation = 3;
            item.reuseDelay = 15;
            item.useStyle = 3;
            item.knockBack = 7;
            item.value = Item.buyPrice(0, 1, 0, 0);
            item.rare = 7;
            item.UseSound = SoundID.Item1;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.CrystalBlock, 100);
            recipe.AddIngredient(ItemID.RainbowBrick, 100);
            recipe.AddIngredient(ItemID.BrokenHeroSword, 2);
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}