using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Xml;
using System.IO;

public class FunctionDatabase : MonoBehaviour {
	// XML Files
	public TextAsset functionXML;
	
	// Active database
	public static List<BaseFunction> functions = new List<BaseFunction>();
	
	// Temporary container
	private List<Dictionary<string, string>> functionsDictionary = new List<Dictionary<string, string>>();
	
	// Temporary reference
	private Dictionary<string, string> functionDictionary;
	
	void Awake(){
		ReadItemsDatabase();		
		for(int i = 0; i < functionsDictionary.Count; i++){
			functions.Add(new BaseFunction(functionsDictionary[i]));
		}
	}
	
	
	public void ReadItemsDatabase(){
		LoadOffensiveHardware();
	}
	
	public void LoadOffensiveHardware(){
		XmlDocument xmlDocument = new XmlDocument();
		xmlDocument.LoadXml (functionXML.text);
		XmlNodeList functionList = xmlDocument.GetElementsByTagName("Function");
		foreach (XmlNode functionInfo in functionList){
			XmlNodeList functionContent = functionInfo.ChildNodes;
			functionDictionary = new Dictionary<string, string>();
			
			foreach(XmlNode content in functionContent){
				switch(content.Name){
				case "Name":
					functionDictionary.Add("Name", content.InnerText);
					break;
				case "Description":
					functionDictionary.Add("Description", content.InnerText);
					break;
				case "ID":
					functionDictionary.Add("ID", content.InnerText);
					break;
				case "Target":
					functionDictionary.Add("Target", content.InnerText);
					break;
				case "Intensity":
					functionDictionary.Add("Intensity", content.InnerText);
					break;
				case "Cost":
					functionDictionary.Add("Cost", content.InnerText);
					break;
				case "Type":
					functionDictionary.Add("Type", content.InnerText);
					break;
				case "WeaponModifier":
					functionDictionary.Add("WeaponModifier", content.InnerText);
					break;
				case "StrengthModifier":
					functionDictionary.Add("StrengthModifier", content.InnerText);
					break;
				case "DexterityModifier":
					functionDictionary.Add("DexterityModifier", content.InnerText);
					break;
				case "IntellectModifier":
					functionDictionary.Add("IntellectModifier", content.InnerText);
					break;
				}
			}
			functionsDictionary.Add(functionDictionary);
		}
	}
}
