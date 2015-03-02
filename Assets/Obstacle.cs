using UnityEngine;
using System.Collections;

public class Obstacle : MonoBehaviour {

	public Vector2 velocity = new Vector2(-4, 0);
	public float range = 2.5f;
	// Use this for initialization
	void Start()
	{
		DontDestroyOnLoad (gameObject);
		rigidbody2D.velocity = velocity;
		transform.position = new Vector2 (transform.position.x, transform.position.y - range * Random.value);
	}


	
	// Update is called once per frame
	void Update () {
	
		Vector2 screenPosition = Camera.main.WorldToScreenPoint (transform.position);
		if (screenPosition.x > Screen.width || screenPosition.x < -1 * Screen.width)
		{
			Destroy (gameObject);
		}

		if (Application.loadedLevelName=="GameOver")
		    {
			rigidbody2D.velocity=Vector2.zero;
			}
		if (Application.loadedLevelName=="End")
		{
			Destroy (gameObject);
		}
	}
}
