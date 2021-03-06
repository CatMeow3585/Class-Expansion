using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace UV.Items.Sets.Wood
{
	public class WoodenCharmMelee : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Charm that enhances Melee combat" + "\n2 Defense" + "\n1% increased melee damage" + "\n1% increased melee critical hit chance" + "\n1% increased melee speed" + "\nIncreased Melee Knockback");
			DisplayName.SetDefault("Wooden Sword Charm");
		}

		public override void SetDefaults()
		{
			item.width = 24;
			item.height = 24;
			item.value = 10000;
			item.rare = 0;
			item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
				player.statDefense += 2;
				player.meleeDamage += 0.01f;
				player.meleeSpeed += 0.01f;
				player.meleeCrit += 1;
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