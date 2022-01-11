using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurtleDrawing.DataStructures.Exceptions
{
    internal class EmptyException : Exception
    {
        public EmptyException(string message) : base(message)
        {

        }
    }
}
