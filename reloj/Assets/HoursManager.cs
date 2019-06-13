using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HoursManager : MonoBehaviour
{
    public Clock clock;
    public Slider slider;

    void Start()
    {

    }
    public void OnSliderChange()
    {
        float newHour = slider.value * 24 / 1;
        clock.ChangeHour(newHour);
    }

}
