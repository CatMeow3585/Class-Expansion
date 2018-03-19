using Terraria.ID;
using Terraria.ModLoader;

namespace UV.Items.Sets.Ninja
{
	public class Tanto : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Tanto");
		}
		public override void SetDefaults()
		{
			item.damage = 10;
			item.melee = true;
			item.width = 28;
			item.height = 30;
			item.useTime = 13;
			item.useAnimation = 12;
			item.useStyle = 3;
			item.knockBack = 4;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.useTurn = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.IronBar, 4);
			recipe.anyIronBar = true;
			recipe.AddIngredient(null, "SilentSilk",1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

	}
}
