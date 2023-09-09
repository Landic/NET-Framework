using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volkov_HW_20_NET
{
    internal class EngTypeTranslate : ITypeTranslate
    {
        EngRusDictionary list;

        public EngTypeTranslate(EngRusDictionary list)
        {
            this.list = list;
        }

        public string Type(string word)
        {
            for (int i = 0; i < list.CountList; i++)
            {
                if (list.GetList(i).Item1.Contains(word))
                {
                    return list.GetList(i).Item2;
                }
            }
            return "No translate";
        }
    }
}
