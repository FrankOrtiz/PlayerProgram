using UnityEngine;
using System.Collections;

public class CreateOffensiveHardware : MonoBehaviour {

	private BaseOffensiveHardware newHardware;
	private string[] rarities = new string[4]{"Common", "Rare", "Relic", "Anomaly"};

	public void CreateHardware(int teir, float relic, float rare, float iceWeight, float ramWeight, float strWeight, float intWeight, float dexWeight){
		int level = DetermineLevel(teir);

		newHardware = new BaseOffensiveHardware();
		ChooseHardwareType ();
		newHardware.ItemName = "OHW" + Random.Range(1,100);
		newHardware.RAM =  DetermineStatValue(level, newHardware.Rarity, ramWeight);;
		newHardware.ItemDescription = "Description" + Random.Range(1,100);
		newHardware.Generic = true;
		BaseHardware.GenericID += 1;
		newHardware.ItemID = BaseHardware.GenericID;
		newHardware.CPURequirement = level;
		newHardware.Strength = DetermineStatValue(level, newHardware.Rarity, strWeight);
		newHardware.Dexterity = DetermineStatValue(level, newHardware.Rarity, dexWeight);
		newHardware.Intellect = DetermineStatValue(level, newHardware.Rarity, intWeight);

		ChooseRarityType(relic, rare); // 0.03f, 0.15f == 0.03% & 0.15%
	}

	private int DetermineStatValue(int level, string rarity, float weight){
		float maxValue = 2f;
		if (rarity=="Rare") {
			maxValue = 3f + weight;
		} else if (rarity=="Relic") {
			maxValue = 4f + weight;
		}
		float statValue = (float)level * Random.Range (1f,maxValue);
		return  (int)statValue;
	}

	private int DetermineLevel(int teir){
		switch(teir){
		case(1):
			return Random.Range (1,5);
		case(2):
			return Random.Range (6,10);
		}
		return 0;
	}

	private void ChooseRarityType(float relic, float rare){
		float randomTemp = Random.Range (0f, 100f);
		if(randomTemp <= relic) {
			newHardware.Rarity = rarities [2]; // relic
		} else if(randomTemp <= rare) {
			newHardware.Rarity = rarities [1]; // rare
		} else {
			newHardware.Rarity = rarities [0]; // anomaly
		}
	}

	private void ChooseHardwareType(){
		int randomTemp = Random.Range (1, 7);
		if (randomTemp == 1) {
			newHardware.OffensiveHardwareType = BaseOffensiveHardware.OffensiveHardwareTypes.SABER;
		} else if (randomTemp == 2) {
			newHardware.OffensiveHardwareType = BaseOffensiveHardware.OffensiveHardwareTypes.BARRIER;
		} else if (randomTemp == 3) {
			newHardware.OffensiveHardwareType = BaseOffensiveHardware.OffensiveHardwareTypes.SPIKE;
		} else if (randomTemp == 4) {
			newHardware.OffensiveHardwareType = BaseOffensiveHardware.OffensiveHardwareTypes.DISKS;
		} else if (randomTemp == 5) {
			newHardware.OffensiveHardwareType = BaseOffensiveHardware.OffensiveHardwareTypes.TWIN_BLADES;
		} else if (randomTemp == 6) {
			newHardware.OffensiveHardwareType = BaseOffensiveHardware.OffensiveHardwareTypes.EQUALIZER;
		}
	}
}