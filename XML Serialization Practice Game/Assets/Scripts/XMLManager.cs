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
}

[System.Serializable]
public class ItemEntry {
	public string itemName;
	public Material material;//material
	public int value;
}

[System.Serializable]
public class ItemDatabase{
	public List<ItemEntry> list = new List<ItemEntry> ();

}


public enum Material {
	Wood,
	Copper,
	Iron,
	Steel,
	Obsidian
}
