using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization.XmlObjectSerializer;
class Program
{
	static void Main()
	{
		InfoTerkini infoTerkini = new InfoTerkini("ilham", "tambun", 1);
		
		XmlSerializer saveInfo = new XmlSerializer(typeof(InfoTerkini));
		
		using (StreamWriter writer = new StreamWriter("person.xml"))
		{
			saveInfo.Serialize(writer, infoTerkini);
		}
		
	}
}

[DataContract]
public class InfoTerkini
{
	
	public string siapa;
	public string kemana;
	public int berapa;
	
	public InfoTerkini(string siapa, string kemana, int berapa)
	{
		this.siapa = siapa;
		this.kemana = kemana;
		this.berapa = berapa;
	}
}