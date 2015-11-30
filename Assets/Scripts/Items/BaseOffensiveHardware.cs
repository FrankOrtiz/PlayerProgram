using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BaseOffensiveHardware : BaseHardware {

	public enum OffensiveHardwareTypes{
		SABER, // dual (tracer) - single with barrier (warden)
		BARRIER, // with equalizer (derezzer) - with equalizer or saber (warden)
		SPIKE, // (warden)
		DISKS, // (derezzer) - (warden)
		TWIN_BLADES, // (tracer) - (warden)
		EQUALIZER // dual (tracer) - single (derezzer) - single with barrier (warden)
	}
	private OffensiveHardwareTypes offensiveHardwareTypes;
	private int spellEffectID;

	public OffensiveHardwareTypes OffensiveHardwareType {get;set;}
	public int SpellEffectID {get;set;}

	public BaseOffensiveHardware(){}
	public BaseOffensiveHardware(Dictionary<string, string> itemsDictionary){
		WeaponDamage = int.Parse(itemsDictionary["WeaponDamage"]);
		ItemName = itemsDictionary["ItemName"];
		ItemID = int.Parse(itemsDictionary["ItemID"]);
		ItemDescription = itemsDictionary["ItemDescription"];
		ImageID = itemsDictionary["ImageID"];
		Strength = int.Parse(itemsDictionary["Strength"]);
        Dexterity = int.Parse(itemsDictionary["Dexterity"]);
		Intellect = int.Parse(itemsDictionary["Intellect"]);
		RAM = int.Parse(itemsDictionary["RAM"]);
		ICE = int.Parse(itemsDictionary["ICE"]);
        CPURequirement = int.Parse(itemsDictionary["CPURequirement"]);
		Rarity = itemsDictionary["Rarity"];
		OffensiveHardwareType = (OffensiveHardwareTypes)System.Enum.Parse(typeof(BaseOffensiveHardware.OffensiveHardwareTypes), itemsDictionary["OffensiveHardwareType"].ToString());		
	}
	
	public static BaseOffensiveHardware Find(int queryID){
//		Debug.Log(ItemDatabase.offensiveHardwareItems.Count);
		for(int i = 0; i < ItemDatabase.offensiveHardwareItems.Count; i++){
//			Debug.Log(ItemDatabase.offensiveHardwareItems[i]);
			if ( ItemDatabase.offensiveHardwareItems[i].ItemID == queryID){
				return ItemDatabase.offensiveHardwareItems[i];
			}
		}
		return ItemDatabase.offensiveHardwareItems[0];
	}
}
