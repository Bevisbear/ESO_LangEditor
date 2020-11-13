﻿using ESO_LangEditorModels.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace ESO_LangEditorModels
{
    public class JsonDto
    {
        public List<LangTextDto> LangTexts { get; set; }
        //public List<LangLuaDto> LangLuas { get; set; }
        public string Version { get; set; }
        public DateTime ExportTime { get; set; }
        public LangChangeType ChangeType { get; set; }
        //List<>
    }
}