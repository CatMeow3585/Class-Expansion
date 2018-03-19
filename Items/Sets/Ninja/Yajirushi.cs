using Terraria.ID;
using Terraria.ModLoader;

namespace UV.Items.Sets.Ninja
{
	public class Yajirushi : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("The silky fletching makes it go faster than average");
		}

		public override void SetDefaults()
		{
			item.damage = 9;
			item.ranged = true;
			item.width = 14;
			item.height = 32;
			item.maxStack = 999;
			item.consumable = true;             
			item.knockBack = 1.5f;
			item.value = 10;
			item.rare = 2;
			item.shoot = mod.ProjectileType("YajirushiProjectile");  
			item.shootSpeed = 16f;                  
			item.ammo = AmmoID.Arrow;             
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.WoodenArrow, 111);
			recipe.AddIngredient(null, "SilentSilk");
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this, 111);
			recipe.AddRecipe();
		}
	}
}
