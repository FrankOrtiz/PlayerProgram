using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[System.Serializable]
public class BaseTracerClass : BaseClass {
	
	public BaseTracerClass(){
		ClassName = "Tracer";
		ClassDescription = "Quiet, calm, and calculated: Tracers are the most dangerous when hidden.";
		
		Strength = 2;
		Dexterity = 3;
		Intellect = 2;
		RAM = 2;
		AddFunctionToPlayer(1);
	}	

	public override void AddFunctionToPlayer(int playerCPU){
		switch(playerCPU){
		case(1):
			functions.Add(BaseFunction.FindByName("Attack"));
			break;
		case(7):
			functions.Add(BaseFunction.FindByName("Data Pulse"));
			break;
		}
	}
}
