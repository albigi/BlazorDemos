using System.Collections.Generic;

namespace wasm
{
    public interface IEnvironmentPrinter
    {
        IDictionary<string, string> PrintEnvironmentInfo();
    }
}
