using UnityEngine;
using EasyAR;
using System.Collections;

public class SoundsManager : MonoBehaviour {

    public AudioSource source;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void PlaySound(int i)
    {
        EasyImageTargetBehaviour imageTarget = FindObjectOfType<EasyImageTargetBehaviour>();
        if(imageTarget != null)
        {
            if(imageTarget.clips != null && i >= 0 && i < imageTarget.clips.Length)
            {
                source.clip = imageTarget.clips[i];
                source.Play();
            }
        }
    }
}
