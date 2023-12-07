﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ALSN.Application.Common.Utility.SD;

namespace ALSN.Domain.Entities.Translator
{
    public class Language
    {
        public int LanguageId { get; set; }
        public string LanguageCode { get; set; }
        public string LanguageName { get; set; }
        public LanguageDirection Direction { get; set; }
    }
}
