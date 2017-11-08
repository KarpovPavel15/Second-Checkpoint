using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Checkpoint2.Interfaces;

namespace Checkpoint2.Parsers
{
    public abstract class Parser
    {
        public abstract Text Parse(StreamReader fileReader);
        public abstract ISentence ParseSentence(string sentence);
    }
}
