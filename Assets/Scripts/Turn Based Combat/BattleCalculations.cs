using UnityEngine;
using System.Collections;

public class BattleCalculations {
	//	private BasePlayer player = GameInformation;
	private StatCalculations statCalcScript = new StatCalculations();
	
	private int totalDamage;
	
	public void CalculatePlayerFunctionDamage(BaseFunction usedFunction){
		totalDamage = (int)CalculateFunctionIntensity(usedFunction);
		TurnBasedCombatStateMachine.Enemy.RAM -= totalDamage;
		Debug.Log(TurnBasedCombatStateMachine.Enemy.RAM);
		AnalyzeOutcome();
	}
	
	private float CalculateFunctionIntensity(BaseFunction usedFunction){
		float totalModified = statCalcScript.FunctionIntensityModifications(usedFunction.StrengthModifier, usedFunction.DexterityModifier, usedFunction.IntellectModifier, usedFunction.WeaponModifier);
		if(totalModified > 0){
			return usedFunction.Intensity * (totalModified * statCalcScript.FunctionIntensityRange());
		} else {
			return usedFunction.Intensity * statCalcScript.FunctionIntensityRange();
		}
	}

	private void AnalyzeOutcome(){
		if(TurnBasedCombatStateMachine.Enemy.RAM <= 0 ){
			TurnBasedCombatStateMachine.currentState = TurnBasedCombatStateMachine.BattleStates.WIN;
		} else {
			TurnBasedCombatStateMachine.currentState = TurnBasedCombatStateMachine.BattleStates.ENEMYCHOICE;
		}
	}
	
}
