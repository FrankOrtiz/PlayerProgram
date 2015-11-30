using UnityEngine;
using System.Collections;

public class CreateDefensiveHardware : MonoBehaviour {

	private BaseDefensiveHardware newHardware;
	private string[] rarities = new string[4]{"Common", "Rare", "Relic", "Anomaly"};
	
	public void CreateHardware(){
		
		newHardware = new BaseDefensiveHardware();
		ChooseHardwareType ();

		newHardware.ItemName = "DHW" + Random.Range(1,100);
		newHardware.Rarity = rarities [Random.Range (0, 4)];
		newHardware.ItemDescription = "Description" + Random.Range(1,100);
		newHardware.ItemID = Random.Range (1, 100);

		newHardware.CPURequirement = Random.Range (1, 100);

		newHardware.Strength = Random.Range (1, 3) * newHardware.CPURequirement;
		newHardware.Dexterity = Random.Range (1, 3) * newHardware.CPURequirement;
		newHardware.Intellect = Random.Range (1, 3) * newHardware.CPURequirement;

		newHardware.RAM = Random.Range (1, 3) * newHardware.CPURequirement;
	}
		
	private void ChooseHardwareType(){
		int randomTemp = Random.Range (1, 5);
		if (randomTemp == 1) {
			newHardware.DefensiveHardwareType = BaseDefensiveHardware.DefensiveHardwareTypes.SHELL;
		} else if (randomTemp == 2) {
			newHardware.DefensiveHardwareType = BaseDefensiveHardware.DefensiveHardwareTypes.PROCESSOR;
		} else if (randomTemp == 3) {
			newHardware.DefensiveHardwareType = BaseDefensiveHardware.DefensiveHardwareTypes.EXPANSION;
		} else if (randomTemp == 4) {
			newHardware.DefensiveHardwareType = BaseDefensiveHardware.DefensiveHardwareTypes.COROUTINE;
		}
	}
}
