using UnityEngine;
using System.Collections;

public class StatTotals {
	
	public static int baseStrength = GameInformation.Strength;
	public static int baseDexterity = GameInformation.Dexterity;
	public static int baseIntellect = GameInformation.Intellect;
	public static int baseICE = GameInformation.ICE;
	public static int baseRAM = GameInformation.RAM;
	
	public static BaseDefensiveHardware shell = GameInformation.EquipedShell;
	public static BaseDefensiveHardware processor = GameInformation.EquipedProcessor;
	public static BaseDefensiveHardware expansion1 = GameInformation.EquipedExpansion1;
	public static BaseDefensiveHardware expansion2 = GameInformation.EquipedExpansion2;
	public static BaseDefensiveHardware coroutine = GameInformation.EquipedCoroutine;
	public static BaseOffensiveHardware mainHand = GameInformation.EquipedMainHand;
	public static BaseOffensiveHardware offHand = GameInformation.EquipedOffHand;

	public static int Strength(){
		return EquipedStatTotal("strength") + baseStrength;
	}

	public static int Dexterity(){
		return EquipedStatTotal("dexterity") + baseDexterity;
	}

	public static int Intellect(){
		return EquipedStatTotal("intellect") + baseIntellect;
	}
	
	public static int ICE(){
		return EquipedStatTotal("ICE") + baseICE;
	}
	
	public static int RAM(){
		return EquipedStatTotal("RAM") + baseRAM;
	}

	public static int EquipedStatTotal(string stat){
		return ValueFromHardware(shell, stat) + ValueFromHardware(processor, stat) + ValueFromHardware(expansion1, stat) + ValueFromHardware(expansion2, stat) + ValueFromHardware(coroutine, stat) + ValueFromHardware(mainHand, stat) + ValueFromHardware(offHand, stat);
	}

	public static int BonusStatTotal(string stat){
		// measure based on method points spent
		return 0;
	}

	public static int ValueFromHardware(BaseHardware hardware, string stat){
		if(hardware != null){
			switch(stat){
			case("strength"):
				return hardware.Strength;
			case("dexterity"):
				return hardware.Dexterity;
			case("intellect"):
				return hardware.Intellect;
			case("ICE"):
				return hardware.ICE;
			case("RAM"):
				return hardware.RAM;
			}
		}
		return 0;
	}
	
	public static int WeaponDamage(){
		int weaponsEquiped = 0;
		int main = 0;
		int off = 0;
		if(GameInformation.MainHandIsEquiped){
			main = GameInformation.EquipedMainHand.WeaponDamage;
			weaponsEquiped += 1;
		}
		if(GameInformation.OffHandIsEquiped){
			off = GameInformation.EquipedOffHand.WeaponDamage;
			weaponsEquiped += 1;
		}
		return (main+off/weaponsEquiped);
	}
}
