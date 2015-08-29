using UnityEngine;
using System.Collections;

public class BirdCollision : MonoBehaviour {

	public bool godMode = false;
	private bool alive = true;

	Animator animator;
	Scorer scorer;

	// Use this for initialization
	void Start () {
		GameObject scorer_go =  GameObject.Find("Score");

		if(scorer_go == null){
			Debug.Log ("Scorer tag not found");
		}

		scorer = scorer_go.GetComponent<Scorer>();

		if(scorer == null){
			Debug.Log ("Scorer component not found");
		}

		animator = GetComponentInChildren<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnCollisionEnter2D(Collision2D col){
		alive = false;
		animator.SetTrigger("BirdDead");
		audio.Play();
	}

	void OnTriggerEnter2D(Collider2D collider){
		
		if(collider.tag == "Score" && isAlive ()){
			scorer.AddScore();
			collider.GetComponent<AudioSource>().Play();
		}
	}

	public bool isAlive(){
		return alive || godMode;
	}
	
}
