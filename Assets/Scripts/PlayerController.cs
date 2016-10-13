using UnityEngine;
using System.Collections;

public class PlayerController: MonoBehaviour {

	private Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}

	void FixedUpdate ()
	{
		transform.Translate (Input.GetAxis ("Horizontal") * Time.deltaTime, 0f, Input.GetAxis ("Vertical") * Time.deltaTime);
	}
}
