using UnityEngine;
using System.Collections;

public class MoonMovement : MonoBehaviour {

    public float speed;
    public float distance;
    private Vector3[] thePath;
    private float pathLength;
 
    void Start()
    {
        thePath = iTweenPath.GetPath("MoonMovement");
        pathLength = iTween.PathLength(thePath);
    }

    void Update()
    {
        distance += speed * Time.deltaTime;
        float perc = distance / pathLength;
        iTween.PutOnPath(gameObject, thePath, perc);
        if (distance >= pathLength)
        {
            distance = 0;
        }
    }
}
