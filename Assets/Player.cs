using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public Vector2 jumpForce = new Vector2(0, 300);

	void Start()
	{
				rigidbody2D.velocity = Vector2.zero;
				rigidbody2D.AddForce(jumpForce);
		}
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Mouse0))
		{
			if (Application.loadedLevelName=="GameOver")
			{
					rigidbody2D.velocity=Vector2.zero;
			} else
			{
			rigidbody2D.velocity = Vector2.zero;
			rigidbody2D.AddForce(jumpForce);
			}
		}

		Vector2 screenPosition = Camera.main.WorldToScreenPoint (transform.position);

		if (screenPosition.y < -1 * Screen.height)
				{
				Die ();
				}

		if(rigidbody2D.velocity.y > 0) {
			float angle1 = Mathf.Lerp (0, 25, (rigidbody2D.velocity.y / 10f));
			transform.rotation = Quaternion.Euler(0, 0, angle1); 
		}

		else {
			float angle = Mathf.Lerp (0, -90, (-rigidbody2D.velocity.y / 30f) );
			transform.rotation = Quaternion.Euler(0, 0, angle);
		}

		if (Application.loadedLevelName=="End")
		{
			Destroy (gameObject);
		}

	
	}

	void OnCollisionEnter2D(Collision2D col)
	{
				Die ();
		}

	void Die()
	{
				DontDestroyOnLoad (transform.gameObject);
				Application.LoadLevel ("GameOver");
		}
}

