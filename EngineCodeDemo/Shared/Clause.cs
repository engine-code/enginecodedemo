using System;
using System.Collections.Generic;

using System.Linq;
using System.Threading.Tasks;
using ProtoBuf;
namespace enginecodedemo.Shared
{
    [ProtoContract]
    public class Clause
    {
        [ProtoMember(1)]
        public string ? CodeNo { get; set; }
        [ProtoMember(2)]
        public string ? ClauseNo { get; set; }
        [ProtoMember(3)]
        public string ? Content { get; set; }
        [ProtoMember(4)]
        public string ? Explanation { get; set; }
        [ProtoMember(5)]
        public string ? Specility { get; set; }        
    }
    /*
        
    public enum SpecialityEnum
    {
        [Display(Name = "建筑")]
        Architecture,
        [Display(Name = "结构")]
        Structure,
        [Display(Name = "电气")]
        Electrical,
        [Display(Name = "给排水")]
        Water,
        [Display(Name = "暖通")]
        Ventilation,
        [Display(Name = "通用")]
        All
    }*/
}
