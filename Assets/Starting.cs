using UnityEngine;
using System.Collections;

public class Starting : MonoBehaviour {

	public GUIStyle Style;


	void OnGUI ()
	{
		GUILayout.Label ("0", Style);

	}


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Input.GetKeyDown (KeyCode.Space) || Input.GetKeyDown(KeyCode.Mouse0))
		{
			Application.LoadLevel ("Scene1");
		}
	}
}
