using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {


	public float moveSpeed;
	public float jumpForce;

	public bool grounded;
	public LayerMask floor;

	public GameManager theGameManager;

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
		//playerBody.velocity.y
		playerBody.velocity = new Vector2 (moveSpeed, playerBody.velocity.y);

		if (Input.GetKeyDown (KeyCode.Space) || Input.GetMouseButtonDown(0) ) {

			if (grounded) {
				playerBody.velocity = new Vector2 (playerBody.velocity.x, jumpForce);

				if (playerBody.position.y > transform.position.y) {
					//playerBody.AddForce(new Vector2(10, -100), ForceMode2D.Impulse);
					playerBody.velocity = new Vector2 (playerBody.velocity.x, jumpForce);
				}


			}

			//playerBody.AddForce(new Vector2(0, 15), ForceMode2D.Impulse);
		}


			
	}

	void OnCollisionEnter2D (Collision2D other) {
		if (other.gameObject.tag == "killbox") {
			theGameManager.RestartLevel();
		}
	}
}
