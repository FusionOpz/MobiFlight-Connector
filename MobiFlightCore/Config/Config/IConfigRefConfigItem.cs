﻿using MobiFlight.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobiFlight.Config
{
    public interface IConfigRefConfigItem
    {
        ConfigRefList ConfigRefs { get; set; }
    }
}
