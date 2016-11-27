using UnityEngine;
using System.Collections;
using Rewired;

[RequireComponent(typeof(CharacterController))]
public class CharTest_1 : MonoBehaviour {

	public int playerId = 1;
	private Player player;
	private CharacterController cc;
	//private Vector3 moveVector;

    private float thrust2;
    private Rigidbody rb;
    public float jumpforce;
	private Vector3 moveVector;
	private float m;
	private float leftAxis;

	// Use this for initialization
	void Start () {
		 // Get the Rewired Player object for this player and keep it for the duration of the character's lifetime
        player = ReInput.players.GetPlayer(playerId);

        // Get the character controller
        cc = GetComponent<CharacterController>();

		// move init
        rb = GetComponent<Rigidbody>();
        thrust2 = 0f;
	
	}
	
	// Update is called once per frame
	void Update () {
		m = Input.GetAxis("Horizontal") * thrust2 * Time.deltaTime;
		GetInput();
		ProcessInput();
	}

	private void GetInput(){
		leftAxis = player.GetAxis("Move Horizontal");
	}

	private void ProcessInput(){
		if(leftAxis < 0.0f){
			thrust2 = -500000f;
			rb.AddTorque(transform.right * m * leftAxis);
		}
		if(leftAxis > 0.0f){
			thrust2 = 500000f;
			rb.AddTorque(transform.right * m * leftAxis);
		}
	}

}
