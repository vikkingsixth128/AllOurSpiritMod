using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace AllOurSpiritMod.Items.swords
{
    public class ObsidianKhalis : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Obsidian Arkhalis");
            Tooltip.SetDefault("Quick as the Arkhalis, but with a deadly edge.");

            //Traducciones - translates

            DisplayName.AddTranslation(GameCulture.Spanish, "Arkhalis de Obsidiana");    //Español - Spanish
            Tooltip.AddTranslation(GameCulture.Spanish, "Rápida como la Arkhalis, pero con un filo mortal.");        //Español - Spanish
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.Arkhalis);
            item.damage = 50;
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