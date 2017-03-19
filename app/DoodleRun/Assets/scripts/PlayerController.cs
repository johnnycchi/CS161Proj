using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {


	public float moveSpeed;
	public float jumpForce;

	public bool grounded;
	public LayerMask floor;

	private Collider2D myCollider;

	private Rigidbody2D playerBody;

	// Use this for initialization
	void Start () {
		playerBody = GetComponent<Rigidbody2D>();
		myCollider = GetComponent<Collider2D>();
	}
	
	// Update is called once per frame
	void Update () {

		grounded = Physics2D.IsTouchingLayers (myCollider, floor);

		playerBody.velocity = new Vector2 (moveSpeed, playerBody.velocity.y);

		if (Input.GetKeyDown (KeyCode.Space) || Input.GetMouseButtonDown(0) ) {

			if (grounded) {
				playerBody.velocity = new Vector2 (playerBody.velocity.x, jumpForce);
			}
		}
			
	}
}
