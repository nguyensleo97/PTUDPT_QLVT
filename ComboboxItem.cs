﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLVT
{
    class ComboboxItem
    {
        public string Text { get; set; }
        public string Value { get; set; }
        public int SoLuongTon { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}
