using UnityEngine;
using System.Collections;

public class PlayerController: MonoBehaviour {

    public float rotDegrees;
    public float rotSpeed;

    bool rotating = false;
    bool rotated = false;

    Vector3 axis = Vector3.right;

    void Update ()
	{
        if (!rotating && Input.GetKeyDown (KeyCode.Space))
        {
            StartCoroutine(Rotate(rotDegrees, axis, rotSpeed));
        }
        if (!rotating && rotated)
        {
            float rot = 0 - rotDegrees;
            StartCoroutine(Rotate(rot, axis, rotSpeed));
        }
	}

    IEnumerator Rotate( float angle, Vector3 axis, float speed)
    {
        rotating = true;
        Quaternion start = transform.rotation;

        float curAngle = 0.0f;

        while (Mathf.Abs (curAngle - angle) > 0.0001f)
        {
            curAngle = Mathf.MoveTowards(curAngle, angle, Time.deltaTime * rotSpeed);
            transform.rotation = Quaternion.AngleAxis(curAngle, axis) * start;
            yield return null;
        }

        transform.rotation = Quaternion.AngleAxis(angle, axis) * start;
        rotating = false;
        rotated = !rotated;
    }
}