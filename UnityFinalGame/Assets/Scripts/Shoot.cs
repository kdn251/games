using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {

	//declare bullet
	public Transform bullet;
	
	// Update is called once per frame
	void Update () {

		//check if space bar has been pressed
		if(Input.GetKeyUp(KeyCode.Space)) {

			//instantiate bullet
			Instantiate(bullet, transform.position, Quaternion.identity);

			//play shooting sound
			audio.Play ();
		}
	}
}
