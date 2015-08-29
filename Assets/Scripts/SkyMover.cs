using UnityEngine;
using System.Collections;

public class SkyMover : MonoBehaviour {

	Transform player;
	float offset;

	// Use this for initialization
	void Start () {
		GameObject player_go = GameObject.FindGameObjectWithTag("Player");
		if(player_go == null) Debug.Log ("Could not find player");
		
		player = player_go.transform;
		
		offset = transform.position.x - player.position.x;
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	void FixedUpdate(){
		offset -= 0.001f;

		Vector3 pos = transform.position;
		pos.x = player.position.x + offset;
		transform.position = pos;
	}
}
