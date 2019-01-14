
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace AllOurSpiritMod.Items.pickaxes
{
    public class MiniuxPickaxe : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Miniux Pickaxe");
            Tooltip.SetDefault("[c/9c27b0:Y][c/3f51b5:E][c/4caf50:II][c/aa00ff:II][c/#9fa8da:!!]");

            //Traducciones - translates

            DisplayName.AddTranslation(GameCulture.Spanish, "Pico de Miniux");    //Español - Spanish
            Tooltip.AddTranslation(GameCulture.Spanish, "[c/9c27b0:Y][c/3f51b5:E][c/4caf50:II][c/aa00ff:II][c/#9fa8da:!!]");        //Español - Spanish
        }

        public override void SetDefaults()
        {
            item.damage = 777;
            item.melee = true;
            item.width = 128;
            item.height = 128;
            item.pick = 650;
            item.useTime = 3;
            item.useAnimation = 3;
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