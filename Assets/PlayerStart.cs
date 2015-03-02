using UnityEngine;
using System.Collections;

public class PlayerStart : MonoBehaviour {

	// Use this for initialization
	void Start () {
		InvokeRepeating ("Flap", .1f, .4f);
	}
	public Vector2 jumpForce = new Vector2(0, 300);

	void Update () {


	}

	void Flap () {
			
				rigidbody2D.velocity = Vector2.zero;
				rigidbody2D.AddForce (jumpForce);
		}
}
