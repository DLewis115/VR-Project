using UnityEngine;
using System.Collections;

public class PlayerController: MonoBehaviour {

    public float rotDegrees;
    public float totalDegrees;
    public float rotSpeed;

    private Quaternion targetRotation;

	// Use this for initialization
	void Start () {
        targetRotation = transform.rotation;
	}

	void Update ()
	{
        if (Input.GetKeyDown (KeyCode.Space))
        {
            targetRotation *= Quaternion.AngleAxis(rotDegrees, Vector3.right);
        }
        transform.rotation = Quaternion.Lerp(transform.rotation , targetRotation , 10 * rotSpeed * Time.deltaTime);
	}
}