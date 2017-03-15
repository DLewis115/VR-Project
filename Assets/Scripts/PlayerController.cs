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
    bool wait = false;
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

        if (!rotating && executeRot && !wait)
        {
            wait = !wait;
            StartCoroutine(Rotate(rotDegrees, axis, rotSpeed));
        }
        if (!rotating && rotated && wait)
        {
            float rot = 0 - rotDegrees;
            StartCoroutine(Rotate(rot, axis, rotSpeed));
            wait = !wait;
        }
	}

    IEnumerator Rotate(float angle, Vector3 axis, float speed)
    {
        rotating = true;
        executeRot = false;
        Quaternion start = transform.localRotation;

        float curAngle = 0.0f;

        while (Mathf.Abs (curAngle - angle) > 0.0000000001f)
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
        if (minTime >= maxTime || minTime < 7.0f)
            yield break;
        automated = true;

        do
        {
            while (wait)
            {
                yield return new WaitForSeconds(1);
            }
            yield return new WaitForSeconds(UnityEngine.Random.Range(minTime, maxTime));
            waitTime = UnityEngine.Random.Range(0.0f, 3.0f);
            rotDegrees = UnityEngine.Random.Range(-80.0f, 80.0f);
            while (rotDegrees == 0)
            {
                rotDegrees = UnityEngine.Random.Range(-80.0f, 80.0f);
            }
            rotSpeed = UnityEngine.Random.Range(30.0f, 180.0f);
            execute();
        } while (automate);

        automated = false;
    }

    //Used to set the degrees/s you want to rotate the camera
    public void setSpeed(float newSpeed)
    {
        rotSpeed = newSpeed;
    }

    //Used to set the # of degrees you want to rotate the camera
    public void setDegree(float newDegree)
    {
        rotDegrees = newDegree;
    }

    //Used to set how many seconds to keep the camera rotated before returning it to it's original position
    public void setWaitTime(float newTime)
    {
        waitTime = newTime/10;
    }

    //Used to set the minimum number of seconds to take before the next rotation
    public void setMinTime(String newTime)
    {
        minTime = float.Parse(newTime);
    }

    //Used to set the maximum number of seconds to take before the next rotation
    public void setMaxTime(String newTime)
    {
        maxTime = float.Parse(newTime);
    }

    //Used to toggle having an random number generator control the camera rotations
    public void setAutomate()
    {
        automate = !automate;
    }

    //Used to execute the camera rotation
    public void execute()
    {
        executeRot = true;
    }
}