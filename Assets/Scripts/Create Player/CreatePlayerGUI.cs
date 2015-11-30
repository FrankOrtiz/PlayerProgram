using UnityEngine;
using System.Collections;

public class CreatePlayerGUI : MonoBehaviour {

	public enum CreatePlayerStates{
		CLASSSELECTION, // display class types
		FINALSETUP
	}

	private DisplayCreatePlayerFunctions displayFunctions = new DisplayCreatePlayerFunctions();
	public static CreatePlayerStates currentState;

	void Start(){
		currentState = CreatePlayerStates.CLASSSELECTION;
	}

	void Update(){
		switch(currentState){
		case(CreatePlayerStates.CLASSSELECTION):
			break;
		case(CreatePlayerStates.FINALSETUP):
			break;
		}
	}

	void OnGUI(){
		displayFunctions.DisplayUI();
		if(currentState == CreatePlayerStates.CLASSSELECTION){
			// display class selection function
			displayFunctions.DisplayClassSelection();
			displayFunctions.DisplayNewName();
		}
		if(currentState == CreatePlayerStates.FINALSETUP){
			// display class selection function
			displayFunctions.DisplayFinalSetup();
		}

	}
}
