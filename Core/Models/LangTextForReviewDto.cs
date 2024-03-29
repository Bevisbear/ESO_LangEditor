﻿using Core.EnumTypes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Models
{
    public class LangTextForReviewDto
    {
        public Guid Id { get; set; }
        public string TextId { get; set; }
        public int IdType { get; set; }
        public string TextEn { get; set; }
        public string TextZh { get; set; }
        public LangType LangTextType { get; set; }
        public byte IsTranslated { get; set; }
        public string UpdateStats { get; set; }
        public DateTime EnLastModifyTimestamp { get; set; }
        public DateTime ZhLastModifyTimestamp { get; set; }
        public Guid UserId { get; set; }
        public Guid ReviewerId { get; set; }
        public DateTime ReviewTimestamp { get; set; }
        public ReviewReason ReasonFor { get; set; }
    }
}
