using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameInformation : MonoBehaviour {

	void Awake() {
		DontDestroyOnLoad (gameObject);
	}

	public static List<BaseFunction> PlayerFunctions;

	public static string PlayerName {get;set;}
	public static BaseClass PlayerClass {get;set;}

	public static int PlayerCPU {get;set;}

	public static int MethodPoints {get;set;}

	public static int CurrentXP {get;set;}
	public static int RequiredXP {get;set;}

	public static int ICE {get;set;}
	public static int RAM {get;set;}
	public static int Strength {get;set;}
	public static int Dexterity {get;set;}
	public static int Intellect {get;set;}

	public static int Credits {get;set;}
	
	public static BaseDefensiveHardware EquipedShell {get;set;}
	public static BaseDefensiveHardware EquipedProcessor {get;set;}
	public static BaseDefensiveHardware EquipedExpansion1 {get;set;}
	public static BaseDefensiveHardware EquipedExpansion2 {get;set;}
	public static BaseDefensiveHardware EquipedCoroutine {get;set;}

	public static BaseOffensiveHardware EquipedMainHand {get;set;}
	public static BaseOffensiveHardware EquipedOffHand {get;set;}

	public static bool MainHandIsEquiped {get;set;}
	public static bool OffHandIsEquiped {get;set;}

	public static string CurrentRoom {get;set;}

	public static int CurrentRAM {get;set;}

	public static void SetupInformation(){
		BaseClass.StartingHardware();
		SetupStats();
	}
	
	private static void SetupStats(){
		PlayerCPU = 1;
		BaseClass classType = PlayerClass;
		RAM = classType.RAM;
		CurrentRAM = classType.RAM;
		CurrentXP = 0;
		LevelUp.DetermineRequiredXP();
		Strength = classType.Strength;
		Dexterity = classType.Dexterity;
		Intellect = classType.Intellect;
		PlayerFunctions = PlayerClass.functions;
		
	}
	
	public static void EquipOffensiveHardware(BaseOffensiveHardware newHardware){ // check for main or off as an argument
		switch(newHardware.OffensiveHardwareType){
		case(BaseOffensiveHardware.OffensiveHardwareTypes.SABER):
			GameInformation.EquipedMainHand = newHardware;
			GameInformation.MainHandIsEquiped = true;
			break;
		case(BaseOffensiveHardware.OffensiveHardwareTypes.BARRIER):
//			Debug.Log(newHardware.ItemName);
			GameInformation.EquipedOffHand = newHardware;
			GameInformation.OffHandIsEquiped = true;
			break;
		case(BaseOffensiveHardware.OffensiveHardwareTypes.SPIKE):
			// EquipBothHands(newHardware) to remove main and off
			GameInformation.EquipedMainHand = newHardware;
			GameInformation.MainHandIsEquiped = true;
			break;
		case(BaseOffensiveHardware.OffensiveHardwareTypes.DISKS):
			GameInformation.EquipedMainHand = newHardware;
			GameInformation.MainHandIsEquiped = true;
			break;
		case(BaseOffensiveHardware.OffensiveHardwareTypes.TWIN_BLADES):
			GameInformation.EquipedMainHand = newHardware;
			GameInformation.MainHandIsEquiped = true;
			break;
		case(BaseOffensiveHardware.OffensiveHardwareTypes.EQUALIZER):
			GameInformation.EquipedMainHand = newHardware;
			GameInformation.MainHandIsEquiped = true;
			break;
		}
	}
	
	public void EquipDeffensiveHardware(BaseDefensiveHardware newHardware){
	}
}