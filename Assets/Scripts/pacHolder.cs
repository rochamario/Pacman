using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class pacHolder : MonoBehaviour {

	private Transform holder;
	public Text youWin;

	// Use this for initialization
	void Start () {
		youWin.enabled = false;
		holder = GetComponent<Transform>();
		
	}
	
	// Update is called once per frame
	void Update () {

		if (holder.childCount == 0)
			youWin.enabled = true;

		if (Input.GetKeyDown (KeyCode.R))

			SceneManager.LoadScene("pacman");
		
	}

}
