using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PacDot : MonoBehaviour {
	
	void OnTriggerEnter2D(Collider2D coll) {
		if (coll.name == "pacman") {
			Destroy (gameObject);

		}

}
}
