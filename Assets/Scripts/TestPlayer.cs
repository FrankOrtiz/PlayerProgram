using UnityEngine;
using System.Collections;

public class TestPlayer : MonoBehaviour {

	// Use this for initialization
	void Start () {
//		GameInformation.PlayerClass = new BaseWardenClass();
//		GameInformation.PlayerName = "VomTesty";
//		GameInformation.PlayerCPU = 1;
//		GameInformation.RAM = GameInformation.PlayerClass.RAM;
//		GameInformation.Strength = GameInformation.PlayerClass.Strength;
//		GameInformation.Intellect = GameInformation.PlayerClass.Intellect;
//		GameInformation.Dexterity = GameInformation.PlayerClass.Dexterity;
//		GameInformation.EquipOffensiveHardware(BaseOffensiveHardware.Find(1));
//		GameInformation.EquipOffensiveHardware(BaseOffensiveHardware.Find(2));
//		GameInformation.playerFunctions = GameInformation.PlayerClass.functions;
//		GameInformation.playerFunctions.Add(BaseFunction.Find(2));
	}

	public static BaseOffensiveHardware TestEqualizer(){
		BaseOffensiveHardware newEqualizer = new BaseOffensiveHardware();
		newEqualizer.OffensiveHardwareType = BaseOffensiveHardware.OffensiveHardwareTypes.EQUALIZER;
		newEqualizer.ItemName = "Equalizer of a Thousand Truths";
		newEqualizer.Rarity = "Anomaly";
		newEqualizer.ItemDescription = "You are not prepared.";
		newEqualizer.ItemID = -1;
		newEqualizer.ImageID= "equalizer_common_5";
		
		newEqualizer.CPURequirement = 1;
		
		newEqualizer.Strength = 10;
		newEqualizer.Dexterity = 10;
		newEqualizer.Intellect = 10;
		
		newEqualizer.RAM = 10;
		return newEqualizer;
	}

	public static BaseOffensiveHardware TestBarrier(){
		BaseOffensiveHardware newBarrier = new BaseOffensiveHardware();
		newBarrier.OffensiveHardwareType = BaseOffensiveHardware.OffensiveHardwareTypes.BARRIER;
		
		newBarrier.ItemName = "Unbreakable Barrier";
		newBarrier.Rarity = "Anomaly";
		newBarrier.ItemDescription = "If you breach this barrier, you'll realize you never did.";
		newBarrier.ItemID = -1;
		newBarrier.ImageID= "barrier_common_2";
		
		newBarrier.CPURequirement = 1;
		
		newBarrier.Strength = 10;
		newBarrier.Dexterity = 10;
		newBarrier.Intellect = 10;
		newBarrier.ICE = 10;

		newBarrier.RAM = 10;
		return newBarrier;
	}
}
