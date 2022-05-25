using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProtoBuf;

namespace enginecodedemo.Shared
{
    [ProtoContract]
    public class Foreword
    {
        [ProtoMember(1)]
        public string ? CodeNo { get; set; }
        [ProtoMember(2)]
        //本规范编制依据
        public string ?  Accordingto{ get; set; }
        [ProtoMember(3)]
        //本规范或标准编制过程
        public string ? Process{ get; set; }
        [ProtoMember(4)]
        //本规范或标准主要部分和简单介绍
        public string ? BriefIntro { get; set; }
        [ProtoMember(5)]
        //规范或标准的说明解释部门和单位
        public string ? ExplainService { get; set; }
        [ProtoMember(6)]
        //规范或标准主要编制单位
        public string ? MainEditUnit { get; set; }
        [ProtoMember(7)]
        //规范或标准参与编制单位
        public string ? EditUnit { get; set; }
        [ProtoMember(8)]
        //参与编制主要人员
        public string ? MainEditStaff { get; set; }
        [ProtoMember(9)]
        //规范或标准审查人员
        public string ? AuditStaff { get; set; }
    }
}
