using UnityEngine;
using System.Collections;

public class PlayerController: MonoBehaviour {

    public float speed;
    public float rotSpeed;

	private Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}

	void FixedUpdate ()
	{
        float horizontal = speed * Input.GetAxis("Horizontal") * Time.deltaTime;
        float vertical = speed * Input.GetAxis("Vertical") * Time.deltaTime;
        float rotX = Input.GetAxis("Mouse X") * rotSpeed * Mathf.Deg2Rad;

        transform.Translate (horizontal, 0f, vertical);
        transform.RotateAround(Vector3.up, rotX);

	}
}