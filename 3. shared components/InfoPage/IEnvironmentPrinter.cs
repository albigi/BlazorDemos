using System;
using System.Collections.Generic;
using System.Text;

namespace InfoPage
{
    public interface IEnvironmentPrinter
    {
        IDictionary<string, string> PrintEnvironmentInfo();
    }
}
