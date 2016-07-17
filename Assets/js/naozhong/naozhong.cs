using UnityEngine;
using System.Collections;

public class naozhong : MonoBehaviour {
	private AudioSource naozhong1;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnMouseDown(){
		Debug.Log ("11111");
		naozhong1 = gameObject.GetComponent<AudioSource> ();
		naozhong1.Play ();
		Debug.Log ("22222");
	}
}
