using UnityEngine;
using System.Collections;
using Rewired;

[RequireComponent(typeof(CharacterController))]
public class CharacterTest2 : MonoBehaviour {

	public int playerId2;
	private Player player2;
	private CharacterController cc2;
	//private Vector3 moveVector;

    private float thrust2;
    private Rigidbody rb2;
    public float jumpforce;
	private Vector3 moveVector2;
	private float m2;
	private float leftAxis2;

	// Use this for initialization
	void Start () {
		 // Get the Rewired Player object for this player and keep it for the duration of the character's lifetime
        player2 = ReInput.players.GetPlayer(playerId2);

        // Get the character controller
        cc2 = GetComponent<CharacterController>();

		// move init
        rb2 = GetComponent<Rigidbody>();
        thrust2 = 0f;
	
	}
	
	// Update is called once per frame
	void Update () {
		m2 = Input.GetAxis("Horizontal") * thrust2 * Time.deltaTime;
		GetInput();
		ProcessInput();
		Debug.Log(playerId2);
		Debug.Log(leftAxis2);
	}

	private void GetInput(){
		leftAxis2 = player2.GetAxis("Move Horizontal");
	}

	private void ProcessInput(){
		// if(leftAxis2 < 0.0f){
		// 	//thrust2 = -500000f;
		// 	//rb2.AddTorque(transform.right * m2 * leftAxis2);
		// 	tran
		// }
		// if(leftAxis2 > 0.0f){
		// 	//thrust2 = 500000f;
		// 	//rb2.AddTorque(transform.right * m2 * leftAxis2);
		//}
	}

}
