
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace AllOurSpiritMod.Items.swords
{
    public class Heavenly : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Heavenly");
            Tooltip.SetDefault("A word-game between heaven and heavy" + "\nLegendary Wapon!");

            Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(5, 6));//Para animar un objeto, poner esto
            //Traducciones - translates

            DisplayName.AddTranslation(GameCulture.Spanish, "Cielote");    //Español - Spanish
            Tooltip.AddTranslation(GameCulture.Spanish, "Creo que es cielo anda un poco pesado hoy..." + "\n¡Arma legendaria!");        //Español - Spanish
        }

        public override void SetDefaults()
        {
            item.damage = 33;
            item.melee = true;
            item.width = 24;
            item.height = 24;
            item.useTime = 15;
            item.useAnimation = 15;
            item.useStyle = 1;
            item.knockBack = 7;
            item.value = 7;
            item.rare = 7;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DirtBlock, 10);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}