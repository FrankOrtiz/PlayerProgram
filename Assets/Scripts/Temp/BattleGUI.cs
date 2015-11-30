using UnityEngine;
using System.Collections;

public class BattleGUI : MonoBehaviour {

	private string playerName;
	private int playerCPU;
	private int playerRAM;

	// Use this for initialization
	void Start () {
		playerName = GameInformation.PlayerName;
		playerCPU = GameInformation.PlayerCPU;
		playerRAM = GameInformation.RAM;

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI(){
		TurnBasedCombatStateMachine.TestTurns();
		if (TurnBasedCombatStateMachine.currentState == TurnBasedCombatStateMachine.BattleStates.PLAYERCHOICE){
			DisplayPlayerChoices();
		}
	}

	private void DisplayPlayerChoices(){
		for(int i = 0; i < GameInformation.PlayerFunctions.Count; i++){
			if(GUI.Button(new Rect(Screen.width/2, (Screen.height/2)/(i+1),100,30), GameInformation.PlayerFunctions[i].Name)){
				TurnBasedCombatStateMachine.playerFunctionUsed = GameInformation.PlayerFunctions[i];
				TurnBasedCombatStateMachine.currentState = TurnBasedCombatStateMachine.BattleStates.CALCDAMAGE;
			}
		}
	}

}
