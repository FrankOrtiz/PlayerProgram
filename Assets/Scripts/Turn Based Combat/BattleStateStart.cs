using UnityEngine;
using System.Collections;

public class BattleStateStart {

	public BasePlayer newEnemy = new BasePlayer ();
	private StatCalculations statCalculations = new StatCalculations ();
	private string[] enemyNames = new string[]{"Enemy1", "Enemy2"};

	public void PrepareBattle(){
		CreateNewEnemy();
		DetermineFirstTurn();
	}

	private void CreateNewEnemy(){
		// pull base values from dictionary created via xml
		newEnemy.PlayerName = enemyNames[Random.Range(0, enemyNames.Length)]; // chosen from dictionary with set stats that are slightly modified
		int highestLevel = (GameInformation.PlayerCPU / 5) * 5 + 5; // enemyTeir * 5;
		int lowestLevel = highestLevel - 5;
		
		newEnemy.CPULevel = Random.Range(lowestLevel, highestLevel+1); // replace playerlevel with enemy teir
		newEnemy.PlayerClass = new BaseWardenClass(); // replace with enemy class via randomly selected enemy
		newEnemy.ICE = statCalculations.CalculateStat(10, StatCalculations.StatType.ICE, newEnemy.CPULevel);
		newEnemy.RAM = statCalculations.CalculateStat(100, StatCalculations.StatType.RAM, newEnemy.CPULevel);
		newEnemy.Strength = statCalculations.CalculateStat(3, StatCalculations.StatType.STRENGTH, newEnemy.CPULevel);
		newEnemy.Dexterity = statCalculations.CalculateStat(3, StatCalculations.StatType.DEXTERITY, newEnemy.CPULevel);
		newEnemy.Intellect = statCalculations.CalculateStat(3, StatCalculations.StatType.INTELLECT, newEnemy.CPULevel); 
		TurnBasedCombatStateMachine.Enemy = newEnemy;
	}

	private void DetermineFirstTurn(){
		if (newEnemy.Dexterity > GameInformation.Dexterity){
			TurnBasedCombatStateMachine.currentState = TurnBasedCombatStateMachine.BattleStates.ENEMYCHOICE; // enemy goes first
		} else {
			TurnBasedCombatStateMachine.currentState = TurnBasedCombatStateMachine.BattleStates.PLAYERCHOICE; // player goes first
		}
	}

//	private void DetermineCurrentRam(){
//		GameInformation.CurrentRAM = statCalculations.CalculateRAM(GameInformation.PlayerRAM);
//	}
}
