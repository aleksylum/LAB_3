using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabDictionary
{
	[Serializable]
	public class Meanings
	{
		public uint PartsOfSpeech { get; set; }
		public List<TranslationInfo> Translations { get; set; }
		public Meanings()//для десериализации
		{
			Translations = new List<TranslationInfo>();
		}

		public Meanings(PartOfSpeech partOfSp, string translation)
		{
			PartsOfSpeech = (uint)partOfSp;
			Translations = new List<TranslationInfo>() { new TranslationInfo(translation, partOfSp) };
		}

		public void AddTranslation(PartOfSpeech partOfSp, string translation)
		{
			PartsOfSpeech = PartsOfSpeech | (uint)partOfSp;//формируем побит маску
			Translations.Add(new TranslationInfo(translation, partOfSp));
		}
	}
}

