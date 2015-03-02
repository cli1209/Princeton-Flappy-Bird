using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {


	public Texture Play;
	public GUIStyle Style;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnGUI() {
		
		if (GUI.Button(new Rect(Screen.width/2-50, Screen.height/2-10, 100, 50), Play, Style))
		{

			Application.LoadLevel("End");
			Destroy(gameObject);
		}

	}

}
