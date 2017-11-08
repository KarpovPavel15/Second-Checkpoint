using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Checkpoint2.Structures;

namespace Checkpoint2.Interfaces
{
    public interface IDigit : ISentenceItem
    {
        Symbol[] Symbols { get; }
        Symbol this[int index] { get; }
        int Length { get; }
    }
}
