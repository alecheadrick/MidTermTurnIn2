using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{
	public Rigidbody rb;
	public GameObject celebration;
	public GameObject[] celebrationSpawns;

	void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "Player") {
			GameManager.win = true;
			if (celebration != null)
			{
				Instantiate(celebration, celebrationSpawns[0].transform.position, celebrationSpawns[0].transform.rotation);
				Instantiate(celebration, celebrationSpawns[1].transform.position, celebrationSpawns[1].transform.rotation);
				Instantiate(celebration, celebrationSpawns[2].transform.position, celebrationSpawns[2].transform.rotation);
				Instantiate(celebration, celebrationSpawns[3].transform.position, celebrationSpawns[3].transform.rotation);
			}
			rb = col.gameObject.GetComponent<Rigidbody>();
			col.gameObject.GetComponent<MovePlayer>().enabled = false;
			rb.velocity = Vector3.zero;

		}
		
	}
}