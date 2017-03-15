using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AutomateSync : MonoBehaviour {

    private UnityEngine.UI.Toggle my_toggle;
    private UnityEngine.UI.InputField my_field;

    // Use this for initialization
    void Start () {
        my_toggle = gameObject.GetComponent<UnityEngine.UI.Toggle>();
        my_field = gameObject.GetComponent<UnityEngine.UI.InputField>();
    }

    public void toggle(bool state)
    {
        if(state == true)
        {
            my_field.interactable = false;
        }
        if (state == false)
        {
            my_field.interactable = true;
        }
    }
}
