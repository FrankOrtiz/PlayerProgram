using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	private float speed = 2.0f;
	private Vector3 position;
	public LayerMask blockingLayer;
	public LayerMask eventLayer;
	private BoxCollider boxCollider;
	private GameObject mainCamera;
	private bool canMove = true;

	public bool IgnoreTriggers {get;set;}
	public bool CanMove {get;set;}
	public float Speed {get;set;}

	void Awake() {
		DontDestroyOnLoad (gameObject);
	}

	void Start () {
		CanMove =true;
		mainCamera = GameObject.Find ("Main Camera");
		boxCollider = GetComponent <BoxCollider> ();
		position = transform.position;
	}
	
	void Update () {
		Debug.Log("Current Exp: " + GameInformation.CurrentXP);
		mainCamera.transform.position = new Vector3(transform.position.x,transform.position.y,-10); // center player on screen
		PlayerCommands (); // listens for player input
		if (Collision (position.x, position.y)) {
			position.x = Mathf.RoundToInt (transform.position.x);
			position.y = Mathf.RoundToInt (transform.position.y);
		}
		else {
			transform.position = Vector3.MoveTowards(transform.position, position, Time.deltaTime * speed); // allows for position manipulation
		}
		canMove = CanMove;
	}

	public void MovePlayer(string direction){
		if(direction.Equals("RIGHT")){position += Vector3.right;}
		else if (direction.Equals("LEFT")){position += Vector3.left;}
		else if (direction.Equals("UP")){position += Vector3.up;} 
		else if (direction.Equals("DOWN")){position += Vector3.down;}
	}

	public void AutoMove(string direction){
			// player has been set to move
//			Debug.Log ("SET MOV " + direction);
			// player will be moved
			MovePlayer (direction);
	}

	private void PlayerCommands(){
		// for debugging
		if (Input.GetKeyUp("space")){
//			Debug.Log ("Position x and y are whole numbers: " + ((transform.position.x == Mathf.RoundToInt (transform.position.x)) && (transform.position.x == Mathf.RoundToInt (transform.position.x))).ToString());
		}
		if (Input.GetButton ("Sprint")) {speed = 10.0f;} else {speed = 2.0f;}
		if (canMove) {
			if (Input.GetButton("Horizontal") && transform.position == position){
				if(Input.GetAxisRaw("Horizontal") >= 0){MovePlayer("RIGHT");}
				else {MovePlayer("LEFT");}
				ChanceOfEncounter();
			}
			if (Input.GetButton("Vertical") && transform.position == position){
				if(Input.GetAxisRaw("Vertical") >= 0){MovePlayer("UP");}
				else{MovePlayer("DOWN");}
				ChanceOfEncounter();
			}
		}
	}

	bool Collision(float xDir, float yDir){
		Vector3 start = transform.position; // mark start position
		Vector3 end = new Vector3 (xDir, yDir); // determine end position
		boxCollider.enabled = false; // disable collider (can hit own collider)
		bool hit = Physics2D.Linecast (start, end, blockingLayer); // test for collision
//		if (hit) {Debug.Log("HIT");}
		boxCollider.enabled = true; // re-enable collider
		return hit;
	}

	public void SetPosition(Vector3 intendedLocation, string direction){
		if (!(string.IsNullOrEmpty (direction))) {
			// set player motion during scene change if specified
			AutoMove (direction);
			// note that the player has been moved
		} else {
			// log intended position
//			Debug.Log ("SET POS (xyz) " + intendedLocation.ToString ());
			// set player position to intended position
			transform.position = intendedLocation;
		}
	}

	private void OnTriggerEnter(Collider other){
		if (!IgnoreTriggers){
			if ((canMove) && (other.gameObject.layer == 9)){
				StartEvent(other.gameObject);
			}
		}
	}

	private void StartEvent(GameObject collisionObj){
		if(collisionObj.tag.Equals("Exit")){
			StartCoroutine(collisionObj.GetComponent<SceneChange>().NewRoom());
		}
	}

	private void ChanceOfEncounter(){
//		float p = 50.0f/187.5f;
		float p = 10f;
		if (Random.Range(0f, 100f) <= p){
			CanMove = false;
			SceneChange.Encounter();
		} 
	}
}







