using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace TheSixthMod.Items.bows
{
    public class AquaniumBow : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Aquanium Bow");
            Tooltip.SetDefault("From the depths of the ocean, these bow are the fastest of these universe");

            //Traducciones - translates

            DisplayName.AddTranslation(GameCulture.Spanish, "Arco de Aquanio");                                                             //Español - Spanish
            Tooltip.AddTranslation(GameCulture.Spanish, "Desde las profundidades del océano, este arco es el más rápido de este universo"); //Español - Spanish
        }

        public override void SetDefaults()
        {
            item.damage = 150;
            item.noMelee = true;
            item.ranged = true;
            item.width = 23;
            item.height = 54;
            item.useTime = 10;
            item.useAnimation = 30;
            item.useStyle = 5;
            item.shoot = 3;
            item.useAmmo = AmmoID.Arrow;
            item.knockBack = 1f;
            item.value = 15000000;
            item.rare = 10;
            item.UseSound = SoundID.Item5;
            item.autoReuse = true;
            item.shootSpeed = 10f;

        }
        
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}