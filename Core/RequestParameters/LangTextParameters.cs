﻿using Core.EnumTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.RequestParameters
{
    public class LangTextParameters : PageParameters
    {
        public string SearchTerm { get; set; }
        public bool CaseSensitive { get; set; }
        public int IdType { get; set; }
        public int GameApiVersion { get; set; }
        public Guid UserId { get; set; }
        public Guid ReviewerId { get; set; }
        public int Revised { get; set; }
        public string UniqueId { get; set; }
        public DateTime EnLastModifyTimestamp { get; set; }
        public DateTime ZhLastModifyTimestamp { get; set; }

        //Others
        public SearchPostion SearchPostion { get; set; }
    }
}
