using System;
using System.Collections.Generic;

namespace SingleInstanceApp
{
    public interface ISingleInstance
    {
        bool SignalExternalCommandLineArgs(IList<string> args);
    }
}