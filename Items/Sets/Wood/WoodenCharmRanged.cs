using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace UV.Items.Sets.Wood
{
	public class WoodenCharmRanged : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Charm that enhances Ranged combat" + "\n1% increased ranged damage" + "\n1% increased ranged critical strike chance" + "\n1% increased movement speed");
			DisplayName.SetDefault("Wooden Bow Charm");
		}

		public override void SetDefaults()
		{
			item.width = 14;
			item.height = 26;
			item.value = 10000;
			item.rare = 0;
			item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
				player.rangedDamage += 0.01f;
				player.rangedCrit += 1;
				player.moveSpeed += 0.01f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Wood, 10);
			recipe.AddIngredient(ItemID.FallenStar);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}