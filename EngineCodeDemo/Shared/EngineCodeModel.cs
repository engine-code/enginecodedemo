using System;
using System.Collections.Generic;
using ProtoBuf;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace enginecodedemo.Shared
{
    [ProtoContract]
    public class EngineCodeModel
    {
        [ProtoMember(1)]
        public string CodeNo { get; set; }
        [ProtoMember(2)]

        public string Name { get; set; }
        [ProtoMember(3)]
        public string Compulsory { get; set; }
        [ProtoMember(4)]
        public string Category { get; set; }
        [ProtoMember(5)]

        public Coverpage Coverpage { get; set; }
        [ProtoMember(6)]
        public Announcement Announcement { get; set; }
        [ProtoMember(7)]
        public Foreword Foreword { get; set; }
        [ProtoMember(8)]

        public  ICollection<Clause> Clauses { get; set; }
        //The order way by every segments value.In general: 2,10,3 order result is 10,2,3
        //In fact the result should be 2,3,10,the below order way:2,10,3=>02,10,03,then get
        //the result 2,3,10
        public static ICollection<Clause> OrderedByClauseNo(ICollection<Clause> clauses)
        {
            ICollection<Clause> newClauses = new List<Clause>();
            foreach (var item in clauses)
            {
                item.ClauseNo = ToDoubleBits(item.ClauseNo);
                newClauses.Add(item);
            }
            clauses.Clear();
            newClauses = newClauses.OrderBy(a => a.ClauseNo).ToList();
            foreach (var item in newClauses)
            {
                item.ClauseNo = ToSingleBit(item.ClauseNo);
                clauses.Add(item);
            }
            return clauses;
        }
        //In order to orderby ,make clauseNo'segments to two digits by
        //add 0 if segment is one digit,such as 7.11.6=>07.11.06
        private static string ToDoubleBits(string clauseNo)
        {            
            string[] clauseNoArr = clauseNo.Split('.');
            clauseNo= clauseNoArr[0].Length != 1 ? clauseNoArr[0] : "0" + clauseNoArr[0];//附录A A.0.1,不要求像其他段满足数字正则表达式
            for (int i =1; i < clauseNoArr.Length; i++)
            {                               
                clauseNo = clauseNo + "." + (Regex.Matches(clauseNoArr[i], @"\b\d+")[0].Value.Length != 1 ? clauseNoArr[i] : "0" + clauseNoArr[i]);
            }
                
           ;
            return clauseNo;
        }
        /// <summary>
        /// Length of numermic bits is one or not?
        /// Beause of 4, 4A,4B numeric bits is 1;
        /// 12,22 nemeric bits is 2
        /// </summary>
        /// <param name="segNo"></param>
        /// <returns>numeric bits</returns>
        //private static bool 

        //Above way to double digits clauseNo,
        //now change to one digit by removing 0 in segments start  
        private static string ToSingleBit(string clauseNo)
        {
            string[] clauseNoArr = clauseNo.Split('.');
            for (int i=0;i<clauseNoArr.Length;i++)
            {
                if (i == 0)
                    clauseNo = clauseNoArr[i].TrimStart('0');
                else
                {
                    if(clauseNoArr[i]=="00")//2.00.1=>2.0.1
                        clauseNo = clauseNo + "." + "0";
                    else
                        clauseNo = clauseNo + "." + clauseNoArr[i].TrimStart('0');
                }
                    
            }
            return clauseNo;    

        }

    }
    /*
    public enum CategoryEnum
    {
        [Display(Name = "全部")]
        All,
        [Display(Name = "民用")]
        Civil,
        [Display(Name = "工业")]
        Industry,
        [Display(Name = "教育")]
        Education,
        [Display(Name = "金融")]
        Finance,
        [Display(Name = "医药")]
        Medical,
        [Display(Name = "交通")]
        Transportation,
        [Display(Name = "文体")]
        CulturesSports,
        [Display(Name = "商旅")]
        BusinessTour,
        [Display(Name = "市政")]
        Mucinicipal
    }
    */
}
