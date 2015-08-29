using UnityEngine;
using System.Collections;

public class BirdMovement : MonoBehaviour {

	BirdCollision status;
	Animator animator;

	public float flapForce = 200f;
	public float forwardSpeed = 50f;
	public float deathCoolDown = 2f;

	bool didFlap = false;


	// Use this for initialization
	void Start () {
		animator = GetComponentInChildren<Animator>();
		status = GetComponent<BirdCollision>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)){
			didFlap = true;
		}
	}

	void FixedUpdate(){
		if(!status.isAlive()){
			deathCoolDown -= Time.deltaTime;
			if(didFlap && deathCoolDown < 0){
				Application.LoadLevel("GameScreen");
			}
			// Stops auto loading the level
			didFlap = false;
			return;
		}

		rigidbody2D.AddForce(Vector2.right * forwardSpeed * Time.deltaTime);


		if(didFlap){
			rigidbody2D.AddForce(Vector2.up * flapForce);
			didFlap = false;
			animator.SetTrigger("BirdFlap");
		}

		if(rigidbody2D.velocity.y < 0){

			float angle = Mathf.Lerp (0, -90, -rigidbody2D.velocity.y / 8f);
			rigidbody2D.transform.rotation = Quaternion.Euler(0,0,angle);

		}else{
			rigidbody2D.transform.rotation = Quaternion.Euler(0,0,0);
		}

	}
}
