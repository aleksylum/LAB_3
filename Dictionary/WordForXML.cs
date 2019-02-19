using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace LabDictionary
{
	public class WordForXML
	{
		[XmlAttribute]
		public string word;
		public Meanings meaning;
	}
}
