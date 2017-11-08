using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Checkpoint2.Structures;

namespace Checkpoint2.Interfaces
{
    public interface IPunctuation : ISentenceItem
    {
        Symbol Symbols { get; }
    }
}
