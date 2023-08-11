using MelonLoader;
using Il2CppAssets.Scripts.Models.GenericBehaviors;
using Il2CppAssets.Scripts.Models.Towers;
using Il2CppAssets.Scripts.Models.Towers.Behaviors;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Attack;
using Il2CppAssets.Scripts.Models.Towers.Projectiles.Behaviors;
using Il2CppAssets.Scripts.Utils;
using BTD_Mod_Helper.Extensions;
using BTD_Mod_Helper;
using BTD_Mod_Helper.Api;
using BTD_Mod_Helper.Api.Towers;
using ModdedMonkey;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Emissions;
using Il2Cpp;
using Il2CppAssets.Scripts.Models.Towers.Behaviors.Abilities.Behaviors;
using Il2CppAssets.Scripts.Unity;

[assembly: MelonInfo(typeof(ModdedMonkey.ModdedMonkey), ModHelperData.Name, ModHelperData.Version, ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]

namespace ModdedMonkey;

public class ModdedMonkey : BloonsTD6Mod
{
    public override void OnApplicationStart()
    {
        ModHelper.Msg<ModdedMonkey>("Modded Monkey! Loading Accomplished.");
        ModHelper.Msg<ModdedMonkey>("if it works im happy... this is my first mod let alone tower mod.");
        ModHelper.Msg<ModdedMonkey>("i wonder if there is a way to add comments to code or smth like it to keep track of my code. what im doing is writing console messages.");
    }
    public class ModdedMonkeyTower : ModHero
    {
        public override string Name => "ModdedMonkey";
        public override string DisplayName => "Modded Monkey";
        public override string Description => "";
        public override string BaseTower => "DartMonkey";
        public override int Cost => 250;
        public override int MaxLevel => 15;
        public override float XpRatio => 1f;
        public override string Title => "Modded Monkey";
        public override string Level1Description => "";
        public override void ModifyBaseTowerModel(TowerModel towerModel)
        {
            // i figured out how to make something like comments by typing "//"! but how do i comment out large segments of stuff?
        }
        public override string Portrait => "Portrait.png";
        public override string Icon => Portrait;
    }
    public class Level2 : ModHeroLevel<ModdedMonkeyTower>
    {
        public override string Description => "i thought modding would be easy and it was just clicking buttons and stuff. its not! you need coding and stuff. well im trying to ask people for help and its working. i hope people like this mod...";
        public override int Level => 2;
        public override void ApplyUpgrade(TowerModel towerModel)
        {
            AttackModel attackModel = towerModel.GetAttackModel();
            attackModel.weapons[0].projectile.GetDamageModel().damage += 5;
        }
        public override string Portrait => "Portrait.png";
    }
    public class Level3 : ModHeroLevel<ModdedMonkeyTower>
    {
        public override string Description => "omg i figured out how to change the size of the tower!!!!! i wanna change how it looks but i cant yet :(";
        public override int Level => 3;
        public override void ApplyUpgrade(TowerModel towerModel)
        {
            AttackModel attackModel = towerModel.GetAttackModel();
            attackModel.weapons[0].projectile.GetDamageModel().damage += 5;
            attackModel.weapons[0].rate *= 0.75f;
            towerModel.displayScale *= 0.75f;
        }
        public override string Portrait => "Portrait.png";
    }
    public class Level4 : ModHeroLevel<ModdedMonkeyTower>
    {
        public override string Description => "i asked people how to change how my tower looks and they told me! ill probably make it look like a triple shot dart monkey so it shoots 3 projectiles!";
        public override int Level => 4;
        public override void ApplyUpgrade(TowerModel towerModel)
        {
            AttackModel attackModel = towerModel.GetAttackModel();
            attackModel.weapons[0].projectile.GetDamageModel().damage += 5;
            attackModel.weapons[0].rate *= 0.95f;
            towerModel.display = new PrefabReference() { guidRef = "1c4ebe6019a2b0743994e3f2ca14d94b" };
        }
        public override string Portrait => "Portrait.png";
    }
    public class Level5 : ModHeroLevel<ModdedMonkeyTower>
    {
        public override string Description => "it didnt work... they told me i need to add an arc emmision model? well im thankful for them being there to help me and i figured out how!";
        public override int Level => 5;
        public override void ApplyUpgrade(TowerModel towerModel)
        {
            AttackModel attackModel = towerModel.GetAttackModel();
            attackModel.weapons[0].emission = new ArcEmissionModel("ArcEmissionModel_Tripapult", 3, 0f, 15f, null, false, true);
        }
        public override string Portrait => "Portrait.png";
    }
    public class Level6 : ModHeroLevel<ModdedMonkeyTower>
    {
        public override string Description => "i forgot the tower doesnt have lead or camo popping powers. ill ask them how to add that.";
        public override int Level => 6;
        public override void ApplyUpgrade(TowerModel towerModel)
        {
            AttackModel attackModel = towerModel.GetAttackModel();
            attackModel.weapons[0].projectile.GetDamageModel().damage += 5;
            attackModel.weapons[0].rate *= 0.95f;
            attackModel.weapons[0].projectile.GetDamageModel().immuneBloonProperties = BloonProperties.None;
            towerModel.AddBehavior(new OverrideCamoDetectionModel("OverrideCamoDetectionModel_", true));
        }
        public override string Portrait => "Portrait.png";
    }
    public class Level7 : ModHeroLevel<ModdedMonkeyTower>
    {
        public override string Description => "this isnt fun anymore. im tired barely awake still working on this useless mod.... i think ill take a break";
        public override int Level => 7;
        public override void ApplyUpgrade(TowerModel towerModel)
        {
            AttackModel attackModel = towerModel.GetAttackModel();
            attackModel.weapons[0].projectile.GetDamageModel().damage += 5;
            attackModel.weapons[0].rate *= 0.95f;
        }
        public override string Portrait => "Portrait.png";
    }
    public class Level8 : ModHeroLevel<ModdedMonkeyTower>
    {
        public override string Description => ".";
        public override int Level => 8;
        public override void ApplyUpgrade(TowerModel towerModel)
        {
            AttackModel attackModel = towerModel.GetAttackModel();
            attackModel.weapons[0].projectile.GetDamageModel().damage += 5;
            attackModel.weapons[0].rate *= 0.95f;
        }
        public override string Portrait => "Portrait.png";
    }
    public class Level9 : ModHeroLevel<ModdedMonkeyTower>
    {
        public override string Description => "..";
        public override int Level => 9;
        public override void ApplyUpgrade(TowerModel towerModel)
        {
            AttackModel attackModel = towerModel.GetAttackModel();
            attackModel.weapons[0].projectile.GetDamageModel().damage += 5;
            attackModel.weapons[0].rate *= 0.95f;
        }
        public override string Portrait => "Portrait.png";
    }
    public class Level10 : ModHeroLevel<ModdedMonkeyTower>
    {
        public override string Description => "...";
        public override int Level => 10;
        public override void ApplyUpgrade(TowerModel towerModel)
        {
            AttackModel attackModel = towerModel.GetAttackModel();
            attackModel.weapons[0].projectile.GetDamageModel().damage += 5;
            attackModel.weapons[0].rate *= 0.95f;
        }
        public override string Portrait => "Portrait.png";
    }
    public class Level11 : ModHeroLevel<ModdedMonkeyTower>
    {
        public override string Description => "im back. modding was getting tiring im glad i took a break. anyway i made the projectile an arrow and maybe last longer!";
        public override int Level => 11;
        public override void ApplyUpgrade(TowerModel towerModel)
        {
            AttackModel attackModel = towerModel.GetAttackModel();
            attackModel.weapons[0].projectile.GetDamageModel().damage += 5;
            attackModel.weapons[0].rate *= 0.95f;
            attackModel.weapons[0].projectile.GetBehavior<TravelStraitModel>().Lifespan = 4;
            attackModel.weapons[0].projectile.display = new PrefabReference() { guidRef = "e57060793f03d3046a9f97b8cb24986a" };
        }
        public override string Portrait => "Portrait.png";
    }
    public class Level12 : ModHeroLevel<ModdedMonkeyTower>
    {
        public override string Description => "i figured out how to add an ability!!";
        public override int Level => 12;
        public override void ApplyUpgrade(TowerModel towerModel)
        {
            AttackModel attackModel = towerModel.GetAttackModel();
            attackModel.weapons[0].projectile.GetDamageModel().damage += 5;
            attackModel.weapons[0].rate *= 0.5f;
            towerModel.AddBehavior(Game.instance.model.GetTowerFromId("MortarMonkey-040").GetAbility().Duplicate());
            towerModel.GetAbility().name = "Machine Gun";
            towerModel.GetAbility().GetBehavior<TurboModel>().extraDamage = 10;
            towerModel.GetAbility().GetBehavior<TurboModel>().multiplier = 0.125f;
            towerModel.GetAbility().GetBehavior<TurboModel>().Lifespan = 31;
            towerModel.GetAbility().Cooldown = 0;
            //also i figured out to comment large segments i use /* and */
        }
        public override string Portrait => "Portrait.png";
    }
    public class Level13 : ModHeroLevel<ModdedMonkeyTower>
    {
        public override string Description => "i dont know what to add. i feel like this is a complete tower already so i just increased the range";

        public override int Level => 13;
        public override void ApplyUpgrade(TowerModel towerModel)
        {
            AttackModel attackModel = towerModel.GetAttackModel();
            attackModel.weapons[0].projectile.GetDamageModel().damage += 5;
            towerModel.range = 50;
            attackModel.range = 50;
        }
        public override string Portrait => "Portrait.png";
    }
    public class Level14 : ModHeroLevel<ModdedMonkeyTower>
    {
        public override string Description => "i think im almost done! i dont think this tower needs 20 upgrades 15 seems fine.";

        public override int Level => 14;
        public override void ApplyUpgrade(TowerModel towerModel)
        {
            AttackModel attackModel = towerModel.GetAttackModel();
            attackModel.weapons[0].projectile.GetDamageModel().damage += 5;
        }
        public override string Portrait => "Portrait.png";
    }
    public class Level15 : ModHeroLevel<ModdedMonkeyTower>
    {
        public override string Description => "im done with this tower...";

        public override int Level => 15;
        public override void ApplyUpgrade(TowerModel towerModel)
        {
            AttackModel attackModel = towerModel.GetAttackModel();
            attackModel.weapons[0].rate *= 0.5f;
        }
        public override string Portrait => "Portrait.png";
    }
}