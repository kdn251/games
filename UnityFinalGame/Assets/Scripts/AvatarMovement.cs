using UnityEngine;
using System.Collections;

public class AvatarMovement : MonoBehaviour {
	
	//initialize variables
	public float avatarMovement = 12f;
	public float wrapDelay = 0.3f;

	//intialize player's score to zero
	public static int score = 0;

	//declare variables
	private float _nextWrap;
	private SpriteRenderer _spriteRenderer;

	// Use this for initialization
	void Start () {

		//initialize sprite renderer
		_spriteRenderer = GetComponent<SpriteRenderer>();

	}
	
	// Update is called once per frame
	void Update () {
		//set A button to move player left
		if(Input.GetKey(KeyCode.A)) {
			//update player's position
			transform.position += Vector3.left * avatarMovement * Time.deltaTime;
		}
		//set D button to move player right
		else if(Input.GetKey(KeyCode.D)) {
			//update player's position
			transform.position += Vector3.right * avatarMovement * Time.deltaTime;
		}
		//otherwise...
		else {
			//continue
		}

		//check if player reaches right side of the screen
		if(_spriteRenderer.bounds.max.x > Camera.main.orthographicSize * Camera.main.aspect && Time.time > _nextWrap) {
			//wrap player to left side of the screen
			transform.position = new Vector3(-Camera.main.orthographicSize * Camera.main.aspect, transform.position.y, 0f);

			//update next wrap
			_nextWrap = Time.time + wrapDelay;
		}

		//check if player reaches left side of the screen
		else if(_spriteRenderer.bounds.min.x < -Camera.main.orthographicSize * Camera.main.aspect && Time.time > _nextWrap) {
			//wrap palyer to the right side of the screen
			transform.position = new Vector3(Camera.main.orthographicSize * Camera.main.aspect, transform.position.y, 0f);

			//update next wrap
			_nextWrap = Time.time + wrapDelay;
		}
	}
}
