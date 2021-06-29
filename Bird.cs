using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bird : MonoBehaviour {

	public float speed=2f;
	public float force=300f;

	private void Start() {
		GetComponent<Rigidbody2D>().velocity=
			Vector2.right*speed;
	}

	private void Update() {
		if(Input.GetKeyDown(KeyCode.Space)){
			GetComponent<Rigidbody2D>().AddForce(Vector2.up*force);
		}
	}

	private void OnCollisionEnter2D(Collision2D other) {
		// Application.LoadLevel(Application.loadedLevel);
		SceneManager.LoadScene("Game");
	}
}
