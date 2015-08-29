using UnityEngine;
using System.Collections;

public class OnStart : MonoBehaviour {

	private bool startGame = false;
	// Use this for initialization
	void Start () {
		GetComponent<SpriteRenderer>().enabled = true;
		Time.timeScale = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {
		if(!startGame && (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))){
			Time.timeScale = 1.0f;
			GetComponent<SpriteRenderer>().enabled = false;
		}
	}

	void FixedUpdate(){


	}
}
