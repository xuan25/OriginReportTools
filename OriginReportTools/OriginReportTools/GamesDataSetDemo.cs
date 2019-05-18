using System;
using System.Collections.Generic;

namespace OriginReportTools
{
    class GamesDataSetDemo
    {
        public GamesDataSet Data;
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
                            },//地图列表
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
                                                "主武器",
                                                new GamesDataSet.Game.Arm.EquipmentSet(
                                                    "Main Weapon",
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
                                                "副武器",
                                                new GamesDataSet.Game.Arm.EquipmentSet(
                                                    "Secondary Weapon",
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
                                                "投掷武器",
                                                new GamesDataSet.Game.Arm.EquipmentSet(
                                                    "Throwing Weapon",
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
                                            },
                                            new object[] {
                                                "装备",
                                                new GamesDataSet.Game.Arm.EquipmentSet(
                                                    "Equipment",
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
                                                "特殊武器",
                                                new GamesDataSet.Game.Arm.EquipmentSet(
                                                    "Assault Special Weapon",
                                                    new object[][]
                                                    {
                                                        new object[] { "地图定点武器", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("STATIONARY WEAPON") },
                                                        new object[] { "刀杀", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Knife#") }
                                                    })
                                            }
                                        })
                                },//医疗
                                new object[]
                                {
                                    "突击兵",
                                    new GamesDataSet.Game.Arm(
                                        "Assault",
                                        new object[][]
                                        {
                                            new object[] {
                                                "主武器",
                                                new GamesDataSet.Game.Arm.EquipmentSet(
                                                    "Assault Main Weapon",
                                                    new object[][]
                                                    {
                                                         new object[] { "Model 10-A", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Model 10-A") },
                                                         new object[] { "M97战壕枪", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("M97 Trench Gun") },
                                                         new object[] { "MP 18", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("MP 18") },
                                                         new object[] { "M918自动冲锋枪", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Automatico M1918") },
                                                         new object[] { "12g 自动散弹枪", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("12g Automatic") },
                                                         new object[] { "Hellriegel 1915", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Hellriegel 1915") },
                                                         new object[] { "地狱战士战壕散弹枪", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Hellfighter Trench") },
                                                         new object[] { "Sjogren Inertial ", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Sjogren Inertial") },
                                                         new object[] { "利贝罗勒 1918", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Ribeyrolles 1918") },
                                                         new object[] { "Moedl 1900", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Moedl 1900") },
                                                         new object[] { "SMG 08/18", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("SMG 08/18") },
                                                         new object[] { "Maschinepistole M1912/P.16", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Maschinepistole M1912/P.16") },
                                                         new object[] { "M1917卡宾枪", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("M1917") },
                                                         new object[] { "RSC 冲锋枪", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("RSC SMG") },
                                                         new object[] { "Annihilator", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Annihilator") },
                                                         new object[] { "弗洛梅尔停止手枪", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Frommer Stop Auto") },
                                                         new object[] { "短管散弹枪", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Sawed Off Shotgun") }
                                                    })
                                            },
                                            new object[] {
                                                "副武器",
                                                new GamesDataSet.Game.Arm.EquipmentSet(
                                                    "Assault Secondary Weapon",
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
                                                "投掷武器",
                                                new GamesDataSet.Game.Arm.EquipmentSet(
                                                    "Assault Throwing Weapon",
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
                                            },
                                            new object[] {
                                                "装备",
                                                new GamesDataSet.Game.Arm.EquipmentSet(
                                                    "Assault Equipment",
                                                    new object[][]
                                                    {
                                                         new object[] { "炸药", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Dynamite") },
                                                         new object[] { "反坦克手雷", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Anti-Tank Grenade") },
                                                         new object[] { "反坦克地雷", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Anti-Tank Mine") },
                                                         new object[] { "反坦克火箭炮", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("AT Rocket Gun") },
                                                         new object[] { "防空火箭炮", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("AA Rocket Gun") },
                                                    })
                                            },
                                            new object[] {
                                                "特殊武器",
                                                new GamesDataSet.Game.Arm.EquipmentSet(
                                                    "Assault Special Weapon",
                                                    new object[][]
                                                    {
                                                        new object[] { "地图定点武器", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("STATIONARY WEAPON") },
                                                        new object[] { "刀杀", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Knife#") }
                                                    })
                                            }
                                        })
                                },//突击
                                new object[]
                                {
                                    "支援兵",
                                    new GamesDataSet.Game.Arm(
                                        "Assault",
                                        new object[][]
                                        {
                                            new object[] {
                                                "主武器",
                                                new GamesDataSet.Game.Arm.EquipmentSet(
                                                    "Assault Main Weapon",
                                                    new object[][]
                                                    {
                                                         new object[] { "路易士机枪", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Lewis Gun") },
                                                         new object[] { "M1909贝内特·梅西耶机枪", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("M1909 Benet-Mercie") },
                                                         new object[] { "马德森机枪", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Madsen MG") },
                                                         new object[] { "MG15 n.A.", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("MG15 n.A.") },
                                                         new object[] { "M1918白朗宁自动步枪", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("BAR M1918") },
                                                         new object[] { "Huot自动步枪", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Huot Automatic") },
                                                         new object[] { "绍沙轻机枪", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Chauchat") },
                                                         new object[] { "Parabellum MG14/17", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Parabellum MG14/17") },
                                                         new object[] { "Perino Mode 1908", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Perino Mode 1908") },
                                                         new object[] { "M1917机枪", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("M1917 MG") },
                                                         new object[] { "轻机枪08/18", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("IMG 08/18") },
                                                         new object[] { "波顿LMR", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Burton LMR") },
                                                         new object[] { "P08 Artillerie", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("P08 Artillerie") },
                                                         new object[] { "皮珀M1893", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Pieper M1893") },
                                                         new object[] { "M1911 Extended", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("M1911 Extended") },
                                                         new object[] { "Mle 1903 Extended", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Mle 1903 Extended") },
                                                         new object[] { "C93 Carbine", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("C93 Carbine") }
                                                    })
                                            },
                                            new object[] {
                                                "副武器",
                                                new GamesDataSet.Game.Arm.EquipmentSet(
                                                    "Assault Secondary Weapon",
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
                                                "投掷武器",
                                                new GamesDataSet.Game.Arm.EquipmentSet(
                                                    "Assault Throwing Weapon",
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
                                            },
                                            new object[] {
                                                "装备",
                                                new GamesDataSet.Game.Arm.EquipmentSet(
                                                    "Assault Equipment",
                                                    new object[][]
                                                    {
                                                        new object[] { "弹药箱", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Ammo Crate") },
                                                        new object[] { "弹药包", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Ammo Pouch") },
                                                        new object[] { "迫击炮-空爆", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Mortar-AIR") },
                                                        new object[] { "迫击炮-高爆", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Mortar-HE") },
                                                        new object[] { "维修工具", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Repair Tools") },
                                                        new object[] { "磁吸地雷", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Limpet Charge") },
                                                        new object[] { "十字弓发射器-高爆", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("CrossBow Launcher-HE") },
                                                        new object[] { "十字弓发射器-破片", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("CrossBow Launcher-FRG") }
                                                    })
                                            },
                                            new object[] {
                                                "特殊武器",
                                                new GamesDataSet.Game.Arm.EquipmentSet(
                                                    "Assault Special Weapon",
                                                    new object[][]
                                                    {
                                                        new object[] { "地图定点武器", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("STATIONARY WEAPON") },
                                                        new object[] { "刀杀", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Knife#") }
                                                    })
                                            }
                                        })


                                 },//支援
                                new object[]
                                {
                                    "侦察兵",
                                    new GamesDataSet.Game.Arm(
                                        "Assault",
                                        new object[][]
                                        {
                                            new object[] {
                                                "主武器",
                                                new GamesDataSet.Game.Arm.EquipmentSet(
                                                    "Assault Main Weapon",
                                                    new object[][]
                                                    {
                                                         new object[] { "Russian 1895", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Russian 1895") },
                                                         new object[] { "Gewehr 98", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Gewehr 98") },
                                                         new object[] { "SMLE MKIII", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("SMLE MKIII") },
                                                         new object[] { "Gewehr M.95", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Gewehr M.95") },
                                                         new object[] { "M1903", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("M1903") },
                                                         new object[] { "马提尼·亨利步枪", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Martini-Henry") },
                                                         new object[] { "阿拉伯的劳伦斯的SMLE ", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Lawrence of Arabia's SMLE") },
                                                         new object[] { "勒贝尔M1886", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Lebel Model 1886") },
                                                         new object[] { "莫辛-纳甘M91", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Mosin-Nagant M91") },
                                                         new object[] { "Vetterli-Vitali M1870/87", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Vetterli-Vitali M1870/87") },
                                                         new object[] { "三八式步枪", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Type 38 Arisaka") },
                                                         new object[] { "卡尔卡诺M91卡宾枪", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Carcano M91") },
                                                         new object[] { "罗斯 MKIII", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Ross MKIII") },
                                                         new object[] { "变种带消音器的那把狙", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("M1917 Enfield") }
                                                    })
                                            },
                                            new object[] {
                                                "副武器",
                                                new GamesDataSet.Game.Arm.EquipmentSet(
                                                    "Assault Secondary Weapon",
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
                                                "投掷武器",
                                                new GamesDataSet.Game.Arm.EquipmentSet(
                                                    "Assault Throwing Weapon",
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
                                            },
                                            new object[] {
                                                "装备",
                                                new GamesDataSet.Game.Arm.EquipmentSet(
                                                    "Assault Equipment",
                                                    new object[][]
                                                    {
                                                        new object[] { "侦察兵装备A", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Assault Equipment A") },
                                                        new object[] { "侦察兵装备B", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Assault Equipment B") }
                                                    })
                                            },
                                            new object[] {
                                                "特殊武器",
                                                new GamesDataSet.Game.Arm.EquipmentSet(
                                                    "Assault Special Weapon",
                                                    new object[][]
                                                    {
                                                        new object[] { "地图定点武器", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("STATIONARY WEAPON") },
                                                        new object[] { "刀杀", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Knife#") }
                                                    })
                                            }
                                        })


                                 },//侦察
                                new object[]
                                {
                                    "驾驶员",
                                    new GamesDataSet.Game.Arm(
                                        "Driver",
                                        new object[][]
                                        {
                                            new object[] {
                                                "载具",
                                                new GamesDataSet.Game.Arm.EquipmentSet(
                                                    "Assault Main Weapon",
                                                    new object[][]
                                                    {
                                                         new object[] { "巡航坦克", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("LANDSHIP") },
                                                         new object[] { "重型坦克", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("HEAVTY TANK") },
                                                         new object[] { "轻型坦克", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("LIGHT TANK") },
                                                         new object[] { "火炮装甲车", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("ARTILLERY TRUCK") },
                                                         new object[] { "攻击坦克", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("ASSAULT TANK") },
                                                         new object[] { "突击装甲车", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("ASSAULT TRUCK") },
                                                         new object[] { "地面载具", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("LAND VEHICLE") },
                                                         new object[] { "船只", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("BOAT") },
                                                         new object[] { "驱逐舰", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("DESTROYER") },
                                                         new object[] { "机械巨兽（坦克）", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Char 2C") },
                                                         new object[] { "机械巨兽（无畏舰）", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Dreadnought") },
                                                         new object[] { "机械巨兽：装甲列车", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Armored Train") },
                                                         new object[] { "地图定点武器", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("STATIONARY WEAPON") }
                                                    })
                                            },
                                            new object[] {
                                                "主武器",
                                                new GamesDataSet.Game.Arm.EquipmentSet(
                                                    "Assault Secondary Weapon",
                                                    new object[][]
                                                    {
                                                         new object[] { "C96 Carbine", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("C96 Carbine") },
                                                         new object[] { "P08 Artillerie", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("P08 Artillerie") },
                                                         new object[] { "皮珀M1893", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Pieper M1893") },
                                                         new object[] { "弗洛梅尔停止手枪", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Frommer Stop Auto") },
                                                         new object[] { "短管散弹枪", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Sawed Off Shotgun") },
                                                         new object[] { "M1911 Extended", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("M1911 Extended") },
                                                         new object[] { "Mle 1903 Extended", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Mle 1903 Extended") },
                                                         new object[] { "C93 Carbine", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("C93 Carbine") }
                                                    })
                                            },
                                            new object[] {
                                                "副武器",
                                                new GamesDataSet.Game.Arm.EquipmentSet(
                                                    "Assault Throwing Weapon",
                                                    new object[][]
                                                    {
                                                         new object[] { "P08手枪", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("P08 Pistol") }
                                                    })
                                            },
                                            new object[] {
                                                "装备",
                                                new GamesDataSet.Game.Arm.EquipmentSet(
                                                    "Assault Equipment",
                                                    new object[][]
                                                    {
                                                         new object[] { "维修工具", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Repair Tools") },
                                                         new object[] { "反坦克手雷", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Anti-Tank Grenade") }
                                                       })
                                            },
                                            new object[] {
                                                "投掷武器",
                                                new GamesDataSet.Game.Arm.EquipmentSet(
                                                    "Assault Special Weapon",
                                                    new object[][]
                                                    {
                                                         new object[] { "木柄手榴弹", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Stick Greenade") }
                                                    })
                                            },
                                            new object[] {
                                                "特殊武器",
                                                new GamesDataSet.Game.Arm.EquipmentSet(
                                                    "Assault Special Weapon",
                                                    new object[][]
                                                    {
                                                        new object[] { "地图定点武器", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("STATIONARY WEAPON") },
                                                        new object[] { "刀杀", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Knife#") }
                                                    })
                                            }
                                        })


                                },//驾驶员
                                new object[]
                                {
                                    "飞行员",
                                    new GamesDataSet.Game.Arm(
                                        "Assault",
                                        new object[][]
                                        {

                                            new object[] {
                                                "载具",
                                                new GamesDataSet.Game.Arm.EquipmentSet(
                                                    "Assault Main Weapon",
                                                    new object[][]
                                                    {
                                                         new object[] { "轰炸机", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("BOMBER") },
                                                         new object[] { "重型轰炸机", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("HEAVY BOMBER") },
                                                         new object[] { "战斗机", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("FIGHTER") },
                                                         new object[] { "攻击机", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("ATTACK PLANE") },
                                                         new object[] { "普通飞艇", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("AIRSHIP") },
                                                         new object[] { "机械巨兽：飞艇", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Airship L30") },
                                                         new object[] { "地图定点武器", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("STATIONARY WEAPON") }
                                                    })
                                            },
                                            new object[] {
                                                "主武器",
                                                new GamesDataSet.Game.Arm.EquipmentSet(
                                                    "Assault Main Weapon",
                                                    new object[][]
                                                    {
                                                         new object[] { "C96 Carbine", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("C96 Carbine") },
                                                         new object[] { "P08 Artillerie", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("P08 Artillerie") },
                                                         new object[] { "皮珀M1893", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Pieper M1893") },
                                                         new object[] { "弗洛梅尔停止手枪", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Frommer Stop Auto") },
                                                         new object[] { "短管散弹枪", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Sawed Off Shotgun") },
                                                         new object[] { "M1911 Extended", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("M1911 Extended") },
                                                         new object[] { "Mle 1903 Extended", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Mle 1903 Extended") },
                                                         new object[] { "C93 Carbine", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("C93 Carbine") }
                                                    })
                                            },
                                            new object[] {
                                                "副武器",
                                                new GamesDataSet.Game.Arm.EquipmentSet(
                                                    "Assault Secondary Weapon",
                                                    new object[][]
                                                    {
                                                        new object[] { "P08手枪", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("P08 Pistol") },
                                                    })
                                            },
                                            new object[] {
                                                "投掷武器",
                                                new GamesDataSet.Game.Arm.EquipmentSet(
                                                    "Assault Throwing Weapon",
                                                    new object[][]
                                                    {
                                                        new object[] { "木柄手榴弹", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Stick Greenade") }
                                                    })
                                            },
                                            new object[] {
                                                "装备",
                                                new GamesDataSet.Game.Arm.EquipmentSet(
                                                    "Assault Equipment",
                                                    new object[][]
                                                    {
                                                        new object[] { "维修工具", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Repair Tools") },
                                                        new object[] { "信号枪-侦察", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Flare Gun-Spot") }
                                                    })
                                            },
                                            new object[] {
                                                "特殊武器",
                                                new GamesDataSet.Game.Arm.EquipmentSet(
                                                    "Assault Special Weapon",
                                                    new object[][]
                                                    {
                                                        new object[] { "地图定点武器", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("STATIONARY WEAPON") },
                                                        new object[] { "刀杀", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Knife#") }
                                                    })
                                            }
                                        })


                                },//飞行员
                                 new object[]
                                {
                                    "骑兵",
                                    new GamesDataSet.Game.Arm(
                                        "Assault",
                                        new object[][]
                                        {

                                              new object[] {
                                                "载具",
                                                new GamesDataSet.Game.Arm.EquipmentSet(
                                                    "Assault Main Weapon",
                                                    new object[][]
                                                    {
                                                        new object[] { "马（践踏）", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("HORSE") }
                                                    })
                                            },
                                            new object[] {
                                                "主武器",
                                                new GamesDataSet.Game.Arm.EquipmentSet(
                                                    "Assault Main Weapon",
                                                    new object[][]
                                                    {
                                                         new object[] { "Russian 1895", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Russian 1895") }
                                                    })
                                            },
                                            new object[] {
                                                "副武器",
                                                new GamesDataSet.Game.Arm.EquipmentSet(
                                                    "Assault Secondary Weapon",
                                                    new object[][]
                                                    {
                                                         new object[] { "P08手枪", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("P08 Pistol") }
                                                    })
                                            },
                                            new object[] {
                                                "投掷武器",
                                                new GamesDataSet.Game.Arm.EquipmentSet(
                                                    "Assault Throwing Weapon",
                                                    new object[][]
                                                    {
                                                         new object[] { "轻型反坦克手雷", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Light Anti-Tank") }
                                                    })
                                            },
                                            new object[] {
                                                "特殊武器",
                                                new GamesDataSet.Game.Arm.EquipmentSet(
                                                    "Assault Special Weapon",
                                                    new object[][]
                                                    {
                                                        new object[] { "骑兵军刀", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Cavalry Sword") },
                                                        new object[] { "骑兵长枪", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Cavalry Lance") },
                                                        new object[] { "地图定点武器", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("STATIONARY WEAPON") },
                                                        new object[] { "刀杀", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Knife#") }
                                                    })
                                            }
                                        })


                                },//骑兵
                                 new object[]
                                {
                                    "精英兵",
                                    new GamesDataSet.Game.Arm(
                                        "Assault",
                                        new object[][]
                                        {
                                            new object[] {
                                                "主武器",
                                                new GamesDataSet.Game.Arm.EquipmentSet(
                                                    "Assault Main Weapon",
                                                    new object[][]
                                                    {
                                                         new object[] { "坦克猎手", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("tankgewehr M1918") },
                                                         new object[] { "火焰喷射器", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Wex") },
                                                         new object[] { "哨兵机枪", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Mg 08/15") },
                                                         new object[] { "维拉·佩罗隆冲锋枪", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Villar Perosa") },
                                                         new object[] { "奇兵棒", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Raider Club") },
                                                         new object[] { "3号左轮手枪", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("No.3 Revolver") },
                                                         new object[] { "短管散弹枪", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Sawed Off Shotgun") }
                                                    })
                                            },
                                            new object[] {
                                                "投掷武器",
                                                new GamesDataSet.Game.Arm.EquipmentSet(
                                                    "Assault Throwing Weapon",
                                                    new object[][]
                                                    {
                                                         new object[] { "破片手榴弹", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Frag Grenade") },
                                                         new object[] { "木柄手榴弹", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Stick Grenade") },
                                                         new object[] { "毒气手榴弹", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Gas Grenade") },
                                                         new object[] { "冲击手榴弹", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Impact Grenade") },
                                                         new object[] { "燃烧手榴弹", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Incendiary Grenade") },
                                                         new object[] { "小型手榴弹", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Mini Grenade") },
                                                         new object[] { "烟雾手榴弹", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Smoke Grenade") },
                                                         new object[] { "轻型反坦克手榴弹", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Light Anti-Tank Grenade") },
                                                         new object[] { "土制手榴弹", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Improvised Grenade") }
                                                    })
                                            },
                                            new object[] {
                                                "突击兵特殊武器",
                                                new GamesDataSet.Game.Arm.EquipmentSet(
                                                    "Assault Special Weapon",
                                                    new object[][]
                                                    {
                                                        new object[] { "地图定点武器", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("STATIONARY WEAPON") },
                                                        new object[] { "刀杀", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Knife#") }
                                                    })
                                            }
                                        })


                                }//精英兵


                            },//兵种列表
                            new object[][]
                            {
                                new object[]{"透视",new GamesDataSet.Game.CheckType("Wall Hack") },
                                new object[]{"自瞄",new GamesDataSet.Game.CheckType("Aimbot") },
                                new object[]{"改伤",new GamesDataSet.Game.CheckType("Damage hacked") },
                                new object[]{"隐身",new GamesDataSet.Game.CheckType("Invisible") },
                                new object[]{"子弹穿墙",new GamesDataSet.Game.CheckType("Bullet penetration hack") },
                                new object[]{ "一枪秒杀", new GamesDataSet.Game.CheckType("One shot kill in every range without a headshot") },
                                new object[]{"全图索敌",new GamesDataSet.Game.CheckType("WallHack") }
                            }//作弊列表
                            
                            )
                    },//战地1
                    new object[]
                    {
                        "战地V",
                        new GamesDataSet.Game(
                            "BF V",
                            new object[][]
                            {

                                 new object[] { "钢铁熔炉", new GamesDataSet.Game.Map("TWISTED STEEL") },
                                 new object[] { "阿拉斯", new GamesDataSet.Game.Map("ARRAS") },
                                 new object[] { "鹿特丹", new GamesDataSet.Game.Map("ROTTERDAM") },
                                 new object[] { "毁灭", new GamesDataSet.Game.Map("DEVASTATION") },
                                 new object[] { "岩漠", new GamesDataSet.Game.Map("HAMADA") },
                                 new object[] { "小型飞行场", new GamesDataSet.Game.Map("AERODROME") },
                                 new object[] { "纳尔维克", new GamesDataSet.Game.Map("NARVIK") },
                                 new object[] { "菲耶尔652(雪山)", new GamesDataSet.Game.Map("FJELL 652") },
                                 new object[] { "战车风暴", new GamesDataSet.Game.Map("PANZERSTORM") }
                            },//地图
                            new object[][]{
                                new object[]
                                {
                                    "医疗兵",
                                    new GamesDataSet.Game.Arm(
                                        "Medic",
                                        new object[][]
                                        {
                                            new object[] {
                                                "主武器",
                                                new GamesDataSet.Game.Arm.EquipmentSet(
                                                    "Medic Main Weapon",
                                                    new object[][]
                                                    {
                                                         new object[] { "斯登冲锋枪", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("STEN") },
                                                         new object[] { "索米 KP/-31冲锋枪", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Suomi KP/-31") },
                                                         new object[] { "MP40冲锋枪", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("MP40") },
                                                         new object[] { "MP28冲锋枪", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("MP28") },
                                                         new object[] { "埃尔马冲锋枪", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("EMP") },
                                                         new object[] { "MP34冲锋枪", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("MP34") },
                                                         new object[] { "M1928A1冲锋枪", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("M1928A1") }
                                                    })
                                            },
                                            new object[] {
                                                "副武器",
                                                new GamesDataSet.Game.Arm.EquipmentSet(
                                                    "Medic Secondary Weapon",
                                                    new object[][]
                                                    {
                                                         new object[] { "P38 手枪", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("P38 Pistol") },
                                                         new object[] { "红宝石手枪", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Ruby") },
                                                         new object[] { "M1911手枪", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("M1911") },
                                                         new object[] { "P08手枪", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("P08 Pistol") },
                                                         new object[] { "Repetierpistole M1912手枪", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Repetierpistole M1912") },
                                                         new object[] { "Mk VI左轮手枪", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Mk VI Revolver") },
                                                         new object[] { "解放者手枪", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Liberator") }
                                                    })
                                            },
                                            new object[] {
                                                "装备",
                                                new GamesDataSet.Game.Arm.EquipmentSet(
                                                    "Medic Equipment",
                                                    new object[][]
                                                    {
                                                         new object[] { "破片手榴弹", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Frag Grenade") },
                                                         new object[] { "烟雾手榴弹", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Smoke Grenade") },
                                                         new object[] { "燃烧手榴弹", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Incendiary Grenade") },
                                                         new object[] { "绷带包", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Bandages") },
                                                         new object[] { "医疗箱", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Medical Crate") },
                                                         new object[] { "烟雾榴弹步枪", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Smoke Grenade Rifle") },
                                                         new object[] { "反人员地雷", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("AP Mine") }
                                                    })
                                            },
                                            new object[] {
                                                "特殊武器",
                                                new GamesDataSet.Game.Arm.EquipmentSet(
                                                    "Medic Special Weapon",
                                                    new object[][]
                                                    {
                                                        new object[] { "地图定点武器", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("STATIONARY WEAPON") },
                                                        new object[] { "刀杀", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Knife#") }
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
                                                "主武器",
                                                new GamesDataSet.Game.Arm.EquipmentSet(
                                                    "Assault Main Weapon",
                                                    new object[][]
                                                    {
                                                        new object[] { "Sturmgewehr 1-5步枪", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Sturmgewehr 1-5") },
                                                        new object[] { "Gewehr 43步枪", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Gewehr 43") },
                                                        new object[] { "M1A1卡宾枪", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("M1A1 Carbine") },
                                                        new object[] { "M1907 SF步枪", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("M1907 SF") },
                                                        new object[] { "特纳式SMLE步枪", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Turner SMLE") },
                                                        new object[] { "StG44步枪", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("StG 44") },
                                                        new object[] { "SELBSTLADER 1916步枪", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("SELBSTLADER 1916") },
                                                        new object[] { "Gewehr 1-5步枪", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Gewehr 1-5") }
                                                    })
                                            },
                                            new object[] {
                                                "副武器",
                                                new GamesDataSet.Game.Arm.EquipmentSet(
                                                    "Assault Secondary Weapon",
                                                    new object[][]
                                                    {
                                                         new object[] { "P38 手枪", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("P38 Pistol") },
                                                         new object[] { "红宝石手枪", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Ruby") },
                                                         new object[] { "M1911手枪", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("M1911") },
                                                         new object[] { "P08手枪", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("P08 Pistol") },
                                                         new object[] { "Repetierpistole M1912手枪", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Repetierpistole M1912") },
                                                         new object[] { "Mk VI左轮手枪", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Mk VI Revolver") },
                                                         new object[] { "解放者手枪", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Liberator") }
                                                    })
                                            },

                                            new object[] {
                                                "突击兵装备",
                                                new GamesDataSet.Game.Arm.EquipmentSet(
                                                    "Assault Equipment",
                                                    new object[][]
                                                    {
                                                        new object[] { "破片手榴弹", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Frag Grenade") },
                                                        new object[] { "燃烧手榴弹", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Incendiary Grenade") },
                                                        new object[] { "反坦克集束榴弹", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Anti-Tank Bundle Grenade") },
                                                        new object[] { "反坦克榴弹发射器", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Panzerfaust") },
                                                        new object[] { "PIAT", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("PITA") },
                                                        new object[] { "粘性炸药", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Sticky Dynamite") },
                                                        new object[] { "破片榴弹步枪", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Frag Grenade Rifle") },
                                                        new object[] { "反坦克地雷", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("AT Mine") }

                                                    })
                                            },
                                            new object[] {
                                                "突击兵特殊武器",
                                                new GamesDataSet.Game.Arm.EquipmentSet(
                                                    "Assault Special Weapon",
                                                    new object[][]
                                                    {
                                                        new object[] { "地图定点武器", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("STATIONARY WEAPON") },
                                                        new object[] { "刀杀", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Knife#") }
                                                    })
                                            }
                                        })
                                },
                                new object[]
                                {
                                    "支援兵",
                                    new GamesDataSet.Game.Arm(
                                        "Support",
                                        new object[][]
                                        {
                                            new object[] {
                                                "主武器",
                                                new GamesDataSet.Game.Arm.EquipmentSet(
                                                    "Main Weapon",
                                                    new object[][]
                                                    {
                                                         new object[] { "拉利轻机枪", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("KE7") },
                                                         new object[] { "MG 34机枪", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("MG 34") },
                                                         new object[] { "12g自动散弹枪", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("12g Automatic") },
                                                         new object[] { "布伦轻机枪", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Bren Gun") },
                                                         new object[] { "路易士轻机枪", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Lewis Gun") },
                                                         new object[] { "M30 Drilling散弹枪", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("M30 Drilling") },
                                                         new object[] { "FG-42伞兵轻机枪", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("FG-42") },
                                                         new object[] { "MG-42机枪", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("MG-42") }
                                                    })
                                            },
                                            new object[] {
                                                "副武器",
                                                new GamesDataSet.Game.Arm.EquipmentSet(
                                                    "Secondary Weapon",
                                                    new object[][]
                                                    {
                                                         new object[] { "P38 手枪", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("P38 Pistol") },
                                                         new object[] { "红宝石手枪", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Ruby") },
                                                         new object[] { "M1911手枪", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("M1911") },
                                                         new object[] { "P08手枪", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("P08 Pistol") },
                                                         new object[] { "Repetierpistole M1912手枪", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Repetierpistole M1912") },
                                                         new object[] { "Mk VI左轮手枪", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Mk VI Revolver") },
                                                         new object[] { "解放者手枪", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Liberator") }
                                                    })
                                            },
                                            new object[] {
                                                "装备",
                                                new GamesDataSet.Game.Arm.EquipmentSet(
                                                    "Equipment",
                                                    new object[][]
                                                    {
                                                         new object[] { "燃烧手榴弹", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Incendiary Grenade") },
                                                         new object[] { "冲击手榴弹", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Impact Grenade") },
                                                         new object[] { "粘性手榴弹", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Sticky Grenade") },
                                                         new object[] { "弹药包", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Ammo Pouch") },
                                                         new object[] { "弹药箱", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Ammo Crate") },
                                                         new object[] { "反坦克地雷", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("AT Mine") },
                                                         new object[] { "反坦克榴弹手枪", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("AT Grenade Pistol") },
                                                         new object[] { "反人员地雷", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("AP Mine") }
                                                    })
                                            },
                                            new object[] {
                                                "特殊武器",
                                                new GamesDataSet.Game.Arm.EquipmentSet(
                                                    "Assault Special Weapon",
                                                    new object[][]
                                                    {
                                                        new object[] { "地图定点武器", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("STATIONARY WEAPON") },
                                                        new object[] { "刀杀", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Knife#") }
                                                    })
                                            }
                                        })
                                },
                                new object[]
                                {
                                    "侦察兵",
                                    new GamesDataSet.Game.Arm(
                                        "Recon",
                                        new object[][]
                                        {
                                            new object[] {
                                                "主武器",
                                                new GamesDataSet.Game.Arm.EquipmentSet(
                                                    "Main Weapon",
                                                    new object[][]
                                                    {
                                                         new object[] { "李-恩菲尔德No.4Mk I步枪", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Lee-Enfield No.4 Mk I") },
                                                         new object[] { "Model 8 半自动步枪", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Model 8") },
                                                         new object[] { "GewehrM95/30步枪", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Gewehr M95/30") },
                                                         new object[] { "ZH-29步枪", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("ZH-29") },
                                                         new object[] { "克拉格-乔根森步枪", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Krag-Jorgensen") },
                                                         new object[] { "RSC半自动步枪", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("RSC") },
                                                         new object[] { "Kar98k步枪", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Kar98K") }
                                                    })
                                            },
                                            new object[] {
                                                "副武器",
                                                new GamesDataSet.Game.Arm.EquipmentSet(
                                                    "Secondary Weapon",
                                                    new object[][]
                                                    {
                                                         new object[] { "P38 手枪", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("P38 Pistol") },
                                                         new object[] { "红宝石手枪", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Ruby") },
                                                         new object[] { "M1911手枪", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("M1911") },
                                                         new object[] { "P08手枪", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("P08 Pistol") },
                                                         new object[] { "Repetierpistole M1912手枪", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Repetierpistole M1912") },
                                                         new object[] { "Mk VI左轮手枪", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Mk VI Revolver") },
                                                         new object[] { "解放者手枪", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Liberator") }
                                                    })
                                            },
                                            new object[] {
                                                "装备",
                                                new GamesDataSet.Game.Arm.EquipmentSet(
                                                    "Equipment",
                                                    new object[][]
                                                    {
                                                         new object[] { "破片手榴弹", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Frag Grenade") },
                                                         new object[] { "烟雾手榴弹", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Smoke Grenade") },
                                                         new object[] { "飞刀", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Throwing Knife") },
                                                         new object[] { "索敌望远镜", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Spotting Scope") },
                                                         new object[] { "信号枪", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Flare Gun") },
                                                         new object[] { "反人员地雷", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("AP Mine") },
                                                         new object[] { "重生信标", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Spawn Beacon") },
                                                         new object[] { "狙击手诱饵", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Sniper Decoy") }
                                                    })
                                            },
                                            new object[] {
                                                "特殊武器",
                                                new GamesDataSet.Game.Arm.EquipmentSet(
                                                    "Special Weapon",
                                                    new object[][]
                                                    {
                                                        new object[] { "地图定点武器", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("STATIONARY WEAPON") },
                                                        new object[] { "刀杀", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("Knife#") }
                                                    })
                                            }
                                        })
                                },
                                new object[]
                                {
                                    "驾驶员",
                                    new GamesDataSet.Game.Arm(
                                        "Assault",
                                        new object[][]
                                        {
                                            new object[] {
                                                "载具",
                                                new GamesDataSet.Game.Arm.EquipmentSet(
                                                    "Assault Main Weapon",
                                                    new object[][]
                                                    {
                                                        new object[] { "四号坦克", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("PANZER IV") },
                                                        new object[] { "T-38坦克", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("PANZER 38T") },
                                                        new object[] { "虎I坦克", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("TIGER I") },
                                                        new object[] { "四号防空战车", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("FLAKPANZER IV") }
                                                    })
                                            },
                                        })
                                },
                                new object[]
                                {
                                    "飞行员",
                                    new GamesDataSet.Game.Arm(
                                        "Assault",
                                        new object[][]
                                        {
                                            new object[] {
                                                "载具",
                                                new GamesDataSet.Game.Arm.EquipmentSet(
                                                    "Assault Main Weapon",
                                                    new object[][]
                                                    {
                                                        new object[] { "BF 109G-2", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("BF 109G-2") },
                                                        new object[] { "BF 109G-6", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("BF 109G-6") },
                                                        new object[] { "B-1 斯图卡轰炸机", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("STUKA B-1") },
                                                        new object[] { "B-2 斯图卡轰炸机", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("STUKA B-2") },
                                                        new object[] { "JU-88 A 轰炸机", new GamesDataSet.Game.Arm.EquipmentSet.Equipment("JU-88") }
                                                    })

                                            },
                                        })
                                }
                            },//兵种
                            new object[][]
                            {
                                 new object[]{"透视",new GamesDataSet.Game.CheckType("WallHack") },
                                new object[]{"自瞄",new GamesDataSet.Game.CheckType("Aimbot") },
                                new object[]{"改伤",new GamesDataSet.Game.CheckType("Change weapon's damage") },
                                //new object[]{"隐身",new GamesDataSet.Game.CheckType("Invisible") },
                               // new object[]{"子弹穿墙",new GamesDataSet.Game.CheckType("Bullet penetration hack") },
                              //  new object[]{ "一枪秒杀", new GamesDataSet.Game.CheckType("One shot kill in every range without a headshot") },
                               // new object[]{"全图索敌",new GamesDataSet.Game.CheckType("WallHack") }
                            }//作弊选项

                            )
                    }
                });
            Data = gamesDataSet;

            Console.WriteLine("名称访问测试:");
            Console.WriteLine(string.Format("战地1 - {0}", gamesDataSet.Games["战地1"]));
            Console.WriteLine(string.Format("战地1医疗兵 - {0}", gamesDataSet.Games["战地1"].Arms["医疗兵"]));
            Console.WriteLine(string.Format("战地1医疗兵主武器 - {0}", gamesDataSet.Games["战地1"].Arms["医疗兵"].EquipmentSets["主武器"]));
            Console.WriteLine(string.Format("战地1医疗兵主武器A - {0}", gamesDataSet.Games["战地1"].Arms["医疗兵"].EquipmentSets["主武器"].Equipments["蒙德拉贡"]));
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
            foreach (KeyValuePair<string, GamesDataSet.Game.Arm.EquipmentSet.Equipment> equipment in gamesDataSet.Games["战地V"].Arms["医疗兵"].EquipmentSets["主武器"].Equipments)
            {
                Console.WriteLine(string.Format("{0} - {1}", equipment.Key, equipment.Value));
            }
        }
    }
}
