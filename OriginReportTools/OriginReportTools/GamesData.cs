using System.Collections.Generic;

namespace OriginReportTools
{
    class GamesData
    {
        public string Name;
        public Dictionary<string, Game> Games;

        public GamesData(string name, object[][] games)
        {
            Name = name;

            Games = new Dictionary<string, Game>();
            foreach (object[] game in games)
            {
                Games.Add((string)game[0], (Game)game[1]);
            }
        }

        public override string ToString()
        {
            return Name;
        }

        public class Game
        {
            public string Name;
            public Dictionary<string, Map> Maps;
            public Dictionary<string, Arm> Arms;

            public Game(string name, object[][] maps, object[][] arms)
            {
                Name = name;

                Maps = new Dictionary<string, Map>();
                foreach (object[] map in maps)
                {
                    Maps.Add((string)map[0], (Map)map[1]);
                }

                Arms = new Dictionary<string, Arm>();
                foreach (object[] arm in arms)
                {
                    Arms.Add((string)arm[0], (Arm)arm[1]);
                }
            }

            public override string ToString()
            {
                return Name;
            }

            public class Map
            {
                public string Name;

                public Map(string name)
                {
                    Name = name;
                }

                public override string ToString()
                {
                    return Name;
                }
            }

            public class Arm
            {
                public string Name;
                public Dictionary<string, EquipmentSet> EquipmentSets;

                public Arm(string name, object[][] equipmentSets)
                {
                    Name = name;

                    EquipmentSets = new Dictionary<string, EquipmentSet>();
                    foreach(object[] equipmentSet in equipmentSets)
                    {
                        EquipmentSets.Add((string)equipmentSet[0], (EquipmentSet)equipmentSet[1]);
                    }
                }

                public override string ToString()
                {
                    return Name;
                }

                public class EquipmentSet
                {
                    public string Name;
                    public Dictionary<string, Equipment> Equipments;

                    public EquipmentSet(string name, object[][] equipments)
                    {
                        Name = name;

                        Equipments = new Dictionary<string, Equipment>();
                        foreach (object[] equipment in equipments)
                        {
                            Equipments.Add((string)equipment[0], (Equipment)equipment[1]);
                        }
                    }

                    public override string ToString()
                    {
                        return Name;
                    }

                    public class Equipment
                    {
                        public string Name;

                        public Equipment(string name)
                        {
                            Name = name;
                        }

                        public override string ToString()
                        {
                            return Name;
                        }
                    }
                }
            }
        }
    }
}
