using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabDictionary
{
	[Serializable]
	public class TranslationInfo
	{
		public string Transl { get; set; }
		public PartOfSpeech SpeechPart { get; set; }

		public TranslationInfo() { }

		public TranslationInfo(string t, PartOfSpeech sp)
		{
			Transl = t;
			SpeechPart = sp;
		}
	}
}
