using System;
using System.Collections.Generic;

namespace OriginReportTools
{
    class GamesDataDemo
    {
        public GamesDataDemo()
        {
            GamesData gamesData = new GamesData(
                "游戏数据集",
                new object[][]
                {
                    new object[]
                    {
                        "战地1",
                        new GamesData.Game(
                            "BF 1",
                            new object[][]
                            {
                                new object[] { "地图1", new GamesData.Game.Map("Map1") },
                                new object[] { "地图2", new GamesData.Game.Map("Map2") }
                            },
                            new object[][]{
                                new object[]
                                {
                                    "医疗兵",
                                    new GamesData.Game.Arm(
                                        "Medic",
                                        new object[][]
                                        {
                                            new object[] {
                                                "医疗兵主武器",
                                                new GamesData.Game.Arm.EquipmentSet(
                                                    "Medic Main Weapon",
                                                    new object[][]
                                                    {
                                                        new object[] { "医疗兵主武器A", new GamesData.Game.Arm.EquipmentSet.Equipment("Medic Main Weapon A") },
                                                        new object[] { "医疗兵主武器B", new GamesData.Game.Arm.EquipmentSet.Equipment("Medic Main Weapon B") }
                                                    })
                                            },
                                            new object[] {
                                                "医疗兵副武器",
                                                new GamesData.Game.Arm.EquipmentSet(
                                                    "Medic Secondary Weapon",
                                                    new object[][]
                                                    {
                                                        new object[] { "医疗兵副武器A", new GamesData.Game.Arm.EquipmentSet.Equipment("Medic Secondary Weapon A") },
                                                        new object[] { "医疗兵副武器B", new GamesData.Game.Arm.EquipmentSet.Equipment("Medic Secondary Weapon B") }
                                                    })
                                            },
                                            new object[] {
                                                "医疗兵投掷武器",
                                                new GamesData.Game.Arm.EquipmentSet(
                                                    "Medic Throwing Weapon",
                                                    new object[][]
                                                    {
                                                        new object[] { "医疗兵投掷武器A", new GamesData.Game.Arm.EquipmentSet.Equipment("Medic Throwing Weapon A") },
                                                        new object[] { "医疗兵投掷武器B", new GamesData.Game.Arm.EquipmentSet.Equipment("Medic Throwing Weapon B") }
                                                    })
                                            },
                                            new object[] {
                                                "医疗兵装备",
                                                new GamesData.Game.Arm.EquipmentSet(
                                                    "Medic Equipment",
                                                    new object[][]
                                                    {
                                                        new object[] { "医疗兵装备A", new GamesData.Game.Arm.EquipmentSet.Equipment("Medic Equipment A") },
                                                        new object[] { "医疗兵装备B", new GamesData.Game.Arm.EquipmentSet.Equipment("Medic Equipment B") }
                                                    })
                                            },
                                            new object[] {
                                                "医疗兵特殊武器",
                                                new GamesData.Game.Arm.EquipmentSet(
                                                    "Medic Special Weapon",
                                                    new object[][]
                                                    {
                                                        new object[] { "医疗兵特殊武器A", new GamesData.Game.Arm.EquipmentSet.Equipment("Medic Special Weapon A") },
                                                        new object[] { "医疗兵特殊武器B", new GamesData.Game.Arm.EquipmentSet.Equipment("Medic Special Weapon B") }
                                                    })
                                            }
                                        })
                                },
                                new object[]
                                {
                                    "突击兵",
                                    new GamesData.Game.Arm(
                                        "Assault",
                                        new object[][]
                                        {
                                            new object[] {
                                                "突击兵主武器",
                                                new GamesData.Game.Arm.EquipmentSet(
                                                    "Assault Main Weapon",
                                                    new object[][]
                                                    {
                                                        new object[] { "突击兵主武器A", new GamesData.Game.Arm.EquipmentSet.Equipment("Assault Main Weapon A") },
                                                        new object[] { "突击兵主武器B", new GamesData.Game.Arm.EquipmentSet.Equipment("Assault Main Weapon B") }
                                                    })
                                            },
                                            new object[] {
                                                "突击兵副武器",
                                                new GamesData.Game.Arm.EquipmentSet(
                                                    "Assault Secondary Weapon",
                                                    new object[][]
                                                    {
                                                        new object[] { "突击兵副武器A", new GamesData.Game.Arm.EquipmentSet.Equipment("Assault Secondary Weapon A") },
                                                        new object[] { "突击兵副武器B", new GamesData.Game.Arm.EquipmentSet.Equipment("Assault Secondary Weapon B") }
                                                    })
                                            },
                                            new object[] {
                                                "突击兵投掷武器",
                                                new GamesData.Game.Arm.EquipmentSet(
                                                    "Assault Throwing Weapon",
                                                    new object[][]
                                                    {
                                                        new object[] { "突击兵投掷武器A", new GamesData.Game.Arm.EquipmentSet.Equipment("Assault Throwing Weapon A") },
                                                        new object[] { "突击兵投掷武器B", new GamesData.Game.Arm.EquipmentSet.Equipment("Assault Throwing Weapon B") }
                                                    })
                                            },
                                            new object[] {
                                                "突击兵装备",
                                                new GamesData.Game.Arm.EquipmentSet(
                                                    "Assault Equipment",
                                                    new object[][]
                                                    {
                                                        new object[] { "突击兵装备A", new GamesData.Game.Arm.EquipmentSet.Equipment("Assault Equipment A") },
                                                        new object[] { "突击兵装备B", new GamesData.Game.Arm.EquipmentSet.Equipment("Assault Equipment B") }
                                                    })
                                            },
                                            new object[] {
                                                "突击兵特殊武器",
                                                new GamesData.Game.Arm.EquipmentSet(
                                                    "Assault Special Weapon",
                                                    new object[][]
                                                    {
                                                        new object[] { "突击兵特殊武器A", new GamesData.Game.Arm.EquipmentSet.Equipment("Assault Special Weapon A") },
                                                        new object[] { "突击兵特殊武器B", new GamesData.Game.Arm.EquipmentSet.Equipment("Assault Special Weapon B") }
                                                    })
                                            }
                                        })
                                }
                            })
                    },
                    new object[]
                    {
                        "战地V",
                        new GamesData.Game(
                            "BF V",
                            new object[][]
                            {
                                new object[] { "地图1", new GamesData.Game.Map("map1") },
                                new object[] { "地图2", new GamesData.Game.Map("map2") }
                            },
                            new object[][]{
                                new object[]
                                {
                                    "医疗兵",
                                    new GamesData.Game.Arm(
                                        "Medic",
                                        new object[][]
                                        {
                                            new object[] {
                                                "医疗兵主武器",
                                                new GamesData.Game.Arm.EquipmentSet(
                                                    "Medic Main Weapon",
                                                    new object[][]
                                                    {
                                                        new object[] { "医疗兵主武器A", new GamesData.Game.Arm.EquipmentSet.Equipment("Medic Main Weapon A") },
                                                        new object[] { "医疗兵主武器B", new GamesData.Game.Arm.EquipmentSet.Equipment("Medic Main Weapon B") }
                                                    })
                                            },
                                            new object[] {
                                                "医疗兵副武器",
                                                new GamesData.Game.Arm.EquipmentSet(
                                                    "Medic Secondary Weapon",
                                                    new object[][]
                                                    {
                                                        new object[] { "医疗兵副武器A", new GamesData.Game.Arm.EquipmentSet.Equipment("Medic Secondary Weapon A") },
                                                        new object[] { "医疗兵副武器B", new GamesData.Game.Arm.EquipmentSet.Equipment("Medic Secondary Weapon B") }
                                                    })
                                            },
                                            new object[] {
                                                "医疗兵投掷武器",
                                                new GamesData.Game.Arm.EquipmentSet(
                                                    "Medic Throwing Weapon",
                                                    new object[][]
                                                    {
                                                        new object[] { "医疗兵投掷武器A", new GamesData.Game.Arm.EquipmentSet.Equipment("Medic Throwing Weapon A") },
                                                        new object[] { "医疗兵投掷武器B", new GamesData.Game.Arm.EquipmentSet.Equipment("Medic Throwing Weapon B") }
                                                    })
                                            },
                                            new object[] {
                                                "医疗兵装备",
                                                new GamesData.Game.Arm.EquipmentSet(
                                                    "Medic Equipment",
                                                    new object[][]
                                                    {
                                                        new object[] { "医疗兵装备A", new GamesData.Game.Arm.EquipmentSet.Equipment("Medic Equipment A") },
                                                        new object[] { "医疗兵装备B", new GamesData.Game.Arm.EquipmentSet.Equipment("Medic Equipment B") }
                                                    })
                                            },
                                            new object[] {
                                                "医疗兵特殊武器",
                                                new GamesData.Game.Arm.EquipmentSet(
                                                    "Medic Special Weapon",
                                                    new object[][]
                                                    {
                                                        new object[] { "医疗兵特殊武器A", new GamesData.Game.Arm.EquipmentSet.Equipment("Medic Special Weapon A") },
                                                        new object[] { "医疗兵特殊武器B", new GamesData.Game.Arm.EquipmentSet.Equipment("Medic Special Weapon B") }
                                                    })
                                            }
                                        })
                                },
                                new object[]
                                {
                                    "突击兵",
                                    new GamesData.Game.Arm(
                                        "Assault",
                                        new object[][]
                                        {
                                            new object[] {
                                                "突击兵主武器",
                                                new GamesData.Game.Arm.EquipmentSet(
                                                    "Assault Main Weapon",
                                                    new object[][]
                                                    {
                                                        new object[] { "突击兵主武器A", new GamesData.Game.Arm.EquipmentSet.Equipment("Assault Main Weapon A") },
                                                        new object[] { "突击兵主武器B", new GamesData.Game.Arm.EquipmentSet.Equipment("Assault Main Weapon B") }
                                                    })
                                            },
                                            new object[] {
                                                "突击兵副武器",
                                                new GamesData.Game.Arm.EquipmentSet(
                                                    "Assault Secondary Weapon",
                                                    new object[][]
                                                    {
                                                        new object[] { "突击兵副武器A", new GamesData.Game.Arm.EquipmentSet.Equipment("Assault Secondary Weapon A") },
                                                        new object[] { "突击兵副武器B", new GamesData.Game.Arm.EquipmentSet.Equipment("Assault Secondary Weapon B") }
                                                    })
                                            },
                                            new object[] {
                                                "突击兵投掷武器",
                                                new GamesData.Game.Arm.EquipmentSet(
                                                    "Assault Throwing Weapon",
                                                    new object[][]
                                                    {
                                                        new object[] { "突击兵投掷武器A", new GamesData.Game.Arm.EquipmentSet.Equipment("Assault Throwing Weapon A") },
                                                        new object[] { "突击兵投掷武器B", new GamesData.Game.Arm.EquipmentSet.Equipment("Assault Throwing Weapon B") }
                                                    })
                                            },
                                            new object[] {
                                                "突击兵装备",
                                                new GamesData.Game.Arm.EquipmentSet(
                                                    "Assault Equipment",
                                                    new object[][]
                                                    {
                                                        new object[] { "突击兵装备A", new GamesData.Game.Arm.EquipmentSet.Equipment("Assault Equipment A") },
                                                        new object[] { "突击兵装备B", new GamesData.Game.Arm.EquipmentSet.Equipment("Assault Equipment B") }
                                                    })
                                            },
                                            new object[] {
                                                "突击兵特殊武器",
                                                new GamesData.Game.Arm.EquipmentSet(
                                                    "Assault Special Weapon",
                                                    new object[][]
                                                    {
                                                        new object[] { "突击兵特殊武器A", new GamesData.Game.Arm.EquipmentSet.Equipment("Assault Special Weapon A") },
                                                        new object[] { "突击兵特殊武器B", new GamesData.Game.Arm.EquipmentSet.Equipment("Assault Special Weapon B") }
                                                    })
                                            }
                                        })
                                }
                            })
                    }
                });

            Console.WriteLine("名称访问测试:");
            Console.WriteLine(string.Format("战地1 - {0}", gamesData.Games["战地1"]));
            Console.WriteLine(string.Format("战地1医疗兵 - {0}", gamesData.Games["战地1"].Arms["医疗兵"]));
            Console.WriteLine(string.Format("战地1医疗兵主武器 - {0}", gamesData.Games["战地1"].Arms["医疗兵"].EquipmentSets["医疗兵主武器"]));
            Console.WriteLine(string.Format("战地1医疗兵主武器A - {0}", gamesData.Games["战地1"].Arms["医疗兵"].EquipmentSets["医疗兵主武器"].Equipments["医疗兵主武器A"]));
            Console.WriteLine();

            Console.WriteLine("遍历测试:");
            Console.WriteLine("战地V全部兵种:");
            foreach (KeyValuePair<string, GamesData.Game.Arm> arm in gamesData.Games["战地V"].Arms)
            {
                Console.WriteLine(string.Format("{0} - {1}", arm.Key, arm.Value));
            }
            Console.WriteLine("战地V医疗兵全部主武器:");
            foreach (KeyValuePair<string, GamesData.Game.Arm.EquipmentSet.Equipment> equipment in gamesData.Games["战地V"].Arms["医疗兵"].EquipmentSets["医疗兵主武器"].Equipments)
            {
                Console.WriteLine(string.Format("{0} - {1}", equipment.Key, equipment.Value));
            }
        }
    }
}
