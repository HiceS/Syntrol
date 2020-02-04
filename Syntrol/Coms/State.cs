using System;
using System.Collections.Generic;
using System.Text;

namespace Syntrol.Communication
{
    public static class State
    {
        public static ComStateEnum ComStatus { get; set; }
    }

    /// <summary>
    /// Enum of possible communication states
    /// </summary>
    public enum ComStateEnum
    {
        Connected,
        Disconnected,
        Unavailable,
        Emergency
    }
}
