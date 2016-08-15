using UnityEngine;
using System.Collections;

public class Destroy : MonoBehaviour {

	//declare game object for when enemy is destroyed
	public GameObject enemyExplosion;

	//declare game object for when player is destroyed
	public GameObject playerExplosion;

	void OnCollisionEnter2D(Collision2D col) {

		//if the name of the current object is Bullet(Clone)
		if(gameObject.name == "Bullet(Clone)") {
			//check if the object collided with is an enemy
			if(col.gameObject.tag == "Enemy") {

				//play enemy explosion sound
				Instantiate(enemyExplosion, new Vector3(0, 0, 0), Quaternion.identity);

				//increment player's score
				AvatarMovement.score += 10;

				//destroy the enemy
				Destroy(col.gameObject);

				//destroy bullet
				Destroy(gameObject);

				//record the number of enemies
				int numEnemies = GameObject.FindGameObjectsWithTag("Enemy").Length;

				//check if all enemies have been destroyed
				if(numEnemies == 2){
					Application.LoadLevel("WinScreen");
				}
			}
		}
		//otherwise, if the name of the current object is enemyBullet(Clone)
		else if(gameObject.name == "enemyBullet(Clone)") {
			//check if the name of the object the current object collided with is Player
			if(col.gameObject.tag == "Player") {

				//play player explosion sound
				Instantiate(playerExplosion, new Vector3(0, 0, 0), Quaternion.identity);

				//destroy Player
				Destroy(col.gameObject);

				//destroy bullet
				Destroy(gameObject);

				//load game over screen
				Application.LoadLevel("GameOver");
			}
		}

	}
}
