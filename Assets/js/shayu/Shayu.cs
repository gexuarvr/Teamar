using UnityEngine;
using System.Collections;

public class Shayu : MonoBehaviour {

	private int SetState = 0;
	// Use this for initialization
	private Animation a ;
	private Animation b ;
	private Animation c ;
	public GameObject phySystem;
	private ParticleSystem partsys;
	void Start () {
		

		a = gameObject.GetComponent<Animation>();
		a.Play ();
		//Debug.Log (a.clip.name);
		b = gameObject.GetComponent<Animation>();
		c = gameObject.GetComponent<Animation>();
		partsys = phySystem.GetComponent<ParticleSystem> ();
		partsys.Play ();
	}
	
	// Update is called once per frame
	void Update () {
		//if (SetState == 1) {
			//if (shayuAnimator.GetInteger("speed") != 1) {
			//	Debug.Log ("speed等于"+shayuAnimator.GetInteger("speed"));
			//	shayuAnimator.SetInteger("speed", 1);
			//}
		//} 
		if (SetState == 0) {
			if (!a.IsPlaying("Take 001")) {
				a.Play("Take 001");
			}
		} else if (SetState == 1) {
			if (!b.IsPlaying("shot")) {
				b.Play("shot");
			}
		} else if (SetState == 2) {
			if (!c.IsPlaying("youy")) {
				partsys.Play();
				c.Play("youy");
			}
		}
	}

	void OnMouseDown(){
		
		SetState ++;
		if (SetState == 3) {
			SetState = 0;
		}
	}
}