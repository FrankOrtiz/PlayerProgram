using UnityEngine;
using System.Collections;

public class DisplayCreatePlayerFunctions {

	private int classSelection;
	private string playerName = "";
	private string[] classSelectionNames = new string[] {"Warden", "Derezzer", "Tracer"};

	public void DisplayClassSelection(){
		classSelection = GUI.SelectionGrid(new Rect(Screen.width/3, Screen.height/3, 250, 75), classSelection, classSelectionNames, 3);
		GUI.Label(new Rect(Screen.width/5, 50, 300, 300), ClassDescription(classSelection));
		GUI.Label(new Rect(Screen.width/5, Screen.height/5, 300, 300), ClassAttributes(classSelection));

		if(GUI.Button(new Rect(Screen.width/2, Screen.height - Screen.height/2, 100, 25), "Next")){
			ChooseClass(classSelection);
			GameInformation.PlayerName = playerName;
			CreatePlayerGUI.currentState = CreatePlayerGUI.CreatePlayerStates.FINALSETUP;
		}
	}

	private string ClassDescription(int classSelection){
		if(classSelection.Equals(0)){
			BaseClass tempClass = new BaseWardenClass();
			return tempClass.ClassDescription;
			
		} else if(classSelection.Equals(1)){
			BaseClass tempClass = new BaseDerezzerClass();
			return tempClass.ClassDescription;
			
		} else if(classSelection.Equals(2)){
			BaseClass tempClass = new BaseTracerClass();
			return tempClass.ClassDescription;
		}
		return "Choose your path.";
	}

	private string ClassAttributes(int classSelection){
		if(classSelection.Equals(1)){
			BaseClass tempClass = new BaseDerezzerClass();
			string tempStats = StatString(tempClass);
			return tempStats;
			
		} else if(classSelection.Equals(2)){
			BaseClass tempClass = new BaseTracerClass();
			string tempStats = StatString(tempClass);
			return tempStats;
		}else{
			BaseClass tempClass = new BaseWardenClass();
			string tempStats = StatString(tempClass);
			return tempStats;
		}
	}

	private string StatString(BaseClass tempClass){
		return "RAM " + tempClass.RAM + "\nStrength " +tempClass.Strength + "\nDexterity " +tempClass.Dexterity + "\nIntellect " +tempClass.Intellect;
	}

	private void ChooseClass(int classSelection){
		if(classSelection.Equals(0)){
			GameInformation.PlayerClass = new BaseWardenClass();
			
		} else if(classSelection.Equals(1)){
			GameInformation.PlayerClass = new BaseDerezzerClass();
			
		} else if(classSelection.Equals(2)){
			GameInformation.PlayerClass = new BaseTracerClass();
		}
	}

	public void DisplayNewName(){
		GUI.Label(new Rect(Screen.width/3, Screen.height/3 + 150, 180, 300), "Enter player name");
		playerName = GUI.TextArea(new Rect(Screen.width/3, Screen.height/3 + 200, 180, 25), playerName, 15);
	}
	
	public void DisplayFinalSetup(){
		GUI.Label(new Rect(Screen.width/3, 35, 250, 100), "Character name: " + GameInformation.PlayerName);
		GUI.Label(new Rect(Screen.width/3, 50, 250, 100), GameInformation.PlayerClass.ClassName);
		GUI.Label(new Rect(Screen.width/3, 80, 250, 100), ClassAttributes(classSelection));
		GUI.Label(new Rect(Screen.width/3, 180, 250, 100), "Is this correct?");
		if (GUI.Button(new Rect(Screen.width/3, 200, 100, 25), "Yes")){
			GameInformation.SetupInformation();
			AutoFade.LoadLevel (1, 0, 1, Color.black);
		}
		if (GUI.Button(new Rect(Screen.width/2, 200, 100, 25), "No")){
			CreatePlayerGUI.currentState = CreatePlayerGUI.CreatePlayerStates.CLASSSELECTION;
		}
	}

	public void DisplayUI(){
		GUI.Label(new Rect(Screen.width/3, 20, 250, 100), "Character Creation");
	}
	
}
