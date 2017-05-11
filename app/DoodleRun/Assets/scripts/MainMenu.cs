using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GooglePlayGames;
using UnityEngine.SocialPlatforms;

public class MainMenu : MonoBehaviour {

	public string playGameLevel;

	public void PlayGame(){
		Application.LoadLevel(playGameLevel);
	}

	public void QuitGame(){
		Application.Quit ();
	}

	void Start ()
	{
		PlayGamesPlatform.Activate ();
	}

	public void LogIn ()
	{
		Social.localUser.Authenticate ((bool success) => {
			if (success) {
				Debug.Log ("Login Sucess");
				Social.ReportProgress (GPGSIds.achievement_installed_game, 100, (bool success2) => {
					Debug.Log ("Achievement unlocked");
				});
			} else {
				Debug.Log ("Login failed");
			}
		});
	}

	public void ShowLeaderboard ()
	{
		Social.ShowLeaderboardUI ();
	}

	public void ShowAchievements ()
	{
		Social.ShowAchievementsUI ();
	}
}
