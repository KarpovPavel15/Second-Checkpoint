using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkpoint2.Interfaces
{
    public interface IWord : ISentenceItem
    {
        Symbol[] Symbols { get; }
        Symbol this[int index] { get; }
        int Length { get; }
        bool IsСonsonant(string[] vowels);
    }
}
