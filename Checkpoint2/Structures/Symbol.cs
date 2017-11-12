using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkpoint2.Structures
{
    public struct Symbol
    {
        public string Chars { get; set; }

        public Symbol(string chars)
        {
            Chars = chars;
        }

        public Symbol(char source)
        {
            Chars = $"{source}";
        }
    }
}