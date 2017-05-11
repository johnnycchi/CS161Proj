using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class levelEnd : MonoBehaviour {

	public string level;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D(Collision2D coll) {
		if (coll.gameObject.tag =="Player") {
			//Social.ReportProgress (GPGSIds.achievement_beat_level_1, 100, (bool success2) => {
			//	Debug.Log ("Achievement unlocked");
			//});
			Application.LoadLevel(level);
		}
	}
}
