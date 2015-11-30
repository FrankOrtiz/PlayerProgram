using UnityEngine;
using System.Collections;

public class CreateNewPlayer : MonoBehaviour {

	private BasePlayer newPlayer;
	private bool isWarden;
	private bool isDerezzer;
	private bool isTracker;
	private string playerName = "EnterName";

	void Start(){
		newPlayer = new BasePlayer ();
	}

	void OnGUI(){
		if (string.IsNullOrEmpty (GameInformation.PlayerName)) {
			playerName = GUILayout.TextArea (playerName, 15);

			isWarden = GUILayout.Toggle (isWarden, "Warden Class");
			isDerezzer = GUILayout.Toggle (isDerezzer, "Derezzer Class");
			isTracker = GUILayout.Toggle (isTracker, "Tracker Class");
			if (GUILayout.Button ("Create")) {
				if (isWarden) {
					newPlayer.PlayerClass = new BaseWardenClass ();
				} else if (isDerezzer) {
					newPlayer.PlayerClass = new BaseDerezzerClass ();
				} else if (isTracker) {
					newPlayer.PlayerClass = new BaseTracerClass ();
				}

				CreatePlayer();
				StoreNewPlayerInfo ();
				SaveInformation.SaveAllInformation ();
			}
		}
	}

	private void StoreNewPlayerInfo(){
		GameInformation.PlayerName = newPlayer.PlayerName;
		GameInformation.PlayerClass = newPlayer.PlayerClass;
		GameInformation.PlayerCPU = newPlayer.CPULevel;
		GameInformation.Credits = newPlayer.Credits;
		GameInformation.RAM = newPlayer.RAM;
		GameInformation.Strength = newPlayer.Strength;
		GameInformation.Dexterity = newPlayer.Dexterity;
		GameInformation.Intellect = newPlayer.Intellect;
	}

	private void CreatePlayer(){
		newPlayer.CPULevel = 1;
		newPlayer.RAM = newPlayer.PlayerClass.RAM;
		newPlayer.Credits = 0;
		newPlayer.MethodPoints = 1;
		newPlayer.Strength = newPlayer.PlayerClass.Strength;
		newPlayer.Dexterity = newPlayer.PlayerClass.Dexterity;
		newPlayer.Intellect = newPlayer.PlayerClass.Intellect;
		newPlayer.PlayerName = playerName;
	}
}


