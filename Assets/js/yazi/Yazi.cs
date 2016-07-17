using UnityEngine;
using System.Collections;

public class Yazi : MonoBehaviour {
	private Animation swim;
	private Animation fly;
	private Animation glideToLanding;
	private Animation idleWater3;

	private int count = 0;
	// Use this for initialization
	void Start () {
		swim = gameObject.GetComponent<Animation> ();
		fly = gameObject.GetComponent<Animation> ();
		glideToLanding = gameObject.GetComponent<Animation> ();
		idleWater3 = gameObject.GetComponent<Animation> ();

	}
	
	// Update is called once per frame
	void Update () {
		if (count == 0) {
			if (!swim.IsPlaying("swim")) {
			swim.Play ("swim");
			}
		} else if (count == 1) {
			if (!fly.IsPlaying("fly")) {
				fly.Play("fly");
			}
		} else if (count == 2) {
			if (!glideToLanding.IsPlaying("glideToLanding")) {
				glideToLanding.Play("glideToLanding");
			}

		} else if (count == 3) {
			if (!idleWater3.IsPlaying("idleWater3")) {
				idleWater3.Play("idleWater3");
			}

		}  else if (count == 4) {
			if (!fly.IsPlaying("fly")) {
				fly.Play("fly");
			}

		} 
	}



	void OnMouseDown() {
		count++;
		if (count == 5) {
			count = 0;
		}
	}
}
