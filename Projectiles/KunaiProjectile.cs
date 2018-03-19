using System.Collections.Generic;
using UV.Items.Sets.Ninja;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace UV.Projectiles
{
	public class KunaiProjectile : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("KunaiProjectile");
		}

		public override void SetDefaults()
		{
			projectile.width = 10;
			projectile.height = 28;
			projectile.aiStyle = 2;
			projectile.friendly = true;
			projectile.melee = true;
			projectile.penetrate = 3;
			projectile.alpha = 0;
		}

        public override bool TileCollideStyle(ref int width, ref int height, ref bool fallThrough)
        {
            width = 10 ; height = 28;
            return true;
        }

        public override void Kill(int timeLeft)
        {
            Main.PlaySound(0, (int)projectile.position.X, (int)projectile.position.Y);
            if (Main.rand.Next(0) == (0))
            {
				Item.NewItem((int)projectile.position.X, (int)projectile.position.Y, projectile.width, projectile.height, mod.ItemType<Items.Sets.Ninja.Kunai>());
            }

        }
	}
}
