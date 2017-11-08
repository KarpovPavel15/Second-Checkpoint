﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkpoint2.TextObjects
{
    class Digit
    {
        public Digit(string chars)
        {
            Symbols = chars?.Select(x => new Symbol(x)).ToArray();
        }

        public string Chars
        {
            get
            {
                var sb = new StringBuilder();

                foreach (var symbol in Symbols)
                {
                    sb.Append(symbol.Chars);
                }

                return sb.ToString();
            }
        }

        public Symbol[] Symbols { get; }

        public Symbol this[int index] => Symbols[index];

        public int Length => Symbols.Length;
    }
}

