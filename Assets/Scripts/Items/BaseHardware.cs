using UnityEngine;
using System.Collections;

public class BaseHardware : BaseItem {

	private int strength;
	private int dexterity;
	private int intellect;
	private int weaponDamage;
	private int ram; // health
	private int ice; // defense
	private int cpuRequirement; // level
	private string rarity;
	private bool generic;
	public static int GenericID = 0;

	public bool Generic {get;set;}
	public string Rarity {get;set;}
	public int CPURequirement {get;set;}
	
	public int Strength {get;set;}
	public int Dexterity {get;set;}
	public int Intellect {get;set;}
	public int WeaponDamage {get;set;}

	public int RAM {get;set;}
	public int ICE {get;set;}
}
