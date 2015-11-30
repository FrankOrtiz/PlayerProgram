using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[System.Serializable]
public class BaseItem {

	private string itemName;
	private string itemDescription;
	private int itemID;
	private int imageID;

	public enum ItemTypes{
		OFFENSIVE_HARDWARE, // equipment
		DEFFENSIVE_HARDWARE,
		DISC, // Key items
		PROCEDURE // battle usable items ( potions / temporary enhancements / fireblast-esque scrolls )
	}
	private ItemTypes itemType;

	public BaseItem(){}

//	public BaseItem(Dictionary<string, string> itemsDictionary){
//		itemName = itemsDictionary["ItemName"];
//		itemID = int.Parse(itemsDictionary["ItemID"]);
//		itemType = (ItemTypes)System.Enum.Parse(typeof(BaseItem.ItemTypes), itemsDictionary["ItemType"].ToString());
//	}

//	public static BaseItem Find(int queryID){
//		for(int i = 0; i < ItemDatabase.inventoryItems.Count; i++){
//			if ( ItemDatabase.inventoryItems[i].ItemID == queryID){
//				return ItemDatabase.inventoryItems[i];
//			}
//		}
//		return ItemDatabase.inventoryItems[0];
//	}

	public string ItemName {get;set;}
	public string ImageID {get;set;}
	public string ItemDescription {get;set;}
	public int ItemID {get;set;}
	public ItemTypes Itemtype {get;set;}
	
}
