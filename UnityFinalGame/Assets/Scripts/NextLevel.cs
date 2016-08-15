using UnityEngine;
using System.Collections;

public class NextLevel : MonoBehaviour {

	//if button is clicked, restart game
	public void Next_Level() {
		
		//increase enemy movement
		EnemyMovement.enemyMovement += 1;

		//increase chance of enemies shooting
		EnemyMovement.chance -= 1;

		//increase how often enemies shoot
		EnemyMovement.timer -= 10;

		//load game
		Application.LoadLevel("Game");
		
	}
}
