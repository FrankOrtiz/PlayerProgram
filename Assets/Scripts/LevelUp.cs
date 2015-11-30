using UnityEngine;
using System.Collections;

public class LevelUp {

	public int maxLevel = 100;

	public void LevelUpCharacter(){
		// check to see if current xp > requiredxp
		if (GameInformation.CurrentXP > GameInformation.RequiredXP) {GameInformation.CurrentXP -= GameInformation.RequiredXP;} 
		else {GameInformation.CurrentXP = 0;}

		// level up if not max level
		if (GameInformation.PlayerCPU < maxLevel) {GameInformation.PlayerCPU += 1;} 
		else {GameInformation.PlayerCPU = maxLevel;}

		// give attribute boost (stat)
		// check if player gains a function (abilitiy)
		CheckIfFunctionGained();
		// give a method point (talent point)
		// GameInformation.MethodPoints += 1;
		// determine next required xp
		DetermineRequiredXP();
	}
	
//	private void DetermineRequiredXP(){
//		int calculatedRequirement = (GameInformation.PlayerLevel * 1000) + 250;
//		GameInformation.RequiredXP = calculatedRequirement;
//	}
	
	public static void DetermineRequiredXP(){
		int calculatedRequirement = (GameInformation.PlayerCPU * 1000) + 250;
		GameInformation.RequiredXP = calculatedRequirement;
	}

	private void DetermineAttributeIncrease(){

	}

	private void CheckIfFunctionGained(){
		GameInformation.PlayerClass.AddFunctionToPlayer(GameInformation.PlayerCPU);
	}
}
