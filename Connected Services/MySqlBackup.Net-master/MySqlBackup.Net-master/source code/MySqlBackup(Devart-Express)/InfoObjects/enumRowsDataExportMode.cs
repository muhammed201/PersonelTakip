﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Devart.Data.MySql
{
    public enum RowsDataExportMode
    {
        Insert = 1,
        InsertIgnore = 2,
        Replace = 3,
        OnDuplicateKeyUpdate = 4,
        Update = 5
    }
}
