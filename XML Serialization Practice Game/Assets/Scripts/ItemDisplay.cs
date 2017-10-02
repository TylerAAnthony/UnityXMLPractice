using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDisplay : MonoBehaviour {

	public ItemBlock blockPrefab;

	void Start (){
		for (int i = 0; i < 20; i++) {
			Display ();
		}
	}

	public void Display(ItemEntry item) {
		foreach(ItemEntry item in XMLManager.ins.itemDB.list){
			ItemBlock newBlock = Instantiate(blockPrefab) as ItemBlock;
			newBlock.transform.SetParent(transform, false);
			newBlock.Display(item);
		}

	}

}
