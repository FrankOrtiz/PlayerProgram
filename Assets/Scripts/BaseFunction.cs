using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[System.Serializable]
public class BaseFunction { // function == ability

	private string name;
	private string description;
	private int id;
	private int intensity; // can be modified
	private int cost; // most cost RAM
	private float strengthModifier;
	private float dexterityModifier;
	private float intellectModifier;
	
	public enum Targets {
		SELF,
		ENEMY
	}	
	public enum Types {
		DATA, // weaken, enhance
		FORCE, // damage
		PROCESS // over-time
	}
	
	private Targets targets;
	private Types types;

	public Targets Target {get;set;}
	public Types Type {get;set;}
	public string Name {get;set;}
	public string Description {get;set;}
	public int ID {get;set;}
	public int Intensity {get;set;}
	public int Cost {get;set;}

	public float WeaponModifier {get;set;}
	public float StrengthModifier {get;set;}
	public float DexterityModifier {get;set;}
	public float IntellectModifier {get;set;}

	public BaseFunction(){}
	public BaseFunction(Dictionary<string, string> functionDictionary){
		Type = (Types)System.Enum.Parse(typeof(BaseFunction.Types), functionDictionary["Type"].ToString());		
		Target = (Targets)System.Enum.Parse(typeof(BaseFunction.Targets), functionDictionary["Target"].ToString());		
		Name = functionDictionary["Name"];
		Description = functionDictionary["Description"];
		ID = int.Parse(functionDictionary["ID"]);
		Intensity = int.Parse(functionDictionary["Intensity"]);
		Cost = int.Parse(functionDictionary["Cost"]);
		WeaponModifier = float.Parse(functionDictionary["WeaponModifier"]);
		StrengthModifier = float.Parse(functionDictionary["StrengthModifier"]);
		DexterityModifier = float.Parse(functionDictionary["DexterityModifier"]);
		IntellectModifier = float.Parse(functionDictionary["IntellectModifier"]);
	}
	
	public static BaseFunction Find(int queryID){
//		Debug.Log(FunctionDatabase.functions.Count);
		for(int i = 0; i < FunctionDatabase.functions.Count; i++){
//			Debug.Log(FunctionDatabase.functions[i].Name);
			if ( FunctionDatabase.functions[i].ID == queryID){
				return FunctionDatabase.functions[i];
			}
		}
		return FunctionDatabase.functions[0];
	}
	
	public static BaseFunction FindByName(string queryName){
		for(int i = 0; i < FunctionDatabase.functions.Count; i++){
			if ( FunctionDatabase.functions[i].Name == queryName){
				return FunctionDatabase.functions[i];
			}
		}
		return FunctionDatabase.functions[0];
	}

}