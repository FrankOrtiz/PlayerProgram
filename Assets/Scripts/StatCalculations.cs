using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class StatCalculations {

	private float enemyICEModifier = 0.5f; // 50%
	private float enemyRAMModifier = 0.5f;
	private float enemyStrengthModifier = 0.25f;
	private float enemyDexterityModifier = 0.25f;
	private float enemyIntellectModifier = 0.25f;
	private float statModifier;

	public enum StatType{
		ICE,
		RAM,
		STRENGTH,
		DEXTERITY,
		INTELLECT
	}

	public int CalculateStat(int statVal, StatType statType, int level){
		SetEnemyModifire(statType);
		return(statVal + (int)((statVal * statModifier) * level));
	}

	private void SetEnemyModifire(StatType statType){
		if(statType == StatType.ICE){
			statModifier = enemyICEModifier;
		}
		if(statType == StatType.RAM){
			statModifier = enemyRAMModifier;
		}
		if(statType == StatType.STRENGTH){
			statModifier = enemyStrengthModifier;
		}
		if(statType == StatType.DEXTERITY){
			statModifier = enemyDexterityModifier;
		}
		if(statType == StatType.INTELLECT){
			statModifier = enemyIntellectModifier;
		}
	}

//	public int CalculateRAM(int statValue){
//		return (float)statValue * 100.0f; // calculating ram on total stamina stat times 100 (add ram from hardware here?)
//	}	
	public int FunctionIntensityModifications(float strMod, float dexMod, float intMod, float wepMod){
		int strInt = (int)(StatTotals.Strength() * strMod);
		int wepInt = (int)(StatTotals.WeaponDamage() * wepMod);
		int dexInt = (int)(StatTotals.Dexterity() * dexMod);
		int intInt = (int)(StatTotals.Intellect() * intMod);
		return (strInt + dexInt + intInt + wepInt);
	}

	public float FunctionIntensityRange(){
		float max = 1.2f;
		float min = 0.8f + (GameInformation.Dexterity/ (GameInformation.PlayerCPU * 20));
		return Random.Range(min, max);
	}
}
