using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovingRight : MonoBehaviour {

	public Vector3 velocity;

	// Use this for initialization
	void Start () {

		velocity = new Vector3 (0f, 0f, Random.Range(-.05f,.05f));
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.position += velocity;
		CheckMove ();

	}
	void CheckMove(){
		if (this.transform.position.z >= 3f){
			velocity.z *= -1f;

		}   
		if (this.transform.position.z <= 2f){
			velocity.z *= -1f;

		}

	}
}
