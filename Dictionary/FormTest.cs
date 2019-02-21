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
	public partial class FormTest : Form
	{
		private MainMenu parentForm;

		private uint corrAnswer;
		private uint userAnswer;
		private uint score;
		private uint numOfQ;
		private uint maxQ;
		private List<int> qList;
		int dictCount;
		public FormTest(MainMenu parentForm, uint max)
		{
			InitializeComponent();
			this.parentForm = parentForm;
			maxQ = max;
			score = 0;
			numOfQ = 1;
			qList = new List<int>();
			dictCount = parentForm.MyDict.Dict.Count;
			generateQ();
		}

		public void generateQ()
		{
			Random rnd = new Random();
			while (dictCount > numOfQ)
			{
				int rnd1 = rnd.Next(dictCount);
				//
				if (!qList.Contains(rnd1))//если это слово еще не использовали
				{
					string word = parentForm.MyDict.Dict.Keys.ElementAt(rnd1);//достаем слово из словаря
																																		//под сгенерированным номером
					string rightAnswer;
					string[] answer = new string[3];//сделать  массив из 3 эл -ответов
					int numOfTransl = parentForm.MyDict.Dict[word].Translations.Count;
					//количество переводов выбранного слова
					int rnd2 = rnd.Next(numOfTransl);
					//выбор 1 варианта правильного перевода
					rightAnswer = parentForm.MyDict.Dict[word].Translations[rnd2].Transl;
					//сохраняем правильный ответ

					qList.Add(rnd1);//доб в список использованных слов индекс слова
					lWord.Text = word;
					lWord.Visible = true;

					//3 заведомо неправ варианта ответа
					for (int i = 0; i < 3; i++)
					{
						int rnd3;
						//чтобы два ответа не были правильными берем в цикле номер др слова
						do { rnd3 = rnd.Next(dictCount); } while (rnd3 == rnd1);

						//берем слово с таким номером из словаря - неправильное слово
						string incorAnswer = parentForm.MyDict.Dict.Keys.ElementAt(rnd3);

						//используем неправ слово в качестве ключа - получаем кол-во его переводов
						numOfTransl = parentForm.MyDict.Dict[incorAnswer].Translations.Count;

						//берем из словаря кол-то переводов неправ слова, берем случайное из них (от нуля до кол-ва переводов)
						int rnd4 = rnd.Next(numOfTransl);
						//берем слово под этим номером (один из рандомных переводов рандомного неправильного слова)
						//помещаем в массив ответов
						answer[i] = parentForm.MyDict.Dict[incorAnswer].Translations[rnd4].Transl;
					}
					//в цикле - з раза

					corrAnswer = (uint)rnd.Next(3);//генерируем номер правильного ответа 
					answer[corrAnswer] = rightAnswer;//массив ответов из 3 элементов
																					 // до этого 3 неправильных ответа, теперь - 1 рандомный правильный

					radioButton1.Text = answer[0];
					radioButton2.Text = answer[1];
					radioButton3.Text = answer[2];

					break;
				}
			}
		}

		private void radioButton1_CheckedChanged(object sender, EventArgs e)
		{
			bSubmit.Enabled = true;
			userAnswer = 0;
		}

		private void radioButton2_CheckedChanged(object sender, EventArgs e)
		{
			bSubmit.Enabled = true;
			userAnswer = 1;
		}

		private void radioButton3_CheckedChanged(object sender, EventArgs e)
		{
			bSubmit.Enabled = true;
			userAnswer = 2;
		}

		private void bSubmit_Click(object sender, EventArgs e)
		{
			if (userAnswer == corrAnswer)
			{
				++score;
			}
			if (numOfQ < maxQ)
			{
				++numOfQ;
				radioButton1.Checked = false;
				radioButton2.Checked = false;
				radioButton3.Checked = false;
				generateQ();
			}
			else
			{
				radioButton1.Visible = false;
				radioButton2.Visible = false;
				radioButton3.Visible = false;
				label2.Text = score.ToString()+"/"+maxQ;
				label2.Visible = true;
				lWord.Text = "Результат: ";
				bSubmit.Visible = false;
			}
		}
	}
}
