using UnityEngine;
using System.Collections;
using Rewired;

[RequireComponent(typeof(CharacterController))]
public class PlayerMove : MonoBehaviour {

	public int playerId;
	private Player player;
	private CharacterController cc;
	public Rigidbody rb;
	private float lStickX;
	private float lStickY;
	private float rStickX;
	private float rStickY;

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
		lStickX = player.GetAxis ("StickLeftX");
		lStickY = player.GetAxis ("StickLeftY");
		rStickX = player.GetAxis ("StickRightX");
		rStickY = player.GetAxis ("StickRightY");
	}

	private void ProcessInput(){
		
			rb.AddForce (0, lStickY * 20, 0, ForceMode.Impulse);
			rb.AddForce (lStickX * 20, 0, 0, ForceMode.Impulse);

	}
}
