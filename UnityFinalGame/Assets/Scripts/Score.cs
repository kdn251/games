using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	//declare text for player's score
	private Text scoreText;

	// Use this for initialization
	void Start () {

		//get component of score text
		scoreText = GetComponent<Text>();

	}
	
	// Update is called once per frame
	void Update () {

		//display player's score
		scoreText.text = "Score: " + AvatarMovement.score;

	}
}
