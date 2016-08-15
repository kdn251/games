using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour {

	//set boolean for left movement
	bool left = true;

	//instantiate timer for AI shooting
	public static int timer = 150;


	//declare enemy movement
	public static float enemyMovement = 5f;


	//declare enemy chance of shooting
	public static int chance = 10;

	//declare bullet
	public Transform bullet;
	
	// Use this for initialization
	void Start () {
	

	}
	
	// Update is called once per frame
	void Update () {

		//if left is true move left
		if(left) {
			//update position
			transform.position += Vector3.left * enemyMovement * Time.deltaTime;
		}
		//otherwise move right
		else {
			//update position
			transform.position += Vector3.right * enemyMovement * Time.deltaTime;
		}

		//decrement timer by 1 each frame
		timer -= 1;

		//check if timer < 2
		if(timer < 0) {
			//store a random number between 0 and chance (continuously changed based on difficulty)
			int randomNumber = Random.Range(0, chance);

			//store the random number in chosen number
			int chosenNumber = randomNumber;

			//if chosen number is 1, fire
			if(chosenNumber == 1) {
				//instantiate bullet
				Transform shot = Instantiate(bullet, transform.position, Quaternion.identity) as Transform;

				//give bullet direction
				shot.rigidbody2D.AddForce(-Vector3.up);
			}
			//reset timer
			timer = 100;
		}
	}

	//check if there has been a collision
	void OnTriggerEnter2D(Collider2D col) {
		//check if we have hit the left border
		if(col.gameObject.name == "leftBorder") {
			//set left to false
			left = false;
		}
		//check if wew have hit the right border
		else if(col.gameObject.name == "rightBorder") {
			//set left to true
			left = true;
		}

	}
}
