using UnityEngine;
using System.Collections;

public class CreateProcedure : MonoBehaviour {

	private BaseProcedure newProcedure;

	private void CreateNewProcedure(){

		newProcedure = new BaseProcedure();
		ChooseProcedureType ();

		newProcedure.ItemName = "Procedure";
		newProcedure.ItemDescription = "New Procedure";
		newProcedure.ItemID = Random.Range (1, 100);
	}

	private void ChooseProcedureType(){
		int randomTemp = Random.Range (1, 6);
		if (randomTemp == 1) {
			newProcedure.ProcedureType = BaseProcedure.ProcedureTypes.RAM;
		} else if (randomTemp == 2) {
			newProcedure.ProcedureType = BaseProcedure.ProcedureTypes.STRENGTH;
		} else if (randomTemp == 3) {
			newProcedure.ProcedureType = BaseProcedure.ProcedureTypes.INTELLECT;
		} else if (randomTemp == 4) {
			newProcedure.ProcedureType = BaseProcedure.ProcedureTypes.DEXTERITY;
		} else if (randomTemp == 5) {
			newProcedure.ProcedureType = BaseProcedure.ProcedureTypes.FUNCTION;
		}
	}

}