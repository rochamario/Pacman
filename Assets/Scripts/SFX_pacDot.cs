using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SFX_pacDot : MonoBehaviour {

	public AudioClip wakka;

	private AudioSource audioSource;

	// Use this for initialization
	void Start ()
	{
		audioSource = GetComponent<AudioSource>();
	}

	void OnCollisionEnter(Collision coll)
	{
		if (coll.gameObject.tag =="pacman")
		{
			audioSource.clip = wakka;
			audioSource.Play();
		}


	}
}
