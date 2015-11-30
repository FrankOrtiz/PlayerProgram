using UnityEngine;
using System.Collections;

public static class IncreaseExperience {

	private static float xpGranted;
	private static LevelUp levelUpScript = new LevelUp();

	public static void AddExperience(){
		// scale exp based on enemys
		xpGranted = GameInformation.PlayerCPU * 100;
		GameInformation.CurrentXP += (int)xpGranted;
		CheckIfLeveled ();
	}

	public static void AddExplorationExperience(){
		xpGranted = GameInformation.PlayerCPU * 50;
		GameInformation.CurrentXP += (int)xpGranted;
		CheckIfLeveled ();
	}

	private static void CheckIfLeveled(){
		if(GameInformation.CurrentXP >= GameInformation.RequiredXP){
			// player has leveled up
			levelUpScript.LevelUpCharacter();
		}
	}

	// add player lose exp on failure to incite training
}
