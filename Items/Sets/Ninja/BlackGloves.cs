using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace UV.Items.Sets.Ninja
{
	public class BlackGloves : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Black Gloves");
			Tooltip.SetDefault("For throwing Shurikens and Kunais.");
		}

		public override void SetDefaults()
		{
			item.damage = 11;
			item.thrown = true;
			item.width = 20;
			item.height = 54;
			item.useTime = 27;
			item.useAnimation = 27;
			item.useStyle = 1;
			item.noMelee = true;
			item.knockBack = 4;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shoot = 10;
			item.shootSpeed = 6.6f;
			item.useAmmo = 949;
			item.noUseGraphic = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "SilentSilk",2);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}