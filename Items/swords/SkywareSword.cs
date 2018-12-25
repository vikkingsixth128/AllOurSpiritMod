using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace AllOurSpiritMod.Items.swords
{
    public class SkywareSword : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Skyware Sword");
            Tooltip.SetDefault("Auch! Apparently, it transmits [c/4f9da6:electr][c/f9ff21:icity]");

            //Traducciones - translates

            DisplayName.AddTranslation(GameCulture.Spanish, "Espada soleada");    //Español - Spanish
            Tooltip.AddTranslation(GameCulture.Spanish, "¡Ah! Al parecer, transmite [c/4f9da6:electri][c/f9ff21:cidad]");        //Español - Spanish
        }

        public override void SetDefaults()
        {
            item.damage = 40;
            item.melee = true;
            item.width = 64;
            item.height = 64;
            item.useTime = 3;
            item.useAnimation = 20;
            item.useStyle = 1;
            item.knockBack = 7f;
            item.value = 7;
            item.rare = 2;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.MagicMissile);
            recipe.AddIngredient(ItemID.SunplateBlock, 50);
            recipe.AddIngredient(ItemID.Star, 100);
            recipe.AddIngredient(ItemID.EnchantedSword);
            recipe.AddIngredient(ItemID.Cloud, 60);
            recipe.AddTile(TileID.SkyMill);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

        public override bool CanHitPvp(Player player, Player target)
        {
            target.AddBuff(BuffID.Electrified, 100);
            return base.CanHitPvp(player, target);
        }
    }
}