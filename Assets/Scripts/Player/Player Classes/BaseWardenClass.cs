using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[System.Serializable]
public class BaseWardenClass : BaseClass {

	public BaseWardenClass(){
		ClassName = "Warden";
		ClassDescription = "Built to weild powerful hardware: Wardens are not the easiest programs to breach to say the least.";

		Strength = 3;
		Dexterity = 2;
		Intellect = 1;
		RAM = 300;
		AddFunctionToPlayer(1);
	}

	public override void AddFunctionToPlayer(int playerCPU){
		switch(playerCPU){
		case(1):
			functions.Add (BaseFunction.FindByName("Attack"));
			break;
		case(2):
			functions.Add (BaseFunction.FindByName("Quick Splice"));
			break;
		case(7):
			functions.Add (BaseFunction.FindByName("Modified Strike"));
			break;
		case(12):
			functions.Add (BaseFunction.FindByName("Data Pulse"));
			break;
		}
	}
}
