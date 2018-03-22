using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace UV.Items.Sets.Wood
{
	public class WoodenCharmThrown : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Charm that enhances Throwing combat" + "\n1% increased throwing damage" + "\n1% increased throwing critical hit chance" + "\n1% increased throwing velocity");
			DisplayName.SetDefault("Wooden Shuriken Charm");
		}

		public override void SetDefaults()
		{
			item.width = 22;
			item.height = 22;
			item.value = 10000;
			item.rare = 0;
			item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
				player.thrownDamage += 0.2f;
				player.thrownVelocity += 0.01f;
				player.thrownCrit += 1;
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