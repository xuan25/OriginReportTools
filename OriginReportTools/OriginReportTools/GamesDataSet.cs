using System;
using System.Collections.Generic;

namespace OriginReportTools
{
    /// <summary>
    /// Class <c>GamesDataSet</c> models the a dataset of games.
    /// Author: Xuan525
    /// Date: 24/04/2019
    /// </summary>
    [Serializable]
     public class GamesDataSet
    {
        /// <summary>
        /// Name of the Dataset
        /// </summary>
        public string Name;
        /// <summary>
        /// Dictionary of Games
        /// </summary>
        public Dictionary<string, Game> Games;

        /// <summary>
        /// Constructor of Class <c>GamesDataSet</c>.
        /// </summary>
        /// <param name="name">The name of the dataset</param>
        /// <param name="games">An array of Games, each Game is an array with its key and <c>Game</c> instance</param>
        public GamesDataSet(string name, object[][] games)
        {
            Name = name;

            Games = new Dictionary<string, Game>();
            foreach (object[] game in games)
            {
                Games.Add((string)game[0], (Game)game[1]);
            }
        }

        /// <summary>
        /// Returns the Name of the Dataset
        /// </summary>
        /// <returns>Name of the Dataset</returns>
        public override string ToString()
        {
            return Name;
        }
        [Serializable]
        /// <summary>
        /// Class <c>Game</c> models the the content of a game.
        /// Author: Xuan525
        /// Date: 24/04/2019
        /// </summary>
        public class Game
        {
            /// <summary>
            /// Name of the Game
            /// </summary>
            public string Name;
            /// <summary>
            /// Dictionary of Maps
            /// </summary>
            public Dictionary<string, Map> Maps;
            /// <summary>
            /// Dictionary of Arms
            /// </summary>
            public Dictionary<string, Arm> Arms; 

            public Dictionary<string, CheckType> CheckTypes;

            /// <summary>
            /// Constructor of Class <c>Game</c>.
            /// </summary>
            /// <param name="name">The name of the Game</param>
            /// <param name="maps">An array of Maps, each Map is an array with its key and <c>Map</c> instance</param>
            /// <param name="arms">An array of Arms, each Arm is an array with its key and <c>Arm</c> instance</param>
            public Game(string name, object[][] maps, object[][] arms, object [][] checktypes)
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

                CheckTypes = new Dictionary<string, CheckType>();
                foreach (object[] check in checktypes)
                {
                    CheckTypes.Add((string)check[0], (CheckType)check[1]);
                }
            }

            /// <summary>
            /// Returns the Name of the Game
            /// </summary>
            /// <returns>Name of the Game</returns>
            public override string ToString()
            {
                return Name;
            }
            [Serializable]
            /// <summary>
            /// Class <c>Map</c> models a Map in a Game.
            /// Author: Xuan525
            /// Date: 24/04/2019
            /// </summary>
            public class Map
            {
                /// <summary>
                /// Name of the Map
                /// </summary>
                public string Name;

                /// <summary>
                /// Constructor of Class <c>Map</c>.
                /// </summary>
                /// <param name="name">The name of the Map</param>
                public Map(string name)
                {
                    Name = name;
                }

                /// <summary>
                /// Returns the Name of the Map
                /// </summary>
                /// <returns>Name of the Map</returns>
                public override string ToString()
                {
                    return Name;
                }
            }
            [Serializable]
            public class CheckType
            {

                public string Name;
                public CheckType(string name)
                {
                    Name = name;
                }

                public override string ToString()
                {
                    return Name;
                }
            }


            [Serializable]
            /// <summary>
            /// Class <c>Arm</c> models an Arm in a Game.
            /// Author: Xuan525
            /// Date: 24/04/2019
            /// </summary>
            public class Arm
            {
                /// <summary>
                /// Name of the Arm
                /// </summary>
                public string Name;
                /// <summary>
                /// Dictionary of EquipmentSets
                /// </summary>
                public Dictionary<string, EquipmentSet> EquipmentSets;

                /// <summary>
                /// Constructor of Class <c>Arm</c>.
                /// </summary>
                /// <param name="name">The name of the Arm</param>
                /// <param name="equipmentSets">An array of EquipmentSet, each EquipmentSet is an array with its key and <c>EquipmentSet</c> instance</param>
                public Arm(string name, object[][] equipmentSets)
                {
                    Name = name;

                    EquipmentSets = new Dictionary<string, EquipmentSet>();
                    foreach(object[] equipmentSet in equipmentSets)
                    {
                        EquipmentSets.Add((string)equipmentSet[0], (EquipmentSet)equipmentSet[1]);
                    }
                }
                /// <summary>
                /// Returns the Name of the Arm
                /// </summary>
                /// <returns>Name of the Arm</returns>
                public override string ToString()
                {
                    return Name;
                }
                [Serializable]
                /// <summary>
                /// Class <c>EquipmentSet</c> models an EquipmentSet in a Game.
                /// Author: Xuan525
                /// Date: 24/04/2019
                /// </summary>
                public class EquipmentSet
                {
                    /// <summary>
                    /// Name of the EquipmentSet
                    /// </summary>
                    public string Name;
                    /// <summary>
                    /// Dictionary of Equipments
                    /// </summary>
                    public Dictionary<string, Equipment> Equipments;

                    /// <summary>
                    /// Constructor of Class <c>EquipmentSet</c>.
                    /// </summary>
                    /// <param name="name">The name of the EquipmentSet</param>
                    /// <param name="equipments">An array of Equipment, each Equipment is an array with its key and <c>Equipment</c> instance</param>
                    public EquipmentSet(string name, object[][] equipments)
                    {
                        Name = name;

                        Equipments = new Dictionary<string, Equipment>();
                        foreach (object[] equipment in equipments)
                        {
                            Equipments.Add((string)equipment[0], (Equipment)equipment[1]);
                        }
                    }

                    /// <summary>
                    /// Returns the Name of the EquipmentSet
                    /// </summary>
                    /// <returns>Name of the EquipmentSet</returns>
                    public override string ToString()
                    {
                        return Name;
                    }
                    [Serializable]
                    public class Equipment
                    {
                        /// <summary>
                        /// Name of the Equipment
                        /// </summary>
                        public string Name;

                        /// <summary>
                        /// Constructor of Class <c>Equipment</c>.
                        /// </summary>
                        /// <param name="name">The name of the Equipment</param>
                        public Equipment(string name)
                        {
                            Name = name;
                        }

                        /// <summary>
                        /// ToString
                        /// </summary>
                        /// <returns>Name of the Equipment</returns>
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
