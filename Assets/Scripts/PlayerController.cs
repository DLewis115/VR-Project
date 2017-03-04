using UnityEngine;
using System.Collections;
using System;

public class PlayerController: MonoBehaviour {

    public float rotDegrees;
    public float rotSpeed;
    public float waitTime;
    public float minTime;
    public float maxTime;

    bool rotating = false;
    bool rotated = false;
    bool executeRot = false;
    bool automate = false;
    bool automated = false;

    Vector3 axis = Vector3.right;

    void Update ()
	{
        if (!automated && automate)
        {
            StartCoroutine(Automate(minTime, maxTime));
        }

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

    IEnumerator Rotate(float angle, Vector3 axis, float speed)
    {
        rotating = true;
        executeRot = false;
        Quaternion start = transform.localRotation;

        float curAngle = 0.0f;

        while (Mathf.Abs (curAngle - angle) > 0.0001f)
        {
            curAngle = Mathf.MoveTowards(curAngle, angle, Time.deltaTime * rotSpeed);
            transform.localRotation = Quaternion.AngleAxis(curAngle, axis) * start;
            yield return null;
        }

        transform.localRotation = Quaternion.AngleAxis(angle, axis) * start;
        yield return new WaitForSeconds(waitTime);
        rotating = false;
        rotated = !rotated;
    }

    IEnumerator Automate(float minTime, float maxTime)
    {
        automated = true;

        while (automate)
        {
            rotDegrees = UnityEngine.Random.Range(-80, 80);
            rotSpeed = UnityEngine.Random.Range(1, 180);
            execute();
            yield return new WaitForSeconds(waitTime + 5);
        }

        automated = false;
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
        waitTime = newTime/10;
    }

    public void setAutomate()
    {
        automate = !automate;
    }

    public void execute()
    {
        executeRot = true;
    }
}