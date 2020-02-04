using System;
using System.Collections.Generic;
using System.Text;

namespace Syntrol.Communication
{
    internal static class State
    {
        /// <summary>
        /// Has the connection state for the API
        /// </summary>
        internal static ComStateEnum ComStatus { get; set; }
    }

    /// <summary>
    /// Enum of possible communication states
    /// </summary>
    public enum ComStateEnum
    {
        /// <summary>
        /// Currently Connected
        /// </summary>
        Connected,
        /// <summary>
        /// Not Connected to Simulator
        /// </summary>
        Disconnected,
        /// <summary>
        /// Cannot make a new Connection
        /// </summary>
        Unavailable,
        /// <summary>
        /// Emergency Stopped
        /// </summary>
        Emergency
    }
}
