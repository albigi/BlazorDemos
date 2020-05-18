using System;
using System.Collections.Generic;
using System.Text;

namespace wasm
{
    public interface IEnvironmentPrinter
    {
        IDictionary<string, string> PrintEnvironmentInfo();
    }
}
