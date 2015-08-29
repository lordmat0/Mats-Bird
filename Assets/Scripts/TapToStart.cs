using UnityEngine;
using System.Collections;

public class TapToStart : MonoBehaviour {
	bool didTap = false;

	float floatCounter = 0f;
	bool shouldDecrease = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)){
			didTap = true;
		}
	}

	void FixedUpdate(){
		if(didTap){
			Application.LoadLevel("GameScreen");
		}

		if(shouldDecrease){
			floatCounter -= Time.deltaTime;
			if(floatCounter < 1f){
				shouldDecrease = false;
			}
		}else{
			floatCounter += Time.deltaTime;
			if(floatCounter > 1.2f){
				shouldDecrease = true;
			}

		}

		float scal = Mathf.Lerp(0.9f, 1.2f, floatCounter/4);
		Vector3 scale =  transform.localScale;
		scale.x = scal;
		scale.y = scal;
		transform.localScale = scale;
	}
}
