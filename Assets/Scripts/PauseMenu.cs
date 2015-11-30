using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PauseMenu : MonoBehaviour {
	public GameObject pauseMenu;
	public GameObject toggleSpec;
	private Text toggleText;

	public static bool Paused {get;set;}

	void Awake(){
		DontDestroyOnLoad(gameObject);
		toggleText = toggleSpec.GetComponent<Text>();
	}

	void Update()
	{
		if(Input.GetKeyDown(KeyCode.Escape))
			Paused = TogglePause();
	}
	
	bool TogglePause()
	{
		if(Time.timeScale == 0f)
		{
			pauseMenu.SetActive(false);
			Time.timeScale = 1f;
			return(false);
		}
		else
		{
			pauseMenu.SetActive(true);
			Time.timeScale = 0f;
			return(true);    
		}
	}

	public void ButtonTogglePause(){
		Paused = TogglePause();
	}

	public void TogglePlayerSpecs(){
		if(toggleText.text.Equals("Back to menu")){
			GameObject.Find ("Player Specs Text").GetComponent<Text>().text = "Player Specs";
			Destroy(GameObject.Find("Player Specs Panel(Clone)"));
			GameObject.Find ("Player Hardware Text").GetComponent<Text>().text = "Player Hardware";
			Destroy(GameObject.Find("Player Hardware Panel(Clone)"));
		}else{
			GameObject playerSpecs = (GameObject)Instantiate(Resources.Load("Player Specs Panel"));
			playerSpecs.transform.SetParent(pauseMenu.transform, false);
			GameObject.Find ("Player Specs Text").GetComponent<Text>().text = "Back to menu";
			Text[] textAreas = playerSpecs.GetComponentsInChildren<Text>();
			PopulateSpecs(textAreas);
		}
	}

	private void PopulateSpecs(Text[] textAreas){
		foreach(Text givenText in textAreas){
			if (givenText.name.Equals("Player Name Text")){
				givenText.text = GameInformation.PlayerName;
			}
			if (givenText.name.Equals("Player Level Text")){
				givenText.text = "CPU Level: " + GameInformation.PlayerCPU.ToString();
			}
			if (givenText.name.Equals("Player Experience Text")){
				givenText.text = "Next Level: " + GameInformation.CurrentXP.ToString() + "/" + GameInformation.RequiredXP;
			}
			if (givenText.name.Equals("Player RAM Text")){
				givenText.text = "RAM: "+GameInformation.CurrentRAM.ToString() + "/" +GameInformation.RAM.ToString();
			}
			if (givenText.name.Equals("Player Strength Text")){
				givenText.text = "STR: " +GameInformation.Strength.ToString();
			}
			if (givenText.name.Equals("Player Dexterity Text")){
				givenText.text = "DEX: " +GameInformation.Dexterity.ToString();
			}
			if (givenText.name.Equals("Player Intellect Text")){
				givenText.text = "INT: " +GameInformation.Dexterity.ToString();
			}
		}
	}

	public void TogglePlayerHardware(){
		GameObject playerHardware = (GameObject)Instantiate(Resources.Load("Player Hardware Panel"));
		playerHardware.transform.SetParent(pauseMenu.transform, false);
		GameObject.Find ("Player Specs Text").GetComponent<Text>().text = "Back to menu";
		HardwareDisplay.DisplayHardwareSprites();
		HardwareDisplay.PopulateHardwareGrid(playerHardware);
	}
}
