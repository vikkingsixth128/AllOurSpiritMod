
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace AllOurSpiritMod.Items.swords
{
    public class Shifty : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("The Sifty");
            Tooltip.SetDefault("What the hell?!" + "\nLegendary Weapon!");

            //Traducciones - translates

            DisplayName.AddTranslation(GameCulture.Spanish, "Shifty");    //Español - Spanish
            Tooltip.AddTranslation(GameCulture.Spanish, "¡¿Qué demonios?!" + "\n¡Arma Legendaria!");        //Español - Spanish
        }

        public override void SetDefaults()
        {
            item.damage = 45;
            item.melee = true;
            item.width = 32;
            item.height = 32;
            item.useTime = 10;
            item.useAnimation = 10;
            item.useStyle = 1;
            item.knockBack = 7;
            item.value = Item.buyPrice(0, 10, 0, 0);
            item.rare = 3;
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