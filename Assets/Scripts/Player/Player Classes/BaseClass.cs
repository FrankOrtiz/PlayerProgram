using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[System.Serializable]
public class BaseClass {

	private string className;
	private string classDescription;
	
	private int ram; // health
	private int strength;
	private int dexterity;
	private int intellect;
	
	public string ClassName {get;set;}
	public string ClassDescription {get;set;}
	public int MethodPoints {get;set;}
	
	public int RAM {get;set;}
	
	public int Strength {get;set;}
	public int Dexterity {get;set;}
	public int Intellect {get;set;}

	public List<BaseFunction> functions = new List<BaseFunction>();

	public virtual void AddFunctionToPlayer(int playerCPU){
	}

	public static void StartingHardware(){
		switch(GameInformation.PlayerClass.ClassName){
		case("Derezzer"):
			GameInformation.EquipOffensiveHardware(BaseOffensiveHardware.Find(1));
			GameInformation.EquipOffensiveHardware(BaseOffensiveHardware.Find(2));
			break;
		case("Warden"):
			GameInformation.EquipOffensiveHardware(BaseOffensiveHardware.Find(3));
			break;
		case("Tracer"):
			GameInformation.EquipOffensiveHardware(BaseOffensiveHardware.Find(4));
			break;
		}
	}
}
