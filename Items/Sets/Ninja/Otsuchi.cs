using Terraria.ID;
using Terraria.ModLoader;

namespace UV.Items.Sets.Ninja
{
	public class Otsuchi : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Otsuchi");
		}
		public override void SetDefaults()
		{
			item.damage = 18;
			item.melee = true;
			item.width = 54;
			item.height = 54;
			item.useTime = 33;
			item.useAnimation = 33;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.hammer = 40;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.IronBar, 2);
			recipe.anyIronBar = true;
			recipe.AddIngredient(ItemID.DynastyWood, 4);
			recipe.AddIngredient(null, "SilentSilk",2);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();

		}

	}
}
