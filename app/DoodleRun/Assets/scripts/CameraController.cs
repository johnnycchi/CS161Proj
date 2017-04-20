using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	public PlayerController thePlayer;

	private Vector3 playerPos;
	private float distanceToMoveX;
	private float distanceToMoveY;

	// Use this for initialization
	void Start () {
		thePlayer = FindObjectOfType<PlayerController> ();	
		playerPos = thePlayer.transform.position;

	}
	
	// Update is called once per frame
	void Update () {
		distanceToMoveX = thePlayer.transform.position.x - playerPos.x;
		distanceToMoveY = thePlayer.transform.position.y - playerPos.y;

		transform.position = new Vector3 (transform.position.x + distanceToMoveX, transform.position.y + distanceToMoveY, transform.position.z);
		playerPos = thePlayer.transform.position;
	}
}
