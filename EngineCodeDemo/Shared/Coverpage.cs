using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EngineCodeDemo.Shared
{
    //规范或标准封面
    public class Coverpage
    {
        //规范或标准等级，国家标准，行业标准，地方标准等
        public string CodeLevel { get; set; }
        //规范或标准编号 GB 50116-2013 JGJ 242-2011      
        public string CodeNo { get; set; }
        //规范或标准发布日期
        public string CodeName { get; set; }
        public string CodeNameWithEnglish { get; set; }
        public string MainEditUnit { get; set; }
        public string ApproveUnit { get; set; }
        //规范或标准实施日期
        public string ExecuteDate { get; set; }
    }
}
