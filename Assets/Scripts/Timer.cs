using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    public Text myTimer;
    public float startTime;

    void start()
    {
        startTime = Time.time;
    }
    
    void update()
    {
        float t = Time.time - startTime;

        string minutes = ((int)t / 60).ToString();
        string seconds = (t % 60).ToString("f2");

        myTimer.text = minutes + ":" + seconds;
        print(seconds);
    }
}
