using UnityEngine;
using System.Collections;

public class BackgroundMover : MonoBehaviour {

	int panels = 5;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D collider){
		if(collider.tag == "Pipe"){
			collider.GetComponent<RandomPipe>().Randomize();
		}

		Vector2 pos = collider.transform.position;

		float widthOfBGObject = ((BoxCollider2D)collider).size.x;

		pos.x = (pos.x + widthOfBGObject * panels) -0.2f;

		collider.transform.position = pos;
	}
}
