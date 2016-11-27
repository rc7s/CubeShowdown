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

	public Rigidbody rb;
	public Vector3 boost;

	// Use this for initialization
	void Awake () {
		 // Get the Rewired Player object for this player and keep it for the duration of the character's lifetime
        player = ReInput.players.GetPlayer(playerId);

        // Get the character controller
        cc = GetComponent<CharacterController>();

		rb = GetComponent<Rigidbody> ();
	
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
		b1 = player.GetButton ("Button1");
		b2 = player.GetButton ("Button2");
		b3 = player.GetButton ("Button3");
		b4 = player.GetButton ("Button4");
		l1 = player.GetButton ("L1");
		r1 = player.GetButton ("R1");
		l2 = player.GetAxis ("L2");
		r2 = player.GetAxis ("R2");

	}

	private void ProcessInput(){
		
//		rb.AddForce (0, lStickY*0.3f, 0, ForceMode.VelocityChange);
//		rb.AddForce (lStickX*0.3f, 0, 0, ForceMode.VelocityChange);

	}
}
