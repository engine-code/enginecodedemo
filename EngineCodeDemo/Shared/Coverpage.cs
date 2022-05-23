using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProtoBuf;

namespace enginecodedemo.Shared
{
    [ProtoContract]
    //规范或标准封面
    public class Coverpage
    {
        //规范或标准等级，国家标准，行业标准，地方标准等
        [ProtoMember(1)]
        public string CodeLevel { get; set; }
        [ProtoMember(2)]
        //规范或标准编号 GB 50116-2013 JGJ 242-2011      
        public string CodeNo { get; set; }
        [ProtoMember(3)]
        //规范或标准发布日期
        public string CodeName { get; set; }
        [ProtoMember(4)]
        public string CodeNameWithEnglish { get; set; }
        [ProtoMember(5)]
        public string MainEditUnit { get; set; }
        [ProtoMember(6)]
        public string ApproveUnit { get; set; }
        [ProtoMember(7)]
        //规范或标准实施日期
        public string ExecuteDate { get; set; }
    }
}
