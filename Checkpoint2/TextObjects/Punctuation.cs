using System.Linq;
using System.Text;
using Checkpoint2.Interfaces;
using Checkpoint2.Structures;

namespace Checkpoint2.TextObjects
{
    public class Punctuation : IPunctuation
    {
        public Punctuation(string chars)
        {
            Symbols = new Symbol(chars);
        }

        public string Chars => Symbols.Chars;

        public Symbol Symbols { get; }

    }
}