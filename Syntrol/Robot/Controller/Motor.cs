using System;
using System.Collections.Generic;
using System.Text;

namespace Syntrol.Robot.Controller
{
    /// <summary>
    /// Base Motor Object
    /// </summary>
    /// <remarks>
    /// abstractable to create new types of motors with default properties
    /// </remarks>
    public abstract class Motor
    {
        /// <summary>
        /// Torque output of motorController
        /// </summary>
        /// <remarks>
        /// This should be a curve ideally, not sure how to represent that (maybe a nested function or datatype that understands polynomials)
        /// </remarks>
        /// <returns></returns>
        public abstract int Torque { get; }

        /// <summary>
        /// Channel motorController is currently reading on
        /// </summary>
        /// <returns></returns>
        public abstract int Channel { get; }

        /// <summary>
        /// Unique Idnetifier for the motorController 
        /// </summary>
        /// <returns></returns>
        public abstract int UID { get; }

        /// <summary>
        /// Temporary for holding the place of the grpc object defining this
        /// </summary>
        /// <returns></returns>
        public abstract Object GrpcObject { get; }
    }
}
