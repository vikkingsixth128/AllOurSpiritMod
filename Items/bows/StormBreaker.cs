using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace TheSixthMod.Items.bows
{
    public class StormBreaker : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Stormbreaker");
            Tooltip.SetDefault("The rain and the thunder are the power-source of this bow");

            //Traducciones - translates

            DisplayName.AddTranslation(GameCulture.Spanish, "Rompetormentas");                                          //Español - Spanish
            Tooltip.AddTranslation(GameCulture.Spanish, "La lluvia y el trueno son la fuente de poder de este arco");   //Español - Spanish
        }

        public override void SetDefaults()
        {
            item.damage = 700;
            item.noMelee = true;
            item.expertOnly = true;
            item.ranged = true;
            item.width = 26;
            item.height = 54;
            item.useTime = 6;
            item.useAnimation = 30;
            item.useStyle = 5;
            item.shoot = 3;
            item.useAmmo = AmmoID.Arrow;
            item.knockBack = 1;
            item.value = 15000000;
            item.rare = 11;
            item.UseSound = SoundID.Item5;
            item.autoReuse = true;
            item.shootSpeed = 7f;

        }

    }
}