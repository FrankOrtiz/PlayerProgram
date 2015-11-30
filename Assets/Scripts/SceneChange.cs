using UnityEngine;
using System.Collections;

public class SceneChange : MonoBehaviour {
	public string nextScene;
	public string direction;
	public Vector3 position;
	private PlayerMovement player;

	void Start(){
		player = GameObject.Find("Player").GetComponent<PlayerMovement>();
	}
	
	public IEnumerator NewRoom(){
		if (player.transform.position.Equals(gameObject.transform.position)) {
			player.IgnoreTriggers = true;
			AutoFade.LoadLevel (nextScene, 0, 1, Color.black);
			yield return 0;
			player.SetPosition (position, direction); // set player position
			player.IgnoreTriggers = false;
			GameInformation.CurrentRoom = nextScene;
		}
	}
	
	public static void Encounter(){
		AutoFade.LoadLevel ("Battle_Scene", 0, 1, Color.black);
	}
}