using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabDictionary
{
	public partial class FormAdd : Form
	{
		MainMenu parentForm;
		string word;
		List<TranslationInfo> tInfo;
		uint bitmask;

		public FormAdd(MainMenu parentForm)
		{
			InitializeComponent();
			this.parentForm = parentForm;
			comboBox1.SelectedIndex = 0;
			bSaveAll.Enabled = false;
			bAddVar.Enabled = false;
			tInfo = new List<TranslationInfo>();
			bitmask = 0;
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			if (textBox1.TextLength > 0 && textBox2.TextLength > 0)
			{
				bSaveAll.Enabled = true;
				bAddVar.Enabled = true;
			}

		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{
			if (textBox1.TextLength > 0 && textBox2.TextLength > 0)
			{
				bSaveAll.Enabled = true;
				bAddVar.Enabled = true;
			}

		}
		private void bAddVar_Click(object sender, EventArgs e)
		{
			textBox1.Enabled = false;
			tInfo.Add(new TranslationInfo(textBox2.Text, checkPOS(comboBox1.SelectedIndex)));
			bitmask = bitmask | (uint)checkPOS(comboBox1.SelectedIndex);
			textBox2.Clear();
		}

		private PartOfSpeech checkPOS(int t)
		{
			PartOfSpeech p;
			switch (t)
			{
				case 0:
					p = PartOfSpeech.NOUN;
					break;
				case 1:
					p = PartOfSpeech.VERB;
					break;
				case 2:
					p = PartOfSpeech.ADJECTIVE;
					break;
				case 3:
					p = PartOfSpeech.NUMERAL;
					break;
				case 4:
					p = PartOfSpeech.PRONOUN;
					break;
				case 5:
					p = PartOfSpeech.ADVERB;
					break;
				case 6:
					p = PartOfSpeech.ARTICLE;
					break;
				case 7:
					p = PartOfSpeech.PREPOSITION;
					break;
				case 8:
					p = PartOfSpeech.CONJUNCTION;
					break;
				default:
					p = PartOfSpeech.INTERJECTION;
					break;
			}
			return p;
		}

		private void bSaveAll_Click(object sender, EventArgs e)
		{
			word = textBox1.Text;
			tInfo.Add(new TranslationInfo(textBox2.Text, checkPOS(comboBox1.SelectedIndex)));
			bitmask = bitmask | (uint)checkPOS(comboBox1.SelectedIndex);
			//добавить слово с пустым списком
			//добавить список
			if (!(parentForm.MyDict.Dict.ContainsKey(word)))
			{
				parentForm.MyDict.Dict.Add(word, new Meanings());
			}
			parentForm.MyDict.Dict[word].Translations.AddRange(tInfo);
			parentForm.MyDict.Dict[word].PartsOfSpeech = parentForm.MyDict.Dict[word].PartsOfSpeech | bitmask;
			Close();
		}
	}
}
