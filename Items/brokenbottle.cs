using Terraria.ID;
using Terraria.ModLoader;

namespace RussianMod.Items
{
	public class brokenbottle : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Разбитая бутылка");
			Tooltip.SetDefault("Эй, будь аккуратнее, она же острая!");
		}

		public override void SetDefaults() 
		{
			item.melee = true;
			item.damage = 1;
			item.width = 40;
			item.height = 40;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 3;
			item.maxStack = 1;
			item.value = 10;
			item.rare = -1;
			item.autoReuse = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(31, 1); // 31 - бутылка   1 - кол-во
			recipe.AddTile(18); // 18 - верстак
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}