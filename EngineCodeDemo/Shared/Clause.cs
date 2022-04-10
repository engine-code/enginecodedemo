using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using ProtoBuf;
namespace enginecodedemo.Shared
{
    [ProtoContract]
    public class Clause
    {
        
        public string CodeNo { get; set; }       
        public string ClauseNo { get; set; }
        public string Content { get; set; }
        public string Explanation { get; set; }
        public string Specility { get; set; }        
    }
    
        
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
    }
}
