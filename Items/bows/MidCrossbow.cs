using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace AllOurSpiritMod.Items.bows
{
    public class MidCrossbow : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Medium-Quality Crossbow");
            Tooltip.SetDefault("I think I can kill some bosses with this weapon...");

            //Traducciones - translates

            DisplayName.AddTranslation(GameCulture.Spanish, "Ballesta de mediana calidad");  //Español - Spanish
            Tooltip.AddTranslation(GameCulture.Spanish, "Creo que puedo matar algunos jefes con esta arma ...");      //Español - Spanish
        }

        public override void SetDefaults()
        {
            item.damage = 50;
            item.noMelee = true;
            item.ranged = true;
            item.width = 50;
            item.height = 17;
            item.useTime = 30;
            item.useAnimation = 30;
            item.useStyle = 5;
            item.shoot = 3;
            item.useAmmo = AmmoID.Arrow;
            item.knockBack = 1;
            item.value = 15000000;
            item.rare = 7;
            item.UseSound = SoundID.Item5;
            item.autoReuse = true;
            item.shootSpeed = 10f;

        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DirtBlock, 10);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}