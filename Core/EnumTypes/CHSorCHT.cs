﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Core.EnumTypes
{
    public enum CHSorCHT : ushort
    {
        [Description("打包简体中文")]
        chs = 1,
        [Description("打包繁体中文")]
        cht,
    }
}
