using UnityEngine;
using System.Collections;

public class PlayerController: MonoBehaviour {

    public float rotDegrees;
    public float rotSpeed;
    public float waitTime;

    bool rotating = false;
    bool rotated = false;
    bool executeRot = false;

    Vector3 axis = Vector3.right;

    void Update ()
	{
        if (!rotating && executeRot)
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
        executeRot = false;
        Quaternion start = transform.rotation;

        float curAngle = 0.0f;

        while (Mathf.Abs (curAngle - angle) > 0.0001f)
        {
            curAngle = Mathf.MoveTowards(curAngle, angle, Time.deltaTime * rotSpeed);
            transform.rotation = Quaternion.AngleAxis(curAngle, axis) * start;
            yield return null;
        }

        transform.rotation = Quaternion.AngleAxis(angle, axis) * start;
        yield return new WaitForSeconds(waitTime);
        rotating = false;
        rotated = !rotated;
    }

    public void setSpeed(float newSpeed)
    {
        rotSpeed = newSpeed;
    }

    public void setDegree(float newDegree)
    {
        rotDegrees = newDegree;
    }

    public void setWaitTime(float newTime)
    {
        waitTime = newTime/5;
    }

    public void execute()
    {
        executeRot = true;
    }
}