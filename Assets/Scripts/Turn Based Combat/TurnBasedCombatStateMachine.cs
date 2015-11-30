using UnityEngine;
using System.Collections;

public class TurnBasedCombatStateMachine : MonoBehaviour {

	private BattleStateStart battleStartScript = new BattleStateStart();
	private bool hasAddedExp;
	public static BasePlayer Enemy {get;set;}
	
	private BattleCalculations battleCalcScript = new BattleCalculations();
	public static BaseFunction playerFunctionUsed;

	public enum BattleStates{
		START,
		PLAYERCHOICE,
		ENEMYCHOICE,
		CALCDAMAGE,
		STATUSEFFECTS,
		LOSE,
		WIN
	}

	public static BattleStates currentState;

	void Start(){
		currentState = BattleStates.START;
		hasAddedExp = false;
	}

	void Update(){
		switch(currentState){
		case(BattleStates.START):
			battleStartScript.PrepareBattle();
			break;
		case(BattleStates.PLAYERCHOICE):
			break;
		case(BattleStates.ENEMYCHOICE):
			break;
		case(BattleStates.CALCDAMAGE):
			battleCalcScript.CalculatePlayerFunctionDamage(playerFunctionUsed);
			break;
		case(BattleStates.STATUSEFFECTS):
			break;
		case(BattleStates.LOSE):
			break;
		case(BattleStates.WIN):
			if(!hasAddedExp){
				IncreaseExperience.AddExperience();
				hasAddedExp = true;
			}
			GameObject.Find("Player").GetComponent<PlayerMovement>().CanMove = true;
			AutoFade.LoadLevel (GameInformation.CurrentRoom, 0, 1, Color.black);
			break;
		}
	}

	public static void TestTurns(){
		if(GUI.Button(new Rect(100,100,100,30), "Player Turn")){
			if(TurnBasedCombatStateMachine.currentState != TurnBasedCombatStateMachine.BattleStates.PLAYERCHOICE){
				TurnBasedCombatStateMachine.currentState = TurnBasedCombatStateMachine.BattleStates.PLAYERCHOICE;
			}
		}
		if(GUI.Button(new Rect(150,150,100,30), "Win Battle")){
			if(TurnBasedCombatStateMachine.currentState != TurnBasedCombatStateMachine.BattleStates.WIN){
				TurnBasedCombatStateMachine.currentState = TurnBasedCombatStateMachine.BattleStates.WIN;
			}
		}
		if(GUI.Button(new Rect(200,200,100,30), "Next Turn")){
			switch(currentState){
			case(BattleStates.ENEMYCHOICE):
				currentState = BattleStates.PLAYERCHOICE;
				break;
			case(BattleStates.CALCDAMAGE):
				currentState = BattleStates.STATUSEFFECTS;
				break;
			case(BattleStates.STATUSEFFECTS):
				currentState = BattleStates.ENEMYCHOICE;
				break;
			}
		}
	}
}