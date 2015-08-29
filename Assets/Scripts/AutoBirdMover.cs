using UnityEngine;
using System.Collections;

public class AutoBirdMover : MonoBehaviour {

	bool dead = false;
	float nextFlap = 0f;
	public float flapForce = 200f;
	public float slowestSpeed;
	public float fastestSpeed;
	float forwardSpeed;

	float jumpPosition = 0f;
	float minY = -0.103868f;
	float maxY = 0.8619366f;
	Animator animator;

	// Use this for initialization
	void Start () {
		Randomize();
		animator = GetComponentInChildren<Animator>();
	}

	public float Randomize(){
		jumpPosition = Random.Range(minY, maxY);
		forwardSpeed = Random.Range(slowestSpeed, fastestSpeed);
		return jumpPosition;
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void KillBird(){
		dead = true;
		if(animator != null){
			animator.SetTrigger("BirdDead");
		}
	}

	void FixedUpdate(){
		if(dead){
			return;
		}
		rigidbody2D.AddForce(Vector2.right * Random.Range (0, forwardSpeed) * Time.deltaTime);

		nextFlap -= Time.deltaTime;

		if(transform.position.y < jumpPosition && nextFlap < 0){
			rigidbody2D.AddForce(Vector2.up * flapForce);

			nextFlap = .2f;
		}

		if(rigidbody2D.velocity.y < 0){
			
			float angle = Mathf.Lerp (0, -90, -rigidbody2D.velocity.y / 8f);
			rigidbody2D.transform.rotation = Quaternion.Euler(0,0,angle);
			
		}else{
			rigidbody2D.transform.rotation = Quaternion.Euler(0,0,0);
		}
		animator.SetTrigger("BirdFlap");

	}
}
