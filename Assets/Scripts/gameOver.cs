using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameOver : MonoBehaviour {
	public AudioClip playerHit;
	public GameObject explosion;

	void OnCollisionEnter (Collision collider) {
		if (collider.gameObject.tag == "Player") {
			if (explosion != null)
			{
				Instantiate(explosion, collider.transform.position, collider.transform.rotation);
			}
				if (playerHit != null)
			{
				AudioSource.PlayClipAtPoint(playerHit, transform.position, 100f);
			}
			GameManager.gameOver = true;
		}
	}
}
