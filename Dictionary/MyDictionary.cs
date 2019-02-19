using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
///Лабораторная работа №4 Кравцоваой А. В.///
///Пример заполненного словаря можно десериализовать///

namespace LabDictionary
{

	public enum PartOfSpeech : uint
	{
		NOUN = 1, VERB = 2, ADJECTIVE = 4, NUMERAL = 8, PRONOUN = 16, ADVERB = 32, ARTICLE = 64,
		PREPOSITION = 128, CONJUNCTION = 256, INTERJECTION = 512

	}
	[Serializable]
	public class MyDictionary
	{
		public Dictionary<string, Meanings> Dict { get; set; }

		public MyDictionary()
		{
			Dict = new Dictionary<string, Meanings>();
		}

		public Statistics GetStatistics()
		{
			Statistics stat = new Statistics();
			foreach (KeyValuePair<string, Meanings> i in Dict)
			//стандарт Dictionary состоит из элементов типа KeyValuePair
			{
				++stat.NumOfWords;
				stat.WordLength += i.Key.Length;
				//побитовое умножение
				stat.NumOfNouns += ((int)(i.Value.PartsOfSpeech & (uint)PartOfSpeech.NOUN) == 0 ? 0 : 1);
				stat.NumOfVerbs += ((int)(i.Value.PartsOfSpeech & (uint)PartOfSpeech.VERB) == 0 ? 0 : 1);
				stat.NumOfAdjectives += ((int)(i.Value.PartsOfSpeech & (uint)PartOfSpeech.ADJECTIVE) == 0 ? 0 : 1);
				stat.NumOfNumerals += ((int)(i.Value.PartsOfSpeech & (uint)PartOfSpeech.NUMERAL) == 0 ? 0 : 1);
				stat.NumOfPronouns += ((int)(i.Value.PartsOfSpeech & (uint)PartOfSpeech.PRONOUN) == 0 ? 0 : 1);
				stat.NumOfAdverbs += ((int)(i.Value.PartsOfSpeech & (uint)PartOfSpeech.ADVERB) == 0 ? 0 : 1);
				stat.NumOfArticles += ((int)(i.Value.PartsOfSpeech & (uint)PartOfSpeech.ARTICLE) == 0 ? 0 : 1);
				stat.NumOfPrepositions += ((int)(i.Value.PartsOfSpeech & (uint)PartOfSpeech.PREPOSITION) == 0 ? 0 : 1);
				stat.NumOfConjunctions += ((int)(i.Value.PartsOfSpeech & (uint)PartOfSpeech.CONJUNCTION) == 0 ? 0 : 1);
				stat.NumOfInterjections += ((int)(i.Value.PartsOfSpeech & (uint)PartOfSpeech.INTERJECTION) == 0 ? 0 : 1);
			}
			if (stat.NumOfWords != 0)
			{
				stat.WordLength = stat.WordLength / stat.NumOfWords;
			}
			return stat;
		}

		public void AddMeaning(string word, TranslationInfo tInfo)
		{
			if (Dict.ContainsKey(word))
			{//если слово существует, добавляем перевод
				Dict[word].AddTranslation(tInfo.SpeechPart, tInfo.Transl);
			}
			else
			{//заводим карточку
				Dict.Add(word, new Meanings(tInfo.SpeechPart, tInfo.Transl));
			}
		}

		public bool DeleteWord(string word)
		{
			if (Dict.ContainsKey(word))
			{
				Dict.Remove(word);
				return true;
			}
			return false;
		}
	}
}
