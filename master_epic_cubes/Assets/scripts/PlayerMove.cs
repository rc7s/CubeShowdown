using UnityEngine;
using System.Collections;
using Rewired;

[RequireComponent(typeof(CharacterController))]
public class PlayerMove : MonoBehaviour {

	//ctrl init vars
	public int playerId;
	private Player player;
	private CharacterController cc;

	//ctrl vars
	private float lStickX;
	private float lStickY;
	private float rStickX;
	private float rStickY;
	private bool b1;
	private bool b2;
	private bool b3;
	private bool b4;
	private bool r1;
	private bool l1;
	private float r2;
	private float l2;

//	public Rigidbody rb;
//	public Vector3 boost;
	private Vector3 moveVector;
	public float moveSpeed;

	// Use this for initialization
	void Awake () {
		 // Get the Rewired Player object for this player and keep it for the duration of the character's lifetime
        player = ReInput.players.GetPlayer(playerId);

        // Get the character controller
        cc = GetComponent<CharacterController>();

//		rb = GetComponent<Rigidbody> ();
	
	}

	// Update is called once per frame
	void FixedUpdate () {
		GetInput();
		ProcessInput();
	}

	private void GetInput(){

		//vars for control input
		lStickX = player.GetAxis ("StickLeftX");
		lStickY = player.GetAxis ("StickLeftY");
		rStickX = player.GetAxis ("StickRightX");
		rStickY = player.GetAxis ("StickRightY");
		b1 = player.GetButtonDown ("Button1");
		b2 = player.GetButtonDown ("Button2");
		b3 = player.GetButtonDown ("Button3");
		b4 = player.GetButtonDown ("Button4");
		l1 = player.GetButtonDown ("L1");
		r1 = player.GetButtonDown ("R1");
		l2 = player.GetAxis ("L2");
		r2 = player.GetAxis ("R2");

		moveVector.x = lStickX;
		moveVector.z = lStickY;

	}

	private void ProcessInput(){
		
		if (lStickX != 0 || lStickY != 0) {
			cc.Move (moveVector * moveSpeed * Time.deltaTime);
		}
	}
}
