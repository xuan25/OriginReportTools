using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace OriginReportTools
{
    [Serializable]
    class ChEnData
    {
        public Game BF1 = new Game();
        public Game BFV = new Game();
        public Game APEX = new Game();
        public ChEnData()
        {
            BF1.Name = new EnCh("BF 1", "战地1");                          //创建游戏名字

            BF1.CheatCheckBox.Add(new EnCh("WallHack", "透视"));      //创建该游戏下的作弊列表
            BF1.CheatCheckBox.Add(new EnCh("Aimbot", "自瞄"));
            BF1.CheatCheckBox.Add(new EnCh("Change weapon's damage", "修改伤害"));
            BF1.CheatCheckBox.Add(new EnCh("Invisible", "隐身"));

            GameClass Medic = new GameClass(new EnCh("Medic", "医疗兵"));  //创建该游戏下的兵种分类WeaponClass

            Medic.WeaponClassList.Add(new WeaponClass("主武器"));
            Medic.WeaponClassList[0].List.Add(new EnCh("Cei-Rigotti", "Cei-Rigotti"));
            Medic.WeaponClassList[0].List.Add(new EnCh("Selbstlader M1916", "Selbstlader M1916"));
            //Medic.WeaponClassList[0].List.Add(new EnCh("M1907 SL", "M1907半自动步枪"));
            //Medic.WeaponClassList[0].List.Add(new EnCh("Mondragon", "蒙德拉贡"));
            //Medic.WeaponClassList[0].List.Add(new EnCh("Autoloading 8.35", "自动装填步枪8.35"));
            //Medic.WeaponClassList[0].List.Add(new EnCh("Selbstlader 1906", "Selbstlader 1906"));
            //Medic.WeaponClassList[0].List.Add(new EnCh("RSC 1917", "RSC 1917 "));
            //Medic.WeaponClassList[0].List.Add(new EnCh("Fedorov Avtomat", "菲德洛夫自动步枪"));
            //Medic.WeaponClassList[0].List.Add(new EnCh("General Liu Rifle", "刘将军步枪"));
            //Medic.WeaponClassList[0].List.Add(new EnCh("Farquhar-Hill", "Farquhar-Hill步枪"));
            //Medic.WeaponClassList[0].List.Add(new EnCh("Howell Automatic", "Howell 自动步枪"));
            //Medic.WeaponClassList.Add(new WeaponClass("副武器"));
            //Medic.WeaponClassList[1].List.Add(new EnCh("M1911", "M1911"));
            //Medic.WeaponClassList[1].List.Add(new EnCh("P08 Pistol", "P08 Pistol"));
            //Medic.WeaponClassList[1].List.Add(new EnCh("Mle 1903", "Mle 1903"));
            //Medic.WeaponClassList[1].List.Add(new EnCh("C93", "C93"));
            //Medic.WeaponClassList[1].List.Add(new EnCh("No.3 Revolver", "No.3 Revolver"));
            //Medic.WeaponClassList[1].List.Add(new EnCh("Kolibri", "蜂鸟手枪（娘娘枪）"));
            //Medic.WeaponClassList[1].List.Add(new EnCh("Nagant Revolver", "Nagant Revolver"));
            //Medic.WeaponClassList[1].List.Add(new EnCh("Obrez Pistol", "Obrez手枪 "));
            //Medic.WeaponClassList[1].List.Add(new EnCh("Revolver MK VI", "MK VI左轮手枪"));
            //Medic.WeaponClassList[1].List.Add(new EnCh("Auto Revolver", "Auto Revolver"));
            //Medic.WeaponClassList[1].List.Add(new EnCh("C96", "C96"));
            //Medic.WeaponClassList[1].List.Add(new EnCh("Taschenpistole M1914", "Taschenpistole M1914"));
            //Medic.WeaponClassList[1].List.Add(new EnCh("Hellfighter M1911", "地狱战士M1911"));
            //Medic.WeaponClassList[1].List.Add(new EnCh("Red Barn's P08", "红男爵的P08"));
            //Medic.WeaponClassList[1].List.Add(new EnCh("M1911 Silencer", "M1911消音版"));
            //Medic.WeaponClassList.Add(new WeaponClass("投掷武器"));
            //Medic.WeaponClassList[2].List.Add(new EnCh("Stick Grenade", "木柄手榴弹"));
            //Medic.WeaponClassList[2].List.Add(new EnCh("Gas Grenade", "毒气手榴弹"));
            //Medic.WeaponClassList[2].List.Add(new EnCh("Impact Grenade", "冲击手榴弹"));
            //Medic.WeaponClassList[2].List.Add(new EnCh("Incendiary Grenade", "燃烧手榴弹"));
            //Medic.WeaponClassList[2].List.Add(new EnCh("Mini Grenade", "小型手榴弹"));
            //Medic.WeaponClassList[2].List.Add(new EnCh("Smoke Grenade", "烟雾手榴弹"));
            //Medic.WeaponClassList[2].List.Add(new EnCh("Light Anti-Tank Grenade", "轻型反坦克手榴弹"));
            //Medic.WeaponClassList[2].List.Add(new EnCh("Improvised Grenade", "土制手榴弹"));
            //Medic.WeaponClassList.Add(new WeaponClass("装备"));
            //Medic.WeaponClassList[3].List.Add(new EnCh("Medical Syringe", "医疗用针筒"));
            //Medic.WeaponClassList[3].List.Add(new EnCh("Medical Crate", "医疗箱"));
            //Medic.WeaponClassList[3].List.Add(new EnCh("Bandage Pouch", "医疗包"));
            //Medic.WeaponClassList[3].List.Add(new EnCh("Rifle Grenade-FRG", "步枪手榴弹-破片"));
            //Medic.WeaponClassList[3].List.Add(new EnCh("Rifle Grenade-SMK", "步枪手榴弹-烟雾"));
            //Medic.WeaponClassList[3].List.Add(new EnCh("Rifle Grenade-HE", "步枪手榴弹-高爆"));
            //Medic.WeaponClassList.Add(new WeaponClass("特殊武器"));
            //Medic.WeaponClassList[4].List.Add(new EnCh("STATIONARY WEAPON", "地图定点武器"));
            //Medic.WeaponClassList[4].List.Add(new EnCh("Knife", "刀杀"));

            GameClass Assault = new GameClass(new EnCh("Assault", "突击兵"));//覆盖其他兵种  
            Assault.WeaponClassList.Add(new WeaponClass("主武器"));
            Assault.WeaponClassList[0].List.Add(new EnCh("Model 10-A", "Model 10-A"));
            //Assault.WeaponClassList[0].List.Add(new EnCh("M97 Trench Gun", "M97战壕枪"));
            //Assault.WeaponClassList[0].List.Add(new EnCh("MP 18", "MP 18"));
            //Assault.WeaponClassList[0].List.Add(new EnCh("Automatico M1918", "M918自动冲锋枪"));
            //Assault.WeaponClassList[0].List.Add(new EnCh("12g Automatic", "12g 自动散弹枪"));
            //Assault.WeaponClassList[0].List.Add(new EnCh("Hellriegel 1915", "Hellriegel 1915"));
            //Assault.WeaponClassList[0].List.Add(new EnCh("Hellfighter Trench", "地狱战士战壕散弹枪"));
            //Assault.WeaponClassList[0].List.Add(new EnCh("Sjogren Inertial", "Sjogren Inertial "));
            //Assault.WeaponClassList[0].List.Add(new EnCh("Ribeyrolles 1918", "利贝罗勒 1918"));
            //Assault.WeaponClassList[0].List.Add(new EnCh("Moedl 1900", "Moedl 1900"));
            //Assault.WeaponClassList[0].List.Add(new EnCh("SMG 08/18", "SMG 08/18"));
            //Assault.WeaponClassList[0].List.Add(new EnCh("Maschinepistole M1912/P.16", "Maschinepistole M1912/P.16"));
            //Assault.WeaponClassList[0].List.Add(new EnCh("M1917", "M1917卡宾枪"));
            //Assault.WeaponClassList[0].List.Add(new EnCh("RSC SMG", "RSC 冲锋枪"));
            //Assault.WeaponClassList[0].List.Add(new EnCh("Annihilator", "Annihilator"));
            //Assault.WeaponClassList[0].List.Add(new EnCh("Frommer Stop Auto", "弗洛梅尔停止手枪"));
            //Assault.WeaponClassList[0].List.Add(new EnCh("Sawed Off Shotgun", "短管散弹枪"));
            //Assault.WeaponClassList.Add(Medic.WeaponClassList[1]);
            //Assault.WeaponClassList.Add(Medic.WeaponClassList[2]);
            //Assault.WeaponClassList.Add(new WeaponClass("装备"));
            //Assault.WeaponClassList[3].List.Add(new EnCh("Dynamite", "炸药"));
            //Assault.WeaponClassList[3].List.Add(new EnCh("Anti-Tank Grenade", "反坦克手雷"));
            //Assault.WeaponClassList[3].List.Add(new EnCh("Anti-Tank Mine", "反坦克地雷"));
            //Assault.WeaponClassList[3].List.Add(new EnCh("AT Rocket Gun", "反坦克火箭炮"));
            //Assault.WeaponClassList[3].List.Add(new EnCh("AA Rocket Gun", "防空火箭炮"));
            //Assault.WeaponClassList.Add(Medic.WeaponClassList[4]);

            //GameClass Scout = new GameClass(new EnCh("Assault", "侦察兵"));
            //Scout.WeaponClassList.Add(new WeaponClass("主武器"));
            //Scout.WeaponClassList.Add(Medic.WeaponClassList[1]);
            //Scout.WeaponClassList.Add(Medic.WeaponClassList[2]);
            //Scout.WeaponClassList.Add(new WeaponClass("装备"));
            //Scout.WeaponClassList.Add(Medic.WeaponClassList[4]);

            //GameClass Support = new GameClass(new EnCh("Support", "支援兵"));
            //Support.WeaponClassList.Add(new WeaponClass("主武器"));
            //Support.WeaponClassList[0].List.Add(new EnCh("Lewis Gun", "路易士机枪"));
            //Support.WeaponClassList[0].List.Add(new EnCh("M1909 Benet-Mercie", "M1909贝内特·梅西耶机枪"));
            //Support.WeaponClassList[0].List.Add(new EnCh("Madsen MG", "马德森机枪"));
            //Support.WeaponClassList[0].List.Add(new EnCh("MG15 n.A.", "MG15 n.A."));
            //Support.WeaponClassList[0].List.Add(new EnCh("BAR M1918", "M1918白朗宁自动步枪"));
            //Support.WeaponClassList[0].List.Add(new EnCh("Huot Automatic", "Huot自动步枪"));
            //Support.WeaponClassList[0].List.Add(new EnCh("Chauchat", "绍沙轻机枪"));
            //Support.WeaponClassList[0].List.Add(new EnCh("Parabellum MG14/17", "Parabellum MG14/17"));
            //Support.WeaponClassList[0].List.Add(new EnCh("Parabellum MG14/17", "Parabellum MG14/17"));
            //Support.WeaponClassList[0].List.Add(new EnCh("M1917 MG", "M1917机枪"));
            //Support.WeaponClassList[0].List.Add(new EnCh("IMG 08/18", "轻机枪08/18"));
            //Support.WeaponClassList[0].List.Add(new EnCh("Burton LMR", "波顿LMR"));
            //Support.WeaponClassList[0].List.Add(new EnCh("P08 Artillerie", "P08 Artillerie"));
            //Support.WeaponClassList[0].List.Add(new EnCh("Pieper M1893", "皮珀M1893"));
            //Support.WeaponClassList[0].List.Add(new EnCh("M1911 Extended", "M1911 Extended"));
            //Support.WeaponClassList[0].List.Add(new EnCh("Mle 1903 Extended", "Mle 1903 Extended"));
            //Support.WeaponClassList[0].List.Add(new EnCh("C93 Carbine", "C93 Carbine"));
            //Support.WeaponClassList.Add(Medic.WeaponClassList[1]);
            //Support.WeaponClassList.Add(Medic.WeaponClassList[2]);
            //Support.WeaponClassList.Add(new WeaponClass("装备"));
            //Support.WeaponClassList[3].List.Add(new EnCh("Ammo Crate", "弹药箱"));
            //Support.WeaponClassList[3].List.Add(new EnCh("Ammo Pouch", "弹药包"));
            //Support.WeaponClassList[3].List.Add(new EnCh("Mortar-AIR", "迫击炮-空爆"));
            //Support.WeaponClassList[3].List.Add(new EnCh("Mortar-HE", "迫击炮-高爆"));
            //Support.WeaponClassList[3].List.Add(new EnCh("Repair Tools", "维修工具"));
            //Support.WeaponClassList[3].List.Add(new EnCh("Limpet Charge", "磁吸地雷"));
            //Support.WeaponClassList[3].List.Add(new EnCh("CrossBow Launcher-HE", "十字弓发射器-高爆"));
            //Support.WeaponClassList[3].List.Add(new EnCh("CrossBow Launcher-FRG", "十字弓发射器-破片"));
            //Support.WeaponClassList.Add(Medic.WeaponClassList[4]);

            //GameClass Driver = new GameClass(new EnCh("Driver", "驾驶员"));
            //Driver.WeaponClassList.Add(new WeaponClass("载具"));
            //Driver.WeaponClassList[0].List.Add(new EnCh("LANDSHIP", "巡航坦克"));
            //Driver.WeaponClassList[0].List.Add(new EnCh("HEAVTY TANK", "重型坦克"));
            //Driver.WeaponClassList[0].List.Add(new EnCh("LIGHT TANK", "轻型坦克"));
            //Driver.WeaponClassList[0].List.Add(new EnCh("ARTILLERY TRUCK", "火炮装甲车"));
            //Driver.WeaponClassList[0].List.Add(new EnCh("ASSAULT TANK", "攻击坦克"));
            //Driver.WeaponClassList[0].List.Add(new EnCh("ASSAULT TRUCK", "突击装甲车"));
            //Driver.WeaponClassList[0].List.Add(new EnCh("LAND VEHICLE", "地面载具"));
            //Driver.WeaponClassList[0].List.Add(new EnCh("BOAT", "船只"));
            //Driver.WeaponClassList[0].List.Add(new EnCh("DESTROYER", "驱逐舰"));
            //Driver.WeaponClassList[0].List.Add(new EnCh("Char 2C", "机械巨兽（坦克）"));
            //Driver.WeaponClassList[0].List.Add(new EnCh("Dreadnought", "机械巨兽（无畏舰）"));
            //Driver.WeaponClassList[0].List.Add(new EnCh("Armored Train", "机械巨兽：装甲列车"));
            //Driver.WeaponClassList[0].List.Add(new EnCh("STATIONARY WEAPON", "地图定点武器"));
            //Driver.WeaponClassList.Add(new WeaponClass("主武器"));
            //Driver.WeaponClassList[1].List.Add(new EnCh("C96 Carbine", "C96 Carbine"));
            //Driver.WeaponClassList[1].List.Add(new EnCh("P08 Artillerie", "P08 Artillerie"));
            //Driver.WeaponClassList[1].List.Add(new EnCh("Pieper M1893", "皮珀M1893"));
            //Driver.WeaponClassList[1].List.Add(new EnCh("Frommer Stop Auto", "弗洛梅尔停止手枪"));
            //Driver.WeaponClassList[1].List.Add(new EnCh("Sawed Off Shotgun", "短管散弹枪"));
            //Driver.WeaponClassList[1].List.Add(new EnCh("M1911 Extended", "M1911 Extended"));
            //Driver.WeaponClassList[1].List.Add(new EnCh("Mle 1903 Extended", "Mle 1903 Extended"));
            //Driver.WeaponClassList[1].List.Add(new EnCh("C93 Carbine", "C93 Carbine"));
            //Driver.WeaponClassList.Add(new WeaponClass("副武器"));
            //Driver.WeaponClassList[2].List.Add(new EnCh("P08 Pistol", "P08手枪"));
            //Driver.WeaponClassList.Add(new WeaponClass("投掷武器"));
            //Driver.WeaponClassList[3].List.Add(new EnCh("Repair Tools", "维修工具"));
            //Driver.WeaponClassList[3].List.Add(new EnCh("Anti-Tank Grenade", "反坦克手雷"));
            //Driver.WeaponClassList.Add(new WeaponClass("装备"));
            //Driver.WeaponClassList[4].List.Add(new EnCh("Stick Greenade", "木柄手榴弹"));
            //Driver.WeaponClassList.Add(Medic.WeaponClassList[4]);


            //GameClass Cavalry = new GameClass(new EnCh("Cavalry", "骑兵"));
            //Cavalry.WeaponClassList.Add(new WeaponClass("载具"));
            //Cavalry.WeaponClassList.Add(new WeaponClass("主武器"));
            //Cavalry.WeaponClassList.Add(new WeaponClass("副武器"));
            //Cavalry.WeaponClassList.Add(new WeaponClass("投掷武器"));
            //Cavalry.WeaponClassList.Add(new WeaponClass("装备"));
            //Cavalry.WeaponClassList.Add(Medic.WeaponClassList[4]);



            //GameClass Pilot = new GameClass(new EnCh("Pilot", "飞行员兵"));
            //Pilot.WeaponClassList.Add(new WeaponClass("载具"));
            //Pilot.WeaponClassList[0].List.Add(new EnCh("BOMBER","轰炸机"));
            //Pilot.WeaponClassList[0].List.Add(new EnCh("HEAVY BOMBER","重型轰炸机"));
            //Pilot.WeaponClassList[0].List.Add(new EnCh("FIGHTER","战斗机"));
            //Pilot.WeaponClassList[0].List.Add(new EnCh("ATTACK PLANE","攻击机"));
            //Pilot.WeaponClassList[0].List.Add(new EnCh("AIRSHIP","普通飞艇"));
            //Pilot.WeaponClassList[0].List.Add(new EnCh("Airship L30","机械巨兽：飞艇"));
            //Pilot.WeaponClassList[0].List.Add(new EnCh("STATIONARY WEAPON","地图定点武器"));
            //Pilot.WeaponClassList.Add(new WeaponClass("主武器"));
            //Pilot.WeaponClassList[1].List.Add(new EnCh("C96 Carbine","C96 Carbine"));
            //Pilot.WeaponClassList[1].List.Add(new EnCh("P08 Artillerie","P08 Artillerie"));
            //Pilot.WeaponClassList[1].List.Add(new EnCh("Pieper M1893","皮珀M1893"));
            //Pilot.WeaponClassList[1].List.Add(new EnCh("Frommer Stop Auto","弗洛梅尔停止手枪"));
            //Pilot.WeaponClassList[1].List.Add(new EnCh("Sawed Off Shotgun","短管散弹枪"));
            //Pilot.WeaponClassList[1].List.Add(new EnCh("M1911 Extended","M1911 Extended"));
            //Pilot.WeaponClassList[1].List.Add(new EnCh("Mle 1903 Extended","Mle 1903 Extended"));
            //Pilot.WeaponClassList[1].List.Add(new EnCh("C93 Carbine","C93 Carbine"));
            //Pilot.WeaponClassList.Add(new WeaponClass("副武器"));
            //Pilot.WeaponClassList[2].List.Add(new EnCh("P08 Pistol", "P08手枪"));
            //Pilot.WeaponClassList.Add(new WeaponClass("投掷武器"));
            //Pilot.WeaponClassList[3].List.Add(new EnCh("Stick Greenade", "木柄手榴弹"));
            //Pilot.WeaponClassList.Add(new WeaponClass("装备"));
            //Pilot.WeaponClassList[4].List.Add(new EnCh("Repair Tools", "维修工具"));
            //Pilot.WeaponClassList[4].List.Add(new EnCh("Flare Gun-Spot", "信号枪-侦察"));
            //Pilot.WeaponClassList.Add(Medic.WeaponClassList[4]);


            //GameClass Elite = new GameClass(new EnCh("Elite Class", "精英兵"));
            //Elite.WeaponClassList.Add(new WeaponClass("武器"));
            //Elite.WeaponClassList.Add(new WeaponClass("投掷武器"));

            BF1.Class.Add(Medic);
            BF1.Class.Add(Assault);
            //BF1.Class.Add(Scout);
            //BF1.Class.Add(Support);
            //BF1.Class.Add(Pilot);
            //BF1.Class.Add(Driver);
            //BF1.Class.Add(Cavalry);
            //BF1.Class.Add(Elite);
            /*医疗*/





            /*支援*/




            /*侦察*/





            //Pilot.WeaponClassList[2].List.Add(new EnCh("P08 Pistol","P08手枪"));

            //Pilot.WeaponClassList[3].List.Add(new EnCh(" Stick Greenade","木柄手榴弹"));

            //Pilot.WeaponClassList[4].List.Add(new EnCh(" Repair Tools","维修工具"));
            //Pilot.WeaponClassList[4].List.Add(new EnCh(" Flare Gun - Spot","信号枪-侦察"));










            //Elite.WeaponClassList[0].List.Add(new EnCh("tankgewehr M1918", "坦克猎手"));
            //Elite.WeaponClassList[0].List.Add(new EnCh("Wex", "火焰喷射器"));
            //Elite.WeaponClassList[0].List.Add(new EnCh("Mg 08/15", "哨兵机枪"));
            //Elite.WeaponClassList[0].List.Add(new EnCh("Villar Perosa", "维拉·佩罗隆冲锋枪"));
            //Elite.WeaponClassList[0].List.Add(new EnCh("Raider Club", "奇兵棒"));
            //Elite.WeaponClassList[0].List.Add(new EnCh("Raider Club", "奇兵棒"));
            //Elite.WeaponClassList[0].List.Add(new EnCh("No.3 Revolver", "3号左轮手枪"));
            //Elite.WeaponClassList[0].List.Add(new EnCh("Sawed Off Shotgun", "短管散弹枪"));

            //Elite.WeaponClassList[1].List.Add(new EnCh("Frag Grenade", "破片手榴弹"));
            //Elite.WeaponClassList[1].List.Add(new EnCh("Stick Grenade", "木柄手榴弹"));
            //Elite.WeaponClassList[1].List.Add(new EnCh("Gas Grenade", "毒气手榴弹"));
            //Elite.WeaponClassList[1].List.Add(new EnCh("Impact Grenade", "冲击手榴弹"));
            //Elite.WeaponClassList[1].List.Add(new EnCh("Incendiary Grenade", "燃烧手榴弹"));
            //Elite.WeaponClassList[1].List.Add(new EnCh("Mini Grenade", "小型手榴弹"));
            //Elite.WeaponClassList[1].List.Add(new EnCh("Smoke Grenade", "烟雾手榴弹"));
            //Elite.WeaponClassList[1].List.Add(new EnCh("Light Anti-Tank Grenade", "轻型反坦克手榴弹"));
            //Elite.WeaponClassList[1].List.Add(new EnCh("Improvised Grenade", "土制手榴弹"));

            //Elite.WeaponClassList[0].List.Add(new EnCh("STATIONARY WEAPON", "地图定点武器"));
            //Elite.WeaponClassList[0].List.Add(new EnCh("Knife", "刀杀"));


            //Cavalry.WeaponClassList[0].List.Add(new EnCh("HORSE","马（践踏）"));

            //Cavalry.WeaponClassList[1].List.Add(new EnCh("Russian 1895","Russian 1895"));

            //Cavalry.WeaponClassList[2].List.Add(new EnCh("P08 Pistol","P08手枪"));

            //Cavalry.WeaponClassList[4].List.Add(new EnCh("Light Anti-Tank","轻型反坦克手雷"));

            //Cavalry.WeaponClassList[5].List.Add(new EnCh("Cavalry Sword", "骑兵军刀"));
            //Cavalry.WeaponClassList[5].List.Add(new EnCh("Cavalry Lance", "骑兵长枪"));


        }
        public void SerializableSave(ChEnData chEnData)
        {
            string fileDirectory = Environment.CurrentDirectory + "\\";
            if (!Directory.Exists(fileDirectory))
                Directory.CreateDirectory(fileDirectory);
            string fileName = "ChEnData.dat";
            Stream stream = new FileStream(fileDirectory + fileName, FileMode.Create, FileAccess.ReadWrite);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            binaryFormatter.Serialize(stream, chEnData);
            stream.Close();
        }




    }

    }
    [Serializable]
    public class Game
    {
        public EnCh Name;//游戏名字
        public List<EnCh> CheatCheckBox = new List<EnCh>();//作弊选项
        public List<EnCh> Map = new List<EnCh>();//地图列表
        public List<GameClass> Class = new List<GameClass>();//兵种列表
    }
    [Serializable]

    public class GameClass
    {
        public EnCh Name;//兵种的名字
        public List<WeaponClass> WeaponClassList = new List<WeaponClass>(); //兵种的武器分类

    public GameClass(EnCh ClassName)
            {
                Name = ClassName;
            }
    }
    [Serializable]
    public class WeaponClass
    {
    public Boolean visi;
        public string Name; //分类名字
        public List<EnCh> List= new List<EnCh>();//该名字下的武器列表
        public WeaponClass(string name)
        {
          Name = name;
        }

    }

    [Serializable]
    public class EnCh
    {
        public string En;
        public string Ch;
        public EnCh(string English, string Chinese)
        {
            En = English;
            Ch = Chinese;
        }
    }







