﻿using UnityEngine;
using System.Collections;

public class BirdCollider : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D col){
		GetComponent<AutoBirdMover>().KillBird();
	}

}
