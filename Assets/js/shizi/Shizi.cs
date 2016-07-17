using UnityEngine;
using System.Collections;

public class Shizi : MonoBehaviour {
	private Animation idle;
	private Animation walk;
	private Animation run;
	private Animation jump;
	private Animation jumpAttack;
	private Animation bite;
	private Animation roar;
	private Animation clawsAttackCombo;
	private Animation death;
	private AudioSource shiziSource;
	// Use this for initialization
	private int count = 0;
	private Vector2 direction;
	public void randomDirection() {//随机单位方向
		direction = Random.onUnitSphere.normalized;
	}
	void Rotating (float horizontal, float vertical)
	{
		Vector3 postionV = gameObject.transform.parent.position;
		Debug.Log (Vector3.Distance (gameObject.transform.position, postionV)  +"--"+postionV.x+"---"+postionV.y);
		Vector3 targetDirection;
		if (Vector3.Distance (gameObject.transform.position, postionV) > 10f) {
			targetDirection = new Vector3(-gameObject.transform.position.x, 0, -gameObject.transform.position.z);// Create a new vector of the horizontal and vertical inputs.
		} else {
			targetDirection = new Vector3 (-horizontal, 0f, -vertical); // Create a new vector of the horizontal and vertical inputs.
		}
		Quaternion targetRotation = Quaternion.LookRotation(targetDirection, Vector3.up); // Create a rotation based on this new vector assuming that up is the global y axis.
		Quaternion newRotation = Quaternion.Lerp(gameObject.transform.rotation, targetRotation, 2 * Time.deltaTime); // Create a rotation that is an increment closer to the target rotation from the player's rotation.
		gameObject.transform.rotation = newRotation; // Change the players rotation to this new rotation.
	}
	void Awake () {  
		idle = gameObject.GetComponent<Animation> ();
		walk = gameObject.GetComponent<Animation> ();
		run = gameObject.GetComponent<Animation> ();
		jump = gameObject.GetComponent<Animation> ();
		jumpAttack = gameObject.GetComponent<Animation> ();
		bite = gameObject.GetComponent<Animation> ();
		roar = gameObject.GetComponent<Animation> ();
		clawsAttackCombo = gameObject.GetComponent<Animation> ();
		death = gameObject.GetComponent<Animation> ();


		Debug.Log("Awake");  

	}  
	void Start () {
		InvokeRepeating("addcount", 2, 3.0F);
		InvokeRepeating ("randomDirection" ,1f,3f);//
		shiziSource = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {

		if (count == 0) {
			if (!idle.isPlaying) {
				idle.Play("idle");
			}
		} else if (count == 1) {
			if (!walk.IsPlaying("walk")) {
				walk.Play("walk");
			}
				Rotating (direction.x, direction.y);
				moving (direction.x, direction.y);
		} else if (count == 2) {
			if (!clawsAttackCombo.IsPlaying("clawsAttackCombo")) {
				clawsAttackCombo.Play("clawsAttackCombo");
			}

		} else if (count == 3) {
			if (!run.IsPlaying("run")) {
				run.Play("run");
			}
			Rotating (direction.x, direction.y);
			moving (direction.x, direction.y);
		} else if (count == 4) {
			if (!jump.IsPlaying("jump")) {
				jump.Play("jump");
			}
			Rotating (direction.x, direction.y);
			moving (direction.x, direction.y);
		} else if (count == 5) {
			if (!jumpAttack.IsPlaying("jumpAttack")) {
				jumpAttack.Play("jumpAttack");
			}
			Rotating (direction.x, direction.y);
			moving (direction.x, direction.y);
		} else if (count == 6) {
			if (!run.IsPlaying("run")) {
				run.Play("run");
			}
			Rotating (direction.x, direction.y);
			moving (direction.x, direction.y);
		} else if (count == 7) {
			if (!walk.IsPlaying("walk")) {
				walk.Play("walk");
			}
			Rotating (direction.x, direction.y);
			moving (direction.x, direction.y);
		} else if (count == 8) {
			if (!roar.IsPlaying("roar")) {
				roar.Play("roar");

			}
			if (!shiziSource.isPlaying) {
				shiziSource.Play();
				Debug.Log("dddd");
			}
		}

	
	}  
	public void moving (float h, float v) {
		Debug.Log (h+"----------"+v);
		//往前走
		if (h > 0) {
			//Debug.Log("向右"+h);
			gameObject.transform.Translate(0,0,h*Time.deltaTime*4);
		}
		if (h < 0) {
			//Debug.Log("向左"+h);
			gameObject.transform.Translate(0,0,-h*Time.deltaTime*4);
		}
		if (v > 0) {
			//Debug.Log("向前"+v);
			gameObject.transform.Translate(0,0,v*Time.deltaTime*4);
		}
		if (v < 0) {
			//Debug.Log("向后"+v);
			gameObject.transform.Translate(0,0,-v*Time.deltaTime*4);
		}
		
		
	}

	void addcount()  {
		count++;
		if (count == 9) {
			count = 0;
		}
	}


}
