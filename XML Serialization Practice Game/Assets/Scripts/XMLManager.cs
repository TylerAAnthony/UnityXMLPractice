using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.Collections.Generic;  //lets us use lists
using System.Xml;  				   //basic xml attributes
using System.Xml.Serialization;    //access xmlserializer
using System.IO; 				   //file management

public class XMLManager : MonoBehaviour {

	//simple singleton pattern
	public static XMLManager ins;

	void Awake ()
	{
		ins = this;
	}

	//List of items
	public ItemDatabase itemDB;

	public void SaveItems(){
		//open a new xml file
		XmlSerializer serializer = new XmlSerializer(typeof(ItemDatabase));
		FileStream stream = new FileStream (Application.dataPath + "/StreamingFiles/XML/item_data.xml", FileMode.Create);
		serializer.Serialize (stream, itemDB);
		stream.Close ();
	}
}


[System.Serializable]
public class ItemEntry {
	public string itemName;
	public Material material;//material
	public int value;
}

[System.Serializable]
public class ItemDatabase{
	[XmlArray("CombatEquiptment")]
	public List<ItemEntry> list = new List<ItemEntry> ();

}


public enum Material {
	Wood,
	Copper,
	Iron,
	Steel,
	Obsidian
}
