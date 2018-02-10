using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour {

	public float speed;
	public float JumpForce = 2;
	public Vector3 jumping;
	private Rigidbody rb;

	void Start()
	{
		rb = GetComponent<Rigidbody>();
	}

	void FixedUpdate()
	{
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");

		Vector3 movement = new Vector3(-moveVertical , 0.0f, moveHorizontal);

		rb.AddForce(movement * speed);
		if (Input.GetKeyDown(KeyCode.Space)) {
			jumping = new Vector3(0, JumpForce, 0);
			rb.AddForce(jumping * JumpForce);
		}
		

	}
}