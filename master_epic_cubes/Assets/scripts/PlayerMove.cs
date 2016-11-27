using UnityEngine;
using System.Collections;
using Rewired;

[RequireComponent(typeof(CharacterController))]
public class PlayerMove : MonoBehaviour {

	//ctrl init vars
	public int playerId;
	private Player player;
	private CharacterController cc;
	//private GameObject obj;

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
	private Vector3 shake;
	public float moveSpeed;
	public AudioClip step;
	private AudioSource audio;

	// Use this for initialization
	void Awake () {
		 // Get the Rewired Player object for this player and keep it for the duration of the character's lifetime
        player = ReInput.players.GetPlayer(playerId);

        // Get the character controller
        cc = GetComponent<CharacterController>();

		if(GetComponent<AudioSource>() != null)
		{
			audio = GetComponent<AudioSource> ();
		}
		//audio = GetComponent<AudioSource> ();

		//obj = GetComponent<GameObject>();

//		rb = GetComponent<Rigidbody> ();
	
	}

	// Update is called once per frame
	void FixedUpdate () {
		GetInput();
		ProcessInput();
		iTween.ShakeScale (gameObject, shake, 1);
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
		moveVector.y = -3.0f;

		shake.x = 2f;
		shake.y = 2f;
		shake.z = 2f;

	}

	private void ProcessInput(){
		
		 	
			cc.Move (moveVector * moveSpeed * Time.deltaTime);

			if (!audio.isPlaying && (Mathf.Abs(lStickX) > 0.5f||Mathf.Abs(lStickY) > 0.5f)) {
				//audio.PlayOneShot (step, 1f);
				playStep();
			}
		

	}

	void playStep(){
		iTween.Stab (gameObject, step, 0f);
	}
}
