using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

	public Vector3 velocity;
	public GameObject target;

	// Use this for initialization
	void Start () {
		velocity = new Vector3 (Random.Range (-1f, 1f), Random.Range (-1f, 1f), Random.Range (-1f, 1f));
		
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.position += velocity;

		//BoundsCheck (this.transform.position, target.gameObject.CompareTag("cube"), this.transform.localScale);
	}

	void BoundsCheck(Vector3 checkFrom, Vector3 checkAgainst, Vector3 size){

		if (checkFrom.x + size.x/2f >= checkAgainst.x/2f) {
			velocity.x *= -1f;
		
			print ("hit");
		}
	
	}
}
