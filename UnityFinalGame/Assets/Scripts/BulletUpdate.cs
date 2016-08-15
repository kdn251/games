using UnityEngine;
using System.Collections;

public class BulletUpdate : MonoBehaviour {

	public float yVel = 0.3f;
	
	// Update is called once per frame
	void Update () {
	
		transform.Translate(0, yVel, 0);

	}
}
