using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

    public GameObject player;
    public float speed;
    public float rotSpeed;

    private Vector3 offset;

	//Use this for initialization
	void Start () {
        offset = transform.position - player.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = player.transform.position + offset;
	}

    void FixedUpdate()
    {
        float horizontal = speed * Input.GetAxis("Horizontal") * Time.deltaTime;
        float vertical = speed * Input.GetAxis("Vertical") * Time.deltaTime;
        float rotX = Input.GetAxis("Mouse X") * rotSpeed * Mathf.Deg2Rad;

        transform.Translate(horizontal, 0f, vertical);
        transform.RotateAround(Vector3.up, rotX);

    }
}
