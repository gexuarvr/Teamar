using UnityEngine;
using System.Collections;
 
public class Tuzi : MonoBehaviour {
	private Animation animation;
	private ArrayList list = new ArrayList ();

	private int length;
	private int count = 0;
	// Use this for initialization
	void Start () {
		animation = gameObject.GetComponent<Animation> ();

		foreach (AnimationState state in animation) {
			list.Add(state);
			length++;
		}

	}
	
	// Update is called once per frame
	void Update () {
		AnimationState statue = (AnimationState)list[count];
		animation.clip = statue.clip;
		if (!animation.IsPlaying(animation.clip.name)) {
			Debug.Log(statue.clip.name);
			animation.Play();
		}
	}
	
	
	
	void OnMouseDown() {
		Debug.Log (length);
		count++;
		if (count == length) {
			count = 0;
		}
	}
}
