using UnityEngine;
using System.Collections;

public class RandomPipe : MonoBehaviour {

	public int decreaseForChanceOfHardPipes;

	const float maxDist = 0.6099232f;
	const float minDist = -0.2748176f;

	// Use this for initialization
	void Start () {
		Randomize();
	}


	public void Randomize(){

		Vector3 pos = transform.position;
		int rand = Random.Range(0, decreaseForChanceOfHardPipes > 1 ? decreaseForChanceOfHardPipes : 2);

		if(rand == 0){
			pos.y = Random.Range(0,2) == 0 ? maxDist : minDist;
		}else{
			pos.y = Random.Range(minDist, maxDist);
		}

		transform.position = pos;
	}

	
	// Update is called once per frame
	void Update () {
	
	}
}
