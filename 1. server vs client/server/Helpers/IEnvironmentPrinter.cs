﻿using System;
using System.Collections.Generic;
using System.Text;

namespace server
{
    public interface IEnvironmentPrinter
    {
        IDictionary<string, string> PrintEnvironmentInfo();
    }
}
