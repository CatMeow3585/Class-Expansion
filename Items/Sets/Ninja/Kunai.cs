using UV.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace UV.Items.Sets.Ninja
{
	public class Kunai : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Kunai");
			Tooltip.SetDefault("These don´t break!");
		}

		public override void SetDefaults()
		{
			// Alter any of these values as you see fit, but you should probably keep useStyle on 1, as well as the noUseGraphic and noMelee bools
			item.shootSpeed = 10f;
			item.damage = 11;
			item.knockBack = 5f;
			item.useStyle = 1;
			item.useAnimation = 25;
			item.useTime = 25;
			item.width = 20;
			item.height = 56;
			item.maxStack = 999;
			item.rare = 2;
			item.ammo = 949;
			item.notAmmo = true;

			item.consumable = true;
			item.noUseGraphic = true;
			item.noMelee = true;
			item.autoReuse = true;
			item.thrown = true;

			item.UseSound = SoundID.Item1;
			item.value = Item.sellPrice(silver: 5);
			item.shoot = mod.ProjectileType<KunaiProjectile>();
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.IronBar, 1);
			recipe.anyIronBar = true;
			recipe.AddIngredient(null, "SilentSilk",1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this, 37);
			recipe.AddRecipe();
		}

	}
}
