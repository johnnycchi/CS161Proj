using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {


	public PlayerController thePlayer;
	public Vector3 playerStartPoint;

	// Use this for initialization
	void Start () {
		playerStartPoint = thePlayer.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void RestartLevel() {
		StartCoroutine ("RestartLevelCo");
	}

	public IEnumerator RestartLevelCo() {
		thePlayer.gameObject.SetActive (false);
		yield return new WaitForSeconds (0.5f);
		thePlayer.transform.position = playerStartPoint;
		thePlayer.gameObject.SetActive (true);
	}
}
