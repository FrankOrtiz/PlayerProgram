using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HardwareDisplay : MonoBehaviour {

	private static Text[] textAreas;

	public static void PopulateHardwareGrid(GameObject playerHardware){
		// insert images and what not
		textAreas = playerHardware.GetComponentsInChildren<Text>();
		GameObject.Find("Player Hardware Panel(Clone)").GetComponent<HardwareDisplay>().DisplayMainHand();
	}

	public void DisplayMainHand(){
		if(GameInformation.MainHandIsEquiped){
			foreach(Text givenText in textAreas){
				if (givenText.name.Equals("Hardware Name Text")){
					givenText.text = GameInformation.EquipedMainHand.ItemName;
				}
				if (givenText.name.Equals("Hardware Level Text")){
					givenText.text = "CPU: " + GameInformation.EquipedMainHand.CPURequirement.ToString();
				}
				if (givenText.name.Equals("Hardware ICE Text")){
					givenText.text = "ICE: " + GameInformation.EquipedMainHand.ICE.ToString();
				}
				if (givenText.name.Equals("Hardware RAM Text")){
					givenText.text = "RAM: " + GameInformation.EquipedMainHand.RAM.ToString();
				}
				if (givenText.name.Equals("Hardware Strength Text")){
					givenText.text = "STR: " + GameInformation.EquipedMainHand.Strength.ToString();
				}
				if (givenText.name.Equals("Hardware Dexterity Text")){
					givenText.text = "DEX: " + GameInformation.EquipedMainHand.Dexterity.ToString();
				}
				if (givenText.name.Equals("Hardware Intellect Text")){
					givenText.text = "INT: " + GameInformation.EquipedMainHand.Intellect.ToString();
				}
			}
		}
	}

	public void DisplayOffHand(){
		if(GameInformation.OffHandIsEquiped){
			foreach(Text givenText in textAreas){
				if (givenText.name.Equals("Hardware Name Text")){
					givenText.text = GameInformation.EquipedOffHand.ItemName;
				}
				if (givenText.name.Equals("Hardware Level Text")){
					givenText.text = "CPU: " + GameInformation.EquipedOffHand.CPURequirement.ToString();
				}
				if (givenText.name.Equals("Hardware ICE Text")){
					givenText.text = "ICE: " + GameInformation.EquipedOffHand.ICE.ToString();
				}
				if (givenText.name.Equals("Hardware RAM Text")){
					givenText.text = "RAM: " + GameInformation.EquipedOffHand.RAM.ToString();
				}
				if (givenText.name.Equals("Hardware Strength Text")){
					givenText.text = "STR: " + GameInformation.EquipedOffHand.Strength.ToString();
				}
				if (givenText.name.Equals("Hardware Dexterity Text")){
					givenText.text = "DEX: " + GameInformation.EquipedOffHand.Dexterity.ToString();
				}
				if (givenText.name.Equals("Hardware Intellect Text")){
					givenText.text = "INT: " + GameInformation.EquipedOffHand.Intellect.ToString();
				}
			}
		}
	}

	public static void DisplayHardwareSprites(){
		if (GameInformation.EquipedMainHand != null)
			GameObject.Find("Main Hand Offensive").GetComponent<Image>().sprite = Resources.Load<Sprite>("Hardware/Offensive/" + GameInformation.EquipedMainHand.ImageID);
		if (GameInformation.EquipedOffHand != null)
			GameObject.Find("Off Hand Offensive").GetComponent<Image>().sprite = Resources.Load<Sprite>("Hardware/Offensive/" + GameInformation.EquipedOffHand.ImageID);
		if (GameInformation.EquipedShell != null)
			GameObject.Find("Shell").GetComponent<Image>().sprite = Resources.Load<Sprite>("Hardware/Defensive/" + GameInformation.EquipedShell.ImageID);
		if (GameInformation.EquipedProcessor != null)
			GameObject.Find("Processor").GetComponent<Image>().sprite = Resources.Load<Sprite>("Hardware/Defensive/" + GameInformation.EquipedProcessor.ImageID);
		if (GameInformation.EquipedExpansion1 != null)
			GameObject.Find("Expansion 1").GetComponent<Image>().sprite = Resources.Load<Sprite>("Hardware/Defensive/" + GameInformation.EquipedExpansion1.ImageID);
		if (GameInformation.EquipedExpansion2 != null)
			GameObject.Find("Expansion 2").GetComponent<Image>().sprite = Resources.Load<Sprite>("Hardware/Defensive/" + GameInformation.EquipedExpansion2.ImageID);
		if (GameInformation.EquipedCoroutine != null)
			GameObject.Find("Coroutine").GetComponent<Image>().sprite = Resources.Load<Sprite>("Hardware/Defensive/" + GameInformation.EquipedCoroutine.ImageID);
	}
}
