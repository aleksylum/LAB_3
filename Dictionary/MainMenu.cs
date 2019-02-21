using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace LabDictionary
{
	public partial class MainMenu : Form
	{

		internal MyDictionary MyDict { get; set; }
		public MainMenu()
		{
			InitializeComponent();
			MyDict = new MyDictionary();
		}

		private void bFind_Click(object sender, EventArgs e)
		{
            richTextBox1.Clear();

            if (MyDict.Dict.Count != 0)
				
			{
				if (MyDict.Dict.ContainsKey((tbFind.Text).Trim()))
				{
					string tmp = "";
					foreach (var t in MyDict.Dict[tbFind.Text.Trim()].Translations)
					{
						tmp += t.SpeechPart + ", " + t.Transl + "\n";
					}
					richTextBox1.Text = tmp;
				}
				
			}
            else label1.Text = "Слово не найдено.";
        }

		private void bAdd_Click(object sender, EventArgs e)
		{
			FormAdd formAdd = new FormAdd(this);
			formAdd.ShowDialog();
			label1.Text = "Сохранено.";

		}

		private void bRemove_Click(object sender, EventArgs e)
		{
			if (MyDict.Dict.ContainsKey((tbDel.Text).Trim()))
			{
				MyDict.Dict.Remove((tbDel.Text).Trim());
				label1.Text = "Удалено.";
			}
			else label1.Text = "Слова нет в словаре.";
			tbDel.Clear();
		}

		private void bShow_Click(object sender, EventArgs e)
		{
			richTextBox1.Clear();
			if (MyDict.Dict.Count != 0)
			{
				string tmp = "";
				foreach (var kvp in MyDict.Dict)
				{
					tmp += kvp.Key + "\n";
				}
				richTextBox1.Text = tmp;
			}
		}

		private void bStat_Click(object sender, EventArgs e)
		{
			richTextBox1.Clear();
			Statistics st = MyDict.GetStatistics();
			string s = $@"
общее число карточек: {st.NumOfWords}
средняя длина слов в словаре: {st.WordLength}
число существительных: {st.NumOfNouns}
число глаголов: {st.NumOfVerbs}
число прилагательных: {st.NumOfAdjectives}
число числительных: {st.NumOfNumerals}
число местоимений: {st.NumOfPronouns}
число наречий: {st.NumOfAdverbs}
число артиклей: {st.NumOfArticles}
число предлогов:{st.NumOfPrepositions}
число союзов:{st.NumOfConjunctions}
число междометий:{st.NumOfInterjections}
";
			richTextBox1.Text = s;
		}

		private void bClear_Click(object sender, EventArgs e)
		{
			if (MyDict.Dict.Count != 0)
			{
				MyDict.Dict.Clear();
				richTextBox1.Clear();
			}

			label1.Text = "Словарь очищен!";
		}

		private void bBSer_Click(object sender, EventArgs e)
		{
			BinaryFormatter fmt = new BinaryFormatter();
			using (var stream = new FileStream(Environment.CurrentDirectory + "/dict.bin", FileMode.Create))
			{
				fmt.Serialize(stream, MyDict);
				//stream.Close();//тк using сам выподняет деиниц действия
				label1.Text = "Сериализация выполнена";
			}
		}

		private void bXMLS_Click(object sender, EventArgs e)
		{
			XmlSerializer xmlSer = new XmlSerializer(typeof(WordForXML[]));
			using (var stream = new FileStream(Environment.CurrentDirectory + "/dictxml.xml", FileMode.Create))
			{
				//приводим словарь к массиву вспомогательных объектов
				xmlSer.Serialize(stream, MyDict.Dict.Select(kv => new WordForXML()
				{ word = kv.Key, meaning = kv.Value }).ToArray());
				//stream.Close();
				label1.Text = "XML-сериализация выполнена";

			}
		}

		private void bBDS_Click(object sender, EventArgs e)
		{
			if (System.IO.File.Exists(Environment.CurrentDirectory + "/dict.bin"))
			{
				BinaryFormatter formatter = new BinaryFormatter();
				using (var stream = new FileStream(Environment.CurrentDirectory + "/dict.bin", FileMode.Open))
				{
					MyDict = (MyDictionary)formatter.Deserialize(stream);
					//stream.Close();


					label1.Text = "Десериализация выполнена";

				}
			}
			else { label1.Text = "Десериализация не выполнена"; }
		}

		private void bXmlDS_Click(object sender, EventArgs e)
		{

			if (System.IO.File.Exists(Environment.CurrentDirectory + "/dictxml.xml"))
			{
				XmlSerializer xmlSer = new XmlSerializer(typeof(WordForXML[]));
				using (var stream = new FileStream(Environment.CurrentDirectory + "/dictxml.xml", FileMode.Open))
				{
					MyDict.Dict = ((WordForXML[])xmlSer.Deserialize(stream)).ToDictionary(kv => kv.word, kv => kv.meaning);
					//приводим к словарю
					//stream.Close();
					label1.Text = "XML-десериализация выполнена";
				}
			}
			else { label1.Text = "XML-десериализация не выполнена"; }
		}

		private void bTest_Click(object sender, EventArgs e)
		{
			uint q = 4;
			if (q <= MyDict.Dict.Count)
			{
				FormTest formTest = new FormTest(this, q);
				formTest.ShowDialog();
			}
			else label1.Text = "Недостаточно слов в словаре";
		}
	}
}

