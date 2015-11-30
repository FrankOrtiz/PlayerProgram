using UnityEngine;
using System.Collections;

[System.Serializable]
public class BasePlayer {

	private string playerName;
	private int cpuLevel;
	private BaseClass playerClass;
	private int methodPoints;

	private int credits;
	
	private int ice; // defense
	private int ram; // health
	private int strength;
	private int dexterity;
	private int intellect;

	private int currentXP;
	private int requiredXP;

	// getters & setters
	public string PlayerName {get;set;}
	public int CPULevel {get;set;}
	public BaseClass PlayerClass {get;set;}
	public int MethodPoints {get;set;}

	public int Credits {get;set;}

	public int ICE {get;set;}
	public int RAM {get;set;}
	public int Strength {get;set;}
	public int Dexterity {get;set;}
	public int Intellect {get;set;}
	
	public int CurrentXP {get;set;}
	public int RequiredXP {get;set;}	
}