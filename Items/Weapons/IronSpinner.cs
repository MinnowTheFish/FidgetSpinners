﻿using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace FidgetSpinners.Items.Weapons
{
    public class IronSpinner : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Iron Spinner");
            Tooltip.SetDefault("Spin with an iron fist! OUCH!");
        }
        public override void SetDefaults()
        {
            item.damage = 11;
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
            item.shoot = mod.ProjectileType("IronSpinnerProjectile");
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
            recipe.AddIngredient(ItemID.IronBar, 15);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}