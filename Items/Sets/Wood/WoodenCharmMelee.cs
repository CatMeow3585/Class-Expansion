using Terraria;
using Terraria.ModLoader;

namespace UV.Items.Sets.Wood
{
	[AutoloadEquip(EquipType.Shield)]
	public class WoodenCharmMelee : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Charm that enhances Melee combat" + "\n+2 Defense" + "\n1% increased melee Damage, Critical Chance and Speed" + "\nIncreased Melee Knockback")
		}

		public override void SetDefaults()
		{
			item.width = 24;
			item.height = 24;
			item.value = 10000;
			item.rare = 1;
			item.accessory = true;
			item.defense = 2;
			item.crit = 4;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
				player.statDefense = 2f;
				player.meleeDamage = 0.1f;
				player.meleeSpeed = 0.1f;
				player.meleeCrit = 0.1f
				player.kbGlove = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "EquipMaterial", 60);
			recipe.AddTile(null, "ExampleWorkbench");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}