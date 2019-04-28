using System;
using System.Collections.Generic;

namespace OriginReportTools
{
    class GamesDataSetDemo
    {
        public GamesDataSetDemo()
        {
            GamesDataSet gamesDataSet = new GamesDataSet(
                "游戏数据集",
                new object[][]
                {
                    new object[]
                    {
                        "战地1",
                        new GamesDataSet.Game(
                            "BF 1",
                            new object[][]
                            {
                                 new object[] { "流血宴厅", new GamesDataSet.Game.Map("Ballroom Blitz") },
                                 new object[] { "阿尔贡森林", new GamesDataSet.Game.Map("Argonee Forest") },
                                 new object[] { "法欧堡", new GamesDataSet.Game.Map("Fao Fortress") },
                                 new object[] { "苏伊士", new GamesDataSet.Game.Map("Suez") },
                                 new object[] { "圣康坦的伤痕", new GamesDataSet.Game.Map("The St.Quentin Scar") },
                                 new object[] { "西奈沙漠", new GamesDataSet.Game.Map("Sinai Desert") },
                                 new object[] { "亚眠", new GamesDataSet.Game.Map("Amiens") },
                                 new object[] { "格拉巴山", new GamesDataSet.Game.Map("Monte Grappa") },
                                 new object[] { "帝国边缘", new GamesDataSet.Game.Map("Empires's Edge") },
                                 new object[] { "帕斯尚尔", new GamesDataSet.Game.Map("Passchendaele") },
                                 new object[] { "波雷托", new GamesDataSet.Game.Map("Caporetto") },
                                 new object[] { "索姆河", new GamesDataSet.Game.Map("River Sormme") },
                                 new object[] { "剃刀边缘", new GamesDataSet.Game.Map("Razor's Edge") },
                                 new object[] { "伦敦的呼唤", new GamesDataSet.Game.Map("London Calling") },
                                 new object[] { "黑尔戈兰湾", new GamesDataSet.Game.Map("Heligoland Bight") },
                                 new object[] { "泽布吕赫", new GamesDataSet.Game.Map("Zeebrugge") },
                                 new object[] { "海丽丝岬", new GamesDataSet.Game.Map("Cape Helles") },
                                 new object[] { "阿奇巴巴", new GamesDataSet.Game.Map("Achi Baba") },
                                 new object[] { "武普库夫山口", new GamesDataSet.Game.Map("Lupkow Pass") },
                                 new object[] { "勃鲁西洛夫关口", new GamesDataSet.Game.Map("Brusilov Keep") },
                                 new object[] { "加利西亚", new GamesDataSet.Game.Map("Gali cia") },
                                 new object[] { "阿尔比恩", new GamesDataSet.Game.Map("Albion") },
                                 new object[] { "察里津", new GamesDataSet.Game.Map("Tsaritsyn") },
                                 new object[] { "窝瓦河", new GamesDataSet.Game.Map("Volga River") },
                                 new object[] { "决裂", new GamesDataSet.Game.Map("Rupture") },
                                 new object[] { "苏瓦松", new GamesDataSet.Game.Map("Soissons") },
                                 new object[] { "凡尔登高地", new GamesDataSet.Game.Map("Verdun Heights") },
                                 new object[] { "法乌克斯要塞", new GamesDataSet.Game.Map("For de Vaux") },
                                 new object[] { "攻占托尔", new GamesDataSet.Game.Map("Prise de Tahure") },
                                 new object[] { "尼维尔之夜", new GamesDataSet.Game.Map("Nivelle Nights") },
                                 new object[] { "庞然暗影", new GamesDataSet.Game.Map("Giant's Shadow") }
                            },
                            new object[][]
                            {
                                new object[]
                                {
                                    "医疗兵",
                                    new GamesDataSet.Game.Arm(
                                        "Medic",
                                        new object[][]
                                        {
                                            new object[] {
                                                "医疗兵主武器",
                                                new GamesDataSet.Game.Arm.EquipmentSet(
                                                    "Medic Main Weapon",
                                                    new object[][]
                                                    {
                                                         new object[] { "Cei-Rigotti", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Cei-Rigotti") },
                                                         new object[] { "Selbstlader M1916", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Selbstlader M1916") },
                                                         new object[] { "M1907半自动步枪", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("M1907 SL") },
                                                         new object[] { "蒙德拉贡", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Mondragon") },
                                                         new object[] { "自动装填步枪8.35", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Autoloading 8.35") },
                                                         new object[] { "Selbstlader 1906", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Selbstlader 1906") },
                                                         new object[] { "RSC 1917 ", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("RSC 1917") },
                                                         new object[] { "菲德洛夫自动步枪", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Fedorov Avtomat") },
                                                         new object[] { "刘将军步枪", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("General Liu Rifle") },
                                                         new object[] { "Farquhar-Hill步枪", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Farquhar-Hill") },
                                                         new object[] { "Howell 自动步枪", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Howell Automatic") }
                                                    })
                                            },
                                            new object[] {
                                                "医疗兵副武器",
                                                new GamesDataSet.Game.Arm.EquipmentSet(
                                                    "Medic Secondary Weapon",
                                                    new object[][]
                                                    {
                                                         new object[] { "M1911", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("M1911") },
                                                         new object[] { "P08 Pistol", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("P08 Pistol") },
                                                         new object[] { "Mle 1903", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Mle 1903") },
                                                         new object[] { "C93", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("C93") },
                                                         new object[] { "No.3 Revolver", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("No.3 Revolver") },
                                                         new object[] { "蜂鸟手枪（娘娘枪）", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Kolibri") },
                                                         new object[] { "Nagant Revolver", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Nagant Revolver") },
                                                         new object[] { "Obrez手枪 ", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Obrez Pistol") },
                                                         new object[] { "MK VI左轮手枪", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Revolver MK VI") },
                                                         new object[] { "Auto Revolver", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Auto Revolver") },
                                                         new object[] { "C96", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("C96") },
                                                         new object[] { "Taschenpistole M1914", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Taschenpistole M1914") },
                                                         new object[] { "地狱战士M1911", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Hellfighter M1911") },
                                                         new object[] { "红男爵的P08", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Red Barn's P08") },
                                                         new object[] { "M1911消音版", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("M1911 Silencer") }
                                                    })
                                            },
                                            new object[] {
                                                "医疗兵投掷武器",
                                                new GamesDataSet.Game.Arm.EquipmentSet(
                                                    "Medic Throwing Weapon",
                                                    new object[][]
                                                    {
                                                        new object[] { "医疗兵投掷武器A", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Medic Throwing Weapon A") },
                                                        new object[] { "医疗兵投掷武器B", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Medic Throwing Weapon B") }
                                                    })
                                            },
                                            new object[] {
                                                "医疗兵装备",
                                                new GamesDataSet.Game.Arm.EquipmentSet(
                                                    "Medic Equipment",
                                                    new object[][]
                                                    {
                                                         new object[] { "医疗用针筒", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Medical Syringe") },
                                                         new object[] { "医疗箱", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Medical Crate") },
                                                         new object[] { "医疗包", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Bandage Pouch") },
                                                         new object[] { "步枪手榴弹-破片", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Rifle Grenade-FRG") },
                                                         new object[] { "步枪手榴弹-烟雾", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Rifle Grenade-SMK") },
                                                         new object[] { "步枪手榴弹-高爆", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Rifle Grenade-HE") }
                                                    })
                                            },
                                            new object[] {
                                                "投掷武器",
                                                new GamesDataSet.Game.Arm.EquipmentSet(
                                                    "Medic Special Weapon",
                                                    new object[][]
                                                    {
                                                        new object[] { "木柄手榴弹", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Stick Grenade") },
                                                        new object[] { "毒气手榴弹", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Gas Grenade") },
                                                        new object[] { "冲击手榴弹", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Impact Grenade") },
                                                        new object[] { "燃烧手榴弹", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Incendiary Grenade") },
                                                        new object[] { "小型手榴弹", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Mini Grenade") },
                                                        new object[] { "烟雾手榴弹", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Smoke Grenade") },
                                                        new object[] { "轻型反坦克手榴弹", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Light Anti-Tank Grenade") },
                                                        new object[] { "土制手榴弹", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Improvised Grenade") },
                                                    })
                                            }
                                        })
                                },
                                new object[]
                                {
                                    "突击兵",
                                    new GamesDataSet.Game.Arm(
                                        "Assault",
                                        new object[][]
                                        {
                                            new object[] {
                                                "突击兵主武器",
                                                new GamesDataSet.Game.Arm.EquipmentSet(
                                                    "Assault Main Weapon",
                                                    new object[][]
                                                    {
                                                        new object[] { "突击兵主武器A", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Assault Main Weapon A") },
                                                        new object[] { "突击兵主武器B", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Assault Main Weapon B") }
                                                    })
                                            },
                                            new object[] {
                                                "突击兵副武器",
                                                new GamesDataSet.Game.Arm.EquipmentSet(
                                                    "Assault Secondary Weapon",
                                                    new object[][]
                                                    {
                                                        new object[] { "突击兵副武器A", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Assault Secondary Weapon A") },
                                                        new object[] { "突击兵副武器B", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Assault Secondary Weapon B") }
                                                    })
                                            },
                                            new object[] {
                                                "突击兵投掷武器",
                                                new GamesDataSet.Game.Arm.EquipmentSet(
                                                    "Assault Throwing Weapon",
                                                    new object[][]
                                                    {
                                                        new object[] { "突击兵投掷武器A", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Assault Throwing Weapon A") },
                                                        new object[] { "突击兵投掷武器B", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Assault Throwing Weapon B") }
                                                    })
                                            },
                                            new object[] {
                                                "突击兵装备",
                                                new GamesDataSet.Game.Arm.EquipmentSet(
                                                    "Assault Equipment",
                                                    new object[][]
                                                    {
                                                        new object[] { "突击兵装备A", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Assault Equipment A") },
                                                        new object[] { "突击兵装备B", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Assault Equipment B") }
                                                    })
                                            },
                                            new object[] {
                                                "突击兵特殊武器",
                                                new GamesDataSet.Game.Arm.EquipmentSet(
                                                    "Assault Special Weapon",
                                                    new object[][]
                                                    {
                                                        new object[] { "突击兵特殊武器A", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Assault Special Weapon A") },
                                                        new object[] { "突击兵特殊武器B", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Assault Special Weapon B") }
                                                    })
                                            }
                                        })
                                }
                            },
                            new object[][]
                            {
                                new object[]{"透视",new GamesDataSet.Game.CheckType("WallHack") }
                            }
                            
                            )
                    },
                    new object[]
                    {
                        "战地V",
                        new GamesDataSet.Game(
                            "BF V",
                            new object[][]
                            {
                                new object[] { "地图1", new GamesDataSet.Game.Map("map1") },
                                new object[] { "地图2", new GamesDataSet.Game.Map("map2") }
                            },
                            new object[][]{
                                new object[]
                                {
                                    "医疗兵",
                                    new GamesDataSet.Game.Arm(
                                        "Medic",
                                        new object[][]
                                        {
                                            new object[] {
                                                "医疗兵主武器",
                                                new GamesDataSet.Game.Arm.EquipmentSet(
                                                    "Medic Main Weapon",
                                                    new object[][]
                                                    {
                                                        new object[] { "医疗兵主武器A", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Medic Main Weapon A") },
                                                        new object[] { "医疗兵主武器B", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Medic Main Weapon B") },
                                                    })
                                            },
                                            new object[] {
                                                "医疗兵副武器",
                                                new GamesDataSet.Game.Arm.EquipmentSet(
                                                    "Medic Secondary Weapon",
                                                    new object[][]
                                                    {
                                                        new object[] { "医疗兵副武器A", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Medic Secondary Weapon A") },
                                                        new object[] { "医疗兵副武器B", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Medic Secondary Weapon B") }
                                                    })
                                            },
                                            new object[] {
                                                "医疗兵投掷武器",
                                                new GamesDataSet.Game.Arm.EquipmentSet(
                                                    "Medic Throwing Weapon",
                                                    new object[][]
                                                    {
                                                        new object[] { "医疗兵投掷武器A", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Medic Throwing Weapon A") },
                                                        new object[] { "医疗兵投掷武器B", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Medic Throwing Weapon B") }
                                                    })
                                            },
                                            new object[] {
                                                "医疗兵装备",
                                                new GamesDataSet.Game.Arm.EquipmentSet(
                                                    "Medic Equipment",
                                                    new object[][]
                                                    {
                                                        new object[] { "医疗兵装备A", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Medic Equipment A") },
                                                        new object[] { "医疗兵装备B", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Medic Equipment B") }
                                                    })
                                            },
                                            new object[] {
                                                "医疗兵特殊武器",
                                                new GamesDataSet.Game.Arm.EquipmentSet(
                                                    "Medic Special Weapon",
                                                    new object[][]
                                                    {
                                                        new object[] { "医疗兵特殊武器A", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Medic Special Weapon A") },
                                                        new object[] { "医疗兵特殊武器B", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Medic Special Weapon B") }
                                                    })
                                            }
                                        })
                                },
                                new object[]
                                {
                                    "突击兵",
                                    new GamesDataSet.Game.Arm(
                                        "Assault",
                                        new object[][]
                                        {
                                            new object[] {
                                                "突击兵主武器",
                                                new GamesDataSet.Game.Arm.EquipmentSet(
                                                    "Assault Main Weapon",
                                                    new object[][]
                                                    {
                                                        new object[] { "突击兵主武器A", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Assault Main Weapon A") },
                                                        new object[] { "突击兵主武器B", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Assault Main Weapon B") }
                                                    })
                                            },
                                            new object[] {
                                                "突击兵副武器",
                                                new GamesDataSet.Game.Arm.EquipmentSet(
                                                    "Assault Secondary Weapon",
                                                    new object[][]
                                                    {
                                                        new object[] { "突击兵副武器A", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Assault Secondary Weapon A") },
                                                        new object[] { "突击兵副武器B", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Assault Secondary Weapon B") }
                                                    })
                                            },
                                            new object[] {
                                                "突击兵投掷武器",
                                                new GamesDataSet.Game.Arm.EquipmentSet(
                                                    "Assault Throwing Weapon",
                                                    new object[][]
                                                    {
                                                        new object[] { "突击兵投掷武器A", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Assault Throwing Weapon A") },
                                                        new object[] { "突击兵投掷武器B", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Assault Throwing Weapon B") }
                                                    })
                                            },
                                            new object[] {
                                                "突击兵装备",
                                                new GamesDataSet.Game.Arm.EquipmentSet(
                                                    "Assault Equipment",
                                                    new object[][]
                                                    {
                                                        new object[] { "突击兵装备A", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Assault Equipment A") },
                                                        new object[] { "突击兵装备B", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Assault Equipment B") }
                                                    })
                                            },
                                            new object[] {
                                                "突击兵特殊武器",
                                                new GamesDataSet.Game.Arm.EquipmentSet(
                                                    "Assault Special Weapon",
                                                    new object[][]
                                                    {
                                                        new object[] { "突击兵特殊武器A", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Assault Special Weapon A") },
                                                        new object[] { "突击兵特殊武器B", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Assault Special Weapon B") }
                                                    })
                                            }
                                        })
                                }
                            },
                            new object[][]
                            {
                                new object[]{"透视",new GamesDataSet.Game.CheckType("WallHack") }
                            }

                            )
                    }
                });

            Console.WriteLine("名称访问测试:");
            Console.WriteLine(string.Format("战地1 - {0}", gamesDataSet.Games["战地1"]));
            Console.WriteLine(string.Format("战地1医疗兵 - {0}", gamesDataSet.Games["战地1"].Arms["医疗兵"]));
            Console.WriteLine(string.Format("战地1医疗兵主武器 - {0}", gamesDataSet.Games["战地1"].Arms["医疗兵"].EquipmentSets["医疗兵主武器"]));
            Console.WriteLine(string.Format("战地1医疗兵主武器A - {0}", gamesDataSet.Games["战地1"].Arms["医疗兵"].EquipmentSets["医疗兵主武器"].Equipments["蒙德拉贡"]));
            Console.WriteLine();

            Console.WriteLine("遍历测试:");
            Console.WriteLine("战地V全部兵种:");
            foreach (KeyValuePair<string, GamesDataSet.Game.Arm> arm in gamesDataSet.Games["战地V"].Arms)
            {
                Console.WriteLine(string.Format("{0} - {1}", arm.Key, arm.Value));
            }
            Console.WriteLine("战地1全部作弊列表:");
            foreach (KeyValuePair<string, GamesDataSet.Game.CheckType> check in gamesDataSet.Games["战地1"].CheckTypes)
            {
                Console.WriteLine(string.Format("{0} - {1}", check.Key, check.Value));
            }
            Console.WriteLine("战地V医疗兵全部主武器:");
            foreach (KeyValuePair<string, GamesDataSet.Game.Arm.EquipmentSet.Equipment> equipment in gamesDataSet.Games["战地V"].Arms["医疗兵"].EquipmentSets["医疗兵主武器"].Equipments)
            {
                Console.WriteLine(string.Format("{0} - {1}", equipment.Key, equipment.Value));
            }
        }
    }
}
