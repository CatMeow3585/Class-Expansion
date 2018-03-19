using Terraria.ID;
using Terraria.ModLoader;

namespace UV.Items.Sets.Ninja
{
	public class SilentSilk : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Silent Silk");
			Tooltip.SetDefault("Black woven silk, silent in movement.");
		}

		public override void SetDefaults()
		{
			item.width = 13;
			item.height = 14;
			item.maxStack = 999;
			item.value = 100;
			item.rare = 2;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SilverBar, 5);
			recipe.AddIngredient(null, "SilentSilk", 15);	
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.NinjaHood);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SilverBar, 15);
			recipe.AddIngredient(null, "SilentSilk", 25);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.NinjaShirt);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SilverBar, 10);
			recipe.AddIngredient(null, "SilentSilk", 20);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.NinjaPants);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.TungstenBar, 5);
			recipe.AddIngredient(null, "SilentSilk", 15);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.NinjaHood);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.TungstenBar, 15);
			recipe.AddIngredient(null, "SilentSilk", 25);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.NinjaShirt);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.TungstenBar, 10);
			recipe.AddIngredient(null, "SilentSilk", 20);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.NinjaPants);
			recipe.AddRecipe();
		}
		
	}
}
