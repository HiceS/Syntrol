using System;
using System.Collections.Generic;
using System.Text;

namespace Syntrol.Robot
{
    /// <summary>
    /// Abstract base class for reading and writing from Coms
    /// </summary>
    public abstract class ComObject
    {
        internal abstract int Write();

        internal abstract int Read { get; }
    }
}
