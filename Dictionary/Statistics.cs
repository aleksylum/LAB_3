using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabDictionary
{
	public struct Statistics
	{

		//NOUN, VERB, ADJECTIVE, NUMERAL, PRONOUN, ADVERB, ARTICLE,
		//PREPOSITION, CONJUNCTION, INTERJECTION
		public uint NumOfWords { get; set; }//общ кол-во слов в словаре
		public double WordLength { get; set; }
		public int NumOfNouns { get; set; }
		public int NumOfAdjectives { get; set; }
		public int NumOfVerbs { get; set; }
		public int NumOfNumerals { get; set; }
		public int NumOfPronouns { get; set; }
		public int NumOfAdverbs { get; set; }
		public int NumOfArticles { get; set; }
		public int NumOfPrepositions { get; set; }
		public int NumOfConjunctions { get; set; }
		public int NumOfInterjections { get; set; }

	}
}
