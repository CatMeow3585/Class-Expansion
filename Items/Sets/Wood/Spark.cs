using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace UV.Items.Sets.Wood
{
	public class Spark : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Spark");
		}

		public override void SetDefaults()
		{
			item.CloneDefaults(ItemID.WandofSparking);
			item.useStyle = 5;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SpellTome);
			recipe.AddIngredient(ItemID.Torch, 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Wood, 10);
			recipe.AddIngredient(ItemID.FallenStar, 20);
			recipe.AddIngredient(ItemID.Torch, 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(ItemID.WandofSparking);
			recipe.AddRecipe();
		}
	}
}