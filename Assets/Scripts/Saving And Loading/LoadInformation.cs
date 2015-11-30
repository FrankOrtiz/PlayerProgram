using UnityEngine;
using System.Collections;

public class LoadInformation : MonoBehaviour {

	// LoadInformation.LoadAllInformation();
	public static void LoadAllInformation(){

		GameInformation.PlayerName = PlayerPrefs.GetString ("PLAYERNAME");
		GameInformation.PlayerClass = (BaseClass)PlayerPrefSerialization.Load ("PLAYERCLASS");
		GameInformation.PlayerCPU = PlayerPrefs.GetInt ("PLAYERCPU");

		GameInformation.Credits = PlayerPrefs.GetInt ("CREDITS");
		

		GameInformation.RAM = PlayerPrefs.GetInt ("PLAYERRAM");

		GameInformation.Strength = PlayerPrefs.GetInt ("PLAYERSTRENGTH");
		GameInformation.Dexterity = PlayerPrefs.GetInt ("PLAYERDEXTERITY");
		GameInformation.Intellect = PlayerPrefs.GetInt ("PLAYERINTELLECT");

	}

	public void LoadCurrentlyEquiped(){
		// Save Defensive Hardware
			// Shell
			if (GameInformation.EquipedShell != null) 
				{GameInformation.EquipedShell = (BaseDefensiveHardware)PlayerPrefSerialization.Load ("SHELL");}
			// Processor
			if (GameInformation.EquipedProcessor != null)
				{GameInformation.EquipedProcessor = (BaseDefensiveHardware)PlayerPrefSerialization.Load ("PROCESSOR");}
			// Expansion 1
			if (GameInformation.EquipedExpansion1 != null)
				{GameInformation.EquipedExpansion1 = (BaseDefensiveHardware)PlayerPrefSerialization.Load ("EXPANSION1");}
			// Expansion 2
			if (GameInformation.EquipedExpansion2 != null) 
				{GameInformation.EquipedExpansion2 = (BaseDefensiveHardware)PlayerPrefSerialization.Load ("EXPANSION2");}
			// Coroutine
			if (GameInformation.EquipedCoroutine != null)
				{GameInformation.EquipedCoroutine = (BaseDefensiveHardware)PlayerPrefSerialization.Load ("COROUTINE");}
			
		// Save Offensive Hardware
			// Main hand
			if (GameInformation.EquipedMainHand != null) 
				{PlayerPrefSerialization.Load ("MAINHAND");}
			// Off hand
			if (GameInformation.EquipedOffHand != null) 
				{PlayerPrefSerialization.Load ("OFFHAND");}
	}
}
