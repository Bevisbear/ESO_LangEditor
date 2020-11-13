﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ESO_LangEditorModels.Enum
{
    public enum ProcessDbUpdateResult : byte
    {
        Success = 1,
        UnableToFindDbFile,
        UnableToExportLangText,
        UnableToExportLangLua,
    }
}