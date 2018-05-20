using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Ghost : MonoBehaviour {

	public Transform[] wayPoints;
	public float speed = 0.3f;
	public Text youLose;
	//public float delay = 5;

	private int cur = 0;

	void Start (){
		youLose.enabled = false;
		//StartCoroutine(LoadLevelAfterDelay(2));
	}

	void FixedUpdate() {
		if (transform.position.x != wayPoints [cur].position.x || transform.position.y != wayPoints [cur].position.y) {
			Vector2 p = Vector2.MoveTowards (transform.position,
				            wayPoints [cur].position,
				            speed);
			GetComponent<Rigidbody2D> ().MovePosition (p);
		} else {
			cur = (cur + 1) % wayPoints.Length;
		}


	}

	void OnTriggerEnter2D( Collider2D col) {
		if (col.name == "pacman") {
			youLose.enabled = true;
			Time.timeScale = 1;
			StartCoroutine (LoadLevelAfterDelay (2));
			//yield return new WaitForSeconds(2);
			//SceneManager.LoadScene("pacman");
		}
	}


		IEnumerator LoadLevelAfterDelay(float delay)
	{
		yield return new WaitForSeconds (1);
			SceneManager.LoadScene ("pacman");
		}
	}



