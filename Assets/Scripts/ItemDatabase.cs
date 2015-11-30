using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Xml;
using System.IO;

public class ItemDatabase : MonoBehaviour {
	// XML Files
	public TextAsset offensiveHardwareXml;

	// Active database
	public static List<BaseOffensiveHardware> offensiveHardwareItems = new List<BaseOffensiveHardware>();

	// Temporary container
	private List<Dictionary<string, string>> offensiveHardwareItemsDictionary = new List<Dictionary<string, string>>();

	// Temporary reference
	private Dictionary<string, string> offensiveHardwareDictionary;

	void Awake(){
		ReadItemsDatabase();
		for(int i = 0; i < offensiveHardwareItemsDictionary.Count; i++){
			offensiveHardwareItems.Add(new BaseOffensiveHardware(offensiveHardwareItemsDictionary[i]));
		}
	}

	
	public void ReadItemsDatabase(){
		LoadOffensiveHardware();
	}

	public void LoadOffensiveHardware(){
		XmlDocument xmlDocument = new XmlDocument();
		xmlDocument.LoadXml (offensiveHardwareXml.text);
		XmlNodeList itemList = xmlDocument.GetElementsByTagName("Item");
		foreach (XmlNode itemInfo in itemList){
			XmlNodeList itemContent = itemInfo.ChildNodes;
			offensiveHardwareDictionary = new Dictionary<string, string>();

			foreach(XmlNode content in itemContent){
				switch(content.Name){
				case "ItemName":
					offensiveHardwareDictionary.Add("ItemName", content.InnerText);
					break;
				case "ItemID":
					offensiveHardwareDictionary.Add("ItemID", content.InnerText);
					break;
				case "ItemDescription":
					offensiveHardwareDictionary.Add("ItemDescription", content.InnerText);
					break;
				case "ImageID":
					offensiveHardwareDictionary.Add("ImageID", content.InnerText);
					break;
				case "WeaponDamage":
					offensiveHardwareDictionary.Add("WeaponDamage", content.InnerText);
					break;
				case "Strength":
					offensiveHardwareDictionary.Add("Strength", content.InnerText);
					break;
				case "Dexterity":
					offensiveHardwareDictionary.Add("Dexterity", content.InnerText);
					break;
				case "Intellect":
					offensiveHardwareDictionary.Add("Intellect", content.InnerText);
					break;
				case "RAM":
					offensiveHardwareDictionary.Add("RAM", content.InnerText);
					break;
				case "ICE":
					offensiveHardwareDictionary.Add("ICE", content.InnerText);
					break;
				case "CPURequirement":
					offensiveHardwareDictionary.Add("CPURequirement", content.InnerText);
					break;
				case "Rarity":
					offensiveHardwareDictionary.Add("Rarity", content.InnerText);
					break;
				case "OffensiveHardwareType":
					offensiveHardwareDictionary.Add("OffensiveHardwareType", content.InnerText);
					break;
				}
			}
//			string value = "";
//			offensiveHardwareDictionary.TryGetValue("Rarity", out value);
//			Debug.Log(value);
			offensiveHardwareItemsDictionary.Add(offensiveHardwareDictionary);
		}
	}
}
