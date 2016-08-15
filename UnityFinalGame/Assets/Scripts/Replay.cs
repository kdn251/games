using UnityEngine;
using System.Collections;

public class Replay : MonoBehaviour {

	//if button is clicked, restart game
	public void Restart_Game() {

		//reset score to 0
		AvatarMovement.score = 0;

		//reset enemy movement
		EnemyMovement.enemyMovement = 5f;

		//reset how often enemies shoot
		EnemyMovement.timer = 150;

		//reset chance of enemies shooting
		EnemyMovement.chance = 10;

		//load game
		Application.LoadLevel("Game");

	}

}
