using Terraria.ID;
using Terraria.ModLoader;

namespace UV.Items.Sets.Ninja
{
	public class Katana : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Katana");
		}
		public override void SetDefaults()
		{
			item.damage = 13;
			item.melee = true;
			item.width = 44;
			item.height = 46;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 4;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = false;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.IronBar, 8);
			recipe.anyIronBar = true;
			recipe.AddIngredient(null, "SilentSilk",1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

	}
}
