using UnityEngine;
using System.Collections;

public class Generate : MonoBehaviour {

	// Use this for initialization

		public GUIStyle Style;
		public GUIStyle ScoreDisplay;
		public GameObject obstacle;
	    float timer=0f;
	    int score=0;
		// Use this for initialization
		void Start()
		{
				DontDestroyOnLoad (gameObject);
				InvokeRepeating ("CreateObstacle", 1f, 1.5f);
					 
		}
		void OnGUI () 
		{
			if (Application.loadedLevelName == "Scene0" || Application.loadedLevelName == "Scene1") {
						GUILayout.Label (score.ToString (), Style);
				}
			if (Application.loadedLevelName == "GameOver") {
			GUI.Box (new Rect (Screen.width / 2 - 125, Screen.height / 2 - 100, 250, 100), "GAME OVER     " + "YOUR SCORE: " + score, ScoreDisplay);
		}
	}
	
		void CreateObstacle()
		{
		
			if (Application.loadedLevelName == "Scene1") {
						Instantiate (obstacle);
				}

		if (timer > 5 && Application.loadedLevelName=="Scene1") {
						score++;
				}
				
		}

	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		if (Application.loadedLevelName == "End") {
			DestroyObject(gameObject);
				}
	}
}
