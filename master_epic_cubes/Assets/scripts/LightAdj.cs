using UnityEngine;
using System.Collections;
using Rewired;

[RequireComponent(typeof(CharacterController))]
public class LightAdj : MonoBehaviour {

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

	public GameObject light;
	public GameObject sprite;

	private Vector3 lightMove;
	private Vector3 lightOrigin;
	private Vector3 originMove;
	private Vector3 spriteOrigin;
	private Vector3 lightDisp;
	private Vector3 shake;

	// Use this for initialization
	void Awake () {
		// Get the Rewired Player object for this player and keep it for the duration of the character's lifetime
		player = ReInput.players.GetPlayer(playerId);

		// Get the character controller
		cc = GetComponent<CharacterController>();

		lightOrigin = light.transform.position;
		spriteOrigin = sprite.transform.position;
		lightDisp = spriteOrigin - lightOrigin;

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

		lightMove.x = rStickX;
		lightMove.z = rStickY;
		lightMove.y = 0;

		originMove.x = lStickX;
		originMove.z = lStickY;
		originMove.y = 0;

		shake.x = 20f;
		shake.y = 20f;
		shake.z = 20f;

	}

	private void ProcessInput(){
		if (rStickX != 0 || rStickY != 0) {
			light.transform.position = lightOrigin + lightMove * 30;
		} else {
			light.transform.position = lightOrigin;
		}

		if (lStickX != 0 || lStickY != 0) {
			lightOrigin = sprite.transform.position - lightDisp;
		}
	}

}