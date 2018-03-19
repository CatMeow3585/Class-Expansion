using System.Collections.Generic;
using UV.Items.Sets.Ninja;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace UV.Projectiles
{
	public class ShurikenProjectile : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("ShurikenProjectile");
		}

		public override void SetDefaults()
		{
			projectile.width = 30;
			projectile.height = 30;
			projectile.aiStyle = 2;
			projectile.friendly = true;
			projectile.melee = true;
			projectile.penetrate = 3;
			projectile.alpha = 0;
		}
	
        public override bool TileCollideStyle(ref int width, ref int height, ref bool fallThrough)
        {
            width = 30 ; height = 30;
            return true;
        }

		 public override bool? Colliding(Rectangle projHitbox, Rectangle targetHitbox)
        {
            if (targetHitbox.Width > 8 && targetHitbox.Height > 8)
            {
                targetHitbox.Inflate(-targetHitbox.Width / 8, -targetHitbox.Height / 8);
            }
            return projHitbox.Intersects(targetHitbox);
        }

        public override void Kill(int timeLeft)
        {
            Main.PlaySound(0, (int)projectile.position.X, (int)projectile.position.Y);
            if (Main.rand.Next(0) == (0))
            {
                Item.NewItem((int)projectile.position.X, (int)projectile.position.Y, projectile.width, projectile.height, mod.ItemType<Items.Sets.Ninja.Shuriken>());
            }

        }
	}
}
