using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabDictionary
{
    [Serializable]
   public class Card
    {
        string Key;
        public List<TranslationInfo> TranslInfo { get; set;}
        public Card (List<TranslationInfo> l) { TranslInfo = l; }
    }
}
