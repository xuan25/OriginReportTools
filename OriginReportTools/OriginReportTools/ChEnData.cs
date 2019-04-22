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
            //BF1.Name = new EnCh("BF 1", "战地1");                          //游戏名字对应的中文英文 
            //BF1.CheatCheckBox.Add(new EnCh("WallHack", "透视"));
            ////BF1.CheatCheckBox.Add(new EnCh("Aimbot", "自瞄"));
            ////BF1.CheatCheckBox.Add(new EnCh("Change weapon's damage", "修改伤害"));
            ////BF1.CheatCheckBox.Add(new EnCh("Invisible", "隐身"));

            //BFV.CheatCheckBox.Add(new EnCh("WallHack2", "透视2"));
            ////BFV.CheatCheckBox.Add(new EnCh("Aimbot2", "自瞄2"));
            ////BFV.CheatCheckBox.Add(new EnCh("Change weapon's damage2", "修改伤害2"));
            ////BFV.CheatCheckBox.Add(new EnCh("Invisible2", "隐身2"));
            //GameClass YL = new GameClass(new EnCh("Medic", "医疗兵"));    //游戏内，兵种对应的中文英文
            //YL.Weapon.Add(new EnCh("M97 Trench Gun", "M97战壕枪"));     //游戏内，兵种对应的武器列表的中文英文
            //YL.Weapon.Add(new EnCh("MP 18", "MP 18"));
            //YL.Weapon.Add(new EnCh("Hellfighter Trench", "地狱战士战壕散弹枪"));

            //BF1.Map.Add(new EnCh("Ballroom Blitz", "流血宴厅"));        //游戏内对应的地图列表的中文英文
            //BF1.Map.Add(new EnCh("Argonee Forest", "阿尔贡森林"));


            //GameClass TJ = new GameClass(new EnCh("Assault", "突击兵"));


            //GameClass ZC = new GameClass(new EnCh("Scout", "侦察兵"));


            //GameClass ZY = new GameClass(new EnCh("Support", "支援兵"));


            //BF1.Class.Add(YL);
            //BF1.Class.Add(TJ);
            //BF1.Class.Add(ZC);
            //BF1.Class.Add(ZY);

            //BFV.Name = new EnCh("BF V", "战地1");

            //APEX.Name = new EnCh("APEX", "APEX");






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
        public EnCh Name;
        public List<EnCh> CheatCheckBox = new List<EnCh>();
        public List<EnCh> Map = new List<EnCh>();
        public List<GameClass> Class = new List<GameClass>();
    }
    [Serializable]

    public class GameClass : Game
    {
        public List<EnCh> Weapon = new List<EnCh>();

        public GameClass(EnCh ClassName)
        {
            Name = ClassName;
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







