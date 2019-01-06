using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace TheSixthMod.Items.bows
{
    public class ModBow : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("ModBow");
            Tooltip.SetDefault("ModBow");

            //Traducciones - translates

            DisplayName.AddTranslation(GameCulture.Spanish, "ModBow");  //Español - Spanish
            Tooltip.AddTranslation(GameCulture.Spanish, "ModBow");      //Español - Spanish
        }

        public override void SetDefaults()
        {
            item.damage = 50;
            item.noMelee = true;
            item.ranged = true;
            item.width = 65;
            item.height = 275;
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