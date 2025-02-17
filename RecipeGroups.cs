using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using TheDepths.Items.Accessories;
using TheDepths.Items.Placeable;
using TheDepths.Items.Weapons;

namespace TheDepths
{
    internal class RecipeGroups : ModSystem
    {
        public static RecipeGroup HellstoneBarRecipeGroup;
        public static RecipeGroup HellstoneRecipeGroup;
        public static RecipeGroup ObsidianRecipeGroup;
        public static RecipeGroup AnkhShieldRecipeGroup;
        public static RecipeGroup FireGauntletRecipeGroup;
        public static RecipeGroup AshBlockRecipeGroup;
        public static RecipeGroup AshwoodRecipeGroup;
        public static RecipeGroup FireblossomRecipeGroup;
        public static RecipeGroup ObsidifishRecipeGroup;
        public static RecipeGroup FlarefinKoiRecipeGroup;
        public static RecipeGroup PwnhammerRecipeGroup;
        public static RecipeGroup FireblossomSeedsRecipeGroup;
        public static RecipeGroup HellforgeRecipeGroup;
        public static RecipeGroup LivingFireBlockRecipeGroup;
        public static RecipeGroup CobaltShieldRecipeGroup;
		public static RecipeGroup CascadeRecipeGroup;
        public static RecipeGroup TreasureMagnetGroup;

		public override void Unload()
        {
            HellstoneBarRecipeGroup = null;
            HellstoneRecipeGroup = null;
            ObsidianRecipeGroup = null;
            AnkhShieldRecipeGroup = null;
            FireGauntletRecipeGroup = null;
            AshBlockRecipeGroup = null;
            AshwoodRecipeGroup = null;
            FireblossomRecipeGroup = null;
            ObsidifishRecipeGroup = null;
            FlarefinKoiRecipeGroup = null;
            PwnhammerRecipeGroup = null;
            FireblossomSeedsRecipeGroup = null;
            HellforgeRecipeGroup = null;
            LivingFireBlockRecipeGroup = null;
            CobaltShieldRecipeGroup = null;
            CascadeRecipeGroup = null;
            TreasureMagnetGroup = null;
        }

        public override void AddRecipes()
        {
            Recipe recipe = Recipe.Create(ItemID.TerrasparkBoots);
                recipe.AddIngredient(ItemID.FrostsparkBoots)
                .AddIngredient(ModContent.ItemType<SilverSlippers>())
                .AddTile(TileID.TinkerersWorkbench)
                .Register();
            Recipe recipe2 = Recipe.Create(ItemID.LogicSensor_Liquid);
                recipe2.AddIngredient(ItemID.Cog, 5)
                .AddIngredient(ItemID.MagicWaterDropper)
                .AddIngredient(ModContent.ItemType<MagicQuicksilverDropper>())
                .AddIngredient(ItemID.MagicHoneyDropper)
                .AddIngredient(ItemID.Wire)
                .AddTile(TileID.MythrilAnvil)
                .Register();
            Recipe recipe3 = Recipe.Create(ItemID.DryBomb);
                recipe3.AddIngredient(ModContent.ItemType<Items.Weapons.QuicksilverBomb>())
                .Register();
            Recipe recipe4 = Recipe.Create(ItemID.DryRocket);
                recipe4.AddIngredient(ModContent.ItemType<Items.Weapons.QuicksilverRocket>())
                .Register();
            Recipe recipe5 = Recipe.Create(ItemID.SeafoodDinner);
                recipe5.AddIngredient(ModContent.ItemType<Items.ShadowFightingFish>(), 2)
                .AddTile(TileID.CookingPots)
                .Register();
            Recipe recipe6 = Recipe.Create(ItemID.SeafoodDinner);
                recipe6.AddIngredient(ModContent.ItemType<Items.QuartzFeeder>(), 2)
                .AddTile(TileID.CookingPots)
                .Register();
            Recipe recipe8 = Recipe.Create(ItemID.NightsEdge);
                recipe8.AddIngredient(ItemID.LightsBane)
                .AddIngredient(ItemID.Muramasa)
                .AddIngredient(ItemID.BladeofGrass)
                .AddIngredient(ModContent.ItemType<Items.Weapons.Terminex>())
                .AddTile(TileID.DemonAltar)
                .Register();
            Recipe recipe9 = Recipe.Create(ItemID.NightsEdge);
                recipe9.AddIngredient(ItemID.BloodButcherer)
                .AddIngredient(ItemID.Muramasa)
                .AddIngredient(ItemID.BladeofGrass)
                .AddIngredient(ModContent.ItemType<Items.Weapons.Terminex>())
                .AddTile(TileID.DemonAltar)
                .Register();
            Recipe recipe18 = Recipe.Create(ItemID.ShellphoneDummy);
                recipe18.AddIngredient(ItemID.CellPhone)
                .AddIngredient(ItemID.MagicConch)
                .AddIngredient(ModContent.ItemType<Items.ShalestoneConch>())
                .AddTile(TileID.TinkerersWorkbench)
                .Register();
			Recipe recipe7 = Recipe.Create(ItemID.FishingPotion);
			    recipe7.AddIngredient(ItemID.BottledWater)
			    .AddIngredient(ModContent.ItemType<Items.Placeable.GlitterBlock>())
			    .AddIngredient(ItemID.Waterleaf)
			    .AddTile(TileID.Bottles)
			    .Register();
		}

        public override void AddRecipeGroups()
        {
            RecipeGroup.recipeGroups[RecipeGroupID.Wood].ValidItems.Add(ModContent.ItemType<Items.Placeable.NightWood>());
            RecipeGroup.recipeGroups[RecipeGroupID.Fruit].ValidItems.Add(ModContent.ItemType<Items.Ciamito>());
            RecipeGroup.recipeGroups[RecipeGroupID.Fruit].ValidItems.Add(ModContent.ItemType<Items.BlackOlive>());

            HellstoneBarRecipeGroup = new RecipeGroup(() => $"{Language.GetTextValue("LegacyMisc.37")} {Lang.GetItemNameValue(ItemID.HellstoneBar)}", ItemID.HellstoneBar, ModContent.ItemType<Items.Placeable.ArqueriteBar>());
            RecipeGroup.RegisterGroup("HellstoneBar", HellstoneBarRecipeGroup);
            HellstoneRecipeGroup = new RecipeGroup(() => $"{Language.GetTextValue("LegacyMisc.37")} {Lang.GetItemNameValue(ItemID.Hellstone)}", ItemID.Hellstone, ModContent.ItemType<Items.Placeable.ArqueriteOre>());
            RecipeGroup.RegisterGroup("Hellstone", HellstoneRecipeGroup);
            ObsidianRecipeGroup = new RecipeGroup(() => $"{Language.GetTextValue("LegacyMisc.37")} {Lang.GetItemNameValue(ItemID.Obsidian)}", ItemID.Obsidian, ModContent.ItemType<Items.Placeable.Quartz>());
            RecipeGroup.RegisterGroup("Obsidian", ObsidianRecipeGroup);
            AnkhShieldRecipeGroup = new RecipeGroup(() => $"{Language.GetTextValue("LegacyMisc.37")} {Lang.GetItemNameValue(ItemID.AnkhShield)}", ItemID.AnkhShield, ModContent.ItemType<Items.Accessories.SanctusShield>());
            RecipeGroup.RegisterGroup("AnkhShield", AnkhShieldRecipeGroup);
            FireGauntletRecipeGroup = new RecipeGroup(() => $"{Language.GetTextValue("LegacyMisc.37")} {Lang.GetItemNameValue(ItemID.FireGauntlet)}", ItemID.FireGauntlet, ModContent.ItemType<Items.Accessories.AquaGlove>());
            RecipeGroup.RegisterGroup("FireGauntlet", FireGauntletRecipeGroup);
            AshBlockRecipeGroup = new RecipeGroup(() => $"{Language.GetTextValue("LegacyMisc.37")} {Lang.GetItemNameValue(ItemID.AshBlock)}", ItemID.AshBlock, ModContent.ItemType<Items.Placeable.ShaleBlock>(), ModContent.ItemType<Items.Placeable.Shalestone>());
            RecipeGroup.RegisterGroup("AshBlock", AshBlockRecipeGroup);
            AshwoodRecipeGroup = new RecipeGroup(() => $"{Language.GetTextValue("LegacyMisc.37")} {Lang.GetItemNameValue(ItemID.AshWood)}", ItemID.AshWood, ModContent.ItemType<Items.Placeable.NightWood>());
            RecipeGroup.RegisterGroup("AshWood", AshwoodRecipeGroup);
            FireblossomRecipeGroup = new RecipeGroup(() => $"{Language.GetTextValue("LegacyMisc.37")} {Lang.GetItemNameValue(ItemID.Fireblossom)}", ItemID.Fireblossom, ModContent.ItemType<Items.ShadowShrub>());
            RecipeGroup.RegisterGroup("Fireblossom", FireblossomRecipeGroup);
            ObsidifishRecipeGroup = new RecipeGroup(() => $"{Language.GetTextValue("LegacyMisc.37")} {Lang.GetItemNameValue(ItemID.Obsidifish)}", ItemID.Obsidifish, ModContent.ItemType<Items.QuartzFeeder>());
            RecipeGroup.RegisterGroup("Obsidifish", ObsidifishRecipeGroup);
            FlarefinKoiRecipeGroup = new RecipeGroup(() => $"{Language.GetTextValue("LegacyMisc.37")} {Lang.GetItemNameValue(ItemID.FlarefinKoi)}", ItemID.FlarefinKoi, ModContent.ItemType<Items.ShadowFightingFish>());
            RecipeGroup.RegisterGroup("FlarefinKoi", FlarefinKoiRecipeGroup);
            PwnhammerRecipeGroup = new RecipeGroup(() => $"{Language.GetTextValue("LegacyMisc.37")} {Lang.GetItemNameValue(ItemID.Pwnhammer)}", ItemID.Pwnhammer, ModContent.ItemType<Items.Weapons.POWHammer>());
            RecipeGroup.RegisterGroup("Pwnhammer", PwnhammerRecipeGroup);
            FireblossomSeedsRecipeGroup = new RecipeGroup(() => $"{Language.GetTextValue("LegacyMisc.37")} {Lang.GetItemNameValue(ItemID.FireblossomSeeds)}", ItemID.FireblossomSeeds, ModContent.ItemType<Items.Placeable.ShadowShrubSeeds>());
            RecipeGroup.RegisterGroup("FireblossomSeeds", FireblossomSeedsRecipeGroup);
            HellforgeRecipeGroup = new RecipeGroup(() => $"{Language.GetTextValue("LegacyMisc.37")} {Lang.GetItemNameValue(ItemID.Hellforge)}", ItemID.Hellforge, ModContent.ItemType<Items.Placeable.Gemforge>());
            RecipeGroup.RegisterGroup("Hellforge", HellforgeRecipeGroup);
            LivingFireBlockRecipeGroup = new RecipeGroup(() => $"{Language.GetTextValue("LegacyMisc.37")} {Lang.GetItemNameValue(ItemID.LivingFireBlock)}", ItemID.LivingFireBlock, ModContent.ItemType<Items.Placeable.LivingFog>());
            RecipeGroup.RegisterGroup("LivingFireBlock", LivingFireBlockRecipeGroup);
            CobaltShieldRecipeGroup = new RecipeGroup(() => $"{Language.GetTextValue("LegacyMisc.37")} {Lang.GetItemNameValue(ItemID.CobaltShield)}", ItemID.CobaltShield, ModContent.ItemType<PalladiumShield>());
            RecipeGroup.RegisterGroup("CobaltShield", CobaltShieldRecipeGroup);
			CascadeRecipeGroup = new RecipeGroup(() => $"{Language.GetTextValue("LegacyMisc.37")} {Lang.GetItemNameValue(ItemID.Cascade)}", ItemID.Cascade, ModContent.ItemType<Skyfall>());
			RecipeGroup.RegisterGroup("Cascade", CascadeRecipeGroup);
            TreasureMagnetGroup = new RecipeGroup(() => $"{Language.GetTextValue("LegacyMisc.37")} {Lang.GetItemNameValue(ItemID.TreasureMagnet)}", ItemID.TreasureMagnet, ModContent.ItemType<LodeStone>());
			RecipeGroup.RegisterGroup("TreasureMagnet", TreasureMagnetGroup);
		}

        public override void PostAddRecipes()
        {
            for (int i = 0; i < Recipe.numRecipes; i++)
            {
                Recipe recipe = Main.recipe[i];
                if (recipe.TryGetIngredient(ItemID.HellstoneBar, out var HB) && !TheDepthsIDs.Sets.RecipeBlacklist.HellstoneBarOnlyItem[recipe.createItem.type])
                {
                    recipe.AddRecipeGroup("HellstoneBar", HB.stack);
                    recipe.RemoveIngredient(HB);
                }
                if (recipe.TryGetIngredient(ItemID.Hellstone, out var Hellstone) && !TheDepthsIDs.Sets.RecipeBlacklist.HellstoneOnlyItem[recipe.createItem.type])
                {
                    recipe.AddRecipeGroup("Hellstone", Hellstone.stack);
                    recipe.RemoveIngredient(Hellstone);
                }
                if (recipe.TryGetIngredient(ItemID.Obsidian, out var Obsidian) && !TheDepthsIDs.Sets.RecipeBlacklist.ObsidianOnlyItem[recipe.createItem.type])
                {
                    recipe.AddRecipeGroup("Obsidian", Obsidian.stack);
                    recipe.RemoveIngredient(Obsidian);
                }
                if (recipe.TryGetIngredient(ItemID.AnkhShield, out var AS) && !TheDepthsIDs.Sets.RecipeBlacklist.AnkhShieldOnlyItem[recipe.createItem.type])
                {
                    recipe.AddRecipeGroup("AnkhShield", AS.stack);
                    recipe.RemoveIngredient(AS);
                }
                if (recipe.TryGetIngredient(ItemID.FireGauntlet, out var FG) && !TheDepthsIDs.Sets.RecipeBlacklist.FireGauntletOnlyItem[recipe.createItem.type])
                {
                    recipe.AddRecipeGroup("FireGauntlet", FG.stack);
                    recipe.RemoveIngredient(FG);
                }
                if (recipe.TryGetIngredient(ItemID.AshBlock, out var AB) && !TheDepthsIDs.Sets.RecipeBlacklist.AshBlockOnlyItem[recipe.createItem.type])
                {
                    recipe.AddRecipeGroup("AshBlock", AB.stack);
                    recipe.RemoveIngredient(AB);
                }
                if (recipe.TryGetIngredient(ItemID.AshWood, out var AW) && !TheDepthsIDs.Sets.RecipeBlacklist.AshWoodOnlyItem[recipe.createItem.type])
                {
                    recipe.AddRecipeGroup("AshWood", AW.stack);
                    recipe.RemoveIngredient(AW);
                }
                if (recipe.TryGetIngredient(ItemID.Fireblossom, out var Fireblossom) && !TheDepthsIDs.Sets.RecipeBlacklist.FireblossomOnlyItem[recipe.createItem.type])
                {
                    recipe.AddRecipeGroup("Fireblossom", Fireblossom.stack);
                    recipe.RemoveIngredient(Fireblossom);
                }
                if (recipe.TryGetIngredient(ItemID.Obsidifish, out var Obsidifish) && !TheDepthsIDs.Sets.RecipeBlacklist.ObsidifishOnlyItem[recipe.createItem.type])
                {
                    recipe.AddRecipeGroup("Obsidifish", Obsidifish.stack);
                    recipe.RemoveIngredient(Obsidifish);
                }
                if (recipe.TryGetIngredient(ItemID.FlarefinKoi, out var FK) && !TheDepthsIDs.Sets.RecipeBlacklist.FlarefinKoiOnlyItem[recipe.createItem.type])
                {
                    recipe.AddRecipeGroup("FlarefinKoi", FK.stack);
                    recipe.RemoveIngredient(FK);
                }
                if (recipe.TryGetIngredient(ItemID.Pwnhammer, out var pwnhammer) && !TheDepthsIDs.Sets.RecipeBlacklist.PwnhammerOnlyItem[recipe.createItem.type])
                {
                    recipe.AddRecipeGroup("Pwnhammer", pwnhammer.stack);
                    recipe.RemoveIngredient(pwnhammer);
                }
                if (recipe.TryGetIngredient(ItemID.FireblossomSeeds, out var FS) && !TheDepthsIDs.Sets.RecipeBlacklist.FireblossomSeedsOnlyItem[recipe.createItem.type])
                {
                    recipe.AddRecipeGroup("FireblossomSeeds", FS.stack);
                    recipe.RemoveIngredient(FS);
                }
                if (recipe.TryGetIngredient(ItemID.Hellforge, out var Hellforge) && !TheDepthsIDs.Sets.RecipeBlacklist.HellforgeOnlyItem[recipe.createItem.type])
                {
                    recipe.AddRecipeGroup("Hellforge", Hellforge.stack);
                    recipe.RemoveIngredient(Hellforge);
                }
                if (recipe.TryGetIngredient(ItemID.LivingFireBlock, out var LFB) && !TheDepthsIDs.Sets.RecipeBlacklist.LivingFireBlockOnlyItem[recipe.createItem.type])
                {
                    recipe.AddRecipeGroup("LivingFireBlock", LFB.stack);
                    recipe.RemoveIngredient(LFB);
                }
                if (recipe.TryGetIngredient(ItemID.CobaltShield, out var CS) && !TheDepthsIDs.Sets.RecipeBlacklist.CobaltShieldOnlyItem[recipe.createItem.type])
                {
                    recipe.AddRecipeGroup("CobaltShield", CS.stack);
                    recipe.RemoveIngredient(CS);
                }
				if (recipe.TryGetIngredient(ItemID.Cascade, out var Cascade) && !TheDepthsIDs.Sets.RecipeBlacklist.CascadeOnlyItem[recipe.createItem.type])
				{
					recipe.AddRecipeGroup("Cascade", Cascade.stack);
					recipe.RemoveIngredient(Cascade);
				}
				if (recipe.TryGetIngredient(ItemID.TreasureMagnet, out var TM) && !TheDepthsIDs.Sets.RecipeBlacklist.TreasureMagnetOnlyItem[recipe.createItem.type])
				{
					recipe.AddRecipeGroup("TreasureMagnet", TM.stack);
					recipe.RemoveIngredient(TM);
				}
			}
        }
    }
}