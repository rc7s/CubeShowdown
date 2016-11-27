using UnityEngine;
using System.Collections;

public class Kill : MonoBehaviour {

	public AudioSource audio;
	public AudioClip clip;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other) {
		if(other.gameObject.tag == "Player")
		{
			Destroy(other.gameObject);
			audio.Play ();
		}
	}
}
