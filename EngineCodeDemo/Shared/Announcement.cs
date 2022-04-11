using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProtoBuf;

namespace enginecodedemo.Shared
{   [ProtoContract]
    public class Announcement
    {
        [ProtoMember(1)]
        public string CodeNo { get; set; }
        //那个部门发布公告
        [ProtoMember(2)]
        public string AnnDept { get; set; }
        //公告标号
        [ProtoMember(3)]
        public string AnnNo { get; set; }
        //公告标题
        [ProtoMember(4)]
        public string AnnTitle { get; set; }
        [ProtoMember(5)]
        //公告内容包括实施日期，强条编号
        public string AnnContent { get; set; }
        [ProtoMember(6)]
        //出版发行单位
        public string Printer { get; set; }
        [ProtoMember(7)]
        //公告发布日期
        public string  AnnDate { get; set; }

    }
}
