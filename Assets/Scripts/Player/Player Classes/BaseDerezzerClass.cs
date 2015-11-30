using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[System.Serializable]
public class BaseDerezzerClass : BaseClass {
	
	public BaseDerezzerClass(){
		ClassName = "Derezzer";
		ClassDescription = "Powerful software specialist: Derezzers have a natural talent for manipulating data.";
		
		Strength = 1;
		Dexterity = 1;
		Intellect = 5;
		RAM = 2;
		AddFunctionToPlayer(1);
	}

	public override void AddFunctionToPlayer(int playerCPU){
		switch(playerCPU){
		case(1):
			functions.Add(BaseFunction.FindByName("Attack"));
			break;
		case(3):
			functions.Add(BaseFunction.FindByName("Data Pulse"));
			break;
		}
	}
}
