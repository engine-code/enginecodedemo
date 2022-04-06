using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace enginecodedemo.Shared
{
    public class Foreword
    {
        public string CodeNo { get; set; }
        //本规范编制依据
        public string  Accordingto{ get; set; }
        //本规范或标准编制过程
        public string Process{ get; set; }
        //本规范或标准主要部分和简单介绍
        public string BriefIntro { get; set; }
        //规范或标准的说明解释部门和单位
        public string ExplainService { get; set; }
        //规范或标准主要编制单位
        public string MainEditUnit { get; set; }
        //规范或标准参与编制单位
        public string EditUnit { get; set; }
        //参与编制主要人员
        public string MainEditStaff { get; set; }
        //规范或标准审查人员
        public string AuditStaff { get; set; }
    }
}
