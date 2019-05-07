using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OriginReportTools
{
    class TextProcessing
    {
        /// <summary>
        /// 将作弊内容list里的字符串集合并为一个上传至Mysql时用的字符串
        /// </summary>
        /// <param name="CheckTypesList">作弊选项List</param>
        /// <returns></returns>
        public string ToString(List<string> CheckTypesList)
        {
            string all = "";
            foreach (string CheckType in CheckTypesList)
            {
                all += "-" + CheckType;
            }
            return all;
        }
        /// <summary>
        /// 将Myslq中获得的作弊内容字符串转换成一个list
        /// </summary>
        /// <param name="CheckTypesList"></param>
        /// <returns></returns>
        public List<string> ToList(string CheckTypesList)
        {
            List<string> HackType = new List<string>();
            string[] CheckTypes = CheckTypesList.Split('-');
            foreach (string a in CheckTypes)
            {
                // string aa = a.Replace("\n\r", "");
                if (a != "")
                {
                    HackType.Add(a);
                }
            }
            return HackType;
        }

        public string ToComment(string Mysqlstring)
        {
            string a = Mysqlstring.Replace("-", "\n\r-");
            return a;
        }

        public string ToComment(List<string> HackTypeList)
        {
            string a = "";
            foreach (string b in HackTypeList)
            {
                a += "\n\r- " + b;
            }

            return a;
        }

        public string AllToComment(string Game, List<string> CheckTypesList, string Class, string Weapon, string Map, string K, string D)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("Cheater's in-"+Game+": ");
            stringBuilder.AppendLine("--------");
            foreach (string a in CheckTypesList)
            {
                stringBuilder.AppendLine("- "+a);
            }
            stringBuilder.AppendLine("--------");
            if (Class != null&Weapon!=null&Map!=null&K!=null&D!=null)
                stringBuilder.AppendLine("Related Information:");
            if (Map != null)
                stringBuilder.AppendLine("Map: "  +Map);
            if (Class != null)
                stringBuilder.AppendLine("Class: " + Class);
            if (Weapon != null)
                stringBuilder.AppendLine("Use: " + Weapon);
            if (K != null)
                stringBuilder.AppendLine("Kill: " + K);
            if (D != null)
                stringBuilder.AppendLine("Death: " + D);

            return stringBuilder.ToString();
        }
        public string AllToComment(HackData hackData)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("Cheater's in-" + hackData.Game + ": ");
            stringBuilder.AppendLine("--------");
            foreach (string a in hackData.HackCheckType)
            {
                stringBuilder.AppendLine("- " + a);
            }
            stringBuilder.AppendLine("--------");
            if (hackData.Class != null & hackData.Weapon != null & hackData.Map != null & hackData.K != null & hackData.D != null)
                stringBuilder.AppendLine("Related Information:");
            if (hackData.Map != null)
                stringBuilder.AppendLine("Map: " + hackData.Map);
            if (hackData.Class != null)
                stringBuilder.AppendLine("Class: " + hackData.Class);
            if (hackData.Weapon != null)
                stringBuilder.AppendLine("Use: " + hackData.Weapon);
            if (hackData.K != null)
                stringBuilder.AppendLine("Kill: " + hackData.K);
            if (hackData.D != null)
                stringBuilder.AppendLine("Death: " + hackData.D);

            return stringBuilder.ToString();
        }




    }
}
