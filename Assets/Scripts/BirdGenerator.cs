using UnityEngine;
using System.Collections;

public class BirdGenerator : MonoBehaviour {

	public GameObject bird;
	public float start;
	public float end;

	float time;
	// Use this for initialization
	void Start () {
		time = Random.Range(start, end);
	}
	
	// Update is called once per frame
	void Update () {
		time -= Time.deltaTime;
	}

	void FixedUpdate(){
		if(time < 0){
			Transform pos = GameObject.Find ("PlaceBirdHere").transform;

			Instantiate(bird, pos.position, pos.rotation);
			time = Random.Range (start, end);
		}

	}
}
