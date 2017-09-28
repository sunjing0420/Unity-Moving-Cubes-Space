using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovingBack : MonoBehaviour {

	public Vector3 velocity;

	// Use this for initialization
	void Start () {

		velocity = new Vector3 (Random.Range(-.05f,.05f), 0f, 0f);
	}

	// Update is called once per frame
	void Update () {
		this.transform.position += velocity;
		CheckMove ();

	}
	void CheckMove(){
		if (this.transform.position.x >= -4.5f){
			velocity.x *= -1f;

		}   
		if (this.transform.position.x <= -6.5f){
			velocity.x *= -1f;

		}

	}
}

