using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DigitalClock : MonoBehaviour
{
    public Clock clock;

    public Text secondsfield;
    public Text minfield;
    public Text hoursfield;
    public Slider speedSlider;

    private void Start()
    {
        clock.Init();
    }


    // Update is called once per frame
    void Update()
    {
        secondsfield.text = clock.seg.ToString();
        minfield.text = clock.min.ToString();
        hoursfield.text = clock.hr.ToString();
        UpdateSpeed();
    }

    public void UpdateSpeed() {
        clock.ChangeSpeed (speedSlider.value);
    }
}
