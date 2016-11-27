using UnityEngine;
using System.Collections;
using Rewired;

[RequireComponent(typeof(CharacterController))]

public class GamepadScript : MonoBehaviour {

	public int playerId;
	private Player player;
	private CharacterController cc;
	private Vector3 moveVector;

	// Use this for initialization
	void Start () {
		 // Get the Rewired Player object for this player and keep it for the duration of the character's lifetime
        player = ReInput.players.GetPlayer(playerId);

        // Get the character controller
        cc = GetComponent<CharacterController>();
	
	}
	
	// Update is called once per frame
	void Update () {
		GetInput();
		ProcessInput();
	}

	private void GetInput(){
		moveVector.z = player.GetAxis("Move Horizontal");
	}

	private void ProcessInput(){
		if(moveVector.z != 0.0f){
			cc.Move(moveVector * 3 * Time.deltaTime);
		}
	}
}
