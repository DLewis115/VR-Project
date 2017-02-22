using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WaitSliderSynchro : MonoBehaviour
{

    private UnityEngine.UI.Slider my_slider;
    private UnityEngine.UI.InputField my_field;

    void Start()
    {
        my_slider = gameObject.GetComponent<UnityEngine.UI.Slider>();
        my_field = gameObject.GetComponent<UnityEngine.UI.InputField>();
    }

    public void UpdateValueFromFloat(float value)
    {
        float copy = value / 10;
        Debug.Log("float value changed: " + value);
        if (my_slider) { my_slider.value = value; }
        if (my_field) { my_field.text = copy.ToString(); }
    }

    public void UpdateValueFromString(string value)
    {
        float copy = float.Parse(value);
        Debug.Log("string value changed: " + value);
        if (my_slider) { my_slider.value = copy * 10; }
        if (my_field) { my_field.text = value; }
    }
}