using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace UV.Items.Sets.Wood
{
	public class WoodenBoomerang : GlobalItem
	{
		public override void AddRecipes()
		{
			if (item.type == ItemID.WoodenBoomerang)
			{
				ModRecipe recipe = new ModRecipe(mod);
				recipe.AddIngredient(ItemID.Wood, 10);
				recipe.AddIngredient(ItemID.StoneBlock, 2)
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(this);
				recipe.AddRecipe();

				recipe = new ModRecipe(mod);
				recipe.AddIngredient(null, "WoodenBoomerangThrown");
				recipe.AddTile(TileID.WorkBenches);
				recipe.SetResult(this);
				recipe.AddRecipe();
			}
		}
	}
}