using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace UV.Items.Sets.Wood
{
	public class WoodenBoomerangThrown : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Wooden Boomerang");
		}

		public override void SetDefaults()
		{
			item.CloneDefaults(ItemID.WoodenBoomerang);
			item.melee = false;
			item.thrown = true;
			item.damage = 8;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Wood, 10);
			recipe.AddIngredient(ItemID.StoneBlock, 2);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.WoodenBoomerang);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "WoodenBoomerangThrown");
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(ItemID.WoodenBoomerang);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Wood, 10);
			recipe.AddIngredient(ItemID.StoneBlock, 2);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.WoodenBoomerang);
			recipe.AddRecipe();
		}
	}
}