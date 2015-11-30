using UnityEngine;
using System.Collections;

public class BaseDefensiveHardware : BaseHardware {
	
	public enum DefensiveHardwareTypes{
		SHELL, // Primary defensive item
		PROCESSOR, // Primary offensive item
		EXPANSION, // rings / necklace (2)
		COROUTINE // trinkets (1)
	}
	private DefensiveHardwareTypes defensiveHardwareTypes;
	private int bonusEffectID; // active or passive abilities (functions)
	
	public DefensiveHardwareTypes DefensiveHardwareType {get;set;}
	public int BonusEffectID {get;set;}
}
