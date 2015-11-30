using UnityEngine;
using System.Collections;

public class SaveInformation : MonoBehaviour {

	// break into smaller funcs
	public static void SaveAllInformation(){
		PlayerPrefs.SetString ("PLAYERNAME", GameInformation.PlayerName);
		PlayerPrefSerialization.Save ("PLAYERCLASS", GameInformation.PlayerClass);
		PlayerPrefs.SetInt ("PLAYERCPU", GameInformation.PlayerCPU);

		PlayerPrefs.SetInt ("CREDITS", GameInformation.Credits);

		PlayerPrefs.SetInt ("PLAYERRAM", GameInformation.RAM);

		PlayerPrefs.SetInt ("PLAYERSTRENGTH", GameInformation.Strength);
		PlayerPrefs.SetInt ("PLAYERDEXTERITY", GameInformation.Dexterity);
		PlayerPrefs.SetInt ("PLAYERINTELLECT", GameInformation.Intellect);

		SaveCurrentlyEquiped ();

		Debug.Log ("Saved information");
	}

	static public void SaveCurrentlyEquiped(){
		// Save Defensive Hardware
			// Shell
			if (GameInformation.EquipedShell != null) {PlayerPrefSerialization.Save ("SHELL", GameInformation.EquipedShell);} 
			// Processor
			if (GameInformation.EquipedProcessor != null) {PlayerPrefSerialization.Save ("PROCESSOR", GameInformation.EquipedProcessor);} 
			// Expansion 1
			if (GameInformation.EquipedExpansion1 != null) {PlayerPrefSerialization.Save ("EXPANSION1", GameInformation.EquipedExpansion1);} 
			// Expansion 2
			if (GameInformation.EquipedExpansion2 != null) {PlayerPrefSerialization.Save ("EXPANSION2", GameInformation.EquipedExpansion2);} 
			// Coroutine
			if (GameInformation.EquipedCoroutine != null) {PlayerPrefSerialization.Save ("COROUTINE", GameInformation.EquipedCoroutine);} 

		// Save Offensive Hardware
			// Main hand
			if (GameInformation.EquipedMainHand != null) {PlayerPrefSerialization.Save ("MAINHAND", GameInformation.EquipedMainHand);} 
			// Off hand
			if (GameInformation.EquipedOffHand != null) {PlayerPrefSerialization.Save ("OFFHAND", GameInformation.EquipedOffHand);} 
	}
}
