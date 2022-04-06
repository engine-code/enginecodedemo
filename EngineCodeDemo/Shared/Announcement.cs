using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace enginecodedemo.Shared
{
    public class Announcement
    {
        public string CodeNo { get; set; }
        //那个部门发布公告
        public string AnnDept { get; set; }
        //公告标号
        public string AnnNo { get; set; }
        //公告标题
        public string AnnTitle { get; set; }
        //公告内容包括实施日期，强条编号
        public string AnnContent { get; set; }
        //出版发行单位
        public string Printer { get; set; }
        //公告发布日期
        public string  AnnDate { get; set; }

    }
}
