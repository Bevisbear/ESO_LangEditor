﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Core.Entities
{
    public class LangTypeCatalog : LangIdType
    {
        [Key]
        public int IdType { get; set; }
        
    }
}
