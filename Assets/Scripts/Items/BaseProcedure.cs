using UnityEngine;
using System.Collections;

public class BaseProcedure : BaseItem {

	public enum ProcedureTypes{
		RAM,
		STRENGTH,
		INTELLECT,
		DEXTERITY,
		FUNCTION
	}
	private ProcedureTypes procedureType;
	private int spellEffectsID;

	public ProcedureTypes ProcedureType {get;set;}
	public int SpellEffectsID {get;set;}
}
