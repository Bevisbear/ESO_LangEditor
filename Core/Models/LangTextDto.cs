﻿using Core.EnumTypes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Models
{
    public class LangTextDto
    {
        public Guid Id { get; set; }
        public string TextId { get; set; }
        public int IdType { get; set; }
        public string TextEn { get; set; }
        public string TextZh { get; set; }
        public string TextJp { get; set; }
        public string TextZh_Official { get; set; }
        public LangType LangTextType { get; set; }
        public int GameApiVersion { get; set; }
        public DateTime EnLastModifyTimestamp { get; set; }
        public DateTime ZhLastModifyTimestamp { get; set; }
        public Guid UserId { get; set; }
        public Guid ReviewerId { get; set; }
        public int Revised { get; set; }
        public DateTime ReviewTimestamp { get; set; }
        public Guid? LangtextInReivewId { get; set; }
    }
}
