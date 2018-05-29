using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace FidgetSpinners.Items.Weapons
{
    public class FierySpinner : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Fiery Spinner");
            Tooltip.SetDefault("Spin with the power of hell!");
        }
        public override void SetDefaults()
        {
            item.damage = 30;
            item.melee = true;
            item.scale = 1.25f;
            item.width = 30;
            item.height = 30;
            item.useTime = 25;
            item.useAnimation = 25;
            item.noUseGraphic = true;
            item.useStyle = 1;
            item.knockBack = 3;
            item.value = 8;
            item.rare = 6;
            item.shootSpeed = 8f;
            item.shoot = mod.ProjectileType("FierySpinnerProjectile");
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            item.maxStack = 1;
        }
        public override bool CanUseItem(Player player)
        {
            for (int i = 0; i < 1000; ++i)
            {
                if (Main.projectile[i].active && Main.projectile[i].owner == Main.myPlayer && Main.projectile[i].type == item.shoot)
                {
                    return false;
                }
            }
            return true;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.HellstoneBar, 15);
            recipe.AddTile(TileID.Hellforge);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}