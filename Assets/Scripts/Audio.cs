using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour {

	public AudioSource LoopAudio; 

	private void OnCollisionEnter2D(Collision2D collision)
	{
		LoopAudio.Play();
	}

}
