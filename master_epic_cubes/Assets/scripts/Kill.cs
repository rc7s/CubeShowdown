using UnityEngine;
using System.Collections;

public class Kill : MonoBehaviour {

	public AudioSource audio;
	public AudioClip clip;
	public int deaths;

	public GameObject spriteFab1;
	public GameObject spriteFab2;
	public GameObject spriteFab3;

	// Use this for initialization
	void Start () {
		deaths = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (deaths == 3) {
			Instantiate (spriteFab1, new Vector3(-185f,22.5f,-21f), transform.rotation);
			Instantiate (spriteFab2, new Vector3(-101f,22.5f,-3f), transform.rotation);
			Instantiate (spriteFab3, new Vector3(-169f,22.5f,73f), transform.rotation);
			deaths = 0;
		}
	}

	void OnTriggerEnter(Collider other) {
		if(other.gameObject.tag == "Player")
		{
			Destroy(other.gameObject);
			audio.Play ();
			deaths += 1;
		}
	}
}
