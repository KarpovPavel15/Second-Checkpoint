using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Checkpoint2.Interfaces;
using Checkpoint2.Separators;
using Checkpoint2.TextObjects;

namespace Checkpoint2
{
    public class Text
    {
        public Text()
        {
            Sentences = new List<ISentence>();
        }

        public Text(IEnumerable<ISentence> sentences) : this()
        {
            foreach (var sentence in sentences)
            {
                Sentences.Add(sentence);
            }
        }

        public IList<ISentence> Sentences { get; set; }

        public ISentence this[int index] => Sentences[index];

        public IEnumerable<ISentence> GetSentencesInAscendingOrder() => Sentences.OrderBy(x => x.Items.Count);

        public IEnumerable<IWord> GetWordsFromInterrogativeSentences(int length)
        {
            var result = new List<IWord>();

            foreach (var sentence in Sentences.Where(sentence => sentence.IsInterrogative))
            {
                result.AddRange(sentence.GetWordsWithoutRepetition(length));
            }

            return result.GroupBy(x => x.Chars.ToLower()).Select(x => x.First()).ToList();
        }

        public void SentencesWithoutConsonants(int length)
        {
            Sentences = Sentences.Select(
                x =>
                    x.RemoveWordsBy(y => y.Length == length && y.IsСonsonant(VolwesSeparator.RussianVolwesSeparator)))
                .ToList();
        }

     

        public string TextToString()
        {
            var sb = new StringBuilder();

            foreach (var sentence in Sentences)
            {
                sb.Append(sentence.SentenceToString() + "\n");
            }

            return sb.ToString();
        }
    }
}
