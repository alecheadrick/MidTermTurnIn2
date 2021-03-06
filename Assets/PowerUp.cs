﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
	public float multiplyer = 2f;
	private MovePlayer playMove;
	public float duration = 10f;


	void OnTriggerEnter(Collider col) {
		if (col.gameObject.tag == "Player") {
			StartCoroutine(Pickup(col));
		}

		
	}

	IEnumerator Pickup(Collider player){
		Debug.Log("picked Up");
		playMove = player.gameObject.GetComponent<MovePlayer>();
		playMove.speed *= multiplyer;
		GetComponent<MeshRenderer>().enabled = false;
		GetComponent<Collider>().enabled = false;
		yield return new WaitForSeconds(duration);
		playMove.speed /= multiplyer;
		Destroy(gameObject);
	}
}