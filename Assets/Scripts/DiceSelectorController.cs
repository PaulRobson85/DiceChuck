using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class DiceSelectorController : MonoBehaviour {

    public Slider Slider;
    public InputField InputField;

    public void Start()
    {
        //Adds a listener to the main slider and invokes a method when the value changes.
        Slider.wholeNumbers = true;
        
        Slider.onValueChanged.AddListener(ValueChangeCheck);

        InputField.text = Slider.value.ToString();
        //mainSlider.On.AddListener(delegate { ValueChangeCheck(); }))
    }

    // Invoked when the value of the slider changes.
    void ValueChangeCheck(float value)
    {
        //Debug.Log(Slider.value);
        InputField.text = value.ToString();
    }
}
