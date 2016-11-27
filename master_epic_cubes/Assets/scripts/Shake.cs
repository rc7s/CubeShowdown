using UnityEngine;
using System.Collections;

public class Shake : MonoBehaviour {
	private Vector3 shake;
	// Use this for initialization
	void Start () {
		shake.x = 1f;
		shake.y = 1f;
		shake.z = 1f;
	}
	
	// Update is called once per frame
	void Update () {
		iTween.ShakeScale (gameObject, shake, 1);
	}
}
