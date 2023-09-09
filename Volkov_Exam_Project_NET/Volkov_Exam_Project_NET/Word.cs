using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volkov_Exam_Project_NET
{
    internal class Word
    {
        List<string> translation;
        string word;

        public Word() 
        {
            translation = new List<string>();
            word = string.Empty;
        }
        public Word(string term, List<string> translations)
        {
            this.translation = translation;
            this.word = word;
        }

        public List<string> Translation
        {
            get { return translation; }
            set { this.translation = value; }
        }

        public string Word2
        {
            get { return word; }
            set { this.word = value; }
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < translation.Count; i++)
            {
                yield return word[i] + " " + translation[i];
            }
        }
    }
}
