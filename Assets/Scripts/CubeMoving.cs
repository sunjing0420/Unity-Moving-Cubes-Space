using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMoving : MonoBehaviour {

	public Vector3 velocity;

	// Use this for initialization
	void Start () {

		velocity = new Vector3 (0f, Random.Range(-.05f,.05f), 0f);


	}
	
	// Update is called once per frame
	void Update () {
		this.transform.position += velocity;
		CheckMove ();
	}

	void CheckMove(){
		if (this.transform.position.y >= 1f){
			velocity.y *= -1f;
	
	}   
		if (this.transform.position.y <= -1f){
			velocity.y *= -1f;

		}

	}
}
