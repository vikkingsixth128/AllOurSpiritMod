using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace AllOurSpiritMod.Items.swords
{
	public class Lightness : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Lightness");
			Tooltip.SetDefault("[c/:808080:The Light and the Dark], the [c/FFCD78:Hallow] and the [c/8400CC:Corruption], all in a sword");

            //Traducciones - Translates

            DisplayName.AddTranslation(GameCulture.Spanish, "Claridad");    //Español - Spanish
            Tooltip.AddTranslation(GameCulture.Spanish, "[c/808080:La luz y la oscuridad], la [c/FFCD78:bendición] y la [c/8400CC:corrupción], todo eso en una espada");  //Español - Spanish

        }
		public override void SetDefaults()
		{
			item.damage = 230;
			item.melee = true;
			item.width = 128;
			item.height = 117;
			item.useTime = 2;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 8f;
			item.value = 10000;
			item.rare = 7;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.ChlorophyteBar, 25);
            recipe.AddIngredient(ItemID.TrueExcalibur);
            recipe.AddIngredient(ItemID.TrueNightsEdge);
            recipe.AddIngredient(ItemID.DarkShard, 10);
            recipe.AddIngredient(ItemID.LightShard, 10);
            recipe.AddIngredient(ItemID.SoulofLight,15);
            recipe.AddIngredient(ItemID.SoulofNight, 15);
            recipe.AddRecipeGroup("AllOurSpiritMod:EvilSouls", 15);
			recipe.AddTile(TileID.DemonAltar);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

        public override bool CanHitPvp(Player player, Player target)
        {
            target.AddBuff(BuffID.Cursed, 200);
            target.AddBuff(BuffID.Electrified, 200);
            return true;
        }

    }
}
